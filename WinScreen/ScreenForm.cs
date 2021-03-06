﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WinScreen.Core;

namespace WinScreen
{
    public partial class ScreenForm : Form
    {
        #region Variable

        /// <summary>
        /// List which contains information about images
        /// </summary>
        private PhotoList PhotoList { get; set; } = new PhotoList();
        /// <summary>
        /// List wich contains information about settings
        /// </summary>
        private SettingList SettingList { get; set; } = new SettingList();
        /// <summary>
        /// Variable for tracking index of ListBox
        /// </summary>
        private int indexer = 0;

        /// <summary>
        /// Tracking closing form and save objects to JSON file
        /// </summary>
        private IEnumerable<ISavable> Containers { get; set; }

        #endregion Variable

        #region Form

        public ScreenForm()

        {
            InitializeComponent();
            InitializeForm();
        }

        /// <summary>
        /// Initializes locale property and other settings
        /// </summary>
        public void InitializeForm()
        {
            IListBox.Items.AddRange(PhotoList.GetData());

            ResX.Text = "Width " + Screen.PrimaryScreen.Bounds.Width.ToString() + " Height " + Screen.PrimaryScreen.Bounds.Height.ToString();

            if (SettingList.TimeType != TimeUnit.None)
            {
                NumericTime.Value = SettingList.Time;
                TimeUnitBox.SelectedItem = SettingList.TimeType.ToString();
            }

            switch (SettingList.TypeImage)
            {
                case ImageType.Tiled:
                    radioButton6.Checked = true;
                    break;

                case ImageType.Centered:
                    radioButton7.Checked = true;
                    break;

                case ImageType.Stretched:
                    radioButton8.Checked = true;
                    break;

                default:
                    break;
            }
            RandomBox.Checked = SettingList.Random;
            SaveImages.Checked = SettingList.SaveImage;
            StartUpApplication.Checked = SettingList.StartUpApplication;

            if (SettingList.StartUpApplication && SettingList.StartUpProgram)
            {
                Start();
                WindowState = FormWindowState.Minimized;
            }
            Containers = new ISavable[] { PhotoList, SettingList };
        }

        /// <summary>
        /// Tracking form resize for Windows State and change NotifyIcon visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScreenForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                INotify.Visible = true;
                INotify.ShowBalloonTip(3000);
                ShowInTaskbar = false;
            }
        }

        /// <summary>
        /// Save object to JSON file when form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScreenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var item in Containers)
            {
                item?.Save(true);
            }
        }

        #endregion Form

        #region Slider

        /// <summary>
        /// Change current image in Panel and ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SliderLeft_Click(object sender, EventArgs e)
        {
            if (indexer > 0 && 0 != IListBox.Items.Count)
                IListBox.SelectedItem = IListBox.Items[indexer - 1];
        }

        /// <summary>
        /// Remove Image from ListBox and PhotoList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveImage_Click(object sender, EventArgs e)
        {
            if (IListBox.Items.Count != 0)
            {
                PhotoList.Remove(IListBox.Items[indexer].ToString());
                IListBox.Items.Remove(IListBox.Items[indexer].ToString());
                indexer = 0;
            }
        }

        /// <summary>
        /// Change current image in Panel and ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void SliderRight_Click(object sender, EventArgs e)
        {
            if (0 != IListBox.Items.Count && indexer < IListBox.Items.Count - 1)
                IListBox.SelectedItem = IListBox.Items[indexer + 1];
        }

        /// <summary>
        /// Add image from call OpenFileDialog to PhotoList,ListBox and puts current picture in Panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void AddImage_Click(object sender, EventArgs e)
        {
            if (OpenFilePicker.ShowDialog() == DialogResult.OK)
            {
                string localPath = "";
                foreach (var item in OpenFilePicker.FileNames)
                {
                    if (SettingList.SaveImage)
                        localPath = DataWorker.Copy(item);
                    else
                        localPath = item;

                    PhotoList.Add(localPath);
                    IListBox.Items.Add(localPath.GetLastPart());
                    Slider.BackgroundImage = Image.FromFile(localPath);
                }
            }
        }

        /// <summary>
        /// If SelectedIndexChanged current image in Panel is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexer = IListBox.SelectedIndex == -1 ? 0 : IListBox.SelectedIndex;
            string locale = PhotoList.File(IListBox.Items[indexer].ToString());

            if (!string.IsNullOrWhiteSpace(locale))
                Slider.BackgroundImage = Image.FromFile(locale);
        }

        /// <summary>
        /// Add image from call UriDialog to PhotoList,ListBox and puts current picture in Panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddImageURL_Click(object sender, EventArgs e)
        {
            string path = "";
            using (var uD = new UrlDialog())
                if (uD.ShowDialog(this) == DialogResult.OK)
                    path = uD.Path;

            if (!string.IsNullOrWhiteSpace(path))
            {
                PhotoList.Add(path);
                IListBox.Items.Add(path.GetLastPart());
                Slider.BackgroundImage = Image.FromFile(path);
            }
        }

        /// <summary>
        /// Changed current windows background
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateWindow_Click(object sender, EventArgs e)
        {
            var path = PhotoList.GetCurrentPath();

            if (!string.IsNullOrWhiteSpace(path))
                Native.SetWindow(path, SettingList.TypeImage);
        }

        /// <summary>
        /// Remove duplicate image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelCopy_Click(object sender, EventArgs e)
        {
            var removes = PhotoList.Remove();
            foreach (var item in removes)
                IListBox.Items.Remove(item);
        }

        /// <summary>
        /// Open image in any programm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IListBox_DoubleClick(object sender, EventArgs e)
        {
            var path = PhotoList.GetCurrentPath();

            if (!string.IsNullOrWhiteSpace(path))
                Process.Start(path);
        }

        #endregion Slider

        #region Timer

        /// <summary>
        /// Call Start()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartUp_Click(object sender, EventArgs e)
        {
            if (PhotoList.Count == 0)
            {
                MessageBox.Show("Sorry but haven't images");
                return;
            }

            switch (SettingList.TimeType)
            {
                case TimeUnit.Second:
                    MainTimer.Interval = SettingList.Time * 1000;
                    break;

                case TimeUnit.Minute:
                    MainTimer.Interval = SettingList.Time * 60000;
                    break;

                case TimeUnit.Hour:
                    MainTimer.Interval = SettingList.Time * 3600000;
                    break;

                case TimeUnit.None:
                    goto case TimeUnit.Second;
                default:
                    break;
            }

            if (StartUpProgramm.Text == "Start Up")
            {
                Start();
            }
            else if (StartUpProgramm.Text == "Stop")
            {
                Stop();
            }
        }

        /// <summary>
        /// Main loop/ticker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainTimer_Tick(object sender, EventArgs e)
        {
            Next();
        }

        #endregion Timer

        #region NotifyCommands

        /// <summary>
        /// Start program changer image
        /// </summary>
        private void Start()
        {
            MainTimer.Start();
            StartUpProgramm.Text = "Stop";
            SettingList.StartUpProgram = true;
        }

        /// <summary>
        /// Stop program changer image
        /// </summary>
        private void Stop()
        {
            MainTimer.Stop();
            StartUpProgramm.Text = "Start up";
            SettingList.StartUpProgram = false;
        }

        /// <summary>
        /// Change image of the following
        /// </summary>
        private void Next()
        {
            string valueSet = "";

            if (SettingList.Random)
                valueSet = PhotoList.Random();
            else
                valueSet = PhotoList.Photo();

            var index = IListBox.Items.IndexOf(valueSet.GetLastPart());

            if (index != -1)
                IListBox.SelectedItem = IListBox.Items[index];

            Native.SetWindow(valueSet, SettingList.TypeImage);
        }

        /// <summary>
        /// Change image of the previous
        /// </summary>
        private void Previous()
        {
            var index = IListBox.Items.IndexOf(PhotoList.Previous().GetLastPart());

            if (index != -1)
                IListBox.SelectedItem = IListBox.Items[index];

            Native.SetWindow(PhotoList.Previous(), SettingList.TypeImage);
        }

        #endregion NotifyCommands

        #region INotify

        /// <summary>
        /// Called this method when user clicked on Item of Content Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void INotifyContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (PhotoList.Count == 0)
            {
                MessageBox.Show("Sorry but haven't images");
                return;
            }

            switch (e.ClickedItem.Text)
            {
                case "Start":
                    Start();
                    break;

                case "Stop":
                    Stop();
                    break;

                case "Next":
                    Next();
                    break;

                case "Previous":
                    Previous();
                    break;

                case "Exit":
                    Close();
                    break;

                case "Show":
                    WindowState = FormWindowState.Normal;
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Called when user doing double click to showing form and hide NotifyIcon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void INotify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            INotify.Visible = false;
        }

        #endregion INotify

        #region Other

        private void NumericTime_ValueChanged(object sender, EventArgs e)
        {
            SettingList.Time = Convert.ToInt32(NumericTime.Value);
        }

        private void TimeUnitBox_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (TimeUnitBox.Text)
            {
                case "Hour":
                    SettingList.TimeType = TimeUnit.Hour;
                    break;

                case "Minute":
                    SettingList.TimeType = TimeUnit.Minute;
                    break;

                case "Second":
                    SettingList.TimeType = TimeUnit.Second;
                    break;

                default:
                    SettingList.TimeType = TimeUnit.None;
                    break;
            }
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            using (var a = new AboutUs())
                a.ShowDialog();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            var l = sender as RadioButton;
            switch (l.Text)
            {
                case "Tiled":
                    SettingList.TypeImage = ImageType.Tiled;
                    break;

                case "Centered":
                    SettingList.TypeImage = ImageType.Centered;
                    break;

                case "Stretched":
                    SettingList.TypeImage = ImageType.Stretched;
                    break;

                default:
                    break;
            }
        }

        private void RandomBox_CheckedChanged(object sender, EventArgs e)
        {
            SettingList.Random = RandomBox.Checked;
        }

        private void SaveImages_CheckedChanged(object sender, EventArgs e)
        {
            SettingList.SaveImage = SaveImages.Checked;
        }

        private void RunStart_CheckedChanged(object sender, EventArgs e)
        {
            SettingList.StartUpApplication = StartUpApplication.Checked;

            if (StartUpApplication.Checked)
                Native.Create().SetStartUpState(StartUpState.Add);
            else
                Native.Create().SetStartUpState(StartUpState.Delete);
        }

        private void NextS_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void PreviousS_Click(object sender, EventArgs e)
        {
            Previous();
        }

        #endregion Other
    }
}