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

﻿namespace MTwExample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.lblChannel = new System.Windows.Forms.Label();
            this.cbxStations = new System.Windows.Forms.ComboBox();
            this.lblDeviceCount = new System.Windows.Forms.Label();
            this.btnMeasure = new System.Windows.Forms.Button();
            this.btnStopRecord = new System.Windows.Forms.Button();
            this.btnStopAll = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rtbSteps = new System.Windows.Forms.RichTextBox();
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.cbxChannel = new System.Windows.Forms.ComboBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.SensFilenameBox = new System.Windows.Forms.TextBox();
            this.ConfBtn = new System.Windows.Forms.Button();
            this.TriSoundBtn = new System.Windows.Forms.Button();
            this.COMPortLbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.C2StartBtn = new System.Windows.Forms.Button();
            this.C2StopBtn = new System.Windows.Forms.Button();
            this.C1StartBtn = new System.Windows.Forms.Button();
            this.C1StopBtn = new System.Windows.Forms.Button();
            this.C4StartBtn = new System.Windows.Forms.Button();
            this.C4StopBtn = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_box_2_1 = new System.Windows.Forms.TextBox();
            this.txt_box_1_4 = new System.Windows.Forms.TextBox();
            this.EndCondBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Confusion = new System.Windows.Forms.TextBox();
            this.TriClassicBtn = new System.Windows.Forms.Button();
            this.StartCounterBtn = new System.Windows.Forms.Button();
            this.StopCounterBtn = new System.Windows.Forms.Button();
            this.ArrivalTimeLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TrialLbl = new System.Windows.Forms.Label();
            this.TrialBox = new System.Windows.Forms.TextBox();
            this.Cassa2Img = new System.Windows.Forms.PictureBox();
            this.Cassa4Img = new System.Windows.Forms.PictureBox();
            this.Cassa1Img = new System.Windows.Forms.PictureBox();
            this.ArrivalStartBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ArrivalStopBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Cassa2Img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cassa4Img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cassa1Img)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(13, 12);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(92, 23);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Enabled = false;
            this.btnEnable.Location = new System.Drawing.Point(12, 111);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(92, 23);
            this.btnEnable.TabIndex = 3;
            this.btnEnable.Text = "Enable Radio";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Location = new System.Drawing.Point(16, 82);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(49, 13);
            this.lblChannel.TabIndex = 4;
            this.lblChannel.Text = "Channel:";
            // 
            // cbxStations
            // 
            this.cbxStations.FormattingEnabled = true;
            this.cbxStations.Location = new System.Drawing.Point(13, 51);
            this.cbxStations.Name = "cbxStations";
            this.cbxStations.Size = new System.Drawing.Size(290, 21);
            this.cbxStations.TabIndex = 5;
            // 
            // lblDeviceCount
            // 
            this.lblDeviceCount.AutoSize = true;
            this.lblDeviceCount.Location = new System.Drawing.Point(120, 151);
            this.lblDeviceCount.Name = "lblDeviceCount";
            this.lblDeviceCount.Size = new System.Drawing.Size(105, 13);
            this.lblDeviceCount.TabIndex = 6;
            this.lblDeviceCount.Text = "MTw\'s Connected: 0";
            // 
            // btnMeasure
            // 
            this.btnMeasure.Enabled = false;
            this.btnMeasure.Location = new System.Drawing.Point(12, 146);
            this.btnMeasure.Name = "btnMeasure";
            this.btnMeasure.Size = new System.Drawing.Size(92, 23);
            this.btnMeasure.TabIndex = 8;
            this.btnMeasure.Text = "Measure";
            this.btnMeasure.UseVisualStyleBackColor = true;
            this.btnMeasure.Click += new System.EventHandler(this.btnMeasure_Click);
            // 
            // btnStopRecord
            // 
            this.btnStopRecord.Enabled = false;
            this.btnStopRecord.Location = new System.Drawing.Point(13, 205);
            this.btnStopRecord.Name = "btnStopRecord";
            this.btnStopRecord.Size = new System.Drawing.Size(91, 23);
            this.btnStopRecord.TabIndex = 9;
            this.btnStopRecord.Text = "Stop Record";
            this.btnStopRecord.UseVisualStyleBackColor = true;
            this.btnStopRecord.Click += new System.EventHandler(this.btnStopRecord_Click);
            // 
            // btnStopAll
            // 
            this.btnStopAll.Enabled = false;
            this.btnStopAll.Location = new System.Drawing.Point(14, 234);
            this.btnStopAll.Name = "btnStopAll";
            this.btnStopAll.Size = new System.Drawing.Size(91, 23);
            this.btnStopAll.TabIndex = 58;
            this.btnStopAll.Text = "Stop All";
            this.btnStopAll.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rtbSteps
            // 
            this.rtbSteps.Location = new System.Drawing.Point(315, 51);
            this.rtbSteps.Name = "rtbSteps";
            this.rtbSteps.ReadOnly = true;
            this.rtbSteps.Size = new System.Drawing.Size(158, 200);
            this.rtbSteps.TabIndex = 10;
            this.rtbSteps.Text = "";
            // 
            // rtbData
            // 
            this.rtbData.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbData.Location = new System.Drawing.Point(12, 273);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(483, 293);
            this.rtbData.TabIndex = 11;
            this.rtbData.Text = "";
            // 
            // cbxChannel
            // 
            this.cbxChannel.DisplayMember = "19";
            this.cbxChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChannel.FormattingEnabled = true;
            this.cbxChannel.Items.AddRange(new object[] {
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.cbxChannel.Location = new System.Drawing.Point(71, 77);
            this.cbxChannel.Name = "cbxChannel";
            this.cbxChannel.Size = new System.Drawing.Size(73, 21);
            this.cbxChannel.TabIndex = 12;
            // 
            // btnRecord
            // 
            this.btnRecord.Enabled = false;
            this.btnRecord.Location = new System.Drawing.Point(12, 176);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(92, 23);
            this.btnRecord.TabIndex = 13;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // SensFilenameBox
            // 
            this.SensFilenameBox.Location = new System.Drawing.Point(110, 176);
            this.SensFilenameBox.Name = "SensFilenameBox";
            this.SensFilenameBox.ReadOnly = true;
            this.SensFilenameBox.Size = new System.Drawing.Size(193, 20);
            this.SensFilenameBox.TabIndex = 21;
            // 
            // ConfBtn
            // 
            this.ConfBtn.Location = new System.Drawing.Point(499, 8);
            this.ConfBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ConfBtn.Name = "ConfBtn";
            this.ConfBtn.Size = new System.Drawing.Size(89, 23);
            this.ConfBtn.TabIndex = 22;
            this.ConfBtn.Text = "CONFUSION";
            this.ConfBtn.UseVisualStyleBackColor = true;
            this.ConfBtn.Click += new System.EventHandler(this.ConfBtn_Click);
            // 
            // TriSoundBtn
            // 
            this.TriSoundBtn.Location = new System.Drawing.Point(499, 34);
            this.TriSoundBtn.Margin = new System.Windows.Forms.Padding(2);
            this.TriSoundBtn.Name = "TriSoundBtn";
            this.TriSoundBtn.Size = new System.Drawing.Size(136, 23);
            this.TriSoundBtn.TabIndex = 23;
            this.TriSoundBtn.Text = "TRIANGLE SOUND";
            this.TriSoundBtn.UseVisualStyleBackColor = true;
            this.TriSoundBtn.Click += new System.EventHandler(this.TriSoundBtn_Click);
            // 
            // COMPortLbl
            // 
            this.COMPortLbl.AutoSize = true;
            this.COMPortLbl.Location = new System.Drawing.Point(649, 27);
            this.COMPortLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.COMPortLbl.Name = "COMPortLbl";
            this.COMPortLbl.Size = new System.Drawing.Size(71, 13);
            this.COMPortLbl.TabIndex = 24;
            this.COMPortLbl.Text = "PORTA COM";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(652, 42);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(737, 38);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 27);
            this.button3.TabIndex = 26;
            this.button3.Text = "SET";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Speaker Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Speaker Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(733, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Speaker Number";
            // 
            // C2StartBtn
            // 
            this.C2StartBtn.Location = new System.Drawing.Point(511, 273);
            this.C2StartBtn.Margin = new System.Windows.Forms.Padding(2);
            this.C2StartBtn.Name = "C2StartBtn";
            this.C2StartBtn.Size = new System.Drawing.Size(56, 20);
            this.C2StartBtn.TabIndex = 33;
            this.C2StartBtn.Text = "START";
            this.C2StartBtn.UseVisualStyleBackColor = true;
            this.C2StartBtn.Click += new System.EventHandler(this.C2StartBtn_Click);
            // 
            // C2StopBtn
            // 
            this.C2StopBtn.Location = new System.Drawing.Point(511, 297);
            this.C2StopBtn.Margin = new System.Windows.Forms.Padding(2);
            this.C2StopBtn.Name = "C2StopBtn";
            this.C2StopBtn.Size = new System.Drawing.Size(56, 20);
            this.C2StopBtn.TabIndex = 34;
            this.C2StopBtn.Text = "STOP";
            this.C2StopBtn.UseVisualStyleBackColor = true;
            this.C2StopBtn.Click += new System.EventHandler(this.C2StopBtn_Click);
            // 
            // C1StartBtn
            // 
            this.C1StartBtn.Location = new System.Drawing.Point(637, 200);
            this.C1StartBtn.Margin = new System.Windows.Forms.Padding(2);
            this.C1StartBtn.Name = "C1StartBtn";
            this.C1StartBtn.Size = new System.Drawing.Size(63, 20);
            this.C1StartBtn.TabIndex = 35;
            this.C1StartBtn.Text = "START";
            this.C1StartBtn.UseVisualStyleBackColor = true;
            this.C1StartBtn.Click += new System.EventHandler(this.C1StartBtn_Click);
            // 
            // C1StopBtn
            // 
            this.C1StopBtn.Location = new System.Drawing.Point(637, 224);
            this.C1StopBtn.Margin = new System.Windows.Forms.Padding(2);
            this.C1StopBtn.Name = "C1StopBtn";
            this.C1StopBtn.Size = new System.Drawing.Size(63, 20);
            this.C1StopBtn.TabIndex = 36;
            this.C1StopBtn.Text = "STOP";
            this.C1StopBtn.UseVisualStyleBackColor = true;
            this.C1StopBtn.Click += new System.EventHandler(this.C1StopBtn_Click);
            // 
            // C4StartBtn
            // 
            this.C4StartBtn.Location = new System.Drawing.Point(746, 273);
            this.C4StartBtn.Margin = new System.Windows.Forms.Padding(2);
            this.C4StartBtn.Name = "C4StartBtn";
            this.C4StartBtn.Size = new System.Drawing.Size(56, 20);
            this.C4StartBtn.TabIndex = 37;
            this.C4StartBtn.Text = "START";
            this.C4StartBtn.UseVisualStyleBackColor = true;
            this.C4StartBtn.Click += new System.EventHandler(this.C4StartBtn_Click);
            // 
            // C4StopBtn
            // 
            this.C4StopBtn.Location = new System.Drawing.Point(746, 297);
            this.C4StopBtn.Margin = new System.Windows.Forms.Padding(2);
            this.C4StopBtn.Name = "C4StopBtn";
            this.C4StopBtn.Size = new System.Drawing.Size(56, 20);
            this.C4StopBtn.TabIndex = 38;
            this.C4StopBtn.Text = "STOP";
            this.C4StopBtn.UseVisualStyleBackColor = true;
            this.C4StopBtn.Click += new System.EventHandler(this.C4StopBtn_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(627, 272);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(73, 20);
            this.button10.TabIndex = 39;
            this.button10.Text = "START ALL";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(627, 296);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(73, 20);
            this.button11.TabIndex = 40;
            this.button11.Text = "STOP ALL";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 369);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Arrival Time 2 ->1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 393);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Arrival Time 1 ->4";
            // 
            // txt_box_2_1
            // 
            this.txt_box_2_1.Location = new System.Drawing.Point(599, 365);
            this.txt_box_2_1.Margin = new System.Windows.Forms.Padding(2);
            this.txt_box_2_1.Name = "txt_box_2_1";
            this.txt_box_2_1.Size = new System.Drawing.Size(68, 20);
            this.txt_box_2_1.TabIndex = 43;
            // 
            // txt_box_1_4
            // 
            this.txt_box_1_4.Location = new System.Drawing.Point(599, 389);
            this.txt_box_1_4.Margin = new System.Windows.Forms.Padding(2);
            this.txt_box_1_4.Name = "txt_box_1_4";
            this.txt_box_1_4.Size = new System.Drawing.Size(68, 20);
            this.txt_box_1_4.TabIndex = 44;
            // 
            // EndCondBtn
            // 
            this.EndCondBtn.Location = new System.Drawing.Point(606, 502);
            this.EndCondBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EndCondBtn.Name = "EndCondBtn";
            this.EndCondBtn.Size = new System.Drawing.Size(133, 23);
            this.EndCondBtn.TabIndex = 45;
            this.EndCondBtn.Text = "END CONDITION";
            this.EndCondBtn.UseVisualStyleBackColor = true;
            this.EndCondBtn.Click += new System.EventHandler(this.EndCondBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(499, 343);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Time Confusion";
            // 
            // txt_Confusion
            // 
            this.txt_Confusion.Location = new System.Drawing.Point(599, 341);
            this.txt_Confusion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Confusion.Name = "txt_Confusion";
            this.txt_Confusion.Size = new System.Drawing.Size(68, 20);
            this.txt_Confusion.TabIndex = 47;
            // 
            // TriClassicBtn
            // 
            this.TriClassicBtn.Location = new System.Drawing.Point(501, 61);
            this.TriClassicBtn.Margin = new System.Windows.Forms.Padding(2);
            this.TriClassicBtn.Name = "TriClassicBtn";
            this.TriClassicBtn.Size = new System.Drawing.Size(134, 23);
            this.TriClassicBtn.TabIndex = 48;
            this.TriClassicBtn.Text = "TRIANGLE CLASSIC";
            this.TriClassicBtn.UseVisualStyleBackColor = true;
            this.TriClassicBtn.Click += new System.EventHandler(this.TriClassicBtn_Click);
            // 
            // StartCounterBtn
            // 
            this.StartCounterBtn.Location = new System.Drawing.Point(627, 272);
            this.StartCounterBtn.Margin = new System.Windows.Forms.Padding(2);
            this.StartCounterBtn.Name = "StartCounterBtn";
            this.StartCounterBtn.Size = new System.Drawing.Size(112, 20);
            this.StartCounterBtn.TabIndex = 49;
            this.StartCounterBtn.Text = "START COUNTER";
            this.StartCounterBtn.UseVisualStyleBackColor = true;
            this.StartCounterBtn.Click += new System.EventHandler(this.StartCounterBtn_Click);
            // 
            // StopCounterBtn
            // 
            this.StopCounterBtn.Location = new System.Drawing.Point(627, 296);
            this.StopCounterBtn.Margin = new System.Windows.Forms.Padding(2);
            this.StopCounterBtn.Name = "StopCounterBtn";
            this.StopCounterBtn.Size = new System.Drawing.Size(112, 20);
            this.StopCounterBtn.TabIndex = 50;
            this.StopCounterBtn.Text = "STOP COUNTER";
            this.StopCounterBtn.UseVisualStyleBackColor = true;
            this.StopCounterBtn.Click += new System.EventHandler(this.StopCounterBtn_Click);
            // 
            // ArrivalTimeLbl
            // 
            this.ArrivalTimeLbl.AutoSize = true;
            this.ArrivalTimeLbl.Location = new System.Drawing.Point(499, 341);
            this.ArrivalTimeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ArrivalTimeLbl.Name = "ArrivalTimeLbl";
            this.ArrivalTimeLbl.Size = new System.Drawing.Size(65, 13);
            this.ArrivalTimeLbl.TabIndex = 51;
            this.ArrivalTimeLbl.Text = "Arrival Time ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(619, 341);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 52;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TrialLbl
            // 
            this.TrialLbl.AutoSize = true;
            this.TrialLbl.Location = new System.Drawing.Point(691, 376);
            this.TrialLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TrialLbl.Name = "TrialLbl";
            this.TrialLbl.Size = new System.Drawing.Size(44, 13);
            this.TrialLbl.TabIndex = 53;
            this.TrialLbl.Text = "TRIAL: ";
            // 
            // TrialBox
            // 
            this.TrialBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TrialBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrialBox.ForeColor = System.Drawing.Color.Red;
            this.TrialBox.Location = new System.Drawing.Point(736, 376);
            this.TrialBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TrialBox.Name = "TrialBox";
            this.TrialBox.ReadOnly = true;
            this.TrialBox.Size = new System.Drawing.Size(48, 13);
            this.TrialBox.TabIndex = 54;
            this.TrialBox.Text = "label10";
            this.TrialBox.TextChanged += new System.EventHandler(this.TrialBox_TextChanged);
            // 
            // Cassa2Img
            // 
            this.Cassa2Img.Image = global::example.Properties.Resources.two;
            this.Cassa2Img.Location = new System.Drawing.Point(495, 180);
            this.Cassa2Img.Margin = new System.Windows.Forms.Padding(2);
            this.Cassa2Img.Name = "Cassa2Img";
            this.Cassa2Img.Size = new System.Drawing.Size(87, 88);
            this.Cassa2Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cassa2Img.TabIndex = 29;
            this.Cassa2Img.TabStop = false;
            // 
            // Cassa4Img
            // 
            this.Cassa4Img.Image = global::example.Properties.Resources.four11;
            this.Cassa4Img.Location = new System.Drawing.Point(729, 180);
            this.Cassa4Img.Margin = new System.Windows.Forms.Padding(2);
            this.Cassa4Img.Name = "Cassa4Img";
            this.Cassa4Img.Size = new System.Drawing.Size(90, 88);
            this.Cassa4Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cassa4Img.TabIndex = 28;
            this.Cassa4Img.TabStop = false;
            // 
            // Cassa1Img
            // 
            this.Cassa1Img.Image = global::example.Properties.Resources.one2;
            this.Cassa1Img.Location = new System.Drawing.Point(619, 104);
            this.Cassa1Img.Margin = new System.Windows.Forms.Padding(2);
            this.Cassa1Img.Name = "Cassa1Img";
            this.Cassa1Img.Size = new System.Drawing.Size(81, 90);
            this.Cassa1Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cassa1Img.TabIndex = 27;
            this.Cassa1Img.TabStop = false;
            // 
            // ArrivalStartBtn
            // 
            this.ArrivalStartBtn.Location = new System.Drawing.Point(627, 272);
            this.ArrivalStartBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ArrivalStartBtn.Name = "ArrivalStartBtn";
            this.ArrivalStartBtn.Size = new System.Drawing.Size(112, 20);
            this.ArrivalStartBtn.TabIndex = 55;
            this.ArrivalStartBtn.Text = "START ARRIVAL";
            this.ArrivalStartBtn.UseVisualStyleBackColor = true;
            this.ArrivalStartBtn.Click += new System.EventHandler(this.ArrivalStartBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(499, 440);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 56;
            // 
            // ArrivalStopBtn
            // 
            this.ArrivalStopBtn.Location = new System.Drawing.Point(627, 297);
            this.ArrivalStopBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ArrivalStopBtn.Name = "ArrivalStopBtn";
            this.ArrivalStopBtn.Size = new System.Drawing.Size(112, 20);
            this.ArrivalStopBtn.TabIndex = 57;
            this.ArrivalStopBtn.Text = "STOP ARRIVAL";
            this.ArrivalStopBtn.UseVisualStyleBackColor = true;
            this.ArrivalStopBtn.Click += new System.EventHandler(this.ArrivalStopBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 610);
            this.Controls.Add(this.btnStopAll);
            this.Controls.Add(this.ArrivalStopBtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ArrivalStartBtn);
            this.Controls.Add(this.TrialBox);
            this.Controls.Add(this.TrialLbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ArrivalTimeLbl);
            this.Controls.Add(this.StopCounterBtn);
            this.Controls.Add(this.StartCounterBtn);
            this.Controls.Add(this.TriClassicBtn);
            this.Controls.Add(this.txt_Confusion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EndCondBtn);
            this.Controls.Add(this.txt_box_1_4);
            this.Controls.Add(this.txt_box_2_1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.C4StopBtn);
            this.Controls.Add(this.C4StartBtn);
            this.Controls.Add(this.C1StopBtn);
            this.Controls.Add(this.C1StartBtn);
            this.Controls.Add(this.C2StopBtn);
            this.Controls.Add(this.C2StartBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cassa2Img);
            this.Controls.Add(this.Cassa4Img);
            this.Controls.Add(this.Cassa1Img);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.COMPortLbl);
            this.Controls.Add(this.TriSoundBtn);
            this.Controls.Add(this.ConfBtn);
            this.Controls.Add(this.SensFilenameBox);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.cbxChannel);
            this.Controls.Add(this.rtbData);
            this.Controls.Add(this.rtbSteps);
            this.Controls.Add(this.btnStopRecord);
            this.Controls.Add(this.btnMeasure);
            this.Controls.Add(this.lblDeviceCount);
            this.Controls.Add(this.cbxStations);
            this.Controls.Add(this.lblChannel);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.btnScan);
            this.Name = "Form1";
            this.Text = "MTw Example";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cassa2Img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cassa4Img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cassa1Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.ComboBox cbxStations;
		private System.Windows.Forms.Label lblDeviceCount;
        private System.Windows.Forms.Button btnMeasure;
        private System.Windows.Forms.Button btnStopRecord;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox rtbSteps;
        private System.Windows.Forms.RichTextBox rtbData;
		private System.Windows.Forms.ComboBox cbxChannel;
		private System.Windows.Forms.Button btnRecord;
		private System.Windows.Forms.TextBox SensFilenameBox;
        private System.Windows.Forms.Button ConfBtn;
        private System.Windows.Forms.Button TriSoundBtn;
        private System.Windows.Forms.Label COMPortLbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox Cassa1Img;
        private System.Windows.Forms.PictureBox Cassa4Img;
        private System.Windows.Forms.PictureBox Cassa2Img;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button C2StartBtn;
        private System.Windows.Forms.Button C2StopBtn;
        private System.Windows.Forms.Button C1StartBtn;
        private System.Windows.Forms.Button C1StopBtn;
        private System.Windows.Forms.Button C4StartBtn;
        private System.Windows.Forms.Button C4StopBtn;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_box_2_1;
        private System.Windows.Forms.TextBox txt_box_1_4;
        private System.Windows.Forms.Button EndCondBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Confusion;
        private System.Windows.Forms.Button TriClassicBtn;
        private System.Windows.Forms.Button StartCounterBtn;
        private System.Windows.Forms.Button StopCounterBtn;
        private System.Windows.Forms.Label ArrivalTimeLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TrialLbl;
        private System.Windows.Forms.TextBox TrialBox;
        private System.Windows.Forms.Button ArrivalStartBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button ArrivalStopBtn;
        private System.Windows.Forms.Button btnStopAll;
    }
}

