using System;

namespace AdminPortal.HaloMysql
{
    public partial class Halopanics
    {
        public long HaloPanicId { get; set; }
        public long? HaloMemberId { get; set; }
        public string HaloMemberPhoneNumber { get; set; }
        public string HaloPanicLatitude { get; set; }
        public string HaloPanicLongitude { get; set; }
        public byte? HaloPanicActive { get; set; }
        public DateTimeOffset? HaloPanicTimeStamp { get; set; }
        public long? HaloPanicHandledBy { get; set; }
        public DateTimeOffset? HaloPanicHandledAt { get; set; }
        public long? HaloPanicProductId { get; set; }
        public long? HaloPanicVmiId { get; set; }
        public string HaloCaseId { get; set; }
    }
}
