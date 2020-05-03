using System;

namespace AdminPortal.HaloMysql
{
    public partial class Communicationlog
    {
        public int Id { get; set; }
        public DateTimeOffset SentAt { get; set; }
        public string Body { get; set; }
    }
}
