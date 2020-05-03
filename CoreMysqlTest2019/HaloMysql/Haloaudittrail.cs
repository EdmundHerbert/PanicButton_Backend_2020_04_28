using System;

namespace AdminPortal.HaloMysql
{
    public partial class Haloaudittrail
    {
        public long HaloAuditTrailId { get; set; }
        public string HaloAuditTrailUserId { get; set; }
        public string HaloAuditTrailTransaction { get; set; }
        public string HaloAuditTrailStatus { get; set; }
        public DateTimeOffset? HaloAuditDate { get; set; }
    }
}
