namespace WinScreen
{
    partial class ScreenForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            foreach (var item in Containers)
            {
                item.Save(true);
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenForm));
            this.INotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.INotifyContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.RandomBox = new System.Windows.Forms.CheckBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.TimeUnitBox = new System.Windows.Forms.ComboBox();
            this.NumericTime = new System.Windows.Forms.NumericUpDown();
            this.Slider = new System.Windows.Forms.Panel();
            this.SliderLeft = new System.Windows.Forms.Button();
            this.SliderRight = new System.Windows.Forms.Button();
            this.IListBox = new System.Windows.Forms.ListBox();
            this.RemoveImage = new System.Windows.Forms.Button();
            this.AddImage = new System.Windows.Forms.Button();
            this.AddImageURL = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.StartUpApplication = new System.Windows.Forms.CheckBox();
            this.SaveImages = new System.Windows.Forms.CheckBox();
            this.OpenFilePicker = new System.Windows.Forms.OpenFileDialog();
            this.UpdateWindow = new System.Windows.Forms.Button();
            this.DelCopy = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ResX = new System.Windows.Forms.Label();
            this.StartUpProgramm = new System.Windows.Forms.Button();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.AboutUs = new System.Windows.Forms.Button();
            this.PreviousS = new System.Windows.Forms.Button();
            this.NextS = new System.Windows.Forms.Button();
            this.INotifyContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTime)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // INotify
            // 
            this.INotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.INotify.BalloonTipText = "WinScreen";
            this.INotify.BalloonTipTitle = "In background";
            this.INotify.ContextMenuStrip = this.INotifyContextMenu;
            this.INotify.Icon = ((System.Drawing.Icon)(resources.GetObject("INotify.Icon")));
            this.INotify.Text = "WinScreen";
            this.INotify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.INotify_MouseDoubleClick);
            // 
            // INotifyContextMenu
            // 
            this.INotifyContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripSeparator2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem6});
            this.INotifyContextMenu.Name = "INotifyContextMenu";
            this.INotifyContextMenu.Size = new System.Drawing.Size(120, 148);
            this.INotifyContextMenu.Text = "WinScreen";
            this.INotifyContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.INotifyContextMenu_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem1.Text = "Start";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem2.Text = "Stop";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(116, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem4.Text = "Next";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem5.Text = "Previous";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(116, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem3.Text = "Exit";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem6.Text = "Show";
            // 
            // RandomBox
            // 
            this.RandomBox.AutoSize = true;
            this.RandomBox.Location = new System.Drawing.Point(6, 24);
            this.RandomBox.Name = "RandomBox";
            this.RandomBox.Size = new System.Drawing.Size(66, 17);
            this.RandomBox.TabIndex = 33;
            this.RandomBox.Text = "Random";
            this.RandomBox.UseVisualStyleBackColor = true;
            this.RandomBox.CheckedChanged += new System.EventHandler(this.RandomBox_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(6, 69);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(71, 17);
            this.radioButton8.TabIndex = 29;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Stretched";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(6, 46);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(68, 17);
            this.radioButton7.TabIndex = 28;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Centered";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 23);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(48, 17);
            this.radioButton6.TabIndex = 27;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Tiled";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // TimeUnitBox
            // 
            this.TimeUnitBox.FormattingEnabled = true;
            this.TimeUnitBox.Items.AddRange(new object[] {
            "Second",
            "Minute",
            "Hour"});
            this.TimeUnitBox.Location = new System.Drawing.Point(6, 49);
            this.TimeUnitBox.Name = "TimeUnitBox";
            this.TimeUnitBox.Size = new System.Drawing.Size(87, 21);
            this.TimeUnitBox.TabIndex = 24;
            this.TimeUnitBox.Text = "Type";
            this.TimeUnitBox.SelectedValueChanged += new System.EventHandler(this.TimeUnitBox_SelectedValueChanged);
            // 
            // NumericTime
            // 
            this.NumericTime.Location = new System.Drawing.Point(6, 23);
            this.NumericTime.Name = "NumericTime";
            this.NumericTime.Size = new System.Drawing.Size(87, 20);
            this.NumericTime.TabIndex = 23;
            this.NumericTime.ValueChanged += new System.EventHandler(this.NumericTime_ValueChanged);
            // 
            // Slider
            // 
            this.Slider.BackgroundImage = global::WinScreen.Properties.Resources.Windows_10;
            this.Slider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Slider.Location = new System.Drawing.Point(334, 12);
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(351, 100);
            this.Slider.TabIndex = 35;
            // 
            // SliderLeft
            // 
            this.SliderLeft.Location = new System.Drawing.Point(334, 118);
            this.SliderLeft.Name = "SliderLeft";
            this.SliderLeft.Size = new System.Drawing.Size(75, 23);
            this.SliderLeft.TabIndex = 36;
            this.SliderLeft.Text = "Left";
            this.SliderLeft.UseVisualStyleBackColor = true;
            this.SliderLeft.Click += new System.EventHandler(this.SliderLeft_Click);
            // 
            // SliderRight
            // 
            this.SliderRight.Location = new System.Drawing.Point(610, 118);
            this.SliderRight.Name = "SliderRight";
            this.SliderRight.Size = new System.Drawing.Size(75, 23);
            this.SliderRight.TabIndex = 37;
            this.SliderRight.Text = "Right";
            this.SliderRight.UseVisualStyleBackColor = true;
            this.SliderRight.Click += new System.EventHandler(this.SliderRight_Click);
            // 
            // IListBox
            // 
            this.IListBox.FormattingEnabled = true;
            this.IListBox.Location = new System.Drawing.Point(334, 147);
            this.IListBox.Name = "IListBox";
            this.IListBox.Size = new System.Drawing.Size(351, 95);
            this.IListBox.TabIndex = 38;
            this.IListBox.SelectedIndexChanged += new System.EventHandler(this.IListBox_SelectedIndexChanged);
            this.IListBox.DoubleClick += new System.EventHandler(this.IListBox_DoubleClick);
            // 
            // RemoveImage
            // 
            this.RemoveImage.Location = new System.Drawing.Point(334, 245);
            this.RemoveImage.Name = "RemoveImage";
            this.RemoveImage.Size = new System.Drawing.Size(75, 23);
            this.RemoveImage.TabIndex = 39;
            this.RemoveImage.Text = "Delete";
            this.RemoveImage.UseVisualStyleBackColor = true;
            this.RemoveImage.Click += new System.EventHandler(this.RemoveImage_Click);
            // 
            // AddImage
            // 
            this.AddImage.Location = new System.Drawing.Point(517, 245);
            this.AddImage.Name = "AddImage";
            this.AddImage.Size = new System.Drawing.Size(87, 23);
            this.AddImage.TabIndex = 40;
            this.AddImage.Text = "Add";
            this.AddImage.UseVisualStyleBackColor = true;
            this.AddImage.Click += new System.EventHandler(this.AddImage_Click);
            // 
            // AddImageURL
            // 
            this.AddImageURL.Location = new System.Drawing.Point(610, 245);
            this.AddImageURL.Name = "AddImageURL";
            this.AddImageURL.Size = new System.Drawing.Size(75, 23);
            this.AddImageURL.TabIndex = 42;
            this.AddImageURL.Text = "Add URL";
            this.AddImageURL.UseVisualStyleBackColor = true;
            this.AddImageURL.Click += new System.EventHandler(this.AddImageURL_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Location = new System.Drawing.Point(119, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(92, 123);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NumericTime);
            this.groupBox1.Controls.Add(this.TimeUnitBox);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 123);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time Interval";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.StartUpApplication);
            this.groupBox3.Controls.Add(this.SaveImages);
            this.groupBox3.Controls.Add(this.RandomBox);
            this.groupBox3.Location = new System.Drawing.Point(217, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(111, 123);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Other";
            // 
            // StartUpApplication
            // 
            this.StartUpApplication.AutoSize = true;
            this.StartUpApplication.Location = new System.Drawing.Point(6, 69);
            this.StartUpApplication.Name = "StartUpApplication";
            this.StartUpApplication.Size = new System.Drawing.Size(105, 17);
            this.StartUpApplication.TabIndex = 35;
            this.StartUpApplication.Text = "Run at Windows";
            this.StartUpApplication.UseVisualStyleBackColor = true;
            this.StartUpApplication.CheckedChanged += new System.EventHandler(this.RunStart_CheckedChanged);
            // 
            // SaveImages
            // 
            this.SaveImages.AutoSize = true;
            this.SaveImages.Location = new System.Drawing.Point(6, 47);
            this.SaveImages.Name = "SaveImages";
            this.SaveImages.Size = new System.Drawing.Size(88, 17);
            this.SaveImages.TabIndex = 34;
            this.SaveImages.Text = "Save Images";
            this.SaveImages.UseVisualStyleBackColor = true;
            this.SaveImages.CheckedChanged += new System.EventHandler(this.SaveImages_CheckedChanged);
            // 
            // OpenFilePicker
            // 
            this.OpenFilePicker.Multiselect = true;
            // 
            // UpdateWindow
            // 
            this.UpdateWindow.Location = new System.Drawing.Point(470, 118);
            this.UpdateWindow.Name = "UpdateWindow";
            this.UpdateWindow.Size = new System.Drawing.Size(87, 23);
            this.UpdateWindow.TabIndex = 46;
            this.UpdateWindow.Text = "Update";
            this.UpdateWindow.UseVisualStyleBackColor = true;
            this.UpdateWindow.Click += new System.EventHandler(this.UpdateWindow_Click);
            // 
            // DelCopy
            // 
            this.DelCopy.Location = new System.Drawing.Point(415, 245);
            this.DelCopy.Name = "DelCopy";
            this.DelCopy.Size = new System.Drawing.Size(96, 23);
            this.DelCopy.TabIndex = 47;
            this.DelCopy.Text = "Delete copies";
            this.DelCopy.UseVisualStyleBackColor = true;
            this.DelCopy.Click += new System.EventHandler(this.DelCopy_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ResX);
            this.groupBox4.Location = new System.Drawing.Point(8, 141);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(320, 38);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resolution";
            // 
            // ResX
            // 
            this.ResX.AutoSize = true;
            this.ResX.Location = new System.Drawing.Point(7, 19);
            this.ResX.Name = "ResX";
            this.ResX.Size = new System.Drawing.Size(57, 13);
            this.ResX.TabIndex = 0;
            this.ResX.Text = "Resolution";
            // 
            // StartUpProgramm
            // 
            this.StartUpProgramm.Location = new System.Drawing.Point(88, 185);
            this.StartUpProgramm.Name = "StartUpProgramm";
            this.StartUpProgramm.Size = new System.Drawing.Size(159, 32);
            this.StartUpProgramm.TabIndex = 49;
            this.StartUpProgramm.Text = "Start Up";
            this.StartUpProgramm.UseVisualStyleBackColor = true;
            this.StartUpProgramm.Click += new System.EventHandler(this.StartUp_Click);
            // 
            // MainTimer
            // 
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // AboutUs
            // 
            this.AboutUs.Location = new System.Drawing.Point(610, 275);
            this.AboutUs.Name = "AboutUs";
            this.AboutUs.Size = new System.Drawing.Size(75, 23);
            this.AboutUs.TabIndex = 50;
            this.AboutUs.Text = "About";
            this.AboutUs.UseVisualStyleBackColor = true;
            this.AboutUs.Click += new System.EventHandler(this.AboutUs_Click);
            // 
            // PreviousS
            // 
            this.PreviousS.Location = new System.Drawing.Point(8, 185);
            this.PreviousS.Name = "PreviousS";
            this.PreviousS.Size = new System.Drawing.Size(75, 32);
            this.PreviousS.TabIndex = 51;
            this.PreviousS.Text = "Previous";
            this.PreviousS.UseVisualStyleBackColor = true;
            this.PreviousS.Click += new System.EventHandler(this.PreviousS_Click);
            // 
            // NextS
            // 
            this.NextS.Location = new System.Drawing.Point(253, 185);
            this.NextS.Name = "NextS";
            this.NextS.Size = new System.Drawing.Size(75, 32);
            this.NextS.TabIndex = 52;
            this.NextS.Text = "Next";
            this.NextS.UseVisualStyleBackColor = true;
            this.NextS.Click += new System.EventHandler(this.NextS_Click);
            // 
            // ScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 310);
            this.Controls.Add(this.NextS);
            this.Controls.Add(this.PreviousS);
            this.Controls.Add(this.AboutUs);
            this.Controls.Add(this.StartUpProgramm);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.DelCopy);
            this.Controls.Add(this.UpdateWindow);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.AddImageURL);
            this.Controls.Add(this.AddImage);
            this.Controls.Add(this.RemoveImage);
            this.Controls.Add(this.IListBox);
            this.Controls.Add(this.SliderRight);
            this.Controls.Add(this.SliderLeft);
            this.Controls.Add(this.Slider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinScreen";
            this.Resize += new System.EventHandler(this.ScreenForm_Resize);
            this.INotifyContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericTime)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon INotify;
        private System.Windows.Forms.CheckBox RandomBox;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.ComboBox TimeUnitBox;
        private System.Windows.Forms.NumericUpDown NumericTime;
        private System.Windows.Forms.Panel Slider;
        private System.Windows.Forms.Button SliderLeft;
        private System.Windows.Forms.Button SliderRight;
        private System.Windows.Forms.ListBox IListBox;
        private System.Windows.Forms.Button RemoveImage;
        private System.Windows.Forms.Button AddImage;
        private System.Windows.Forms.Button AddImageURL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox SaveImages;
        private System.Windows.Forms.OpenFileDialog OpenFilePicker;
        private System.Windows.Forms.Button UpdateWindow;
        private System.Windows.Forms.Button DelCopy;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label ResX;
        private System.Windows.Forms.Button StartUpProgramm;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Button AboutUs;
        private System.Windows.Forms.ContextMenuStrip INotifyContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.CheckBox StartUpApplication;
        private System.Windows.Forms.Button PreviousS;
        private System.Windows.Forms.Button NextS;
    }
}

