using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkynetManager
{
    public partial class frmBack : Form
    {
        public static frmBack frm;
        public frmBack()
        {
            InitializeComponent();
            frm = this;
            Opacity = 0;
        }

        public frmMain Main;

        private void FrmBack_Load(object sender, EventArgs e)
        {

        }

        private void FrmBack_Shown(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            Main = new frmMain(this);
            Main.ShowDialog();
        }

        private void FrmBack_Activated(object sender, EventArgs e)
        {
            if (Main != null)
            {
                Main.Activate();

            }
        }

    }
}
