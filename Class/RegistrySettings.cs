using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkynetManager
{
    public class RegistrySettings
    {
        public RegistryKey Sping { get; private set; }
        public object WriteLog { get; private set; }
        string SubKey = @"SOFTWARE\[SKYNET] NetManager\";
        public RegistrySettings()
        {
            Sping = Registry.CurrentUser.OpenSubKey(SubKey, true);
            if (Sping == null)
            {
                Registry.CurrentUser.CreateSubKey(SubKey);
                frmMain.MinimizeWhenClose = false;
                frmMain.LaunchWindowsStart = false;
                frmMain.FirstLaunch = true;
                frmMain.CurrentSection = "Device";
                frmMain.Key = "F8";
                frmMain.ShowInLeft = false;
                frmMain.OpacityForm = 100;
                frmMain.Timeout = 2000;
                frmMain.BufferSize = 32;
                frmMain.TTL = 32;
                frmMain.CustomSound = false;
                frmMain.CustomSoundPatch = "";
                frmMain.ShowTopPanel = true;

            }
        }
        public void GuardarSettings()
        {
            Sping = Registry.CurrentUser.OpenSubKey(SubKey, true);

            try { Sping.SetValue("MinimizeWhenClose", frmMain.MinimizeWhenClose.ToString()); } catch (Exception ex) { MessageBox.Show(ex.Message); }
            try { Sping.SetValue("LaunchWindowsStart", frmMain.LaunchWindowsStart.ToString()); } catch (Exception ex) { MessageBox.Show(ex.Message); }
            try { Sping.SetValue("CurrentSection", frmMain.CurrentSection.ToString()); } catch (Exception ex) { MessageBox.Show(ex.Message); }
            try { Sping.SetValue("Key", frmMain.Key.ToString()); } catch (Exception ex) { MessageBox.Show(ex.Message); }
            try { Sping.SetValue("ShowInLeft", frmMain.ShowInLeft.ToString()); } catch (Exception ex) { MessageBox.Show(ex.Message); }
            try { Sping.SetValue("OpacityForm", frmMain.OpacityForm.ToString()); } catch (Exception ex) { MessageBox.Show(ex.Message); }
            try { Sping.SetValue("Timeout", frmMain.Timeout.ToString()); } catch (Exception ex) { MessageBox.Show(ex.Message); }
            try { Sping.SetValue("BufferSize", frmMain.BufferSize.ToString()); } catch (Exception ex) { MessageBox.Show(ex.Message); }
            try { Sping.SetValue("TTL", frmMain.TTL.ToString()); } catch (Exception ex) { MessageBox.Show(ex.Message); }
            try { Sping.SetValue("CustomSound", frmMain.CustomSound.ToString()); } catch (Exception ex) { MessageBox.Show(ex.Message); }
            try { Sping.SetValue("CustomSoundPatch", frmMain.CustomSoundPatch.ToString()); } catch (Exception ex) { MessageBox.Show(ex.Message); }
            try { Sping.SetValue("ShowTopPanel", frmMain.ShowTopPanel.ToString()); } catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void CargarSettings()
        {
            Sping = Registry.CurrentUser.OpenSubKey(SubKey, true);
            if (Sping.GetValue("LaunchWindowsStart", RegistryValueKind.String).ToString() == "String")
            {
                frmMain.MinimizeWhenClose = false;
                frmMain.LaunchWindowsStart = false;
                frmMain.CurrentSection = "Device";
                frmMain.Key = "F8";
                frmMain.ShowInLeft = false;
                frmMain.OpacityForm = 100;
                frmMain.Timeout = 2000;
                frmMain.BufferSize = 32;
                frmMain.TTL = 32;
                frmMain.CustomSound = false;
                frmMain.CustomSoundPatch = "";
                frmMain.ShowTopPanel = true;
                return;
            }

            try
            {
                frmMain.LaunchWindowsStart = Convert.ToBoolean(Sping.GetValue("LaunchWindowsStart", RegistryValueKind.String));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            try
            {
                frmMain.MinimizeWhenClose = Convert.ToBoolean(Sping.GetValue("MinimizeWhenClose", RegistryValueKind.String));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            try
            {
                frmMain.CurrentSection = Sping.GetValue("CurrentSection", RegistryValueKind.String).ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            try
            {
                frmMain.Key = Sping.GetValue("Key", RegistryValueKind.String).ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            try
            {
                frmMain.ShowInLeft = Convert.ToBoolean(Sping.GetValue("ShowInLeft", RegistryValueKind.String));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            try
            {
                frmMain.OpacityForm = Convert.ToDouble(Sping.GetValue("OpacityForm", RegistryValueKind.String));
                //frmMain.frm.frmBack.Opacity = frmMain.OpacityForm;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            try
            {
                frmMain.Timeout = Convert.ToInt32(Sping.GetValue("Timeout", RegistryValueKind.String));
                //frmMain.frm.frmBack.Opacity = frmMain.OpacityForm;
            }
            catch (Exception ex) { frmMain.Timeout = 2000; MessageBox.Show(ex.Message); }

            try
            {
                frmMain.BufferSize = Convert.ToInt32(Sping.GetValue("BufferSize", RegistryValueKind.String));
                //frmMain.frm.frmBack.Opacity = frmMain.OpacityForm;
            }
            catch (Exception ex) { frmMain.BufferSize = 32; MessageBox.Show(ex.Message); }

            try
            {
                frmMain.TTL = Convert.ToInt32(Sping.GetValue("TTL", RegistryValueKind.String));
                //frmMain.frm.frmBack.Opacity = frmMain.OpacityForm;
            }
            catch (Exception ex) { frmMain.TTL = 32; MessageBox.Show(ex.Message); }

            try
            {
                frmMain.CustomSound = Convert.ToBoolean(Sping.GetValue("CustomSound", RegistryValueKind.String));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            try
            {
                frmMain.CustomSoundPatch = Sping.GetValue("CustomSoundPatch", RegistryValueKind.String).ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            try
            {
                frmMain.ShowTopPanel = Convert.ToBoolean(Sping.GetValue("ShowTopPanel", RegistryValueKind.String));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        public void GuardarID(object ID)
        {
            RegistryKey handle = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\SkyNetManager", true);
            if (handle == null)
            {
                Registry.CurrentUser.CreateSubKey(@"SOFTWARE\SkyNetManager");
                handle = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\SkyNetManager", true);
            }
            handle.SetValue("Handle", ID);

        }
        public void ResetId()
        {
            Sping = Registry.CurrentUser.OpenSubKey(SubKey, true);
            try { Sping.SetValue("Handle", "0"); } catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
