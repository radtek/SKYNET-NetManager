using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System;

public class LanManager
{
    public List<KeyValuePair<string, int>> _addresses { get; private set; }

    // Addresse that the ping will reach
    public string addressToBroadcast = "255.255.255.0";
    PingOptions pingOption = new PingOptions(128, true);
    public int timeout = 1000;
    System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();
    public LanManager()
    {
        _addresses = new List<KeyValuePair<string, int>>();
    }

    public void SendPing()
    {
        _addresses.Clear();



        // 128 TTL and DontFragment


        // Once the ping has reached his target (or has timed out), call this function
        ping.PingCompleted += ping_PingCompleted;

        byte[] buffer = Encoding.ASCII.GetBytes("ping");

        // Do not block the main thread
        ping.SendAsync("10.31.0.7", timeout, buffer, pingOption, addressToBroadcast);


        for (int i = 1; i < 255; i++)
        {
            //ping.SendAsync("10.31.0." + i, timeout, buffer, pingOption, addressToBroadcast);
        }
    }


    private void ping_PingCompleted(object sender, PingCompletedEventArgs e)
    {
        string address = (string)e.UserState;

        // For debug purpose
        _addresses.Add(new KeyValuePair<string, int>("127.0.0.1", 26000));

        if (e.Cancelled)
        {
            MessageBox.Show("Ping Canceled!");
        }

        if (e.Error != null)
        {
            MessageBox.Show(e.ToString());
        }

        displayReply(e.Reply);
    }
    public void PING(string ip)
    {
        byte[] buffer = Encoding.ASCII.GetBytes("ping");
        ping.SendAsync(ip, timeout, buffer, pingOption, addressToBroadcast);

    }

    private void displayReply(PingReply reply)
    {
        if (reply != null)
        {
            if (reply.Status == IPStatus.Success)
            {
                MessageBox.Show(reply.Address.ToString());
            }
            else if (reply.Status == IPStatus.TimedOut)
            {
                //Form1.Write("Off  : " + reply.Address);
            }
        }
        else
        {
            //Form1.Write("Off  : " + reply.Address);
        }
    }
}
