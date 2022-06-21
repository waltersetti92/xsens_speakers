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
            this.btnStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rtbSteps = new System.Windows.Forms.RichTextBox();
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.cbxChannel = new System.Windows.Forms.ComboBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.textBoxFilename = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(20, 18);
            this.btnScan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(138, 35);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Enabled = false;
            this.btnEnable.Location = new System.Drawing.Point(18, 186);
            this.btnEnable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(138, 35);
            this.btnEnable.TabIndex = 3;
            this.btnEnable.Text = "Enable Radio";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Location = new System.Drawing.Point(24, 126);
            this.lblChannel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(72, 20);
            this.lblChannel.TabIndex = 4;
            this.lblChannel.Text = "Channel:";
            // 
            // cbxStations
            // 
            this.cbxStations.FormattingEnabled = true;
            this.cbxStations.Location = new System.Drawing.Point(20, 78);
            this.cbxStations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxStations.Name = "cbxStations";
            this.cbxStations.Size = new System.Drawing.Size(433, 28);
            this.cbxStations.TabIndex = 5;
            // 
            // lblDeviceCount
            // 
            this.lblDeviceCount.AutoSize = true;
            this.lblDeviceCount.Location = new System.Drawing.Point(180, 252);
            this.lblDeviceCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeviceCount.Name = "lblDeviceCount";
            this.lblDeviceCount.Size = new System.Drawing.Size(152, 20);
            this.lblDeviceCount.TabIndex = 6;
            this.lblDeviceCount.Text = "MTw\'s Connected: 0";
            // 
            // btnMeasure
            // 
            this.btnMeasure.Enabled = false;
            this.btnMeasure.Location = new System.Drawing.Point(18, 245);
            this.btnMeasure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMeasure.Name = "btnMeasure";
            this.btnMeasure.Size = new System.Drawing.Size(138, 35);
            this.btnMeasure.TabIndex = 8;
            this.btnMeasure.Text = "Measure";
            this.btnMeasure.UseVisualStyleBackColor = true;
            this.btnMeasure.Click += new System.EventHandler(this.btnMeasure_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(20, 362);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(136, 35);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rtbSteps
            // 
            this.rtbSteps.Location = new System.Drawing.Point(500, 18);
            this.rtbSteps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbSteps.Name = "rtbSteps";
            this.rtbSteps.ReadOnly = true;
            this.rtbSteps.Size = new System.Drawing.Size(313, 379);
            this.rtbSteps.TabIndex = 10;
            this.rtbSteps.Text = "";
            // 
            // rtbData
            // 
            this.rtbData.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbData.Location = new System.Drawing.Point(18, 420);
            this.rtbData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(723, 449);
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
            this.cbxChannel.Location = new System.Drawing.Point(106, 118);
            this.cbxChannel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxChannel.Name = "cbxChannel";
            this.cbxChannel.Size = new System.Drawing.Size(108, 28);
            this.cbxChannel.TabIndex = 12;
            // 
            // btnRecord
            // 
            this.btnRecord.Enabled = false;
            this.btnRecord.Location = new System.Drawing.Point(18, 303);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(138, 35);
            this.btnRecord.TabIndex = 13;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // textBoxFilename
            // 
            this.textBoxFilename.Location = new System.Drawing.Point(184, 308);
            this.textBoxFilename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFilename.Name = "textBoxFilename";
            this.textBoxFilename.Size = new System.Drawing.Size(127, 26);
            this.textBoxFilename.TabIndex = 21;
            this.textBoxFilename.Text = "logfile.mtb";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(820, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 35);
            this.button1.TabIndex = 22;
            this.button1.Text = "CONFUSION";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(820, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 35);
            this.button2.TabIndex = 23;
            this.button2.Text = "TRIANGLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(974, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "PORTA COM";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(978, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 25;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1105, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 41);
            this.button3.TabIndex = 26;
            this.button3.Text = "SET";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 938);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxFilename);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.cbxChannel);
            this.Controls.Add(this.rtbData);
            this.Controls.Add(this.rtbSteps);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnMeasure);
            this.Controls.Add(this.lblDeviceCount);
            this.Controls.Add(this.cbxStations);
            this.Controls.Add(this.lblChannel);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.btnScan);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "MTw Example";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox rtbSteps;
        private System.Windows.Forms.RichTextBox rtbData;
		private System.Windows.Forms.ComboBox cbxChannel;
		private System.Windows.Forms.Button btnRecord;
		private System.Windows.Forms.TextBox textBoxFilename;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
    }
}

