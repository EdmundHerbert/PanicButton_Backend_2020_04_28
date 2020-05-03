namespace AdminPortal.HaloMysql
{
    public partial class Halomemberclaimsthirdparty
    {
        public long HaloMemberClaimsThirdPartyId { get; set; }
        public long? HaloMemberClaimId { get; set; }
        public string HaloMemberClaimsThirdPartyName { get; set; }
        public string HaloMemberClaimsThirdPartyContact { get; set; }
        public string HaloMemberClaimsThirdPartyAddress { get; set; }
        public string HaloMemberClaimsThirdPartyControlNumber { get; set; }
        public string HaloMemberClaimsThirdPartyLicenceNumber { get; set; }
        public string HaloMemberClaimsThirdPartyRegisterNumber { get; set; }
        public string HaloMemberClaimsThirdPartyDescription { get; set; }
        public string HaloMemberClaimsThirdPartyMake { get; set; }
        public string HaloMemberClaimsThirdPartySeriesName { get; set; }
        public string HaloMemberClaimsThirdPartyColour { get; set; }
        public string HaloMemberClaimsThirdPartyVinNumber { get; set; }
        public string HaloMemberClaimsThirdPartyEngineNumber { get; set; }
        public string HaloMemberClaimsThirdPartyExpiryDate { get; set; }
        public string HaloMemberClaimsThirdPartyPicFront { get; set; }
        public string HaloMemberClaimsThirdPartyPicLeft { get; set; }
        public string HaloMemberClaimsThirdPartyPicBack { get; set; }
        public string HaloMemberClaimsThirdPartyPicRight { get; set; }
        public string HaloMemberClaimsThirdPartyPicWindscreen { get; set; }
        public string HaloMemberClaimsThirdPartyPicLabel { get; set; }
        public string HaloMemberClaimsThirdPartyPicOdo { get; set; }
        public string HaloMemberClaimsThirdPartyPicLicence { get; set; }

        public virtual Halomemberclaims HaloMemberClaim { get; set; }
    }
}
