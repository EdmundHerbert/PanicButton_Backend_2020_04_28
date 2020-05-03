using System;

namespace AdminPortal.HaloMysql
{
    public partial class Token
    {
        public int AutoInc { get; set; }
        public string Id { get; set; }
        public string Issuer { get; set; }
        public string UserId { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
    }
}
