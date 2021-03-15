using NetPinger;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SkynetManager
{
    public partial class frmMenu : Form
    {
        public TypeMessage typeMessage;
        public frmMenu()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;  //Para permitir acceso a los subprocesos
            MenuPanel.Hide();
        }


        public enum TypeMessage
        {
            Alert,
            Normal,
            YesNo
        }

        private void Avatar_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            box.BackColor = Color.FromArgb(43, 47, 48);
            MenuPanel.Location = new Point(box.Location.X, MenuPanel.Location.Y);
            MenuPanel.Show();
            timer1.Enabled = false;

            switch (box.Name)
            {
                case "NewUser": MostrarLabel("Add device"); break;
                case "Profile": MostrarLabel("Profiles"); break;
                case "RepeatPing": MostrarLabel("Search"); break;
                case "Settings": MostrarLabel("Settings"); break;
            }
        }

        private void Avatar_MouseLeave(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            box.BackColor = panel1.BackColor;
            MenuPanel.Hide();

        }
        private void MostrarLabel(string v)
        {
            SettingsTittle.Text = v;
            //Width
            int W_Pantalla = MenuPanel.Width / 2; //680
            int AnchoTexto = Convert.ToInt32(modCommon.GetTextSize(v, SettingsTittle.Font).Width) / 2;
            int WidthText = (W_Pantalla - AnchoTexto) - 3;


            SettingsTittle.Location = new Point(WidthText, SettingsTittle.Location.Y);
        }
        private void FrmMenu_Deactivate(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void FrmMenu_MouseLeave(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void FrmMenu_MouseMove(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void NewUser_Click(object sender, EventArgs e)
        {
            frmMain.frm.ShowManager();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            frmMain.frm.ShowSettings();
        }

        private void RepeatPing_Click(object sender, EventArgs e)
        {
            frmSearch search = new frmSearch();
            search.Show();
            Close();
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            frmProfile profile = new frmProfile();
            profile.ShowDialog();
        }
    }
}
