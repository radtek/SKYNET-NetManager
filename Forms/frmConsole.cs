using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data;
using System.Linq;
using System.ComponentModel;
using Microsoft.Win32;
using System.Threading;
using System.Security.Principal;
using System.IO;                    // Para Stream
using System.Text;                  // Para Encoatagring
using System.Net;                   // Para Dns, IPAddress
using System.Net.Sockets;           // Para NetworkStream    []   |||   &&
using System.Security.Permissions;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels;
using System.Runtime.InteropServices;
using SkynetManager.Properties;
using System.Drawing.Drawing2D;
using System.Net.NetworkInformation;
using SkynetManager;

namespace SkynetManager
{
    public partial class frmConsole : Form
    {
        public static frmConsole frm;
        private bool mouseDown;     //Mover ventana
        private Point lastLocation; //Mover ventana
        //public static string TINclientIP = "10.30.127.11";
        //public static string AHBclientIP = "10.30.127.10";
        public static string Win32;
        public bool Ready = false;
        public DeviceBox BOXmenu;
        string Command;

        public frmConsole(string command)
        {

        }
        public frmConsole(DeviceBox menuBOX, bool constante = false)
        {
            InitializeComponent();
            TopMost = true;
            CheckForIllegalCrossThreadCalls = false;  //Para permitir acceso a los subprocesos
            frm = this;
            BOXmenu = menuBOX;
            if (constante)
                Command = "ping " + menuBOX.IpName + " /t";
            else
                Command = "ping " + menuBOX.IpName;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
        private void frmMain_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            Opacity = 100;
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point((Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
                Opacity = 0.93;
            }
        }

        private void panelMin_MouseMove(object sender, MouseEventArgs e)
        {
            panelMin.BackColor = Color.FromArgb(57, 62, 63);
        }

        private void panelMin_MouseLeave(object sender, EventArgs e)
        {
            panelMin.BackColor = Color.FromArgb(43, 47, 48);
        }

        private void panelClose_MouseMove(object sender, MouseEventArgs e)
        {
            panelClose.BackColor = Color.FromArgb(57, 62, 63);
        }

        private void panelClose_MouseLeave(object sender, EventArgs e)
        {
            panelClose.BackColor = Color.FromArgb(43, 47, 48);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            txtConsole.Clear();
            textBox.Focus();
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c " + Command,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine();
                txtConsole.Text += line + Environment.NewLine;
            }
        }

        private void txtConsole_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void txtConsole_TextChanged(object sender, EventArgs e)
        {
            if (txtConsole.Text.Contains("Media = "))
            {
                try
                {
                    for (int i = 0; i < txtConsole.Lines.Count(); i++)
                    {
                        if (txtConsole.Lines[i].Contains("Media = "))
                        {
                            BOXmenu.Ping = txtConsole.Lines[i].Split('=')[3].Replace("ms", " ms");
                            BOXmenu.Status =  ConnectionStatus.Online;
                        }
                    }
                }
                catch
                {
                    BOXmenu.Ping = "3" + " ms";
                    BOXmenu.Status = ConnectionStatus.Online;

                    BOXmenu.Status = ConnectionStatus.Online;
                }
            }
            ScrollToBottom(txtConsole);
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);
        private const int WM_VSCROLL = 277;
        private const int SB_PAGEBOTTOM = 7;
        public static void ScrollToBottom(RichTextBox MyRichTextBox)
        {
            SendMessage(MyRichTextBox.Handle, WM_VSCROLL, (IntPtr)SB_PAGEBOTTOM, IntPtr.Zero);
        }
    }
}
