using System;

namespace AdminPortal.HaloMysql
{
    public partial class Halomembermessages
    {
        public long HaloMemberMessageId { get; set; }
        public string HaloMemberMessage { get; set; }
        public long? HaloMemberMessageSentFromId { get; set; }
        public string HaloMemberMessageSentFromName { get; set; }
        public long? HaloMemberMessageSentTo { get; set; }
        public byte? HaloMemberMessageRead { get; set; }
        public DateTimeOffset? HaloMemberMessageSentAt { get; set; }
        public byte? HaloMemberMessageDeleted { get; set; }
    }
}
