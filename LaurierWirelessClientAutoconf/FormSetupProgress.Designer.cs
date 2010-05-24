#region Copyright
// <copyright file="LICENSE.txt" company="Open Source at Laurier">
//
// Copyright (C) 2010 Open Source at Laurier
//
// This file is part of the Laurier Wireless Autoconfiguration Tool.
//
// The Laurier Wireless Autoconfiguration Tool is free software: you can
// redistribute it and/or modify it under the terms of the GNU General 
// Public License as published by the Free Software Foundation, either 
// version 3 of the License, or (at your option) any later version.
//
// The Laurier Wireless Autoconfiguration Tool is distributed in the 
// hope that it will be useful, but WITHOUT ANY WARRANTY; without 
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A 
// PARTICULAR PURPOSE.  See the GNU General Public License for more 
// details.
//
// You should have received a copy of the GNU General Public License
// along with the Laurier Wireless Autoconfiguration Tool.  If not,
// see <http://www.gnu.org/licenses/>.
// </copyright>
#endregion

namespace OpenSourceAtLaurier.LaurierWirelessClientAutoconf
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
            this.progressBarSetup = new System.Windows.Forms.ProgressBar();
            this.linkLableOsl = new System.Windows.Forms.LinkLabel();
            this.labelOsl = new System.Windows.Forms.Label();
            this.labelCurrentCommandDescription = new System.Windows.Forms.Label();
            this.GroupBoxSteps = new System.Windows.Forms.GroupBox();
            this.labelInstallSecureW2Description = new System.Windows.Forms.Label();
            this.labelRegisterSecureW2Settings = new System.Windows.Forms.Label();
            this.labelSetupWirelessProfile = new System.Windows.Forms.Label();
            this.GroupBoxSteps.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBarSetup
            // 
            this.progressBarSetup.Location = new System.Drawing.Point(245, 110);
            this.progressBarSetup.Maximum = 3;
            this.progressBarSetup.Name = "progressBarSetup";
            this.progressBarSetup.Size = new System.Drawing.Size(399, 23);
            this.progressBarSetup.TabIndex = 0;
            // 
            // linkLableOsl
            // 
            this.linkLableOsl.AutoSize = true;
            this.linkLableOsl.Location = new System.Drawing.Point(242, 157);
            this.linkLableOsl.Name = "linkLableOsl";
            this.linkLableOsl.Size = new System.Drawing.Size(160, 13);
            this.linkLableOsl.TabIndex = 1;
            this.linkLableOsl.TabStop = true;
            this.linkLableOsl.Text = "http://www.wluopensource.org/";
            // 
            // labelOsl
            // 
            this.labelOsl.AutoSize = true;
            this.labelOsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOsl.Location = new System.Drawing.Point(240, 9);
            this.labelOsl.Name = "labelOsl";
            this.labelOsl.Size = new System.Drawing.Size(284, 29);
            this.labelOsl.TabIndex = 2;
            this.labelOsl.Text = "Open Source at Laurier";
            // 
            // labelCurrentCommandDescription
            // 
            this.labelCurrentCommandDescription.AutoSize = true;
            this.labelCurrentCommandDescription.Location = new System.Drawing.Point(242, 76);
            this.labelCurrentCommandDescription.Name = "labelCurrentCommandDescription";
            this.labelCurrentCommandDescription.Size = new System.Drawing.Size(209, 13);
            this.labelCurrentCommandDescription.TabIndex = 3;
            this.labelCurrentCommandDescription.Text = "Setting up Laurier Wireless client settings...";
            // 
            // GroupBoxSteps
            // 
            this.GroupBoxSteps.Controls.Add(this.labelSetupWirelessProfile);
            this.GroupBoxSteps.Controls.Add(this.labelRegisterSecureW2Settings);
            this.GroupBoxSteps.Controls.Add(this.labelInstallSecureW2Description);
            this.GroupBoxSteps.Location = new System.Drawing.Point(13, 9);
            this.GroupBoxSteps.Name = "GroupBoxSteps";
            this.GroupBoxSteps.Size = new System.Drawing.Size(200, 161);
            this.GroupBoxSteps.TabIndex = 4;
            this.GroupBoxSteps.TabStop = false;
            this.GroupBoxSteps.Text = "Steps";
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
            // labelRegisterSecureW2Settings
            // 
            this.labelRegisterSecureW2Settings.AutoSize = true;
            this.labelRegisterSecureW2Settings.Location = new System.Drawing.Point(7, 44);
            this.labelRegisterSecureW2Settings.Name = "labelRegisterSecureW2Settings";
            this.labelRegisterSecureW2Settings.Size = new System.Drawing.Size(151, 13);
            this.labelRegisterSecureW2Settings.TabIndex = 1;
            this.labelRegisterSecureW2Settings.Text = "2. Register SecureW2 settings";
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
            // FormSetupProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 191);
            this.Controls.Add(this.GroupBoxSteps);
            this.Controls.Add(this.labelCurrentCommandDescription);
            this.Controls.Add(this.labelOsl);
            this.Controls.Add(this.linkLableOsl);
            this.Controls.Add(this.progressBarSetup);
            this.Name = "FormSetupProgress";
            this.Text = "Laurier Wireless Client Autoconfiguration | Open Source at Laurier";
            this.GroupBoxSteps.ResumeLayout(false);
            this.GroupBoxSteps.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarSetup;
        private System.Windows.Forms.LinkLabel linkLableOsl;
        private System.Windows.Forms.Label labelOsl;
        private System.Windows.Forms.Label labelCurrentCommandDescription;
        private System.Windows.Forms.GroupBox GroupBoxSteps;
        private System.Windows.Forms.Label labelSetupWirelessProfile;
        private System.Windows.Forms.Label labelRegisterSecureW2Settings;
        private System.Windows.Forms.Label labelInstallSecureW2Description;
    }
}

