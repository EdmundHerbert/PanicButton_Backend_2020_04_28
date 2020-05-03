using System;

namespace AdminPortal.HaloMysql
{
    public partial class Haloclaims
    {
        public int ClaimId { get; set; }
        public long HaloMemberId { get; set; }
        public long HaloDependantId { get; set; }
        public int? ClaimType { get; set; }
        public int? ClaimStatus { get; set; }
        public string ClaimJson { get; set; }
        public DateTime? ClaimCreatedAt { get; set; }
        public DateTime? ClaimSubmittedAt { get; set; }
        public DateTime? ClaimModifiedAt { get; set; }
        public long ClaimClientId { get; set; }
        public string ClaimReference { get; set; }
    }
}
