namespace WinScreen.Core
{
    public class Setting
    {
        public Setting()
        {
            Time = new AnalogTuple<int, TimeUnit>();
            Type = ImageType.Centered;
            Random = Save = false;
            Time.First = 1;
            Time.Second = TimeUnit.None;
        }

        public bool Random { get; set; }
        public bool Save { get; set; }
        public AnalogTuple<int, TimeUnit> Time { get; set; }
        public ImageType Type { get; set; }
        public bool StartUpApplication { get; set; }
        public bool StartUpProgram { get; set; }
    }

    public enum ImageType : int
    {
        Tiled,
        Centered,
        Stretched
    }

    public enum TimeUnit : int
    {
        Second,
        Minute,
        Hour,
        None
    }
}