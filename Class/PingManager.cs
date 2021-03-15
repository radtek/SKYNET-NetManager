using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Threading;
using SkynetManager;

public class PingManager
{
    public List<string> _addresses { get; private set; }

    // Addresse that the ping will reach
    public string addressToBroadcast = "10.31.0.";

    public int timeout = 100;

    public bool _isSearching { get; private set; }


    public float _percentSearching { get; private set; }

    public int _portServer { get; private set; }
    Ping ping;
    PingOptions pingOption;
    readonly byte[] buffer;
    public PingManager()
    {
        _addresses = new List<string>();
        ping = new Ping();

        // 128 TTL and DontFragment
        pingOption = new PingOptions(128, true);

        buffer = new byte[4];

    }

    public IEnumerator ScanNetworkInterfaces()
    {
        foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
        {
            if (ni.OperationalStatus == OperationalStatus.Up)
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip != null && ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            // My addresses
                        }

                        yield return null;
                    }
                }
            }

            yield return null;
        }
    }

    public IEnumerator SendRangePing(bool bClear = true)
    {
        if (bClear)
        {
            _addresses.Clear();
        }
        _isSearching = true;
        for (int i = 0; i < 255; i++)
        {
            string address = addressToBroadcast + i;

            SendPing(address);

            _percentSearching = (float)i / 255;

            yield return null;
        }
        _isSearching = false;
    }
    DeviceBox PC;
    public void SendPingRange(List<DeviceBox> PCs)
    {
        _isSearching = true;

        foreach (DeviceBox tPC in PCs)
        {
            this.PC = tPC;
            string address = PC.IpName;
            //frmMain.frm.SettingsLbl.Text = "Haciendo ping al IP " + PC.IpName;
            SendPing(address);
        }
        /*
        foreach (BoxTool PC in PCs)
        {
            this.PC = PC;
            string address = PC.IpName;
            frmMain.frm.SettingsLbl.Text = "Haciendo ping al IP " + PC.IpName;
            SendPing(address);
        }*/
        _isSearching = false;
    }
    public void SendPing(string address)
    {
        try
        {
            PingReply reply = ping.Send(address, timeout, buffer, pingOption);
            displayReply(reply);
        }
        catch { }

    }


    private void ping_PingCompleted(object sender, PingCompletedEventArgs e)
    {
        //displayReply(e.Reply);
    }

    private void displayReply(PingReply reply)
    {
        if (reply != null)
        {
            if (reply.Status == IPStatus.Success)
            {
                PC.Ping = reply.RoundtripTime + " ms";
                PC.Status = ConnectionStatus.Online;
                if (!PC.isWeb)
                {
                    //frmMain.onlinePC.Add(PC.IpName);
                }

                /*for (int i = 0; i < frmMain.SetAlert.Count; i++)
                {
                    if (frmMain.SetAlert[i] == PC.IpName)
                    {
                        BoxTool tool = PC;
                        new Thread(() =>
                        {
                            frmAlert alerta = new frmAlert(tool);
                            alerta.ShowDialog();
                        }).Start();
                        frmMain.SetAlert.Remove(frmMain.SetAlert[i]);
                    }
                }*/
                _addresses.Add(reply.Address.ToString());
            }
            else
            {
                PC.Status = ConnectionStatus.Offline;
            }
        }
    }
    public void Dispose()
    {
        ping.Dispose();
    }
}
