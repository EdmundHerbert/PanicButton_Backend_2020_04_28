using System;

namespace AdminPortal.HaloMysql
{
    public partial class Haloftpaudittrail
    {
        public long HaloFtpauditTrailId { get; set; }
        public string HaloFtpauditTrailFileName { get; set; }
        public string HaloFtpauditTrailFileFrom { get; set; }
        public string HaloFtpauditTrailFileDateTime { get; set; }
        public DateTimeOffset? HaloFtpauditTrailProcDateTime { get; set; }
        public long? HaloFtpauditTrailClientId { get; set; }
        public string HaloFtpauditTrailStatus { get; set; }
    }
}
