#region Copyright
// <copyright file="LICENSE.txt" company="Open Source at Laurier">
//
// Copyright (C) 2010 Open Source at Laurier
//
// This file is part of the Laurier Wireless Connect application.
//
// The Laurier Wireless Connect application is free software: you can
// redistribute it and/or modify it under the terms of the GNU General 
// Public License as published by the Free Software Foundation, either 
// version 3 of the License, or (at your option) any later version.
//
// The Laurier Wireless Connect application is distributed in the 
// hope that it will be useful, but WITHOUT ANY WARRANTY; without 
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A 
// PARTICULAR PURPOSE.  See the GNU General Public License for more 
// details.
//
// You should have received a copy of the GNU General Public License
// along with the Laurier Wireless Connect application.  If not,
// see <http://www.gnu.org/licenses/>.
// </copyright>
#endregion

namespace OpenSourceAtLaurier.LaurierWirelessConnect
{
    partial class FormSetupProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetupProgress));
            this.progressBarSetup = new System.Windows.Forms.ProgressBar();
            this.linkLableOsl = new System.Windows.Forms.LinkLabel();
            this.labelCurrentCommandDescription = new System.Windows.Forms.Label();
            this.GroupBoxSteps = new System.Windows.Forms.GroupBox();
            this.labelSetupWirelessProfile = new System.Windows.Forms.Label();
            this.labelRegisterSecureW2Settings = new System.Windows.Forms.Label();
            this.labelInstallSecureW2Description = new System.Windows.Forms.Label();
            this.TitlePictureBox = new System.Windows.Forms.PictureBox();
            this.OSLPictureBox = new System.Windows.Forms.PictureBox();
            this.checkmark3 = new System.Windows.Forms.PictureBox();
            this.checkmark2 = new System.Windows.Forms.PictureBox();
            this.checkmark1 = new System.Windows.Forms.PictureBox();
            this.GroupBoxSteps.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBarSetup
            // 
            this.progressBarSetup.Location = new System.Drawing.Point(219, 127);
            this.progressBarSetup.Maximum = 3;
            this.progressBarSetup.Name = "progressBarSetup";
            this.progressBarSetup.Size = new System.Drawing.Size(399, 23);
            this.progressBarSetup.TabIndex = 0;
            // 
            // linkLableOsl
            // 
            this.linkLableOsl.AutoSize = true;
            this.linkLableOsl.Location = new System.Drawing.Point(216, 224);
            this.linkLableOsl.Name = "linkLableOsl";
            this.linkLableOsl.Size = new System.Drawing.Size(160, 13);
            this.linkLableOsl.TabIndex = 1;
            this.linkLableOsl.TabStop = true;
            this.linkLableOsl.Text = "http://www.wluopensource.org/";
            // 
            // labelCurrentCommandDescription
            // 
            this.labelCurrentCommandDescription.AutoSize = true;
            this.labelCurrentCommandDescription.Location = new System.Drawing.Point(216, 102);
            this.labelCurrentCommandDescription.Name = "labelCurrentCommandDescription";
            this.labelCurrentCommandDescription.Size = new System.Drawing.Size(209, 13);
            this.labelCurrentCommandDescription.TabIndex = 3;
            this.labelCurrentCommandDescription.Text = "Setting up Laurier Wireless client settings...";
            // 
            // GroupBoxSteps
            // 
            this.GroupBoxSteps.Controls.Add(this.checkmark3);
            this.GroupBoxSteps.Controls.Add(this.checkmark2);
            this.GroupBoxSteps.Controls.Add(this.checkmark1);
            this.GroupBoxSteps.Controls.Add(this.labelSetupWirelessProfile);
            this.GroupBoxSteps.Controls.Add(this.labelRegisterSecureW2Settings);
            this.GroupBoxSteps.Controls.Add(this.labelInstallSecureW2Description);
            this.GroupBoxSteps.Location = new System.Drawing.Point(13, 9);
            this.GroupBoxSteps.Name = "GroupBoxSteps";
            this.GroupBoxSteps.Size = new System.Drawing.Size(191, 228);
            this.GroupBoxSteps.TabIndex = 4;
            this.GroupBoxSteps.TabStop = false;
            this.GroupBoxSteps.Text = "Steps";
            // 
            // labelSetupWirelessProfile
            // 
            this.labelSetupWirelessProfile.AutoSize = true;
            this.labelSetupWirelessProfile.Location = new System.Drawing.Point(7, 67);
            this.labelSetupWirelessProfile.Name = "labelSetupWirelessProfile";
            this.labelSetupWirelessProfile.Size = new System.Drawing.Size(118, 13);
            this.labelSetupWirelessProfile.TabIndex = 2;
            this.labelSetupWirelessProfile.Text = "3. Setup wireless profile";
            // 
            // labelRegisterSecureW2Settings
            // 
            this.labelRegisterSecureW2Settings.AutoSize = true;
            this.labelRegisterSecureW2Settings.Location = new System.Drawing.Point(7, 44);
            this.labelRegisterSecureW2Settings.Name = "labelRegisterSecureW2Settings";
            this.labelRegisterSecureW2Settings.Size = new System.Drawing.Size(151, 13);
            this.labelRegisterSecureW2Settings.TabIndex = 1;
            this.labelRegisterSecureW2Settings.Text = "2. Register SecureW2 settings";
            // 
            // labelInstallSecureW2Description
            // 
            this.labelInstallSecureW2Description.AutoSize = true;
            this.labelInstallSecureW2Description.Location = new System.Drawing.Point(7, 20);
            this.labelInstallSecureW2Description.Name = "labelInstallSecureW2Description";
            this.labelInstallSecureW2Description.Size = new System.Drawing.Size(152, 13);
            this.labelInstallSecureW2Description.TabIndex = 0;
            this.labelInstallSecureW2Description.Text = "1. Install SecureW2 EAP client";
            // 
            // TitlePictureBox
            // 
            this.TitlePictureBox.Image = global::OpenSourceAtLaurier.LaurierWirelessConnect.Properties.Resources.Laurier_Wireless_Connect_small1;
            this.TitlePictureBox.Location = new System.Drawing.Point(219, 12);
            this.TitlePictureBox.Name = "TitlePictureBox";
            this.TitlePictureBox.Size = new System.Drawing.Size(399, 74);
            this.TitlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TitlePictureBox.TabIndex = 6;
            this.TitlePictureBox.TabStop = false;
            // 
            // OSLPictureBox
            // 
            this.OSLPictureBox.Image = global::OpenSourceAtLaurier.LaurierWirelessConnect.Properties.Resources.Banner01;
            this.OSLPictureBox.Location = new System.Drawing.Point(219, 174);
            this.OSLPictureBox.Name = "OSLPictureBox";
            this.OSLPictureBox.Size = new System.Drawing.Size(399, 47);
            this.OSLPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OSLPictureBox.TabIndex = 5;
            this.OSLPictureBox.TabStop = false;
            // 
            // checkmark3
            // 
            this.checkmark3.Image = global::OpenSourceAtLaurier.LaurierWirelessConnect.Properties.Resources.orangeCheckmark;
            this.checkmark3.Location = new System.Drawing.Point(164, 64);
            this.checkmark3.Name = "checkmark3";
            this.checkmark3.Size = new System.Drawing.Size(16, 16);
            this.checkmark3.TabIndex = 10;
            this.checkmark3.TabStop = false;
            this.checkmark3.Visible = false;
            // 
            // checkmark2
            // 
            this.checkmark2.Image = global::OpenSourceAtLaurier.LaurierWirelessConnect.Properties.Resources.orangeCheckmark;
            this.checkmark2.Location = new System.Drawing.Point(164, 41);
            this.checkmark2.Name = "checkmark2";
            this.checkmark2.Size = new System.Drawing.Size(16, 16);
            this.checkmark2.TabIndex = 9;
            this.checkmark2.TabStop = false;
            this.checkmark2.Visible = false;
            // 
            // checkmark1
            // 
            this.checkmark1.Image = global::OpenSourceAtLaurier.LaurierWirelessConnect.Properties.Resources.orangeCheckmark;
            this.checkmark1.Location = new System.Drawing.Point(164, 17);
            this.checkmark1.Name = "checkmark1";
            this.checkmark1.Size = new System.Drawing.Size(16, 16);
            this.checkmark1.TabIndex = 8;
            this.checkmark1.TabStop = false;
            this.checkmark1.Visible = false;
            // 
            // FormSetupProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 245);
            this.Controls.Add(this.TitlePictureBox);
            this.Controls.Add(this.OSLPictureBox);
            this.Controls.Add(this.GroupBoxSteps);
            this.Controls.Add(this.labelCurrentCommandDescription);
            this.Controls.Add(this.linkLableOsl);
            this.Controls.Add(this.progressBarSetup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSetupProgress";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Laurier Wireless Connect | Open Source at Laurier";
            this.GroupBoxSteps.ResumeLayout(false);
            this.GroupBoxSteps.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarSetup;
        private System.Windows.Forms.LinkLabel linkLableOsl;
        private System.Windows.Forms.Label labelCurrentCommandDescription;
        private System.Windows.Forms.GroupBox GroupBoxSteps;
        private System.Windows.Forms.Label labelSetupWirelessProfile;
        private System.Windows.Forms.Label labelRegisterSecureW2Settings;
        private System.Windows.Forms.Label labelInstallSecureW2Description;
        private System.Windows.Forms.PictureBox OSLPictureBox;
        private System.Windows.Forms.PictureBox checkmark3;
        private System.Windows.Forms.PictureBox checkmark2;
        private System.Windows.Forms.PictureBox checkmark1;
        private System.Windows.Forms.PictureBox TitlePictureBox;
    }
}

