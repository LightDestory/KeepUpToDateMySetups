using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace KeepUpToDateMySetups
{
    class NetHandler
    {
        public bool completed = true;
        private WebClient NetWindow;
        private Software Software;
        private String WorkingPath, CurrentVersion, OnlineVersion;
        private Uri DownloadLink;
        private int[] Scraping;
        private Label Status;

        public NetHandler(Label Status)
        {
            this.Status = Status;
            NetWindow = new WebClient();
            Scraping = new int[2];
        }

        public bool CheckForUpdate()
        {
            CurrentVersion = Application.ProductVersion;
            OnlineVersion = NetWindow.DownloadString("");
            return !CurrentVersion.Equals(OnlineVersion);
        }

        public void DownloadNew(Software software)
        {
            if (completed)
            {
                Software = software;
                WorkingPath = Worker.WorkingFolder + Software.Name + "\\";
                File.WriteAllText(WorkingPath + "version.keepuptodate", GetOnlineVersion());
                DownloadFile();
            }
        }

        public void Update(Software software)
        {
            if (completed)
            {
                Software = software;
                WorkingPath = Worker.WorkingFolder + Software.Name + "\\";
                OnlineVersion = GetOnlineVersion();
                CurrentVersion = File.ReadAllText(WorkingPath + "version.keepuptodate");
                if (!OnlineVersion.Equals(CurrentVersion))
                {
                    File.WriteAllText(WorkingPath + "version.keepuptodate", OnlineVersion);
                    DownloadFile();
                }
                else
                {
                    Status.Text = "No Update Found";
                }
            }
        }

        private void DownloadFile()
        {
            completed = false;
            CalculateDownloadLink();
            Check64bit();
            Status.Text = "Starting Download of " + Software.Name;
            NetWindow.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            NetWindow.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
            NetWindow.DownloadFileAsync(DownloadLink, WorkingPath + Software.Name + ".exe");
        }

        private string GetOnlineVersion()
        {
            string html = NetWindow.DownloadString(Software.VersionUrl);
            Status.Text = "Reading Latest Online Version of" + Software.Name;
            CalculateScrapping(html);
            return html.Substring(Scraping[0], Scraping[1]);
        }

        public void StopDownloadFile()
        {
            NetWindow.CancelAsync();
            foreach(String s in Directory.GetFiles(WorkingPath))
            {
                File.Delete(s);
            }
            Directory.Delete(WorkingPath);
        }

        public bool DownloadCompleted { get { return completed; } }

        private void DownloadProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            Status.Text = "Downloading "+ Software.Name + " : " + e.ProgressPercentage + "%";
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                Status.Text = "Download Aborted";
            }
            else
            {
                Status.Text = "Download of " + Software.Name + " completed";
            }

            completed = true;
        }

        private void Check64bit()
        {
            if (Software.DownloadUrl.Length < 1)
            {
                if (File.Exists(WorkingPath + "\\app.is64"))
                {
                    DownloadLink = new Uri(Software.DownloadUrl[1]);
                }
                else if ((MessageBox.Show("Do you want to downalod the x64 bit Version?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes))
                {
                    File.WriteAllText(WorkingPath + "\\app.is64", "");
                    DownloadLink = new Uri(Software.DownloadUrl[1]);
                }
            }
            else
            {
                DownloadLink = new Uri(Software.DownloadUrl[0]);
            }
        }

        private void CalculateScrapping(String raw)
        {
            switch (Software.Name)
            {
                case "Revo Uninstaller Pro":
                    Scraping[0] = raw.IndexOf(Software.HTMLPrefix) + Software.HTMLPrefix.Length;
                    Scraping[1] = raw.LastIndexOf(Software.HTMLSuffix) - Scraping[0];
                    break;
                default:
                    Scraping[0] = raw.IndexOf(Software.HTMLPrefix) + Software.HTMLPrefix.Length;
                    Scraping[1] = raw.IndexOf(Software.HTMLSuffix) - Scraping[0];
                    break;
            }
        }

        private void CalculateDownloadLink()
        {
            Status.Text = "Calculating Download Link...";
            switch (Software.Name)
            {
                default:
                    break;
            }
        }
    }
}
