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

namespace MTixExample
{
	public partial class Form1 : Form
	{
		private MyXda _xda;
		private XsDevice _measuringDevice = null;
		private MyMtCallback _myMtCallback = null;
		private ConnectedMtData _connectedData = new ConnectedMtData();

		public Form1()
		{
			InitializeComponent();
			_xda = new MyXda();
			rtbSteps.Text = "Press 'Scan' to scan for MTi / MTx / Mk4 devices";
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			timer1.Enabled = false;

			if (_measuringDevice != null)
				_measuringDevice.clearCallbackHandlers();
			if (_myMtCallback != null)
				_myMtCallback.Dispose();

			_xda.Dispose();
			_xda = null;
		}

		private void btnScan_Click(object sender, EventArgs e)
		{
			rtbSteps.Text = "Scanning for devices...";
			btnScan.Enabled = false;
			Update();

			_xda.reset();
			_xda.scanPorts();
			if (_xda._DetectedDevices.Count > 0)
			{
				rtbSteps.Text = string.Format("Found {0} device(s)\n", _xda._DetectedDevices.Count);
				XsPortInfo portInfo = _xda._DetectedDevices[0];
				if (portInfo.deviceId().isMtMk4() || portInfo.deviceId().isFmt_X000() || portInfo.deviceId().isMt9c() || portInfo.deviceId().isLegacyMtig())
				{
					rtbSteps.Text += "Opening port...\n";
					_xda.openPort(portInfo);
					MasterInfo ai = new MasterInfo(portInfo.deviceId());
					ai.ComPort = portInfo.portName();
					ai.BaudRate = portInfo.baudrate();

					_measuringDevice = _xda.getDevice(ai.DeviceId);
					ai.ProductCode = new XsString(_measuringDevice.productCode());

					// Print information about detected MTi / MTx / MTmk4 device
					rtbSteps.Text += string.Format("Found a device with id: {0} @ port: {1}, baudrate: {2}\n", _measuringDevice.deviceId().toXsString().toString(), ai.ComPort.toString(), ai.BaudRate);

					// Create and attach callback handler to device
					_myMtCallback = new MyMtCallback();
					_measuringDevice.addCallbackHandler(_myMtCallback);

					ConnectedMtData mtwData = new ConnectedMtData();

					// connect signals
					_myMtCallback.DataAvailable += new EventHandler<DataAvailableArgs>(_callbackHandler_DataAvailable);

					// Put the device in configuration mode
					rtbSteps.Text += "Putting device into configuration mode...\n";
					if (!_measuringDevice.gotoConfig()) // Put the device into configuration mode before configuring the device
					{
						rtbSteps.Text = "Could not put device into configuration mode. Aborting.";
						return;
					}

					// Configure the device. Note the differences between MTix and MTmk4
					rtbSteps.Text += "Configuring the device...\n";
					if (_measuringDevice.deviceId().isMt9c() || _measuringDevice.deviceId().isLegacyMtig())
					{
						XsOutputMode outputMode = XsOutputMode.XOM_Orientation; // output orientation data
						XsOutputSettings outputSettings = XsOutputSettings.XOS_OrientationMode_Quaternion; // output orientation data as quaternion
						XsDeviceMode deviceMode = new XsDeviceMode(100); // make a device mode with update rate: 100 Hz
						deviceMode.setModeFlag(outputMode);
						deviceMode.setSettingsFlag(outputSettings);

						// set the device configuration
						if (!_measuringDevice.setDeviceMode(deviceMode))
						{
							rtbSteps.Text = "Could not configure MTix device. Aborting.";
							return;
						}
					}
					else if (_measuringDevice.deviceId().isMtMk4() || _measuringDevice.deviceId().isFmt_X000())
					{
                        XsOutputConfigurationArray configArray = new XsOutputConfigurationArray();
                        if (_measuringDevice.deviceId().isMtMk4_1() || _measuringDevice.deviceId().isMtMk4_10() || _measuringDevice.deviceId().isMtMk4_100() || _measuringDevice.deviceId().isFmt1010())
                        {
                            configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_PacketCounter, 0));
                            configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_SampleTimeFine, 0));
                            configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_DeltaV, 100));
                            configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_DeltaQ, 100));
                            configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_MagneticField, 100));        
                        }
                        else
                        {
                            configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_PacketCounter, 0));
                            configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_SampleTimeFine, 0));
                            configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_Quaternion, 100));
                            configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_DeltaV, 100));
                            configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_DeltaQ, 100));
                            configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_MagneticField, 100));
                            configArray.push_back(new XsOutputConfiguration(XsDataIdentifier.XDI_StatusWord, 0));
                        }
						if (!_measuringDevice.setOutputConfiguration(configArray))
						{
							rtbSteps.Text = "Could not configure MTmk4 device. Aborting.";
							return;
						}
					}
					else
					{
						rtbSteps.Text = "Unknown device while configuring. Aborting.";
						return;
					}

					// Put the device in measurement mode
					rtbSteps.Text += "Putting device into measurement mode...\n";
					if (!_measuringDevice.gotoMeasurement())
					{
						rtbSteps.Text = "Could not put device into measurement mode. Aborting.";
						return;
					}
					btnRecord.Enabled = true;
				}
				timer1.Interval = 20;
				timer1.Enabled = true;
			}
			else
			{
				rtbSteps.Text = "No devices detected. Press 'Scan' to retry.";
				btnScan.Enabled = true;
			}
		}

		private void btnRecord_Click(object sender, EventArgs e)
		{
			_measuringDevice.createLogFile(new XsString(textBoxFilename.Text));
			_measuringDevice.startRecording();
			btnRecord.Enabled = false;
			btnStop.Enabled = true;
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			btnStop.Enabled = false;
			timer1.Enabled = false;

			if (_measuringDevice.isRecording())
				_measuringDevice.stopRecording();
			_measuringDevice.gotoConfig();
			_measuringDevice.clearCallbackHandlers();
			_measuringDevice = null;

			btnScan.Enabled = true;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (_connectedData._orientation != null)
			{
				rtbData.Text = string.Format("{0,-5:f2}, {1,-5:f2}, {2,-5:f2} [°]\n\n",
									   _connectedData._orientation.x(),
									   _connectedData._orientation.y(),
									   _connectedData._orientation.z());
			}
            if (_connectedData._calibratedData != null)
            {
                rtbData.Text += string.Format("{0,-5:f2}, {1,-5:f2}, {2,-5:f2} \n{3,-5:f2}, {4,-5:f2}, {5,-5:f2} \n{6,-5:f2}, {7,-5:f2}, {8,-5:f2} \n",
                                       _connectedData._calibratedData.m_acc.value(0),
                                       _connectedData._calibratedData.m_acc.value(1),
                                       _connectedData._calibratedData.m_acc.value(2),
                                       _connectedData._calibratedData.m_gyr.value(0),
                                       _connectedData._calibratedData.m_gyr.value(1),
                                       _connectedData._calibratedData.m_gyr.value(2),
                                       _connectedData._calibratedData.m_mag.value(0),
                                       _connectedData._calibratedData.m_mag.value(1),
                                       _connectedData._calibratedData.m_mag.value(2));
            }
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
                _connectedData._orientation = oriEuler;
                XsCalibratedData calData = e.Packet.calibratedData();
                _connectedData._calibratedData = calData;
			}
		}
	}
}
