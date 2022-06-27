/*	Copyright (c) 2003-2016 Xsens Technologies B.V. or subsidiaries worldwide.
	All rights reserved.

	Redistribution and use in source and binary forms, with or without modification,
	are permitted provided that the following conditions are met:

	1.	Redistributions of source code must retain the above copyright notice,
		this list of conditions and the following disclaimer.

	2.	Redistributions in binary form must reproduce the above copyright notice,
		this list of conditions and the following disclaimer in the documentation
		and/or other materials provided with the distribution.

	3.	Neither the names of the copyright holders nor the names of their contributors
		may be used to endorse or promote products derived from this software without
		specific prior written permission.

	THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY
	EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF
	MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL
	THE COPYRIGHT HOLDERS OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
	SPECIAL, EXEMPLARY OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT
	OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
	HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY OR
	TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
	SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Xsens;
using XDA;
using System.Media;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Globalization;

namespace MTwExample
{
	public enum expTask
    {
		NONE,
		TriClassic,
		TriSound,
		Confusion
    }

	public delegate void ResumeFromMessage();
	public partial class Form1 : Form
    {
        private MyXda _xda;
		private XsDevice _measuringDevice = null;
		private Dictionary<XsDevice, MyMtCallback> _measuringMts = new Dictionary<XsDevice, MyMtCallback>();
		private Dictionary<ulong, ConnectedMtData> _connectedMtwData = new Dictionary<ulong, ConnectedMtData>();
		
		public static readonly string appPath = Path.Combine(new string[] { Path.GetDirectoryName(Application.ExecutablePath) });
		public static readonly string resourcesPath1 = Path.Combine(new string[] { appPath, "resources1"});
		public static readonly string resourcesPath = Path.Combine(new string[] { appPath, "resources"});
		public static readonly string resultsDir = Path.Combine(new string[] { appPath, "results" });
		
		private UserControl currUC = null;
		public Speakers speakers = null;
		
		public int trialCounter = 0;
		public int verse_rotation { get => trialCounter - 1; }

		public int NTrial = 4;

		private DateTime rootDate;
		private DateTime startDate;
		private DateTime stopDate;

		private string previous;
		private string current;


		public string ID;

		public string[] a_o_cond = { "O", "A", "A", "O" };
		public List<string> random_a_o_cond;
		public String[] a_o = new String[4];

		expTask _task = expTask.NONE;

		private Logger TriangleClassicLogger;
		private Logger TriangleSoundLogger;
		private Logger ConfusionLogger;
		private Logger NullLogger;

		private Logger thisTaskLogger;

		private Logger SensLogger;

		private string[] Form1Header = new string[] { "Code", "ID", "Task", "Condition", "Trial", "StartPoint", "StopPoint", "StartTimestamp", "StopTimestamp", "sensordata", "angle_abs", "radius_abs", "angle_rel" };

		public Form1(string str, DateTime sessionStarted)
        {
            InitializeComponent();

			CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

			rootDate = sessionStarted;

            _xda = new MyXda();
			cbxChannel.SelectedIndex = 0;
            step(1);

			random_a_o_cond = a_o_cond.ToList();
			Random rand = new Random();

			speakers = new Speakers();

			previous = "";
			current = "";

			ID = str;
			
			//Logger.SetCommonPath(appPath, "results", ID, _time: sessionStarted);
			TriangleClassicLogger = new Logger(expTask.TriClassic.ToString(), destinationFolder: ID, extension: "dat", keepStream: false);
			TriangleSoundLogger = new Logger(expTask.TriSound.ToString(), destinationFolder: ID, extension: "dat", keepStream: false);
			ConfusionLogger = new Logger(expTask.Confusion.ToString(), destinationFolder: ID, extension: "dat", keepStream: false);
			NullLogger = new Logger(expTask.NONE.ToString(), destinationFolder: ID, extension: "dat", keepStream: false);
			
			thisTaskLogger = NullLogger;

			UpdateSensFilename();

			if (rootDate == null)
			rootDate = DateTime.Now;
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			timer1.Enabled = false;

			if (_measuringDevice != null)
				_measuringDevice.clearCallbackHandlers();
			
			_measuringMts.Clear();

			_xda.Dispose();
			_xda = null;
		}
        #region XSENSFORM
        private void btnScan_Click(object sender, EventArgs e)
        {
            cbxStations.Items.Clear();
			_xda.scanPorts();
			if (_xda._DetectedDevices.Count > 0)
			{
				foreach (XsPortInfo portInfo in _xda._DetectedDevices)
				{
					if (portInfo.deviceId().isWirelessMaster())
					{
						_xda.openPort(portInfo);
						MasterInfo ai = new MasterInfo(portInfo.deviceId());
						ai.ComPort = portInfo.portName();
						ai.BaudRate = portInfo.baudrate();
						cbxStations.Items.Add(ai);
						break;
					}
				}

				if (cbxStations.Items.Count > 0)
				{
					cbxStations.SelectedIndex = 0;
					btnEnable.Enabled = true;
					step(2);
				}
				else
				{
					step(3);
				}
			}
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
			XsDevice device = _xda.getDevice(((MasterInfo)cbxStations.SelectedItem).DeviceId);
			// Supported update rates and maximum available from xda
			XsIntArray supportedRates = device.supportedUpdateRates();
			int maxUpdateRate = device.maximumUpdateRate();

			// -- Put the allowed update rates in the combobox for the user to choose from --
			comboBoxUpdateRate.Items.Clear();
			for (uint i = 0; i < supportedRates.size() && supportedRates.at(i) <= maxUpdateRate; ++i)
			{
				// This is an allowed update rate, so add it to the list.
				comboBoxUpdateRate.Items.Add(Convert.ToString(supportedRates.at(i)));
			}

			// Select the current update rate of the station.
			int updateRateIndex = comboBoxUpdateRate.FindString(Convert.ToString(device.updateRate()));
			comboBoxUpdateRate.SelectedIndex = updateRateIndex;


			// Set a default update rate of 75 (if available) when we set the radio channel
			updateRateIndex = comboBoxUpdateRate.FindString(Convert.ToString(75));

			if (updateRateIndex != -1)
			{
				comboBoxUpdateRate.SelectedIndex = updateRateIndex;
			}

			if (device.isRadioEnabled())
				device.disableRadio();
            if (device.enableRadio(Convert.ToInt32(cbxChannel.Text)))
            {
                btnScan.Enabled = false;
                btnEnable.Enabled = false;
                btnMeasure.Enabled = true;
                step(4);
            }
            else
            {
                step(6);
                btnScan.Enabled = true;
                btnEnable.Enabled = false;
            }
        }

        private void btnMeasure_Click(object sender, EventArgs e)
        {
            step(9);
			_connectedMtwData.Clear();
			_measuringDevice = _xda.getDevice(((MasterInfo)cbxStations.SelectedItem).DeviceId);

			// First set the update rate
			int desiredUpdateRate = Convert.ToInt32(comboBoxUpdateRate.Text);
			if (desiredUpdateRate != -1 && desiredUpdateRate != _measuringDevice.updateRate())
			{
				if (_measuringDevice.setUpdateRate(desiredUpdateRate))
				{
					rtbSteps.Text = String.Format("Update rate set. ID: {0}, Rate: {1}", _measuringDevice.deviceId().toXsString().toString(), desiredUpdateRate);
				}
				else
				{
					rtbSteps.Text = String.Format("Failed to set update rate. ID: {0}, Rate: {1}", _measuringDevice.deviceId().toXsString().toString(), desiredUpdateRate);
				}
			}

			_measuringDevice.gotoMeasurement();
			XsDevicePtrArray deviceIds = _measuringDevice.children();
			for (uint i = 0; i < deviceIds.size(); i++)
			{
				XsDevice mtw = new XsDevice(deviceIds.at(i));
				MyMtCallback callback = new MyMtCallback();

				ConnectedMtData mtwData = new ConnectedMtData();
				_connectedMtwData.Add(mtw.deviceId().toInt(), mtwData);

				// connect signals
				callback.DataAvailable += new EventHandler<DataAvailableArgs>(_callbackHandler_DataAvailable);

				mtw.addCallbackHandler(callback);
				_measuringMts.Add(mtw, callback);
			}
			lblDeviceCount.Text = string.Format("MTw's Connected: {0}", deviceIds.size());
            btnMeasure.Enabled = false;
			btnRecord.Enabled = true;
            btnStopRecord.Enabled = true;
            timer1.Interval = 20;
            timer1.Enabled = true;
        }

		private async void btnRecord_Click(object sender, EventArgs e)
		{
			if (InvokeRequired)
			{
				// Update UI, make sure this happens on the UI thread
				BeginInvoke(new Action(delegate { btnRecord_Click(sender, e); }));
			}
			else
			{
				if (_measuringDevice == null)
					return;
				if (!_measuringDevice.isMeasuring())
					return;

				UpdateSensFilename();
				SensLogger = new Logger(destinationFile: SensFilenameBox.Text, destinationFolder: ID, extension: "ts", keepStream: true);
				SensLogger.CreateFolder();

				_measuringDevice.createLogFile(new XsString(Path.Combine(thisTaskLogger.thisFileFolder, SensFilenameBox.Text)));
				
				Task sethead = Task.Run(()=>SensLogger.SetHeader(new string[] { "s", "t" }));
				sethead.Wait();
				_measuringDevice.startRecording();
				btnRecord.Enabled = false;
				step(9);
			}
			
		}

        private void btnStopRecord_Click(object sender, EventArgs e)
        {
			if (InvokeRequired)
			{
				// Update UI, make sure this happens on the UI thread
				BeginInvoke(new Action(delegate { btnStopRecord_Click(sender, e); }));
			}
			else
			{
				if (_measuringDevice == null)
					return;

				btnStopRecord.Enabled = false;

				if (_measuringDevice.isRecording())
                {
					_measuringDevice.stopRecording();
					_measuringDevice.closeLogFile();
				}

				btnRecord.Enabled = true;
				btnStopAll.Enabled = true;

				step(10);
					
			}
        }

		private void btnStopAll_Click(object sender, EventArgs e)
		{
			if (InvokeRequired)
			{
				// Update UI, make sure this happens on the UI thread
				BeginInvoke(new Action(delegate { btnStopAll_Click(sender, e); }));
			}
			else
			{
				btnStopRecord_Click(sender, e);

				timer1.Enabled = false;

				if (_measuringDevice == null)
					return;

				_measuringDevice.gotoConfig();
				_measuringDevice.disableRadio();
				_measuringDevice.clearCallbackHandlers();

				step(11);

				btnRecord.Enabled = false;
				btnStopAll.Enabled=false;
				btnScan.Enabled = true;

				if (cbxStations.Items.Count > 0)
				{
					cbxStations.SelectedIndex = 0;
					btnEnable.Enabled = true;
					step(2);
				}
				else
				{
					step(1);
				}
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
        {
			string text = "";
		    foreach (KeyValuePair<ulong, ConnectedMtData> data in _connectedMtwData)
            {
				if (data.Value._orientation != null)
				{
					text += string.Format("{3:X8} {0,-5:f2}, {1,-5:f2}, {2,-5:f2} [°]\n",
										   data.Value._orientation.x(),
										   data.Value._orientation.y(),
										   data.Value._orientation.z(), data.Key);
				}
            }
			rtbData.Text = text;
        }

		void _callbackHandler_DataAvailable(object sender, DataAvailableArgs e)
		{
			if (InvokeRequired)
			{
				// Update UI, make sure this happens on the UI thread
				BeginInvoke(new Action(delegate { _callbackHandler_DataAvailable(sender, e); }));
			}
			else
			{
				//Getting Euler angles.
				XsEuler oriEuler = e.Packet.orientationEuler();

				_connectedMtwData[e.Device.deviceId().toInt()]._orientation = oriEuler;

				if (_measuringDevice.isRecording())
                {
					SensLogger.UpdateValue("s", e.Packet.m_packetId);
					SensLogger.UpdateValue("t", (DateTime.Now-rootDate).TotalMilliseconds );
					SensLogger.LogData();
				}
			}
		}

		//void _callbackHandler_RecordingStarted(object sender, DataAvailableArgs e)
		//{
		//	if (InvokeRequired)
		//	{
		//		// Update UI, make sure this happens on the UI thread
		//		BeginInvoke(new Action(delegate { _callbackHandler_RecordingStarted(sender, e); }));
		//	}
		//	else
		//	{
		//		SensLogger.CreateFolder();
		//		Task mkHdr = Task.Run(() => SensLogger.SetHeader(new string[] { "s", "t" }));
		//		mkHdr.Wait();
		//	}
		//}

		/// <summary>
		/// Some step by step info
		/// </summary>
		/// <param name="stepNumber"></param>
		private void step(int stepNumber)
        {
            switch (stepNumber)
            {
                case 1:
                    rtbSteps.Text = "Connect the Awinda Station, dock the MTWs and click 'Scan'.";
                    break;
                case 2:
                    rtbSteps.Text = "Select a station from the combobox, select a channel and click 'Enable Radio'.";
                    break;
                case 3:
                    rtbSteps.Text = "No station was found, make sure the drivers were installed correctly.";
                    break;
                case 4:
                    rtbSteps.Text = "Undock the MTws from the station and wait for them to connect to the station. This is indicated by the MTw LEDs blinking in sync with the CONN LED on the station.\n\n" +
                                    "Then click 'Measure' and wait a bit.";
                    break;
                case 6:
                    rtbSteps.Text = "There was an unexpected failure enabling the station.";
                    break;
                case 8:
                    rtbSteps.Text = "There was an unexpected failure going to the operational mode.";
                    break;
                case 9:
                    rtbSteps.Text = "Start recording... click 'Stop Record' to stop recording and keep measuring. Click 'Stop all' when no further joy can be obtained from looking at the data.";
                    break;
				case 10:
					rtbSteps.Text = "Recording stopped... yet the MTws are still measuring. Click 'Stop all' when no further joy can be obtained from looking at the data.\nClick 'Record' to start recording again";
					break;
				case 11:
					rtbSteps.Text = "Shutting down MTw and disabling radio...bye bye.";
					break;
				default:
                    rtbSteps.Text = "No station was found, make sure the drivers were installed correctly.";
                    break;
            }
        }
        #endregion

        #region CASSEFORM
        public void Initial_Visibility()
        {
			EndCondBtn.Visible = false;
			button3.Visible = false;
			C2StartBtn.Visible = false;
			C2StopBtn.Visible = false;
			C1StartBtn.Visible = false;
			C1StopBtn.Visible = false;
			C4StartBtn.Visible = false;
			C4StopBtn.Visible = false;
			StartAllBtn.Visible = false;
			StopAllBtn.Visible = false;
			ArrivalStartBtn.Visible = false;
			ArrivalStopBtn.Visible = false;
			comboBox1.Visible = false;
			COMPortLbl.Visible = false;
			label5.Visible = false;
			label6.Visible = false;
			label7.Visible = false;
			txt_box_1_4.Visible = false;
			txt_box_2_1.Visible = false;
			txt_Confusion.Visible = false;
			Cassa1Img.Visible = false;
			Cassa4Img.Visible = false;
			Cassa2Img.Visible = false;
			label2.Visible = false;
			label3.Visible = false;
			label4.Visible = false;
			TrialLbl.Visible = false;
			TrialBox.Visible = false;
			StartCounterBtn.Visible = false;
			StopCounterBtn.Visible = false;
			ArrivalTimeLbl.Visible = false;
			textBox1.Visible = false;
			lbl_condition.Visible = false;
			lbl_orientation.Visible = false;
			//btnRecord.Visible = false;
		}
        private void Form1_Load(object sender, EventArgs e)
        {
			Initial_Visibility();
        }

		private void TrialBox_TextChanged(object sender, EventArgs e)
		{
			UpdateSensFilename();
		}

		private async void TriSoundBtn_Click(object sender, EventArgs e)
        {

			_task = expTask.TriSound;
			thisTaskLogger = TriangleSoundLogger;


			thisTaskLogger.CreateFolder();
			await thisTaskLogger.SetHeader(Form1Header);

			trialCounter++;
			TrialBox.Text = trialCounter.ToString();

			shuffle(ref random_a_o_cond);
			lbl_orientation.Text = trialCounter > NTrial? "" : random_a_o_cond[verse_rotation];

			previous = "B";
			current  = "B";

			UpdateLogBasicInfo();

			//speakers.startSpeaker(Speakers.available_speakers[0], "01 ", 1);
			ConfBtn.Visible = false;
			TriSoundBtn.Enabled = false;
			TriClassicBtn.Visible = false;

			C2StartBtn.Visible = true;
			C1StartBtn.Visible = true;
			C4StartBtn.Visible = true;
			C1StopBtn.Visible = true;
			C2StopBtn.Visible = false;
			C1StopBtn.Visible = false;
			C4StopBtn.Visible = false;
			StartAllBtn.Visible = false;
			StopAllBtn.Visible = false;
			EndCondBtn.Visible = true;
			ArrivalStartBtn.Visible = false;
			Cassa1Img.Visible = true;
			Cassa4Img.Visible = true;
			Cassa2Img.Visible = true;
			label2.Visible = true;
			label3.Visible = true;
			label4.Visible = true;

			TrialLbl.Visible = true;
			TrialBox.Visible = true;
			lbl_orientation.Visible = true;
			lbl_condition.Visible = true;

		}

        private void StopAllBtn_Click(object sender, EventArgs e)
        {

			speakers.stopspeaker();

			btnStopRecord_Click(sender, e);

			UpdateLogToStopBtn();
			thisTaskLogger.LogData();

			txt_Confusion.Text = (stopDate - startDate).TotalMilliseconds.ToString();

			if (++trialCounter > NTrial)
			{
				trialCounter = 9999;
				TrialBox.Text = "FINISHED";
			}
			else
			{
				TrialBox.Text = trialCounter.ToString();
			}

			TrialLbl.Visible = true;
			TrialBox.Visible = true;
			StopAllBtn.Visible = false;
			StartAllBtn.Visible = true;
			EndCondBtn.Visible = true;
			label7.Visible = true;
			txt_Confusion.Visible = true;


		}

        private void C2StartBtn_Click(object sender, EventArgs e)
        {
			EndCondBtn.Visible = false;
			C2StartBtn.Visible = false;
			C2StopBtn.Visible = true;
			C1StartBtn.Visible = false;
			C4StartBtn.Visible = false;
			
			speakers.startSpeaker(Speakers.available_speakers[0], "01 ", 1);

		}

		private void C2StopBtn_Click(object sender, EventArgs e)
        {
			EndCondBtn.Visible = true;
			C2StopBtn.Visible = false;
			C2StartBtn.Visible = true;
			C1StartBtn.Visible = true;
			C4StartBtn.Visible = true;
			speakers.stopspeaker();
		}
		private void C1StartBtn_Click(object sender, EventArgs e)
		{
			EndCondBtn.Visible = false;
			C1StartBtn.Visible = false;
			C1StopBtn.Visible = true;
			C2StartBtn.Visible = false;
			C4StartBtn.Visible = false;

			btnRecord_Click(sender, e);

			speakers.startSpeaker(Speakers.available_speakers[1], "01 ", 1);

			current = "C1";

			UpdateLogToStartBtn();
		}
		private void C1StopBtn_Click(object sender, EventArgs e)
        {
			EndCondBtn.Visible = true;
			C1StopBtn.Visible = false;
			C1StartBtn.Visible = true;
			C2StartBtn.Visible = true;
			C4StartBtn.Visible = true;
			label5.Visible = true;
			txt_box_2_1.Visible = true;
			
			speakers.stopspeaker();

			UpdateLogToStopBtn();
			thisTaskLogger.LogData();

			txt_box_2_1.Text = (stopDate - startDate).TotalMilliseconds.ToString();

			btnStopRecord_Click(sender, e);

			previous = "C1";
		}

		private void C4StartBtn_Click(object sender, EventArgs e)
		{
			EndCondBtn.Visible = false;
			C4StartBtn.Visible = false;
			C2StartBtn.Visible = false;
			C1StartBtn.Visible = false;
			C4StopBtn.Visible = true;

			btnRecord_Click(sender, e);

			speakers.startSpeaker(Speakers.available_speakers[2], "01 ", 1);

			current = "C4";

			UpdateLogToStartBtn();

		}
		private void C4StopBtn_Click(object sender, EventArgs e)
        {
			ArrivalStartBtn.Visible = true;
			EndCondBtn.Visible = true;
			C4StopBtn.Visible = false;
			C2StartBtn.Visible = true;
			C1StartBtn.Visible = true;
			C4StartBtn.Visible = true;
			label6.Visible = true;
			ArrivalStopBtn.Visible = false;
			txt_box_1_4.Visible = true;

			btnStopRecord_Click(sender, e);

			speakers.stopspeaker();

			UpdateLogToStopBtn();
			thisTaskLogger.LogData();

			txt_box_1_4.Text = (stopDate - startDate).TotalMilliseconds.ToString();

			previous = "C4";
		}

        private void StartAllBtn_Click(object sender, EventArgs e)
        {
			StartAllBtn.Visible = false;
			StopAllBtn.Visible = true;
			EndCondBtn.Visible = false;

			btnRecord_Click(sender, e);

			UpdateLogToStartBtn();

			speakers.startSpeaker(Speakers.available_speakers[2], "01 ", 2);

		}

        private void EndCondBtn_Click(object sender, EventArgs e)
        {
			EndCondBtn.Visible = false;
			Initial_Visibility();
			ConfBtn.Visible = true;
			TriSoundBtn.Visible = true;
			TriClassicBtn.Visible = true;
			TriClassicBtn.Enabled = true;
			TriSoundBtn.Enabled = true;
			ConfBtn.Enabled = true;

			btnStopAll_Click(sender, e);

			previous = "";
			current = "";
			trialCounter = 0;
			_task = expTask.NONE;
			thisTaskLogger = NullLogger;
        }

        private async void ConfBtn_Click(object sender, EventArgs e)
        {
			Initial_Visibility();
			TrialLbl.Visible = true;
			TrialBox.Visible = true;
			lbl_orientation.Visible = false;
			lbl_condition.Visible = false;

			ConfBtn.Enabled = false;
			TriSoundBtn.Visible = false;
			EndCondBtn.Visible = true;
			StartAllBtn.Visible = true;
			StopAllBtn.Visible = true;
			TriClassicBtn.Visible = false;

			_task = expTask.Confusion;
			thisTaskLogger = ConfusionLogger;



			thisTaskLogger.CreateFolder();
			await thisTaskLogger.SetHeader(Form1Header);

			trialCounter++;
			TrialBox.Text = trialCounter.ToString();
			lbl_orientation.Text = "";


			UpdateLogBasicInfo();
		}

        private async void TriClassicBtn_Click(object sender, EventArgs e)
        {
			Initial_Visibility();
			ConfBtn.Visible = false;
			TriSoundBtn.Visible = false;
			EndCondBtn.Visible = true;
			StartCounterBtn.Visible = true;
			StopCounterBtn.Visible = false;
			TriClassicBtn.Enabled = false;
			TrialLbl.Visible = true;
			TrialBox.Visible = true;
			lbl_orientation.Visible = true;
			lbl_condition.Visible = true;


			thisTaskLogger = TriangleClassicLogger;
			_task = expTask.TriClassic;

			thisTaskLogger.CreateFolder();
			await thisTaskLogger.SetHeader(Form1Header);

			trialCounter++;
			TrialBox.Text = trialCounter.ToString();

			shuffle(ref random_a_o_cond);
			lbl_orientation.Text = trialCounter > NTrial ? "" : random_a_o_cond[verse_rotation];

			UpdateLogBasicInfo();


		}

        private void StartCounterBtn_Click(object sender, EventArgs e)
        {

				btnRecord_Click(sender, e);

			StartCounterBtn.Visible = false;
			StopCounterBtn.Visible = true;
			btnRecord.Enabled = false;

			lbl_orientation.Visible = true;
			lbl_condition.Visible = true;

			UpdateLogToStartBtn();

		}

		private void StopCounterBtn_Click(object sender, EventArgs e)
		{

			UpdateLogToStopBtn();
			thisTaskLogger.LogData();

			textBox1.Text = (stopDate - startDate).TotalMilliseconds.ToString();
			
			btnStopRecord_Click(sender, e);



			if (++trialCounter > NTrial)
			{
				trialCounter = 9999;
				TrialBox.Text = "FINISHED";
			}
			else
			{
				TrialBox.Text = trialCounter.ToString();
			}
			lbl_orientation.Text = trialCounter > NTrial ? "" : random_a_o_cond[verse_rotation];

			StopCounterBtn.Visible = false;
			StartCounterBtn.Visible = true;
			ArrivalTimeLbl.Visible = true;
			textBox1.Visible = true;
			btnStopRecord.Enabled = false;
			TrialLbl.Visible = true;
			TrialBox.Visible = true;
		}

        private void ArrivalStartBtn_Click(object sender, EventArgs e)
        {
			ArrivalStartBtn.Visible = false;
			ArrivalStopBtn.Visible = true;

			startDate = DateTime.Now;
			thisTaskLogger.UpdateValue("StartPoint", previous);

			current = "B";

			UpdateLogToStartBtn();

		}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ArrivalStopBtn_Click(object sender, EventArgs e)
        {

			ArrivalTimeLbl.Visible = true;
			ArrivalStopBtn.Visible = false;
			ArrivalStartBtn.Visible = false;
			textBox1.Visible = true;
			TrialLbl.Visible = true;
			TrialBox.Visible = true;


			UpdateLogToStopBtn();
			thisTaskLogger.LogData();

			textBox1.Text = (stopDate - startDate).TotalMilliseconds.ToString();

			if (++trialCounter > NTrial)
			{
				trialCounter = 9999;
				TrialBox.Text = "FINISHED";
			}
			else
			{
				TrialBox.Text = trialCounter.ToString();
			}
			lbl_orientation.Text = trialCounter > NTrial ? "" : random_a_o_cond[verse_rotation];



			previous = current;
			current = "B";
		}

		#endregion

		void UpdateSensFilename()
        {
			if (_task == expTask.TriSound)
				SensFilenameBox.Text = string.Join("_", new string[] { thisTaskLogger.thisFileName, trialCounter.ToString(), previous+current }) + ".mtb";
			else
				SensFilenameBox.Text = string.Join("_", new string[] { thisTaskLogger.thisFileName, trialCounter.ToString() }) + ".mtb";

		}
		void UpdateLogBasicInfo()
        {
			thisTaskLogger.UpdateValue("Code", thisTaskLogger.thisFileName);
			thisTaskLogger.UpdateValue("ID", ID);
			thisTaskLogger.UpdateValue("Task", _task.ToString());
		}

		void UpdateLogToStartBtn()
		{
			startDate = DateTime.Now;
			UpdateSensFilename();
			thisTaskLogger.UpdateValue("StartPoint", previous);
			thisTaskLogger.UpdateValue("Trial", trialCounter);
			thisTaskLogger.UpdateValue("StartTimestamp", (startDate - rootDate).TotalMilliseconds);
			thisTaskLogger.UpdateValue("Condition", lbl_orientation.Text);
		}

		void UpdateLogToStopBtn()
        {
			stopDate = DateTime.Now;
			thisTaskLogger.UpdateValue("StopPoint", current);
			thisTaskLogger.UpdateValue("sensordata", SensFilenameBox.Text);
			thisTaskLogger.UpdateValue("StopTimestamp", (stopDate - rootDate).TotalMilliseconds);
		}

		void shuffle<T>(ref List<T> orderedList)
        {
			var rand1 = new Random();

			for (int i = 0; i < orderedList.Count(); i++)
			{
				var randNum = rand1.Next(i, orderedList.Count);
				var temp = orderedList[randNum];
				orderedList[randNum] = orderedList[i];
				orderedList[i] = temp;
			}
		}

    }
}
