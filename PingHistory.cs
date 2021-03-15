namespace SkynetManager
{
    public class PingHistory
    {
        public string IP { get; set; }
        public string HostName { get; set; }
        public string HostDescription { get; set; }
        public string Status { get; set; }
        public string SentPackets { get; set; }
        public string ReceivedPackets { get; set; }
        public string ReceivedPacketsPercent { get; set; }
        public string LostPackets { get; set; }
        public string LostPacketsPercent { get; set; }
        public string LastPacketLost { get; set; }
        public string ConsecutivePacketsLost { get; set; }
        public string MaxConsecutivePacketsLost { get; set; }
        public string RecentlyReceivedPackets { get; set; }
        public string RecentlyReceivedPacketsPercent { get; set; }
        public string RecentlyLostPackets { get; set; }
        public string RecentlyLostPacketsPercent { get; set; }
        public string CurrentResponseTime { get; set; }
        public string AverageResponseTime { get; set; }
        public string MinResponseTime { get; set; }
        public string MaxResponseTime { get; set; }
        public string CurrentStatusDuration { get; set; }
        public string GetAliveDuration { get; set; }
        public string GetDeadDuration { get; set; }
        public string HostAvailability { get; set; }
        public string TotalTestDuration { get; set; }
        public string CurrentTestDuration { get; set; }
    }
}