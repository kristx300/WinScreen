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
        /// <summary>
        /// The main object for manipulation of web requests
        /// </summary>
        private WebClient _web { get; set; }

        public UrlDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Start web request
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterButton_Click(object sender, EventArgs e)
        {
            Create();

            if (string.IsNullOrWhiteSpace(UrlText.Text) || !UrlText.Text.Contains(new char[] { '@', '.' }))
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

        /// <summary>
        /// Called when web request completes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Progress changer of web request state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            DownloadBar.Value = e.ProgressPercentage;
        }

        /// <summary>
        /// Image Path add to main <seealso cref="ScreenForm"/>
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Called when user click on Cancel Button to break web request
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, EventArgs e)
        {
            _web.CancelAsync();
            _web.Dispose();
        }

        /// <summary>
        /// Initializes web client if it is disposed
        /// </summary>
        private void Create()
        {
            if (_web == null)
            {
                _web = new WebClient();
                _web.DownloadProgressChanged += Wc_DownloadProgressChanged;
                _web.DownloadFileCompleted += Wc_DownloadFileCompleted;
            }
        }
    }
}