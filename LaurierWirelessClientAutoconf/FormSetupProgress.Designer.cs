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
            this.labelNowConfiguring = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBarSetup
            // 
            this.progressBarSetup.Location = new System.Drawing.Point(85, 110);
            this.progressBarSetup.Name = "progressBarSetup";
            this.progressBarSetup.Size = new System.Drawing.Size(559, 23);
            this.progressBarSetup.TabIndex = 0;
            // 
            // linkLableOsl
            // 
            this.linkLableOsl.AutoSize = true;
            this.linkLableOsl.Location = new System.Drawing.Point(85, 181);
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
            this.labelOsl.Location = new System.Drawing.Point(80, 9);
            this.labelOsl.Name = "labelOsl";
            this.labelOsl.Size = new System.Drawing.Size(284, 29);
            this.labelOsl.TabIndex = 2;
            this.labelOsl.Text = "Open Source at Laurier";
            // 
            // labelNowConfiguring
            // 
            this.labelNowConfiguring.AutoSize = true;
            this.labelNowConfiguring.Location = new System.Drawing.Point(85, 76);
            this.labelNowConfiguring.Name = "labelNowConfiguring";
            this.labelNowConfiguring.Size = new System.Drawing.Size(209, 13);
            this.labelNowConfiguring.TabIndex = 3;
            this.labelNowConfiguring.Text = "Setting up Laurier Wireless client settings...";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(568, 181);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormSetupProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 219);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelNowConfiguring);
            this.Controls.Add(this.labelOsl);
            this.Controls.Add(this.linkLableOsl);
            this.Controls.Add(this.progressBarSetup);
            this.Name = "FormSetupProgress";
            this.Text = "Laurier Wireless Client Autoconfiguration | Open Source at Laurier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarSetup;
        private System.Windows.Forms.LinkLabel linkLableOsl;
        private System.Windows.Forms.Label labelOsl;
        private System.Windows.Forms.Label labelNowConfiguring;
        private System.Windows.Forms.Button buttonCancel;
    }
}

