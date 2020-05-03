using System;

namespace AdminPortal.HaloMysql
{
    public partial class Halochatrequests
    {
        public long HaloChatRequestId { get; set; }
        public long? HaloChatRequestMemberId { get; set; }
        public string HaloChatRequestMemberPhoneNumber { get; set; }
        public byte? HaloChatRequestActive { get; set; }
        public DateTimeOffset? HaloChatRequestTimeStamp { get; set; }
        public DateTimeOffset? HaloChatRequestLastTransaction { get; set; }
        public long? HaloChatRequestHandledBy { get; set; }
        public string HaloChatRequestHandledAt { get; set; }
        public string HaloChatRequestLatitude { get; set; }
        public string HaloChatRequestLongitude { get; set; }
        public byte? HaloChatRequestHasUnread { get; set; }
    }
}
