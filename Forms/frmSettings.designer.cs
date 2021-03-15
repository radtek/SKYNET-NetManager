
using SkynetManager.Properties;

namespace SkynetManager
{
    partial class frmSettings
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
            try
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            catch { }

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.panelClose = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.status = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyContainer = new System.Windows.Forms.Panel();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OpacityBar = new System.Windows.Forms.TrackBar();
            this.ShowInLeft = new FlatCheckBox();
            this.minimizeBox = new FlatCheckBox();
            this.AceptarBtn = new FlatButton();
            this.launchWindowsBox = new FlatCheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TimeOut = new FlatTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BufferSize = new FlatTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TTL = new FlatTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DefaultSound = new FlatCheckBox();
            this.CustomSound = new FlatCheckBox();
            this.CustomSoundPatch = new FlatTextBox();
            this.SearhSound = new FlatButton();
            this.ShowTopPanel = new FlatCheckBox();
            this.panelClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.KeyContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClose
            // 
            this.panelClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.panelClose.Controls.Add(this.closeBtn);
            this.panelClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelClose.Location = new System.Drawing.Point(302, 0);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(40, 26);
            this.panelClose.TabIndex = 5;
            this.panelClose.Click += new System.EventHandler(this.closeBtn_Click);
            this.panelClose.MouseLeave += new System.EventHandler(this.panelClose_MouseLeave);
            this.panelClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelClose_MouseMove);
            // 
            // closeBtn
            // 
            this.closeBtn.Image = global::SkynetManager.Properties.Resources.close11;
            this.closeBtn.Location = new System.Drawing.Point(14, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(13, 12);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseLeave += new System.EventHandler(this.panelClose_MouseLeave);
            this.closeBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelClose_MouseMove);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.status.Location = new System.Drawing.Point(14, 311);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 15);
            this.status.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(378, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(17, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 8.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 247;
            this.label1.Text = "Configuración";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(361, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 250;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 19);
            this.label2.TabIndex = 254;
            this.label2.Text = "Tecla para Mostrar/Ocultar el programa";
            // 
            // KeyContainer
            // 
            this.KeyContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.KeyContainer.Controls.Add(this.KeyLabel);
            this.KeyContainer.Location = new System.Drawing.Point(268, 151);
            this.KeyContainer.Name = "KeyContainer";
            this.KeyContainer.Size = new System.Drawing.Size(62, 34);
            this.KeyContainer.TabIndex = 255;
            this.KeyContainer.Click += new System.EventHandler(this.KeyClick);
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.KeyLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.KeyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.KeyLabel.Location = new System.Drawing.Point(18, 7);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(24, 19);
            this.KeyLabel.TabIndex = 256;
            this.KeyLabel.Text = "F8";
            this.KeyLabel.TextChanged += new System.EventHandler(this.KeyLabel_TextChanged);
            this.KeyLabel.Click += new System.EventHandler(this.KeyClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(13, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 258;
            this.label3.Text = "Opacidad";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // OpacityBar
            // 
            this.OpacityBar.Location = new System.Drawing.Point(12, 207);
            this.OpacityBar.Name = "OpacityBar";
            this.OpacityBar.Size = new System.Drawing.Size(318, 45);
            this.OpacityBar.TabIndex = 259;
            this.OpacityBar.Scroll += new System.EventHandler(this.OpacityBar_Scroll);
            // 
            // ShowInLeft
            // 
            this.ShowInLeft.BoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.ShowInLeft.BoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(164)))), ((int)(((byte)(245)))));
            this.ShowInLeft.Checked = false;
            this.ShowInLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowInLeft.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ShowInLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.ShowInLeft.Location = new System.Drawing.Point(12, 92);
            this.ShowInLeft.Name = "ShowInLeft";
            this.ShowInLeft.Options = FlatCheckBox._Options.Style1;
            this.ShowInLeft.Size = new System.Drawing.Size(229, 22);
            this.ShowInLeft.TabIndex = 256;
            this.ShowInLeft.Text = "Mostrar programa a la izquierda";
            this.ShowInLeft.Click += new System.EventHandler(this.ShowInLeft_Click);
            // 
            // minimizeBox
            // 
            this.minimizeBox.BoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.minimizeBox.BoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(164)))), ((int)(((byte)(245)))));
            this.minimizeBox.Checked = false;
            this.minimizeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.minimizeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.minimizeBox.Location = new System.Drawing.Point(12, 63);
            this.minimizeBox.Name = "minimizeBox";
            this.minimizeBox.Options = FlatCheckBox._Options.Style1;
            this.minimizeBox.Size = new System.Drawing.Size(148, 22);
            this.minimizeBox.TabIndex = 251;
            this.minimizeBox.Text = "Minimizar al cerrar";
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.AceptarBtn.BackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.AceptarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AceptarBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AceptarBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.AceptarBtn.ForeColorMouseOver = System.Drawing.Color.White;
            this.AceptarBtn.ImageAlignment = FlatButton._ImgAlign.Left;
            this.AceptarBtn.ImageIcon = null;
            this.AceptarBtn.Location = new System.Drawing.Point(229, 466);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Rounded = false;
            this.AceptarBtn.Size = new System.Drawing.Size(100, 32);
            this.AceptarBtn.Style = FlatButton._Style.TextOnly;
            this.AceptarBtn.TabIndex = 249;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            this.AceptarBtn.MouseLeave += new System.EventHandler(this.AceptarBtn_MouseLeave);
            this.AceptarBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AceptarBtn_MouseMove);
            // 
            // launchWindowsBox
            // 
            this.launchWindowsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.launchWindowsBox.BoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.launchWindowsBox.BoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(164)))), ((int)(((byte)(245)))));
            this.launchWindowsBox.Checked = false;
            this.launchWindowsBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.launchWindowsBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.launchWindowsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.launchWindowsBox.Location = new System.Drawing.Point(12, 35);
            this.launchWindowsBox.Name = "launchWindowsBox";
            this.launchWindowsBox.Options = FlatCheckBox._Options.Style1;
            this.launchWindowsBox.Size = new System.Drawing.Size(148, 22);
            this.launchWindowsBox.TabIndex = 248;
            this.launchWindowsBox.Text = "Iniciar con Windows";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panelClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 26);
            this.panel1.TabIndex = 260;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(7, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 17);
            this.label4.TabIndex = 261;
            this.label4.Text = "Opciones del monitoreo";
            // 
            // TimeOut
            // 
            this.TimeOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.TimeOut.BackColorControl = System.Drawing.Color.Empty;
            this.TimeOut.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TimeOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.TimeOut.isCustomColor = false;
            this.TimeOut.Location = new System.Drawing.Point(10, 305);
            this.TimeOut.MaxLength = 32767;
            this.TimeOut.Multiline = false;
            this.TimeOut.Name = "TimeOut";
            this.TimeOut.OnlyNumber = false;
            this.TimeOut.ReadOnly = false;
            this.TimeOut.Size = new System.Drawing.Size(113, 28);
            this.TimeOut.TabIndex = 262;
            this.TimeOut.Text = "2000";
            this.TimeOut.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TimeOut.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(6, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 263;
            this.label5.Text = "Tiempo de espera";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(144, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 19);
            this.label6.TabIndex = 265;
            this.label6.Text = "Tamaño del Buffer";
            // 
            // BufferSize
            // 
            this.BufferSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.BufferSize.BackColorControl = System.Drawing.Color.Empty;
            this.BufferSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BufferSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.BufferSize.isCustomColor = false;
            this.BufferSize.Location = new System.Drawing.Point(148, 305);
            this.BufferSize.MaxLength = 32767;
            this.BufferSize.Multiline = false;
            this.BufferSize.Name = "BufferSize";
            this.BufferSize.OnlyNumber = false;
            this.BufferSize.ReadOnly = false;
            this.BufferSize.Size = new System.Drawing.Size(113, 28);
            this.BufferSize.TabIndex = 264;
            this.BufferSize.Text = "32";
            this.BufferSize.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.BufferSize.UseSystemPasswordChar = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(282, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 19);
            this.label8.TabIndex = 267;
            this.label8.Text = "TTL";
            // 
            // TTL
            // 
            this.TTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.TTL.BackColorControl = System.Drawing.Color.Empty;
            this.TTL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TTL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.TTL.isCustomColor = false;
            this.TTL.Location = new System.Drawing.Point(286, 305);
            this.TTL.MaxLength = 32767;
            this.TTL.Multiline = false;
            this.TTL.Name = "TTL";
            this.TTL.OnlyNumber = false;
            this.TTL.ReadOnly = false;
            this.TTL.Size = new System.Drawing.Size(44, 28);
            this.TTL.TabIndex = 266;
            this.TTL.Text = "32";
            this.TTL.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TTL.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.label7.Location = new System.Drawing.Point(9, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 268;
            this.label7.Text = "Sonido de Alertas";
            // 
            // DefaultSound
            // 
            this.DefaultSound.BoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.DefaultSound.BoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(164)))), ((int)(((byte)(245)))));
            this.DefaultSound.Checked = true;
            this.DefaultSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DefaultSound.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DefaultSound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.DefaultSound.Location = new System.Drawing.Point(12, 376);
            this.DefaultSound.Name = "DefaultSound";
            this.DefaultSound.Options = FlatCheckBox._Options.Style1;
            this.DefaultSound.Size = new System.Drawing.Size(260, 22);
            this.DefaultSound.TabIndex = 269;
            this.DefaultSound.Text = "Usar el sonido de alerta del programa";
            this.DefaultSound.Click += new System.EventHandler(this.DefaultSound_Click);
            // 
            // CustomSound
            // 
            this.CustomSound.BoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.CustomSound.BoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(164)))), ((int)(((byte)(245)))));
            this.CustomSound.Checked = false;
            this.CustomSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomSound.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CustomSound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.CustomSound.Location = new System.Drawing.Point(12, 404);
            this.CustomSound.Name = "CustomSound";
            this.CustomSound.Options = FlatCheckBox._Options.Style1;
            this.CustomSound.Size = new System.Drawing.Size(260, 22);
            this.CustomSound.TabIndex = 270;
            this.CustomSound.Text = "Usar sonido elegido por mi";
            this.CustomSound.Click += new System.EventHandler(this.CustomSound_Click);
            // 
            // CustomSoundPatch
            // 
            this.CustomSoundPatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.CustomSoundPatch.BackColorControl = System.Drawing.Color.Empty;
            this.CustomSoundPatch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CustomSoundPatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.CustomSoundPatch.isCustomColor = false;
            this.CustomSoundPatch.Location = new System.Drawing.Point(13, 432);
            this.CustomSoundPatch.MaxLength = 32767;
            this.CustomSoundPatch.Multiline = false;
            this.CustomSoundPatch.Name = "CustomSoundPatch";
            this.CustomSoundPatch.OnlyNumber = false;
            this.CustomSoundPatch.ReadOnly = false;
            this.CustomSoundPatch.Size = new System.Drawing.Size(210, 28);
            this.CustomSoundPatch.TabIndex = 271;
            this.CustomSoundPatch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.CustomSoundPatch.UseSystemPasswordChar = false;
            // 
            // SearhSound
            // 
            this.SearhSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.SearhSound.BackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.SearhSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearhSound.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearhSound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.SearhSound.ForeColorMouseOver = System.Drawing.Color.White;
            this.SearhSound.ImageAlignment = FlatButton._ImgAlign.Left;
            this.SearhSound.ImageIcon = null;
            this.SearhSound.Location = new System.Drawing.Point(229, 432);
            this.SearhSound.Name = "SearhSound";
            this.SearhSound.Rounded = false;
            this.SearhSound.Size = new System.Drawing.Size(100, 28);
            this.SearhSound.Style = FlatButton._Style.TextOnly;
            this.SearhSound.TabIndex = 272;
            this.SearhSound.Text = "Buscar Sonido";
            this.SearhSound.Click += new System.EventHandler(this.SearhSound_Click);
            // 
            // ShowTopPanel
            // 
            this.ShowTopPanel.BoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.ShowTopPanel.BoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(164)))), ((int)(((byte)(245)))));
            this.ShowTopPanel.Checked = false;
            this.ShowTopPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowTopPanel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ShowTopPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.ShowTopPanel.Location = new System.Drawing.Point(12, 120);
            this.ShowTopPanel.Name = "ShowTopPanel";
            this.ShowTopPanel.Options = FlatCheckBox._Options.Style1;
            this.ShowTopPanel.Size = new System.Drawing.Size(229, 22);
            this.ShowTopPanel.TabIndex = 273;
            this.ShowTopPanel.Text = "Mostrar barra superior e inferior";
            this.ShowTopPanel.Click += new System.EventHandler(this.ShowTopPanel_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(342, 511);
            this.Controls.Add(this.ShowTopPanel);
            this.Controls.Add(this.SearhSound);
            this.Controls.Add(this.CustomSoundPatch);
            this.Controls.Add(this.CustomSound);
            this.Controls.Add(this.DefaultSound);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TTL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BufferSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TimeOut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OpacityBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShowInLeft);
            this.Controls.Add(this.KeyContainer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minimizeBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.launchWindowsBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.status);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkyNet Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            this.panelClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.KeyContainer.ResumeLayout(false);
            this.KeyContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private FlatCheckBox launchWindowsBox;
        private FlatButton AceptarBtn;
        private System.Windows.Forms.Button button1;
        private FlatCheckBox minimizeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel KeyContainer;
        private System.Windows.Forms.Label KeyLabel;
        private FlatCheckBox ShowInLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar OpacityBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private FlatTextBox TimeOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private FlatTextBox BufferSize;
        private System.Windows.Forms.Label label8;
        private FlatTextBox TTL;
        private System.Windows.Forms.Label label7;
        private FlatCheckBox DefaultSound;
        private FlatCheckBox CustomSound;
        private FlatTextBox CustomSoundPatch;
        private FlatButton SearhSound;
        private FlatCheckBox ShowTopPanel;
    }
}