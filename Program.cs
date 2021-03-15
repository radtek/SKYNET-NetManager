using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkynetManager
{
    static class Program
    {
        public static bool Launched { get; private set; }

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>

        [STAThread]
        static void Main()
        {
            modCommon.InitialiceApplication();
            return;

            Process[] processes = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
            if (processes.Length > 1)
            {
                PrevApplication();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(defaultValue: false);
                Application.Run(new frmBack());
            }
        }

        [DllImport("user32.dll")]
        private static extern int SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern int ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsWindow(IntPtr hWnd);
        public static void PrevApplication()
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\SkyNetManager", writable: true);
                registryKey.GetValue("Handle", RegistryValueKind.String);
                string value = (string)registryKey.GetValue("Handle");

                if (string.IsNullOrEmpty(value))
                    value = "0";
                else if (value == "")
                    value = "0";

                int num = Convert.ToInt32(value);
                if (num > 0 && IsWindow((IntPtr)num))
                {
                    //ShowWindow((IntPtr)num, 1);
                    //SetForegroundWindow((IntPtr)num);
                }
            }
            catch
            {

            }
        }

    }
}
