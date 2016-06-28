using System;

namespace WinScreen.Core
{
    public class SettingList : Manager<Setting>
    {
        public SettingList()
        {
            Init();
        }

        public bool Random
        {
            get
            {
                return Ject.Random;
            }
            set
            {
                Ject.Random = value;
                Save();
            }
        }

        public bool SaveImage
        {
            get
            {
                return Ject.Save;
            }
            set
            {
                Ject.Save = value;
                Save();
            }
        }

        public int Time
        {
            get
            {
                return Ject.Time.First;
            }
            set
            {
                Ject.Time.First = value;
                Save();
            }
        }

        public TimeUnit TimeType
        {
            get
            {
                return Ject.Time.Second;
            }
            set
            {
                Ject.Time.Second = value;
                Save();
            }
        }

        public ImageType TypeImage
        {
            get
            {
                return Ject.Type;
            }
            set
            {
                Ject.Type = value;
                Save();
            }
        }
        public bool StartUpApplication
        {
            get
            {
                return Ject.StartUpApplication;
            }
            set
            {
                Ject.StartUpApplication = value;
            }
        }
        public bool StartUpProgram
        {
            get
            {
                return Ject.StartUpProgram;
            }
            set
            {
                Ject.StartUpProgram = value;
            }
        }
        protected override void Ctor()
        {
            Ject = new Setting();
        }

        protected override string SetPath()
        {
            return Environment.CurrentDirectory + @"\setting.json";
        }
    }
}