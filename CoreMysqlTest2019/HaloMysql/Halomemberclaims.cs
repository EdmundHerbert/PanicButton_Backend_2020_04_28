using System;
using System.Collections.Generic;

namespace AdminPortal.HaloMysql
{
    public partial class Halomemberclaims
    {
        public Halomemberclaims()
        {
            Halomemberclaimseyewitness = new HashSet<Halomemberclaimseyewitness>();
            Halomemberclaimsthirdparty = new HashSet<Halomemberclaimsthirdparty>();
        }

        public long HaloMemberClaimId { get; set; }
        public long? HaloMemberId { get; set; }
        public long? HaloDependantId { get; set; }
        public string HaloMemberClaimIncidentDate { get; set; }
        public string HaloMemberClaimIncidentTime { get; set; }
        public string HaloMemberClaimIncidentAddress { get; set; }
        public string HaloMemberClaimIncidentDescription { get; set; }
        public string HaloMemberClaimIncidentIdnumber { get; set; }
        public string HaloMemberClaimIncidentName { get; set; }
        public string HaloMemberClaimIncidentSurname { get; set; }
        public string HaloMemberClaimIncidentContactNumber { get; set; }
        public string HaloMemberClaimVehicleControlNumber { get; set; }
        public string HaloMemberClaimVehicleLicenceNumber { get; set; }
        public string HaloMemberClaimVehicleRegisterNumber { get; set; }
        public string HaloMemberClaimVehicleDescription { get; set; }
        public string HaloMemberClaimVehicleMake { get; set; }
        public string HaloMemberClaimVehicleSeriesName { get; set; }
        public string HaloMemberClaimVehicleColour { get; set; }
        public string HaloMemberClaimVehicleVinNumber { get; set; }
        public string HaloMemberClaimVehicleEngineNumber { get; set; }
        public string HaloMemberClaimVehicleExpiryDate { get; set; }
        public string HaloMemberClaimTowingCompanyName { get; set; }
        public string HaloMemberClaimTowingCompanyDriver { get; set; }
        public string HaloMemberClaimTowingCompanyContact { get; set; }
        public string HaloMemberClaimPicFront { get; set; }
        public string HaloMemberClaimPicLeft { get; set; }
        public string HaloMemberClaimPicBack { get; set; }
        public string HaloMemberClaimPicRight { get; set; }
        public string HaloMemberClaimPicWindscreen { get; set; }
        public string HaloMemberClaimPicLabel { get; set; }
        public string HaloMemberClaimPicOdo { get; set; }
        public string HaloMemberClaimPicLicence { get; set; }
        public DateTimeOffset? HaloMemberClaimSubmitted { get; set; }

        public virtual Halomembers HaloMember { get; set; }
        public virtual ICollection<Halomemberclaimseyewitness> Halomemberclaimseyewitness { get; set; }
        public virtual ICollection<Halomemberclaimsthirdparty> Halomemberclaimsthirdparty { get; set; }
    }
}
