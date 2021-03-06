using NetUtils;
using SkynetManager.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace SkynetManager
{
    public partial class frmDeviceInfo : Form
    {
        private bool mouseDown;     //Mover ventana
        private Point lastLocation; //Mover ventana
        readonly DeviceBox device;
        Image BoxImage;

        private bool CustomAvatar { get; set; }

        private readonly AsyncHostNameResolver _nameResolver = new AsyncHostNameResolver();


        public frmDeviceInfo(DeviceBox tool = null)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;  //Para permitir acceso a los subprocesos
            StatusLabel.Text = "";

            if (tool != null)
            {
                device = tool;

                for (int i = 1; i < device.Values.Count; i++)
                {
                    AddBarGraphic(device.Values[i]);
                }

                CustomAvatar = device.CustomAvatar;

                if (CustomAvatar)
                {
                    BoxImage = DeviceManager.GetDeviceImage(device);
                    
                    if (device.CircularAvatar)
                    {
                        Avatar.Image = modCommon.CropToCircle(BoxImage);
                    }
                    else
                        Avatar.Image = BoxImage;
                }
                else
                {
                    Avatar.Image = device.Avatar.Image;
                }

                if (device.isWeb && string.IsNullOrEmpty(device.Port)) device.Port = "80";

                DeviceName.Text = device.BoxName;

                if (device.isWeb)
                {
                    DeviceIp.Text = device.IpName + ":" + device.Port;
                }
                else
                { 
                    DeviceIp.Text = device.IpName;
                }
                MAC.Text = device.MAC;

                D_Status.Image = GetImageFromStatus(device.Status);

                StatusDevice.Text = device.Status.ToString();
                CenterDeviceInfo();

                device = tool;

                _nameResolver.ResolveHostName(IPAddress.Parse(device.IpName), StoreHostName);

            }
            else
            {
                Close();
            }
            D_Status.Parent = Avatar;



        }
        private ConnectionStatus _Status
        {
            get { return _Status; }
            set
            {
                label23.Text = "Duración del estado actual (            )";

                if (value == ConnectionStatus.Online)
                {
                    StatusICON.Image = Resources.D_Online;
                    StatusLabel.Text = "Online";
                }
                else
                {
                    StatusICON.Image = Resources.D_Offline;
                    StatusLabel.Text = "Offline";
                }
            }
        }
        public float HostAvailability
        {
            get
            {
                long num = device.StartTime.Ticks;
                long num2 = device._statusDurations[1].Ticks;

                DateTime now = DateTime.Now;
                num += now.Subtract(device.StartTime).Ticks;
                if (device.Status == ConnectionStatus.Online)
                {
                    num2 += (now - device._statusReachedAt).Ticks;
                }

                return (float)((double)num2 / (double)num * 100.0);
            }
        }
        private Image GetImageFromStatus(ConnectionStatus status)
        {
            if (status == ConnectionStatus.Online)
                return Resources.D_Online;

            else
                return Resources.D_Offline;
        }

        public void StoreHostName(string name)
        {
            if (name.Length > 12)
            {
                HostDescription.Font = new System.Drawing.Font("Segoe UI Emoji", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            HostDescription.Text = name;
        }

        private void CenterDeviceInfo()
        {
            foreach (Control control in DeviceInfo.Controls)
            {
                if (control is Label)
                {
                    //Width
                    int W_Pantalla = DeviceInfo.Width / 2; //680
                    int AnchoTexto = Convert.ToInt32(modCommon.GetTextSize(control.Text, control.Font).Width) / 2;
                    int WidthText = W_Pantalla - AnchoTexto;

                    //Heigth
                    int HeigthText = Height - 300;

                    control.Location = new Point(WidthText, control.Location.Y);
                }
            }
        }

        private void Event_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point((Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
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

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PanelClose_MouseMove(object sender, MouseEventArgs e)
        {
            panelClose.BackColor = Color.FromArgb(53, 64, 78);
        }

        private void PanelClose_MouseLeave(object sender, EventArgs e)
        {
            panelClose.BackColor = Color.FromArgb(43, 54, 68);
        }
        int PingCount = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (device.SentPackets == 0)
                    return;

                _Status = device.Status;

                CustomAvatar = device.CustomAvatar;

                if (!CustomAvatar)
                { 
                    Avatar.Image = device.Avatar.Image;
                }


                // Graphic ///////////////////////////////////////
                if (PingCount != device.SentPackets)
                {
                    
                    int GraphicTime = (int)device.CurrentResponseTime;
                    AddBarGraphic(GraphicTime);

                    PingCount = device.SentPackets;
                }

                //////////////////////////////////////////////////


                DeviceName.Text = device.BoxName;

                if (device.isWeb)
                {
                    DeviceIp.Text = device.IpName + ":" + device.Port;
                }
                else
                {
                    DeviceIp.Text = device.IpName;
                }
                HostName.Text = device.IpName;
                MAC.Text = device.MAC;

                StatusDevice.Text = device.Status.ToString();
                D_Status.Image = GetImageFromStatus(device.Status);

                if (string.IsNullOrEmpty(HostDescription.Text) || HostDescription.Text == "Loading info...")
                {
                    HostDescription.Text = device.BoxName;
                }
                if (device.BoxName.Length > 12)
                {
                    HostDescription.Font = new System.Drawing.Font("Segoe UI Emoji", 7.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }

                Status.Text = device.Status.ToString();
                SentPackets.Text = device.SentPackets.ToString();
                ReceivedPackets.Text = device.ReceivedPackets.ToString();
                ReceivedPacketsPercent.Text = PercentToString(GetPacketsPercent(device.ReceivedPackets, device.SentPackets));
                LostPackets.Text = device.LostPackets.ToString();
                LostPacketsPercent.Text = PercentToString(GetPacketsPercent(device.LostPackets, device.SentPackets));

                if (device.LastPacketLost)
                    LastPacketLost.Text = "Si";
                else
                    LastPacketLost.Text = "No";

                ConsecutivePacketsLost.Text = device.ConsecutivePacketsLost.ToString();
                CurrentResponseTime.Text = device.CurrentResponseTime + " ms";
                AverageResponseTime.Text = ToString(GetAverageResponseTime(device.ReceivedPackets, device.TotalResponseTime)) + " ms";

                if (device.MinResponseTime == 9223372036854775807L)
                    MinResponseTime.Text = "1000" + " ms";
                else
                    MinResponseTime.Text = device.MinResponseTime + " ms";

                MaxResponseTime.Text = device.MaxResponseTime + " ms";
                CurrentStatusDuration.Text = DurationToString(DateTime.Now.Subtract(device._statusReachedAt));

                GetAliveDuration.Text = device.OnlineStatusDuration;
                GetDeadDuration.Text = device.OfflineStatusDuration;
                TotalTime.Text = GetTotalTime(device.StartTime);
                //HostAvailability.Text = Box.HostAvailability;
            }
            catch { }
        }

        private void AddBarGraphic(int GraphicTime)
        {
            if (device.Status == ConnectionStatus.Offline)
                GraphicTime = 200;
            
            deviceHistory1.Add(GraphicTime);
        }

        private string ToString(float v)
        {
            string Float = v.ToString();
            string[] parts = Float.Split(',');
            if (parts.Length == 2)
            {
                Float = parts[0] + ",";
                for (int i = 0; i < parts[1].Length; i++)
                {
                    Float += parts[1][i];
                    if (i == 2)
                        break;
                }
            }

            return Float;
        }

        private string GetTotalTime(DateTime startTime)
        {
            TimeSpan duration = DateTime.Now - startTime;
            StringBuilder stringBuilder = new StringBuilder();
            if (duration.Days > 0)
            {
                stringBuilder.Append(duration.Days);
                stringBuilder.Append((duration.Days > 1) ? " days " : " day ");
            }
            stringBuilder.AppendFormat("{0:d2} : {1:d2} : {2:d2}", duration.Hours, duration.Minutes, duration.Seconds);
            return stringBuilder.ToString();
        }

        private string DurationToString(TimeSpan duration)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (duration.Days > 0)
            {
                stringBuilder.Append(duration.Days);
                stringBuilder.Append((duration.Days > 1) ? " days " : " day ");
            }
            stringBuilder.AppendFormat("{0:d2} : {1:d2} : {2:d2}", duration.Hours, duration.Minutes, duration.Seconds);
            return stringBuilder.ToString();
        }
        public TimeSpan GetStatusDuration(ConnectionStatus status, DeviceBox Box)
        {
            TimeSpan timeSpan = Box._statusDurations[(int)Box.Status];
            if (Box.Status == status)
            {
                timeSpan += DateTime.Now - Box._statusReachedAt;
            }
            return timeSpan;
        }
        private string PercentToString(float percent)
        {
            return $"{percent / 100f:P}";
        }
        public float GetAverageResponseTime(long receivedPackets, long totalResponseTime)
        {
            return (receivedPackets != 0) ? ((float)totalResponseTime / (float)receivedPackets) : 0f;
        }
        public float GetPacketsPercent(long LostPackets, long SentPackets)
        {
            return (float)LostPackets / (float)SentPackets * 100f;
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void DeviceName_Click(object sender, EventArgs e)
        {

        }
    }
}
