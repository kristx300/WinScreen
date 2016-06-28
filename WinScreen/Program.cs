using System;
using System.Threading;
using System.Windows.Forms;

namespace WinScreen
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        static Mutex mutex = new Mutex(false, "{B0E11F68-7DE0-4737-94F8-5EAB187A96D1}");
        [STAThread]
        static void Main()
        {
            // if you like to wait a few seconds in case that the instance is just 
            // shutting down
            if (!mutex.WaitOne(TimeSpan.Zero, false))
            {
                MessageBox.Show("Application already worked!", "Oops", MessageBoxButtons.OK);
                return;
            }

            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ScreenForm());
            }
            finally { mutex.ReleaseMutex(); } // I find this more explicit
        }
    }
}