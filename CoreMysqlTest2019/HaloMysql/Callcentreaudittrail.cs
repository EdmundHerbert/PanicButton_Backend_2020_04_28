using System;

namespace AdminPortal.HaloMysql
{
    public partial class Callcentreaudittrail
    {
        public long CallCentreAuditTrailId { get; set; }
        public long? CallCentreAuditTrailUserId { get; set; }
        public string CallCentreAuditTrailTransaction { get; set; }
        public DateTimeOffset? CallCentreAuditTrailDate { get; set; }
    }
}
