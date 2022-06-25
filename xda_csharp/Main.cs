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
using System.Threading;
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

		private DateTime rootDate;
		private DateTime startDate;
		private DateTime stopDate;

		private string previous;
		private string current;


		public string ID;

		expTask _task = expTask.NONE;

		private Logger TriangleClassicLogger;
		private Logger TriangleSoundLogger;
		private Logger ConfusionLogger;
		private Logger NullLogger;

		private Logger thisTaskLogger;

		private string[] Form1Header = new string[] { "Code", "ID", "Task", "Condition", "Trial", "StartPoint", "StopPoint", "StartTimestamp", "StopTimestamp", "sensordata", "angle_abs", "radius_abs", "angle_rel" };

		public Form1(string str)
        {
            InitializeComponent();
            _xda = new MyXda();
			cbxChannel.SelectedIndex = 0;
            step(1);
			
			speakers = new Speakers();

			previous = "B";
			current = "B";

			ID = str;
			
			Logger.SetCommonPath(appPath, "results", ID);
			TriangleClassicLogger = new Logger(expTask.TriClassic.ToString(), destinationFolder: ID, extension: "dat", keepStream: false);
			TriangleSoundLogger = new Logger(expTask.TriSound.ToString(), destinationFolder: ID, extension: "dat", keepStream: false);
			ConfusionLogger = new Logger(expTask.Confusion.ToString(), destinationFolder: ID, extension: "dat", keepStream: false);
			NullLogger = new Logger(expTask.NONE.ToString(), destinationFolder: ID, extension: "dat", keepStream: false);
			thisTaskLogger = NullLogger;

			UpdateSensFilename();

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

		private void btnRecord_Click(object sender, EventArgs e)
		{
			if (InvokeRequired)
			{
				// Update UI, make sure this happens on the UI thread
				BeginInvoke(new Action(delegate { btnRecord_Click(sender, e); }));
			}
			else
			{
				_measuringDevice.createLogFile(new XsString(Path.Combine(thisTaskLogger.thisFileFolder, SensFilenameBox.Text)));
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
			}
		}

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
			button10.Visible = false;
			button11.Visible = false;
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
			button10.Visible = false;
			button11.Visible = false;
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
		}

        private void button11_Click(object sender, EventArgs e)
        {
			button11.Visible = false;
			button10.Visible = true;
			EndCondBtn.Visible = true;
			label7.Visible = true;
			txt_Confusion.Visible = true;
			speakers.stopspeaker();
			btnStopRecord.Enabled = false;
			timer1.Enabled = false;

			if (_measuringDevice.isRecording())
				_measuringDevice.stopRecording();
			_measuringDevice.gotoConfig();
			_measuringDevice.disableRadio();
			_measuringDevice.clearCallbackHandlers();

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
			
			trialCounter = trialCounter + 1;
			Int32 unixTimestamp = (Int32)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
			txt_Confusion.Text = unixTimestamp.ToString();
			TrialBox.Text = trialCounter.ToString();
			TrialLbl.Visible = true;
			TrialBox.Visible = true;

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

			btnStopRecord_Click(sender,e);
			
			speakers.stopspeaker();

			UpdateLogToStopBtn();
			thisTaskLogger.LogData();

			txt_box_2_1.Text = (stopDate - startDate).TotalMilliseconds.ToString();

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

        private void button10_Click(object sender, EventArgs e)
        {
			button10.Visible = false;
			button11.Visible = true;
			EndCondBtn.Visible = false;
			_measuringDevice.createLogFile(new XsString(SensFilenameBox.Text));
			_measuringDevice.startRecording();
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
			
			trialCounter = 0;
			_task = expTask.NONE;
			thisTaskLogger = NullLogger;
        }

        private async void ConfBtn_Click(object sender, EventArgs e)
        {
			ConfBtn.Enabled = false;
			TriSoundBtn.Visible = false;
			Initial_Visibility();
			EndCondBtn.Visible = true;
			button10.Visible = true;
			button11.Visible = true;
			TriClassicBtn.Visible = false;

			_task = expTask.Confusion;
			thisTaskLogger = ConfusionLogger;


			thisTaskLogger.CreateFolder();
			await thisTaskLogger.SetHeader(Form1Header);

			TrialBox.Text = trialCounter.ToString();

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


			thisTaskLogger = TriangleClassicLogger;
			_task = expTask.TriClassic;

			thisTaskLogger.CreateFolder();
			await thisTaskLogger.SetHeader(Form1Header);
			
			trialCounter++;
			TrialBox.Text = trialCounter.ToString();

			UpdateLogBasicInfo();


		}

        private void StartCounterBtn_Click(object sender, EventArgs e)
        {

			btnRecord_Click(sender, e);

			StartCounterBtn.Visible = false;
			StopCounterBtn.Visible = true;
			btnRecord.Enabled = false;
			
			thisTaskLogger.UpdateValue("Trial", trialCounter);
		}

		private void StopCounterBtn_Click(object sender, EventArgs e)
		{
			timer1.Enabled = false;

			int unixTimestamp = (int)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
			thisTaskLogger.UpdateValue("sensordata", SensFilenameBox.Text);
			thisTaskLogger.UpdateValue("StopTimestamp", unixTimestamp);
			thisTaskLogger.LogData();

			btnStopRecord_Click(sender, e);

			trialCounter++;

			StopCounterBtn.Visible = false;
			StartCounterBtn.Visible = true;
			ArrivalTimeLbl.Visible = true;
			textBox1.Visible = true;
			btnStopRecord.Enabled = false;
			textBox1.Text = unixTimestamp.ToString();
			TrialBox.Text = trialCounter.ToString();
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

			
			textBox1.Text = (stopDate - startDate).TotalMilliseconds.ToString();

			UpdateLogToStopBtn();
			thisTaskLogger.LogData();

			trialCounter++;
			TrialBox.Text = trialCounter.ToString();
			
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
		}

		void UpdateLogToStopBtn()
        {
			stopDate = DateTime.Now;
			thisTaskLogger.UpdateValue("StopPoint", current);
			thisTaskLogger.UpdateValue("sensordata", SensFilenameBox.Text);
			thisTaskLogger.UpdateValue("StopTimestamp", (stopDate - rootDate).TotalMilliseconds);
		}

    }
}
