using System;

namespace AdminPortal.HaloMysql
{
    public partial class Halochatmessages
    {
        public long HaloChatMessageId { get; set; }
        public long? HaloChatRequestId { get; set; }
        public string HaloChatMessage { get; set; }
        public long? HaloChatMessageSentFrom { get; set; }
        public long? HaloChatMessageSentTo { get; set; }
        public DateTimeOffset? HaloChatMessageSentAt { get; set; }
        public string HaloChatMessageType { get; set; }
    }
}
