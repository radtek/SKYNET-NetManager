using SKYNET.Common;
using SkynetManager.Properties;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace SkynetManager
{
    public partial class frmManager : Form
    {
        private bool mouseDown;     //Mover ventana
        private Point lastLocation; //Mover ventana
        public TypeMessage typeMessage;
        DeviceBox Box;
        string SectionName;
        int sectionNumber;

        public frmManager(DeviceBox tool = null)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;  //Para permitir acceso a los subprocesos

            if (tool != null)
            {
                Box = tool;
                if (Box.isWeb && string.IsNullOrEmpty(Box.Port)) Box.Port = "80";

                DeviceName.Text = Box.BoxName;
                DeviceIp.Text = Box.IpName;
                DeviceWeb.Checked = Box.isWeb;
                Avatar.Image = Box.Avatar.Image;
                SectionName = Box.Name;
                MAC.Text = Box.MAC;
                Port.Visible = DeviceWeb.Checked;
                Port.Text = Box.Port;
                Interval.Text = Box.Interval.ToString();
                OpcionalLocation.Text = Box.OpcionalLocation;
                CircularAvatar.Checked = Box.CircularAvatar;
            }
            else
            {
                /*sectionNumber = modCommon.GetNextSection();
                SectionName = frmMain.CurrentSection + sectionNumber;*/
            }
            Check(DeviceWeb.Checked);
        }
        public frmManager(Host host)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;  //Para permitir acceso a los subprocesos

            if (host != null)
            {
                DeviceName.Text = host.HostName;
                DeviceIp.Text = host.IP;
                MAC.Text = host.MAC;

            }
            else
            {
                Close();
            }
        }


        private void Event_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                base.Location = new Point((base.Location.X - lastLocation.X) + e.X, (base.Location.Y - lastLocation.Y) + e.Y);
                Update();
                Opacity = 0.93;
            }
        }

        private void Event_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }

        private void Event_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            Opacity = 100;
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void panelClose_MouseMove(object sender, MouseEventArgs e)
        {
            panelClose.BackColor = Color.FromArgb(53, 64, 78);
        }

        private void panelClose_MouseLeave(object sender, EventArgs e)
        {
            panelClose.BackColor = Color.FromArgb(43, 54, 68);
        }

        public enum TypeMessage
        {
            Alert,
            Normal,
            YesNo
        }

        private void frmMessage_Activated(object sender, EventArgs e)
        {

        }

        private void frmMessage_Deactivate(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!modCommon.IsValidIp(DeviceIp.Text))
            {
                modCommon.Show("El número IP no es válido... por favor verifíquelo");
                return;
            }
            if (Interval.Text == "0")
            {
                modCommon.Show("El intervalo debe ser al menos cada 1 segundo");
                return;
            }
            if (Box != null)
            {
                Box.BoxName = DeviceName.Text;
                Box.IpName = DeviceIp.Text;
                Box.isWeb = DeviceWeb.Checked;
                Box.SetAvatar(Avatar.Image);

                if (int.TryParse(Interval.Text, out int interval))
                {
                    Box.Interval = interval;
                }
                else
                    Box.Interval = 1;

                Box.Port = Port.Text;
                Box.OpcionalLocation = OpcionalLocation.Text;


                frmMain.frm.UpdateAndSave();
            }
            else
            {
                Device device = new Device();
                device.Name = DeviceName.Text;
                device.Ip = DeviceIp.Text;
                device.TCP = DeviceWeb.Checked;

                if (int.TryParse(Port.Text, out int interval))
                {
                    device.Interval = interval;
                }
                else
                    device.Interval = 1;

                if (int.TryParse(Port.Text, out int port))
                {
                    device.Port = port;
                }
                else
                    device.Port = 0;

                device.OpcionalLocation = OpcionalLocation.Text;
                device.Orden = DeviceManager.GetDeviceCount() + 1;

                frmMain.frm.AddBox(device);
                frmMain.frm.UpdateAndSave();
            }



            frmMain.frm.SaveDevices();
            Close();
        }

        private void DeviceWeb_Click(object sender, EventArgs e)
        {
            Check(DeviceWeb.Checked);
        }

        private void Check(bool _checked)
        {
            Port.Visible = DeviceWeb.Checked;
        }

        private void Avatar_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("Devices"))
            {
                Directory.CreateDirectory("Devices");
            }

            frmPhoto FrmPhoto = new frmPhoto(SectionName);
            OpenFileDialog ofdPhoto = new OpenFileDialog();
            ofdPhoto.FileName = string.Empty;
            ofdPhoto.Filter = "Picture files|*.jpg;*.bmp;*.png;*.gif;*.ico|All Files|*.*";
            ofdPhoto.Title = "Select Photo";
            ofdPhoto.RestoreDirectory = true;
            DialogResult dialogResult = ofdPhoto.ShowDialog();
            //pctPhoto.Tag = string.Empty;
            this.Visible = false;
            WindowState = FormWindowState.Minimized;
            if (dialogResult == DialogResult.OK)
            {
                string FileName = modCommon.CurrentDirectory + "/Data/Images/" + frmMain.CurrentSection + "_" + SectionName + ".png";
                ImageType type = DeviceManager.GetImageType(ofdPhoto.FileName);

                if (type == ImageType.ICO)
                {
                    Bitmap bitmap = (Bitmap)default;
                    try
                    {
                        bitmap = new Icon(ofdPhoto.FileName, 1000, 1000).ToBitmap();
                    }
                    catch (Exception)
                    {
                        bitmap = Bitmap.FromHicon((new Icon(ofdPhoto.FileName, 1000, 1000).Handle));
                    }
                    bitmap = ImageHelper.CreateResizedBitmap(bitmap, 1000, 1000, ImageFormat.Png);
                    bitmap.Save(FileName, ImageFormat.Png);
                    LoadImage();
                }
                else
                {
                    //pctPhoto.Tag = "1";
                    Image image = modCommon.ImageFromFile(ofdPhoto.FileName);

                    if (image.Width < 250)
                    {
                        Bitmap bitmap = (Bitmap)default;
                        bitmap = ImageHelper.CreateResizedBitmap((Bitmap)image, 1000, 1000, ImageFormat.Png);
                        bitmap.Save(FileName, ImageFormat.Png);
                    }
                    else
                    {

                        int width = 413;
                        int height = 423;
                        Image image2 = FrmPhoto.ResizeImage(ofdPhoto.FileName, image, new Size(width, height));
                        FrmPhoto.picSelectPhoto.Width = width;
                        FrmPhoto.picSelectPhoto.Height = height;
                        FrmPhoto.picSelectPhoto.Image = image2;
                        FrmPhoto.picSelectPhoto.Location = new Point((int)Math.Round(unchecked((double)checked(frmPhoto.frm.pnlPhoto.Width - frmPhoto.frm.picSelectPhoto.Width) / 2.0)), (int)Math.Round(unchecked((double)checked(frmPhoto.frm.pnlPhoto.Height - frmPhoto.frm.picSelectPhoto.Height) / 2.0)));
                        FrmPhoto.ShowDialog();
                        FrmPhoto.BringToFront();
                    }

                    LoadImage();
                }
            }
            this.Visible = true;
            WindowState = FormWindowState.Normal;

        }

        private void LoadImage()
        {
            Avatar.Image = modCommon.ImageFromFile(modCommon.CurrentDirectory + "/Data/Images/" + frmMain.CurrentSection + "_" + SectionName + ".png");
            if (Box != null)
            {
                Box.SetAvatar(Avatar.Image, true);
            }
        }

        private void FrmManager_Load(object sender, EventArgs e)
        {
            DeleteAvatar.Parent = Avatar;
        }

        private void DeleteAvatar_Click(object sender, EventArgs e)
        {
            Avatar.Image = modCommon.ImageFromFile(modCommon.CurrentDirectory + "/Data/Images/" + frmMain.CurrentSection + "_" + SectionName + ".png");

            if (Box != null)
            {
                if (File.Exists(modCommon.CurrentDirectory + "/Data/Images/" + frmMain.CurrentSection + "_" + Box.Name + ".png"))
                {
                    try { File.Delete(modCommon.CurrentDirectory + "/Data/Images/" + frmMain.CurrentSection + "_" + Box.Name + ".png"); } catch { }

                    Box.CustomAvatar = false;

                    if (Box.Status == ConnectionStatus.Online)
                    {
                        Avatar.Image = Resources.OnlinePC;
                        Box.SetAvatar(Resources.OnlinePC);
                    }
                    else
                    {
                        Avatar.Image = Resources.OfflinePC;
                        Box.SetAvatar(Resources.OfflinePC);
                    }

                }
            }

        }

        private void MAC_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void SearchPorts_Click(object sender, EventArgs e)
        {
            new frmPortScan(DeviceIp.Text).ShowDialog();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            if (Environment.UserName == "Hackerprod")
            {
                DeviceName.Text = "Hackerprod";
                DeviceIp.Text = "10.31.0.2";
                DeviceWeb.Checked = false;
            }
        }

        private void DeviceIp_TextChanged(object sender, EventArgs e)
        {
            if (modCommon.IsValidIp(DeviceIp.Text))
            {
                PanelDeviceIp.BackColor = DeviceIp.BackColor;
            }
            else
            {
                PanelDeviceIp.BackColor = Color.Red;
            }

            try
            {
                IPAddress address = IPAddress.Parse(DeviceIp.Text);
            }
            catch (Exception)
            {
                PanelDeviceIp.BackColor = Color.Red;
            }
        }

        private void Interval_TextChanged(object sender, EventArgs e)
        {
            string interval = Interval.Text;
            Interval.Text = string.Join("", interval.ToCharArray().Where(Char.IsDigit));
            if (Interval.Text == "0")
            {
                PanelInterval.BackColor = Color.Red;
            }
            else
            {
                PanelInterval.BackColor = Interval.BackColor;
            }
        }


        private void OpcionalLocation_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofdPhoto = new OpenFileDialog();
            ofdPhoto.FileName = string.Empty;
            ofdPhoto.Filter = "All Files|*.*";
            ofdPhoto.Title = "Select File";
            ofdPhoto.RestoreDirectory = true;
            DialogResult dialogResult = ofdPhoto.ShowDialog();
            this.Visible = false;
            WindowState = FormWindowState.Minimized;
            if (dialogResult == DialogResult.OK)
            {
                OpcionalLocation.Text = ofdPhoto.FileName;
            }
            this.Visible = true;
            WindowState = FormWindowState.Normal;
            Activate();
        }

        private void CircularAvatar_Click(object sender, EventArgs e)
        {
            Box.CircularAvatar = CircularAvatar.Checked;

            if (Box.CustomAvatar)
            {
                if (CircularAvatar.Checked)
                {
                    Avatar.Image = modCommon.CropToCircle(Box.BoxImage);
                }
                else
                    Avatar.Image = Box.BoxImage;
            }
        }
    }
}
