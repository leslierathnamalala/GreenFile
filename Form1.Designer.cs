namespace GreenFileDownloader
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
            this.UrlTXT = new System.Windows.Forms.TextBox();
            this.DownloadBTN = new System.Windows.Forms.Button();
            this.DownloadProgress = new System.Windows.Forms.ProgressBar();
            this.StatusLBL = new System.Windows.Forms.Label();
            this.ProgressLBL = new System.Windows.Forms.Label();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UrlTXT
            // 
            this.UrlTXT.Location = new System.Drawing.Point(46, 12);
            this.UrlTXT.Name = "UrlTXT";
            this.UrlTXT.Size = new System.Drawing.Size(394, 20);
            this.UrlTXT.TabIndex = 0;
            this.UrlTXT.TextChanged += new System.EventHandler(this.urlAdd);
            // 
            // DownloadBTN
            // 
            this.DownloadBTN.Location = new System.Drawing.Point(191, 38);
            this.DownloadBTN.Name = "DownloadBTN";
            this.DownloadBTN.Size = new System.Drawing.Size(96, 55);
            this.DownloadBTN.TabIndex = 1;
            this.DownloadBTN.Text = "Download";
            this.DownloadBTN.UseVisualStyleBackColor = true;
            this.DownloadBTN.Click += new System.EventHandler(this.DownloadBTN_Click);
            // 
            // DownloadProgress
            // 
            this.DownloadProgress.Location = new System.Drawing.Point(26, 95);
            this.DownloadProgress.Name = "DownloadProgress";
            this.DownloadProgress.Size = new System.Drawing.Size(433, 23);
            this.DownloadProgress.TabIndex = 2;
            // 
            // StatusLBL
            // 
            this.StatusLBL.AutoSize = true;
            this.StatusLBL.Location = new System.Drawing.Point(23, 133);
            this.StatusLBL.Name = "StatusLBL";
            this.StatusLBL.Size = new System.Drawing.Size(171, 13);
            this.StatusLBL.TabIndex = 3;
            this.StatusLBL.Text = "Status:Ready for a Download a file";
            // 
            // ProgressLBL
            // 
            this.ProgressLBL.AutoSize = true;
            this.ProgressLBL.Location = new System.Drawing.Point(23, 151);
            this.ProgressLBL.Name = "ProgressLBL";
            this.ProgressLBL.Size = new System.Drawing.Size(313, 13);
            this.ProgressLBL.TabIndex = 5;
            this.ProgressLBL.Text = "Progress: downloaded 0.00 MB (0 bytes) of 0.00 MB (0 bytes) 0%";
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(384, 146);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(75, 23);
            this.CancelBTN.TabIndex = 6;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 190);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.ProgressLBL);
            this.Controls.Add(this.StatusLBL);
            this.Controls.Add(this.DownloadProgress);
            this.Controls.Add(this.DownloadBTN);
            this.Controls.Add(this.UrlTXT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "GreenFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UrlTXT;
        private System.Windows.Forms.Button DownloadBTN;
        private System.Windows.Forms.ProgressBar DownloadProgress;
        private System.Windows.Forms.Label StatusLBL;
        private System.Windows.Forms.Label ProgressLBL;
        private System.Windows.Forms.Button CancelBTN;
    }
}

