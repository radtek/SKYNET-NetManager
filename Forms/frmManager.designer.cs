using SkynetManager.Properties;

namespace SkynetManager
{
    partial class frmManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Container = new System.Windows.Forms.Panel();
            this.PanelInterval = new System.Windows.Forms.Panel();
            this.PanelDeviceIp = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteAvatar = new System.Windows.Forms.PictureBox();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.CircularAvatar = new FlatCheckBox();
            this.Interval = new FlatTextBox();
            this.DeviceIp = new FlatTextBox();
            this.Save = new FlatButton();
            this.OpcionalLocation = new FlatTextBox();
            this.SearchPorts = new FlatButton();
            this.DeviceName = new FlatTextBox();
            this.MAC = new FlatTextBox();
            this.Port = new FlatTextBox();
            this.DeviceWeb = new FlatCheckBox();
            this.panel1.SuspendLayout();
            this.panelClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.Container.SuspendLayout();
            this.PanelInterval.SuspendLayout();
            this.PanelDeviceIp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.panelClose);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 26);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Event_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Event_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Event_MouseUp);
            // 
            // panelClose
            // 
            this.panelClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.panelClose.Controls.Add(this.closeBtn);
            this.panelClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelClose.Location = new System.Drawing.Point(434, 0);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(36, 26);
            this.panelClose.TabIndex = 9;
            this.panelClose.Click += new System.EventHandler(this.cancelBtn_Click);
            this.panelClose.MouseLeave += new System.EventHandler(this.panelClose_MouseLeave);
            this.panelClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelClose_MouseMove);
            // 
            // closeBtn
            // 
            this.closeBtn.Image = global::SkynetManager.Properties.Resources.close11;
            this.closeBtn.Location = new System.Drawing.Point(13, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(13, 12);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            this.closeBtn.MouseLeave += new System.EventHandler(this.panelClose_MouseLeave);
            this.closeBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelClose_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Editar datos del dispositivo";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Event_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Event_MouseMove);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Event_MouseUp);
            // 
            // acceptBtn
            // 
            this.acceptBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptBtn.Location = new System.Drawing.Point(485, 375);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(75, 23);
            this.acceptBtn.TabIndex = 16;
            this.acceptBtn.Text = "button1";
            this.acceptBtn.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(181, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Nombre del equipo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(181, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Número IP";
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.Container.Controls.Add(this.CircularAvatar);
            this.Container.Controls.Add(this.PanelInterval);
            this.Container.Controls.Add(this.PanelDeviceIp);
            this.Container.Controls.Add(this.Save);
            this.Container.Controls.Add(this.OpcionalLocation);
            this.Container.Controls.Add(this.label4);
            this.Container.Controls.Add(this.label2);
            this.Container.Controls.Add(this.SearchPorts);
            this.Container.Controls.Add(this.DeviceName);
            this.Container.Controls.Add(this.MAC);
            this.Container.Controls.Add(this.label1);
            this.Container.Controls.Add(this.Port);
            this.Container.Controls.Add(this.DeleteAvatar);
            this.Container.Controls.Add(this.DeviceWeb);
            this.Container.Controls.Add(this.Avatar);
            this.Container.Controls.Add(this.label8);
            this.Container.Controls.Add(this.label10);
            this.Container.Dock = System.Windows.Forms.DockStyle.Top;
            this.Container.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.Container.Location = new System.Drawing.Point(0, 26);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(470, 296);
            this.Container.TabIndex = 8;
            // 
            // PanelInterval
            // 
            this.PanelInterval.Controls.Add(this.Interval);
            this.PanelInterval.Location = new System.Drawing.Point(297, 128);
            this.PanelInterval.Name = "PanelInterval";
            this.PanelInterval.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.PanelInterval.Size = new System.Drawing.Size(153, 27);
            this.PanelInterval.TabIndex = 265;
            // 
            // PanelDeviceIp
            // 
            this.PanelDeviceIp.Controls.Add(this.DeviceIp);
            this.PanelDeviceIp.Location = new System.Drawing.Point(297, 53);
            this.PanelDeviceIp.Name = "PanelDeviceIp";
            this.PanelDeviceIp.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.PanelDeviceIp.Size = new System.Drawing.Size(153, 27);
            this.PanelDeviceIp.TabIndex = 264;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(181, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 262;
            this.label4.Text = "Ejecutar archivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(181, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 260;
            this.label2.Text = "Intervalo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(181, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 256;
            this.label1.Text = "Dirección fisica";
            // 
            // DeleteAvatar
            // 
            this.DeleteAvatar.BackColor = System.Drawing.Color.Transparent;
            this.DeleteAvatar.Image = global::SkynetManager.Properties.Resources._1__154_;
            this.DeleteAvatar.Location = new System.Drawing.Point(105, 105);
            this.DeleteAvatar.Name = "DeleteAvatar";
            this.DeleteAvatar.Size = new System.Drawing.Size(26, 28);
            this.DeleteAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeleteAvatar.TabIndex = 253;
            this.DeleteAvatar.TabStop = false;
            this.DeleteAvatar.Click += new System.EventHandler(this.DeleteAvatar_Click);
            // 
            // Avatar
            // 
            this.Avatar.Image = global::SkynetManager.Properties.Resources.NeutralPC;
            this.Avatar.Location = new System.Drawing.Point(29, 14);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(133, 133);
            this.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avatar.TabIndex = 29;
            this.Avatar.TabStop = false;
            this.Avatar.Click += new System.EventHandler(this.Avatar_Click);
            // 
            // Browser
            // 
            this.Browser.Location = new System.Drawing.Point(0, 348);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(31, 41);
            this.Browser.TabIndex = 19;
            // 
            // CircularAvatar
            // 
            this.CircularAvatar.BoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.CircularAvatar.BoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(164)))), ((int)(((byte)(245)))));
            this.CircularAvatar.Checked = false;
            this.CircularAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CircularAvatar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CircularAvatar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CircularAvatar.Location = new System.Drawing.Point(12, 166);
            this.CircularAvatar.Name = "CircularAvatar";
            this.CircularAvatar.Options = FlatCheckBox._Options.Style1;
            this.CircularAvatar.Size = new System.Drawing.Size(150, 22);
            this.CircularAvatar.TabIndex = 266;
            this.CircularAvatar.Text = "Redondear el avatar";
            this.CircularAvatar.Click += new System.EventHandler(this.CircularAvatar_Click);
            // 
            // Interval
            // 
            this.Interval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.Interval.BackColorControl = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.Interval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Interval.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Interval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.Interval.isCustomColor = false;
            this.Interval.Location = new System.Drawing.Point(0, 0);
            this.Interval.MaxLength = 32767;
            this.Interval.Multiline = false;
            this.Interval.Name = "Interval";
            this.Interval.OnlyNumber = false;
            this.Interval.ReadOnly = false;
            this.Interval.Size = new System.Drawing.Size(153, 26);
            this.Interval.TabIndex = 261;
            this.Interval.Text = "1";
            this.Interval.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.Interval.UseSystemPasswordChar = false;
            this.Interval.TextChanged += new System.EventHandler(this.Interval_TextChanged);
            // 
            // DeviceIp
            // 
            this.DeviceIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.DeviceIp.BackColorControl = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.DeviceIp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeviceIp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeviceIp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.DeviceIp.isCustomColor = false;
            this.DeviceIp.Location = new System.Drawing.Point(0, 0);
            this.DeviceIp.MaxLength = 32767;
            this.DeviceIp.Multiline = false;
            this.DeviceIp.Name = "DeviceIp";
            this.DeviceIp.OnlyNumber = false;
            this.DeviceIp.ReadOnly = false;
            this.DeviceIp.Size = new System.Drawing.Size(153, 26);
            this.DeviceIp.TabIndex = 259;
            this.DeviceIp.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.DeviceIp.UseSystemPasswordChar = false;
            this.DeviceIp.TextChanged += new System.EventHandler(this.DeviceIp_TextChanged);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.Save.BackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Save.ForeColorMouseOver = System.Drawing.Color.Empty;
            this.Save.ImageAlignment = FlatButton._ImgAlign.Left;
            this.Save.ImageIcon = null;
            this.Save.Location = new System.Drawing.Point(338, 256);
            this.Save.Name = "Save";
            this.Save.Rounded = false;
            this.Save.Size = new System.Drawing.Size(112, 29);
            this.Save.Style = FlatButton._Style.TextOnly;
            this.Save.TabIndex = 21;
            this.Save.Text = "Guardar";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // OpcionalLocation
            // 
            this.OpcionalLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.OpcionalLocation.BackColorControl = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.OpcionalLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OpcionalLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.OpcionalLocation.isCustomColor = false;
            this.OpcionalLocation.Location = new System.Drawing.Point(297, 166);
            this.OpcionalLocation.MaxLength = 32767;
            this.OpcionalLocation.Multiline = false;
            this.OpcionalLocation.Name = "OpcionalLocation";
            this.OpcionalLocation.OnlyNumber = false;
            this.OpcionalLocation.ReadOnly = false;
            this.OpcionalLocation.Size = new System.Drawing.Size(153, 26);
            this.OpcionalLocation.TabIndex = 263;
            this.OpcionalLocation.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.OpcionalLocation.UseSystemPasswordChar = false;
            this.OpcionalLocation.DoubleClick += new System.EventHandler(this.OpcionalLocation_DoubleClick);
            // 
            // SearchPorts
            // 
            this.SearchPorts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.SearchPorts.BackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.SearchPorts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchPorts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchPorts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SearchPorts.ForeColorMouseOver = System.Drawing.Color.Empty;
            this.SearchPorts.ImageAlignment = FlatButton._ImgAlign.Left;
            this.SearchPorts.ImageIcon = null;
            this.SearchPorts.Location = new System.Drawing.Point(12, 256);
            this.SearchPorts.Name = "SearchPorts";
            this.SearchPorts.Rounded = false;
            this.SearchPorts.Size = new System.Drawing.Size(148, 29);
            this.SearchPorts.Style = FlatButton._Style.TextOnly;
            this.SearchPorts.TabIndex = 254;
            this.SearchPorts.Text = "Buscar Puertos";
            this.SearchPorts.Click += new System.EventHandler(this.SearchPorts_Click);
            // 
            // DeviceName
            // 
            this.DeviceName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.DeviceName.BackColorControl = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.DeviceName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeviceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.DeviceName.isCustomColor = false;
            this.DeviceName.Location = new System.Drawing.Point(297, 15);
            this.DeviceName.MaxLength = 32767;
            this.DeviceName.Multiline = false;
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.OnlyNumber = false;
            this.DeviceName.ReadOnly = false;
            this.DeviceName.Size = new System.Drawing.Size(153, 26);
            this.DeviceName.TabIndex = 258;
            this.DeviceName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.DeviceName.UseSystemPasswordChar = false;
            // 
            // MAC
            // 
            this.MAC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.MAC.BackColorControl = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.MAC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MAC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.MAC.isCustomColor = false;
            this.MAC.Location = new System.Drawing.Point(297, 91);
            this.MAC.MaxLength = 32767;
            this.MAC.Multiline = false;
            this.MAC.Name = "MAC";
            this.MAC.OnlyNumber = false;
            this.MAC.ReadOnly = false;
            this.MAC.Size = new System.Drawing.Size(153, 26);
            this.MAC.TabIndex = 257;
            this.MAC.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.MAC.UseSystemPasswordChar = false;
            this.MAC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MAC_KeyDown);
            // 
            // Port
            // 
            this.Port.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.Port.BackColorControl = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.Port.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Port.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.Port.isCustomColor = false;
            this.Port.Location = new System.Drawing.Point(12, 222);
            this.Port.MaxLength = 32767;
            this.Port.Multiline = false;
            this.Port.Name = "Port";
            this.Port.OnlyNumber = false;
            this.Port.ReadOnly = false;
            this.Port.Size = new System.Drawing.Size(148, 26);
            this.Port.TabIndex = 24;
            this.Port.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.Port.UseSystemPasswordChar = false;
            this.Port.Visible = false;
            // 
            // DeviceWeb
            // 
            this.DeviceWeb.BoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.DeviceWeb.BoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(164)))), ((int)(((byte)(245)))));
            this.DeviceWeb.Checked = false;
            this.DeviceWeb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeviceWeb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DeviceWeb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DeviceWeb.Location = new System.Drawing.Point(12, 194);
            this.DeviceWeb.Name = "DeviceWeb";
            this.DeviceWeb.Options = FlatCheckBox._Options.Style1;
            this.DeviceWeb.Size = new System.Drawing.Size(148, 22);
            this.DeviceWeb.TabIndex = 252;
            this.DeviceWeb.Text = "Ping a la interfax web";
            this.DeviceWeb.Click += new System.EventHandler(this.DeviceWeb_Click);
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(470, 334);
            this.Controls.Add(this.Browser);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkyNet Manager";
            this.Load += new System.EventHandler(this.FrmManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.Container.ResumeLayout(false);
            this.Container.PerformLayout();
            this.PanelInterval.ResumeLayout(false);
            this.PanelDeviceIp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DeleteAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.WebBrowser Browser;
        private FlatButton Save;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private new System.Windows.Forms.Panel Container;
        private System.Windows.Forms.PictureBox Avatar;
        private FlatCheckBox DeviceWeb;
        private System.Windows.Forms.PictureBox DeleteAvatar;
        public FlatTextBox Port;
        private FlatTextBox MAC;
        private System.Windows.Forms.Label label1;
        private FlatTextBox DeviceName;
        private FlatTextBox DeviceIp;
        private FlatButton SearchPorts;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.PictureBox closeBtn;
        private FlatTextBox Interval;
        private System.Windows.Forms.Label label2;
        private FlatTextBox OpcionalLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PanelDeviceIp;
        private System.Windows.Forms.Panel PanelInterval;
        private FlatCheckBox CircularAvatar;
    }
}