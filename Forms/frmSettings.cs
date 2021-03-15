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
using System.Collections.Generic;

namespace SkynetManager
{
    public partial class frmSettings : Form
    {
        public static frmSettings frm;
        private bool mouseDown;     //Mover ventana
        private Point lastLocation; //Mover ventana
        public bool Ready = false;
        public DeviceBox menuBOX;


        public frmSettings()
        {
            InitializeComponent();

            TopMost = true;
            CheckForIllegalCrossThreadCalls = false;  //Para permitir acceso a los subprocesos
            frm = this;

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (frmMain.FirstLaunch)
            {
                minimizeBox.Checked = false;
                launchWindowsBox.Checked = false;
                KeyLabel.Text = frmMain.Key;
                ShowInLeft.Checked = false;
                CustomSound.Checked = false;
                DefaultSound.Checked = !CustomSound.Checked;
                ShowTopPanel.Checked = true;
            }
            else
            {
                minimizeBox.Checked = frmMain.MinimizeWhenClose;
                launchWindowsBox.Checked = frmMain.LaunchWindowsStart;
                KeyLabel.Text = frmMain.Key;
                ShowInLeft.Checked = frmMain.ShowInLeft;
                TimeOut.Text = frmMain.Timeout.ToString();
                TTL.Text = frmMain.TTL.ToString();
                BufferSize.Text = frmMain.BufferSize.ToString();
                CustomSound.Checked = frmMain.CustomSound;
                DefaultSound.Checked = !CustomSound.Checked;
                CustomSoundPatch.Text = frmMain.CustomSoundPatch;
                ShowTopPanel.Checked = frmMain.ShowTopPanel;
            }

            int maximum = 100;
            string opacity = frmBack.frm.Opacity.ToString();
            opacity = opacity.Replace("0,", "").Replace("0.", "");

            int value = Convert.ToInt32(opacity);
            if (value == 1) value = 100;

            OpacityBar.Maximum = maximum;
            OpacityBar.Value = value;
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
            Visible = false;
        }


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            frmMain.MinimizeWhenClose = minimizeBox.Checked;
            frmMain.LaunchWindowsStart = launchWindowsBox.Checked;

            frmMain.Timeout = Convert.ToInt32(TimeOut.Text);
            frmMain.TTL = Convert.ToInt32(TTL.Text);
            frmMain.BufferSize = Convert.ToInt32(BufferSize.Text);

            frmMain.CustomSoundPatch = CustomSoundPatch.Text;
            frmMain.CustomSound = CustomSound.Checked;
            frmMain.ShowTopPanel = ShowTopPanel.Checked;


            button1.PerformClick();
        }

        private void AceptarBtn_MouseMove(object sender, MouseEventArgs e)
        {
            AceptarBtn.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void AceptarBtn_MouseLeave(object sender, EventArgs e)
        {
            AceptarBtn.ForeColor = Color.FromArgb(147, 157, 160);
        }

        private void KeyLabel_TextChanged(object sender, EventArgs e)
        {
            int W_Pantalla = KeyContainer.Width / 2; //680
            int AnchoTexto = Convert.ToInt32(modCommon.GetTextSize(KeyLabel.Text, KeyLabel.Font).Width) / 2;
            int WidthText = (W_Pantalla - AnchoTexto) - 3;

            KeyLabel.Location = new Point(WidthText, KeyLabel.Location.Y);
        }

        private void KeyClick(object sender, EventArgs e)
        {
            frmKey key = new frmKey();
            key.ShowDialog();
            KeyLabel.Text = frmMain.Key;
        }

        private void ShowInLeft_Click(object sender, EventArgs e)
        {
            frmMain.ShowInLeft = ShowInLeft.Checked;
            frmMain.frm.Maximize(ShowInLeft.Checked);
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void OpacityBar_Scroll(object sender, EventArgs e)
        {
            double value = OpacityBar.Value;
            //

            if (value < 100)
            {
                value = value / 100;
            }
            frmBack.frm.Opacity = value;
            frmMain.OpacityForm = value;
        }

        private void FlatRadioButton1_Click(object sender, EventArgs e)
        {

        }

        private void DefaultSound_Click(object sender, EventArgs e)
        {
            CustomSound.Checked = !DefaultSound.Checked;
        }

        private void CustomSound_Click(object sender, EventArgs e)
        {
            DefaultSound.Checked = !CustomSound.Checked;
        }

        private void SearhSound_Click(object sender, EventArgs e)
        {
            OpenFileDialog Sound = new OpenFileDialog();
            Sound.FileName = string.Empty;
            Sound.Filter = "Audio files|*.wav";
            Sound.Title = "Select Photo";
            Sound.RestoreDirectory = true;
            DialogResult num = Sound.ShowDialog();
            if (num == DialogResult.OK)
            {
                CustomSoundPatch.Text = Sound.FileName;
            }

        }

        private void ShowTopPanel_Click(object sender, EventArgs e)
        {
            modCommon.ShowBars(ShowTopPanel.Checked);
        }
    }
}
