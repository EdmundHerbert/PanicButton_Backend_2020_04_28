using System;

namespace AdminPortal.HaloMysql
{
    public partial class Haloinappmessages
    {
        public int Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public string MessageType { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public int? MemberId { get; set; }
        public int? Read { get; set; }
        public int? Sent { get; set; }
        public DateTimeOffset? SentAt { get; set; }
        public DateTimeOffset? ReadAt { get; set; }
    }
}
