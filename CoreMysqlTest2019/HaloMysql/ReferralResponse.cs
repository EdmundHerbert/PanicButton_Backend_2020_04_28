using System;

namespace AdminPortal.HaloMysql
{
    public partial class ReferralResponse
    {
        public int Id { get; set; }
        public string HttpResponse { get; set; }
        public DateTimeOffset CreateAt { get; set; }
    }
}
