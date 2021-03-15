﻿using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using Microsoft.VisualBasic.CompilerServices;
using System.IO;

namespace SkynetManager
{
    public partial class frmPhoto : Form
    {
        //Settings
        public static frmPhoto frm;
        private int curX;
        private int curY;
        private bool dragging;
        private bool dragging1;
        private Bitmap m_CroppedBm;
        private Bitmap m_CroppedSmallBm;
        private bool mouseDown;     //Mover ventana
        private Point lastLocation; //Mover ventana

        public int PhotoWidth { get; set; }
        public int PhotoHeight { get; set; }
        private static string _OriginalFileName { get; set; }


        /////////////////////////////////////////////////////////////////////////

        public string ActivePluginName => _activePluginName;
        public IEnumerator enumerator;
        public bool _SExit;
        public bool _Exit;
        public bool deactivatemain;
        public bool _isSplitterMoving;
        public string _searchPluginName;
        public bool _hidesearch;
        public static FlowLayoutPanel pnlAnnouncement = new FlowLayoutPanel();
        //private UserHost _userHost;
        private string[] _args;
        public Panel pnlChatDetail;
        public string Selrowkey;
        public static Image userPhoto;
        //Chat
        public static Form SettingsForm = null;
        public bool saveOnExit;
        public bool Muted;
        public bool alive = true;
        public RegistryKey Chat;

        //Servidor Ficheros
        public bool topNivel;
        public string _activePluginName { get; set; }
        public string SectionName { get; private set; }

        public frmPhoto(string sectionName)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;  //Para permitir acceso a los subprocesos
            SectionName = sectionName;
            CursorWorker.RunWorkerAsync();
            base.KeyDown += frmPhoto_KeyDown;
            base.Load += frmPhoto_Load;
            frm = this;
            _OriginalFileName = string.Empty;
            lblResize.DragLeave += lblResize_DragLeave;
            lblResize.MouseDown += lblResize_MouseDown;
            lblResize.MouseHover += lblResize_MouseHover;
            lblResize.MouseMove += lblResize_MouseMove;
            lblResize.MouseUp += lblResize_MouseUp;
            lblSelector.MouseDown += lblSelector_MouseDown;
            lblSelector.MouseMove += lblSelector_MouseMove;
            lblSelector.MouseUp += lblSelector_MouseUp;

        }
        public void ajustarPosicion(int x, int y)
        {
            try
            {
                ResizeControlLocation();
                int width;
                int height;
                using (Image image = modCommon.ImageFromFile(_OriginalFileName))
                {
                    width = image.Width;
                    height = image.Height;
                }
                int width2;
                int height2;
                using (Bitmap bitmap = new Bitmap(picSelectPhoto.Image))
                {
                    width2 = bitmap.Width;
                    height2 = bitmap.Height;
                }
                decimal d = new decimal((double)width / (double)width2);
                decimal d2 = new decimal((double)height / (double)height2);
                using (Bitmap image2 = new Bitmap(_OriginalFileName))
                {
                    decimal value = decimal.Multiply(new decimal(lblSelector.Location.X), d);
                    decimal value2 = decimal.Multiply(new decimal(lblSelector.Location.Y), d2);
                    decimal value3 = decimal.Multiply(new decimal(lblSelector.Width), d);
                    decimal value4 = decimal.Multiply(new decimal(lblSelector.Height), d2);
                    Rectangle srcRect = new Rectangle(Convert.ToInt32(value), Convert.ToInt32(value2), Convert.ToInt32(value3), Convert.ToInt32(value4));
                    Rectangle destRect = new Rectangle(0, 0, pctPhoto.Width, pctPhoto.Height);
                    m_CroppedBm = new Bitmap(pctPhoto.Width, pctPhoto.Height);
                    using (Graphics graphics = Graphics.FromImage(m_CroppedBm))
                    {
                        graphics.SmoothingMode = SmoothingMode.HighQuality;
                        graphics.CompositingQuality = CompositingQuality.HighQuality;
                        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        graphics.DrawImage(image2, destRect, srcRect, GraphicsUnit.Pixel);
                    }
                    pctPhoto.Image = m_CroppedBm;
                    destRect = new Rectangle(0, 0, picSmall.Width, picSmall.Height);
                    m_CroppedSmallBm = new Bitmap(picSmall.Width, picSmall.Height);
                    using (Graphics graphics2 = Graphics.FromImage(m_CroppedSmallBm))
                    {
                        graphics2.SmoothingMode = SmoothingMode.HighQuality;
                        graphics2.CompositingQuality = CompositingQuality.HighQuality;
                        graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        graphics2.DrawImage(image2, destRect, srcRect, GraphicsUnit.Pixel);
                    }
                    picSmall.Image = m_CroppedSmallBm;
                }
            }
            catch (Exception ex)
            {
                Exception ex2 = ex;
            }
        }
        private void frmPhoto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                Close();
            }
        }

        private void frmPhoto_Load(object sender, EventArgs e)
        {
            try
            {
                lblSelector.Location = new Point(76, 69);
                lblSelector.Parent = picSelectPhoto;
                ResizeControlLocation();
                ajustarPosicion(lblSelector.Location.X, lblSelector.Location.Y);
            }
            catch (Exception ex)
            {
                Exception ex2 = ex;
            }
        }
        private void lblOkPhoto_Click(object sender, EventArgs e)
        {
        }
        private void lblResize_DragLeave(object sender, EventArgs e)
        {
            ajustarPosicion(lblSelector.Location.X, lblSelector.Location.Y);
        }
        private void lblResize_MouseDown(object sender, MouseEventArgs e)
        {
            curX = e.X;
            curY = e.Y;
            dragging1 = true;
            lblSelector.SuspendLayout();
            lblResize.Cursor = Cursors.SizeNWSE;
        }
        private void lblResize_MouseHover(object sender, EventArgs e)
        {
            lblResize.Cursor = Cursors.SizeNWSE;
        }
        private void lblResize_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (dragging1)
                {
                    lblSelector.Cursor = Cursors.SizeAll;
                    Control control = (Control)sender;
                    checked
                    {
                        int num = control.Left + e.X - curX - lblSelector.Left;
                        int num2 = control.Top + e.Y - curY - lblSelector.Top;
                        if (num >= 0 && num2 >= 0 && (lblSelector.Height + lblSelector.Top <= picSelectPhoto.Height || num2 <= lblSelector.Height) && (lblSelector.Width + lblSelector.Left <= picSelectPhoto.Width || num <= lblSelector.Width))
                        {
                            lblSelector.Width = control.Left + e.X - curX - lblSelector.Left;
                            lblSelector.Height = lblSelector.Width;
                            if (lblSelector.Height + lblSelector.Top > picSelectPhoto.Height)
                            {
                                lblSelector.Height -= lblSelector.Height + lblSelector.Top - picSelectPhoto.Height;
                            }
                            if (lblSelector.Width + lblSelector.Left > picSelectPhoto.Width)
                            {
                                lblSelector.Width -= lblSelector.Width + lblSelector.Left - picSelectPhoto.Width;
                            }
                            ResizeControlLocation();
                            control.BringToFront();
                            control.Invalidate();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                
                ProjectData.ClearProjectError();
            }
        }
        private void lblResize_MouseUp(object sender, MouseEventArgs e)
        {
            dragging1 = false;
            dragging = false;
            lblSelector.BorderStyle = BorderStyle.Fixed3D;
            ajustarPosicion(lblSelector.Location.X, lblSelector.Location.Y);

        }
        private void lblSelector_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            lblSelector.BringToFront();
            curX = e.X;
            curY = e.Y;
            lblSelector.Cursor = Cursors.SizeAll;
        }
        private void lblSelector_MouseMove(object sender, MouseEventArgs e)
        {
            checked
            {
                try
                {
                    if (dragging && lblSelector.Left + e.X - curX >= 1 && lblSelector.Top + e.Y - curY >= 1 && lblSelector.Left + e.X - curX + lblSelector.Width <= picSelectPhoto.Width && lblSelector.Top + e.Y - curY + lblSelector.Height <= picSelectPhoto.Height)
                    {
                        lblSelector.Left = lblSelector.Left + e.X - curX;
                        lblSelector.Top = lblSelector.Top + e.Y - curY;
                        ResizeControlLocation();
                    }
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    Exception ex2 = ex;
                    
                    ProjectData.ClearProjectError();
                }
            }
        }
        private void lblSelector_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                dragging = false;
                dragging1 = false;
                ajustarPosicion(lblSelector.Location.X, lblSelector.Location.Y);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                
                ProjectData.ClearProjectError();
            }
        }
        private void ResizeControlLocation()
        {
            try
            {
                lblResize.Location = checked(new Point(lblSelector.Left + lblSelector.Width + picSelectPhoto.Left - lblResize.Width - 1, lblSelector.Top + lblSelector.Height + picSelectPhoto.Top - lblResize.Height - 1));
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                
                ProjectData.ClearProjectError();
            }
        }




        public Image ResizeImage(string originalImageFileName, Image image, Size size, bool preserveAspectRatio = true)
        {
            _OriginalFileName = originalImageFileName;
            Image result = default(Image);
            try
            {
                int width2;
                int height2;
                if (preserveAspectRatio)
                {
                    int width = image.Width;
                    int height = image.Height;
                    float num = (float)size.Width / (float)width;
                    float num2 = (float)size.Height / (float)height;
                    float num3 = (num2 < num) ? num2 : num;
                    checked
                    {
                        width2 = (int)Math.Round((double)unchecked((float)width * num3));
                        height2 = (int)Math.Round((double)unchecked((float)height * num3));
                    }
                }
                else
                {
                    width2 = size.Width;
                    height2 = size.Height;
                }
                Image image2 = new Bitmap(width2, height2);
                using (Graphics graphics = Graphics.FromImage(image2))
                {
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.DrawImage(image, 0, 0, width2, height2);
                }
                result = image2;
                return result;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                
                ProjectData.ClearProjectError();
                return result;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        private void frmMain_Shown(object sender, EventArgs e)
        {
            try
            {
                if (this._args == null || this._args.Length <= 1 || !this._args[1].Equals("/m"))
                    return;
                this._args = (string[])null;
                this.Hide();
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                
                ProjectData.ClearProjectError();
            }
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Rectangle rect = new Rectangle(1, 1, checked(this.Width - 2), checked(this.Height - 2));
                using (SolidBrush solidBrush = new SolidBrush(Color.White))
                    e.Graphics.FillRectangle((Brush)solidBrush, rect);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                
                ProjectData.ClearProjectError();
            }
        }

        private void panelClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeBtn_MouseMove(object sender, MouseEventArgs e)
        {
            panelClose.BackColor = Color.FromArgb(57, 62, 63);
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            panelClose.BackColor = Color.FromArgb(43, 47, 48);
        }

        private void Tittle_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            Opacity = 100;
        }

        private void Tittle_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point((Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
                Opacity = 0.93;
            }
        }

        private void Tittle_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void CursorWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //Guardar imagen en formato dat al clickear en ok

            if (!Directory.Exists(modCommon.CurrentDirectory + "/Data/Images/"))
            {
                Directory.CreateDirectory(modCommon.CurrentDirectory + "/Data/Images/");
            }

            string destPath = modCommon.CurrentDirectory + "/Data/Images/" + frmMain.CurrentSection + "_" + SectionName + ".png";
            modCommon.Resize((Bitmap)pctPhoto.Image, 1000, 1000, destPath);
            Close();

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }









        /*
        .
        .
        .
        */
    }
}
