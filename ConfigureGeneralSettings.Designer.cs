﻿namespace iRacingReplayOverlay
{
    partial class ConfigureGeneralSettings
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
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxTimeForIncidentsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PreferredDriverNameTextBox = new System.Windows.Forms.TextBox();
            this.MaxTimeForInterestingEventTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(395, 146);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(109, 37);
            this.okButton.TabIndex = 10;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Maximum time for showing single incidents";
            // 
            // MaxTimeForIncidentsTextBox
            // 
            this.MaxTimeForIncidentsTextBox.Location = new System.Drawing.Point(300, 30);
            this.MaxTimeForIncidentsTextBox.Name = "MaxTimeForIncidentsTextBox";
            this.MaxTimeForIncidentsTextBox.Size = new System.Drawing.Size(134, 22);
            this.MaxTimeForIncidentsTextBox.TabIndex = 13;
            this.MaxTimeForIncidentsTextBox.TextChanged += new System.EventHandler(this.MaxTimeForIncidentsTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "seconds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Preferred driver names (comma separated)";
            // 
            // PreferredDriverNameTextBox
            // 
            this.PreferredDriverNameTextBox.Location = new System.Drawing.Point(300, 86);
            this.PreferredDriverNameTextBox.Name = "PreferredDriverNameTextBox";
            this.PreferredDriverNameTextBox.Size = new System.Drawing.Size(134, 22);
            this.PreferredDriverNameTextBox.TabIndex = 16;
            this.PreferredDriverNameTextBox.TextChanged += new System.EventHandler(this.PreferredDriverNameTextBox_TextChanged);
            // 
            // MaxTimeForInterestingEventTextBox
            // 
            this.MaxTimeForInterestingEventTextBox.Location = new System.Drawing.Point(300, 58);
            this.MaxTimeForInterestingEventTextBox.Name = "MaxTimeForInterestingEventTextBox";
            this.MaxTimeForInterestingEventTextBox.Size = new System.Drawing.Size(134, 22);
            this.MaxTimeForInterestingEventTextBox.TabIndex = 17;
            this.MaxTimeForInterestingEventTextBox.TextChanged += new System.EventHandler(this.MaxTimeForInterestingEventTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "seconds";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Time between cars for interesting event";
            // 
            // ConfigureGeneralSettings
            // 
            this.AcceptButton = this.okButton;
            this.CancelButton = this.okButton;
            this.ClientSize = new System.Drawing.Size(516, 195);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MaxTimeForInterestingEventTextBox);
            this.Controls.Add(this.PreferredDriverNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaxTimeForIncidentsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConfigureGeneralSettings";
            this.Text = "Configure Video Capture";
            this.Load += new System.EventHandler(this.ConfigureGeneralSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaxTimeForIncidentsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PreferredDriverNameTextBox;
        private System.Windows.Forms.TextBox MaxTimeForInterestingEventTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

    }
}