namespace MTwExample
{
    partial class Prompt
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxBirDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxGnr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comBoxHand = new System.Windows.Forms.ComboBox();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 183);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(31, 44);
            this.txtBoxID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(68, 20);
            this.txtBoxID.TabIndex = 2;
            this.txtBoxID.TextChanged += new System.EventHandler(this.txtBoxID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DATE OF BIRTH";
            // 
            // txtBoxBirDate
            // 
            this.txtBoxBirDate.Location = new System.Drawing.Point(159, 44);
            this.txtBoxBirDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxBirDate.Name = "txtBoxBirDate";
            this.txtBoxBirDate.Size = new System.Drawing.Size(68, 20);
            this.txtBoxBirDate.TabIndex = 4;
            this.txtBoxBirDate.TextChanged += new System.EventHandler(this.txtBoxBirDate_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "GENDER";
            // 
            // txtBoxGnr
            // 
            this.txtBoxGnr.Location = new System.Drawing.Point(31, 107);
            this.txtBoxGnr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxGnr.Name = "txtBoxGnr";
            this.txtBoxGnr.Size = new System.Drawing.Size(68, 20);
            this.txtBoxGnr.TabIndex = 6;
            this.txtBoxGnr.TextChanged += new System.EventHandler(this.txtBoxGnr_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "HAND DOMINANCE";
            // 
            // comBoxHand
            // 
            this.comBoxHand.FormattingEnabled = true;
            this.comBoxHand.Items.AddRange(new object[] {
            "Left hand",
            "Right hand"});
            this.comBoxHand.Location = new System.Drawing.Point(152, 107);
            this.comBoxHand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comBoxHand.Name = "comBoxHand";
            this.comBoxHand.Size = new System.Drawing.Size(82, 21);
            this.comBoxHand.TabIndex = 8;
            this.comBoxHand.SelectedIndexChanged += new System.EventHandler(this.comBoxHand_SelectedIndexChanged);
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Location = new System.Drawing.Point(31, 159);
            this.txtBoxAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(68, 20);
            this.txtBoxAge.TabIndex = 9;
            this.txtBoxAge.TextChanged += new System.EventHandler(this.txtBoxAge_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "AGE";
            // 
            // Prompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 213);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxAge);
            this.Controls.Add(this.comBoxHand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxGnr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxBirDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Prompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prompt";
            this.Load += new System.EventHandler(this.Prompt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxBirDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxGnr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comBoxHand;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.Label label5;
    }
}