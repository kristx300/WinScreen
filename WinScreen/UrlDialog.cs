using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using WinScreen.Core;

namespace WinScreen
{
    public partial class UrlDialog : Form
    {
        private WebClient _web { get; set; }

        public UrlDialog()
        {
            InitializeComponent();
            _web = new WebClient();
            _web.DownloadProgressChanged += Wc_DownloadProgressChanged;
            _web.DownloadFileCompleted += Wc_DownloadFileCompleted;
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UrlText.Text) || !UrlText.Text.Contains(new char[] { '@','.' }))
                MessageBox.Show("It's not URL link");
            Path = DataWorker.ImagePath + @"\" + UrlText.Text.GetLastPartLink();
            if (File.Exists(Path))
            {
                var key = Path.GetDotPart();
                Path = Path.Replace(key, "Copy." + key);
            }
            _web.DownloadFileAsync(new Uri(UrlText.Text), Path);
            DownloadBar.Visible = Cancel.Visible = true;
        }

        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                DownloadBar.Value = 0;
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                DownloadBar.Value = 100;
                DialogResult = DialogResult.OK;
                DownloadBar.Visible = Cancel.Visible = false;
            }
        }

        private void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            DownloadBar.Value = e.ProgressPercentage;
        }

        public string Path { get; set; }

        private void Cancel_Click(object sender, EventArgs e)
        {
            _web.CancelAsync();
            _web.Dispose();
            _web = new WebClient();
        }
    }
}