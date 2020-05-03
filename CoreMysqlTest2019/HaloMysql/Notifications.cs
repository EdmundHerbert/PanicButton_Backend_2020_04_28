using System;

namespace AdminPortal.HaloMysql
{
    public partial class Notifications
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
        public int Type { get; set; }
        public string Players { get; set; }
        public string Program { get; set; }
        public int Sent { get; set; }
    }
}
