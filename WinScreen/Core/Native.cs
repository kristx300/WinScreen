using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinScreen.Core
{
    public class Native
    {
        private const int SPI_SETDESKWALLPAPER = 20;
        private const int SPIF_SENDWININICHANGE = 0x02;
        private const int SPIF_UPDATEINIFILE = 0x01;
        private static RegistryKey RK = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        public static bool GetStartUpState()
        {
            return RK.GetValue("WinScreen") == null;
        }

        public static void SetStartUpState(StartUpState ss)
        {
            if (ss == StartUpState.Add)
                RK.SetValue("WinScreen", Application.ExecutablePath);
            else if (ss == StartUpState.Delete)
                RK.DeleteValue("WinScreen", false);
        }

        public static void SetWindow(string path, ImageType style)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
            if (style == ImageType.Stretched)
            {
                key.SetValue(@"WallpaperStyle", 2.ToString());
                key.SetValue(@"TileWallpaper", 0.ToString());
            }
            else if (style == ImageType.Centered)
            {
                key.SetValue(@"WallpaperStyle", 1.ToString());
                key.SetValue(@"TileWallpaper", 0.ToString());
            }
            else if (style == ImageType.Tiled)
            {
                key.SetValue(@"WallpaperStyle", 1.ToString());
                key.SetValue(@"TileWallpaper", 1.ToString());
            }

            SystemParametersInfo(SPI_SETDESKWALLPAPER,
                0,
                path,
                SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
            key.Close();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
    }

    public enum StartUpState
    {
        Add,
        Delete
    }
}