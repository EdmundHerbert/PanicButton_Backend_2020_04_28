using System;

namespace AdminPortal.HaloMysql
{
    public partial class Halosentsmss
    {
        public long HaloSentSmsid { get; set; }
        public long? HaloSentSmsfromId { get; set; }
        public long? HaloSentSmstoId { get; set; }
        public string HaloSentSmsmessage { get; set; }
        public DateTimeOffset? HaloSentSmstimeStamp { get; set; }
        public string HaloSentSmsgatewayResponse { get; set; }
    }
}
