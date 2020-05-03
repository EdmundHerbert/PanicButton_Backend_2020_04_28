using System;

namespace AdminPortal.HaloMysql
{
    public partial class Haloreminders
    {
        public long Id { get; set; }
        public int? ReminderType { get; set; }
        public string ReferenceNumber { get; set; }
        public long? InAppMessageId { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
