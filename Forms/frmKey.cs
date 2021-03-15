using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkynetManager
{
    public partial class frmKey : Form
    {
        public frmKey()
        {
            InitializeComponent();
            KeyPressed.Focus();
            TopMost = true;
        }

        private void KeyPressed_KeyDown(object sender, KeyEventArgs e)
        {
            bool save = true;
            switch (e.KeyData)
            {
                case Keys.Escape:
                    save = false;
                    Close();
                    break;
                case Keys.F1:
                    break;
                case Keys.F2:
                    break;
                case Keys.F3:
                    break;
                case Keys.F4:
                    break;
                case Keys.F5:
                    break;
                case Keys.F6:
                    break;
                case Keys.F7:
                    break;
                case Keys.F8:
                    break;
                case Keys.F9:
                    break;
                case Keys.F10:
                    break;
                case Keys.F11:
                    break;
                case Keys.F12:
                    break;
                default:
                    e.SuppressKeyPress = true;
                    return;
            }
            if (save)
            {
                frmMain.Key = e.KeyData.ToString();
            }
            button1.PerformClick();
        }
    }
}
