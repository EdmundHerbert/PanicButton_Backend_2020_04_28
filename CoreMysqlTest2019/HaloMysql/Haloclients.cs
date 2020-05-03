using System;
using System.Collections.Generic;

namespace AdminPortal.HaloMysql
{
    public partial class Haloclients
    {
        public Haloclients()
        {
            Halobranches = new HashSet<Halobranches>();
            Haloclientbanners = new HashSet<Haloclientbanners>();
            Haloclientpartners = new HashSet<Haloclientpartners>();
            Haloclientprograms = new HashSet<Haloclientprograms>();
        }

        public long HaloClientId { get; set; }
        public string HaloClientName { get; set; }
        public string HaloClientCode { get; set; }
        public DateTimeOffset? HaloClientRegistrationDate { get; set; }
        public string HaloClientLogoPath { get; set; }
        public string HaloClientPdflogoPath { get; set; }
        public string HaloClientFspnumber { get; set; }
        public string HaloClientPhoneNumbers { get; set; }
        public string HaloClientEmailAddress { get; set; }
        public string HaloClientClaimEmailAddress { get; set; }
        public string HaloClientWebsite { get; set; }
        public string HaloClientPhysicalAddress { get; set; }
        public string HaloClientPostalAddress { get; set; }
        public string HaloClientServices { get; set; }
        public string HaloClientAbout { get; set; }
        public string HaloClientWelcomeMessage { get; set; }
        public string HaloClientResetMessage { get; set; }
        public long? HaloClientSmscredits { get; set; }
        public string HaloClientEmergencyPhoneNumber { get; set; }
        public string HaloClientContactDetailsInfo { get; set; }

        public virtual ICollection<Halobranches> Halobranches { get; set; }
        public virtual ICollection<Haloclientbanners> Haloclientbanners { get; set; }
        public virtual ICollection<Haloclientpartners> Haloclientpartners { get; set; }
        public virtual ICollection<Haloclientprograms> Haloclientprograms { get; set; }
    }
}
