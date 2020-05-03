using System;

namespace AdminPortal.HaloMysql
{
    public partial class Referrals
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Relationship { get; set; }
        public int? ClientId { get; set; }
        public long? MemberId { get; set; }
        public DateTimeOffset Timestamp { get; set; }
    }
}
