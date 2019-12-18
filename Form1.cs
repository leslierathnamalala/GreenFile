using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;


namespace GreenFileDownloader
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// GreenFile Downloader V1.0
        /// Downloads only when url typed
        /// </summary>

        public Form1()
        {
            InitializeComponent();
        }

        string filename;
        WebClient CLNT = new WebClient();

        private void GreenFile(string url, string save)
        {
            using(var CLNT = new WebClient())
            {
                CLNT.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Changed);

                CLNT.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);

                CLNT.DownloadFileAsync(new Uri(url), save);



            }

        }

        private void Changed(object sender, DownloadProgressChangedEventArgs e)
        {
            DownloadProgress.Value = e.ProgressPercentage;
            StatusLBL.Text = "Status: downloading...";
            ProgressLBL.Text = "Progress: downloaded " + (e.BytesReceived / 1024d / 1024d).ToString("0.00 MB") + " (" + e.BytesReceived + " bytes) of " + (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00 MB") + " (" + e.TotalBytesToReceive + " bytes) " + e.ProgressPercentage + "%";
            DownloadBTN.Enabled = false;
            CancelBTN.Enabled = true;
            UrlTXT.ReadOnly = true;
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                StatusLBL.Text = "Status: download canceled.";
            }
            else if (e.Cancelled == false)
            {
                StatusLBL.Text = "Status: download completed!";
            }
            DownloadBTN.Enabled = true;
            CancelBTN.Enabled = false;
            DownloadProgress.Value = 0;
            UrlTXT.ReadOnly = false;
        }

        private void urlAdd(object sender, EventArgs e)
        {
            try
            {
                Uri uri = new Uri(UrlTXT.Text);
                filename = Path.GetFileName(uri.LocalPath);
            }
            catch
            {
               
            }
        }

        private void DownloadBTN_Click(object sender, EventArgs e)
        {

            if (UrlTXT.Text == string.Empty)
            {
                MessageBox.Show("Please enter an url address, before clicking on Download.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "All Files|*.*";
                    dialog.FileName = filename;
                    DialogResult result = dialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                       GreenFile(UrlTXT.Text, dialog.FileName);
                    }

                }
                catch
                {
                }
            }

        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            CLNT.CancelAsync();
        }
    }
}
