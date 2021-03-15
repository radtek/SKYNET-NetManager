using SkynetManager.Properties;

namespace SkynetManager
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.acceptBtn = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.SettingsTittle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewUser = new System.Windows.Forms.PictureBox();
            this.Profile = new System.Windows.Forms.PictureBox();
            this.Settings = new System.Windows.Forms.PictureBox();
            this.RepeatPing = new System.Windows.Forms.PictureBox();
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.MenuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatPing)).BeginInit();
            this.SuspendLayout();
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
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.MenuPanel.Controls.Add(this.SettingsTittle);
            this.MenuPanel.Location = new System.Drawing.Point(157, 82);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(70, 19);
            this.MenuPanel.TabIndex = 34;
            // 
            // SettingsTittle
            // 
            this.SettingsTittle.AutoSize = true;
            this.SettingsTittle.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
            this.SettingsTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.SettingsTittle.Location = new System.Drawing.Point(11, 1);
            this.SettingsTittle.Name = "SettingsTittle";
            this.SettingsTittle.Size = new System.Drawing.Size(49, 15);
            this.SettingsTittle.TabIndex = 0;
            this.SettingsTittle.Text = "Settings";
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.NewUser);
            this.panel1.Controls.Add(this.MenuPanel);
            this.panel1.Controls.Add(this.Profile);
            this.panel1.Controls.Add(this.Settings);
            this.panel1.Controls.Add(this.RepeatPing);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 104);
            this.panel1.TabIndex = 35;
            // 
            // NewUser
            // 
            this.NewUser.Image = global::SkynetManager.Properties.Resources.spareroom;
            this.NewUser.Location = new System.Drawing.Point(5, 6);
            this.NewUser.Name = "NewUser";
            this.NewUser.Size = new System.Drawing.Size(70, 70);
            this.NewUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NewUser.TabIndex = 30;
            this.NewUser.TabStop = false;
            this.NewUser.Click += new System.EventHandler(this.NewUser_Click);
            this.NewUser.MouseLeave += new System.EventHandler(this.Avatar_MouseLeave);
            this.NewUser.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Avatar_MouseMove);
            // 
            // Profile
            // 
            this.Profile.Image = global::SkynetManager.Properties.Resources.pingtools;
            this.Profile.Location = new System.Drawing.Point(81, 6);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(70, 70);
            this.Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Profile.TabIndex = 31;
            this.Profile.TabStop = false;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            this.Profile.MouseLeave += new System.EventHandler(this.Avatar_MouseLeave);
            this.Profile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Avatar_MouseMove);
            // 
            // Settings
            // 
            this.Settings.Image = global::SkynetManager.Properties.Resources.xfinity_my_account;
            this.Settings.Location = new System.Drawing.Point(233, 6);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(70, 70);
            this.Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Settings.TabIndex = 33;
            this.Settings.TabStop = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            this.Settings.MouseLeave += new System.EventHandler(this.Avatar_MouseLeave);
            this.Settings.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Avatar_MouseMove);
            // 
            // RepeatPing
            // 
            this.RepeatPing.Image = global::SkynetManager.Properties.Resources.SearchPing;
            this.RepeatPing.Location = new System.Drawing.Point(157, 6);
            this.RepeatPing.Name = "RepeatPing";
            this.RepeatPing.Size = new System.Drawing.Size(70, 70);
            this.RepeatPing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RepeatPing.TabIndex = 32;
            this.RepeatPing.TabStop = false;
            this.RepeatPing.Click += new System.EventHandler(this.RepeatPing_Click);
            this.RepeatPing.MouseLeave += new System.EventHandler(this.Avatar_MouseLeave);
            this.RepeatPing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Avatar_MouseMove);
            // 
            // Browser
            // 
            this.Browser.Location = new System.Drawing.Point(0, 325);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(31, 41);
            this.Browser.TabIndex = 19;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(157)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(309, 106);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Browser);
            this.Controls.Add(this.acceptBtn);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMenu";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkyNet Manager";
            this.Deactivate += new System.EventHandler(this.FrmMenu_Deactivate);
            this.MouseLeave += new System.EventHandler(this.FrmMenu_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMenu_MouseMove);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatPing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.WebBrowser Browser;
        private System.Windows.Forms.PictureBox NewUser;
        private System.Windows.Forms.PictureBox Profile;
        private System.Windows.Forms.PictureBox RepeatPing;
        private System.Windows.Forms.PictureBox Settings;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label SettingsTittle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
    }
}