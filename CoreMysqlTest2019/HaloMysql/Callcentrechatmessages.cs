using System;

namespace AdminPortal.HaloMysql
{
    public partial class Callcentrechatmessages
    {
        public long CallCentreChatMessageId { get; set; }
        public string CallCentreChatMessage { get; set; }
        public long? CallCentreChatMessageSentFrom { get; set; }
        public long? CallCentreChatMessageSentTo { get; set; }
        public byte? CallCentreChatMessageRead { get; set; }
        public DateTimeOffset? CallCentreChatMessageSentAt { get; set; }
    }
}
