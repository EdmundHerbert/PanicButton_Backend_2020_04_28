using System;
using System.Collections.Generic;

namespace AdminPortal.HaloMysql
{
    public partial class Halomembers
    {
        public Halomembers()
        {
            Halomemberclaims = new HashSet<Halomemberclaims>();
        }

        public long HaloMemberId { get; set; }
        public string HaloMemberName { get; set; }
        public string HaloMemberSurname { get; set; }
        public string HaloMemberIdnumber { get; set; }
        public string HaloMemberPassword { get; set; }
        public string HaloMemberOtp { get; set; }
        public string HaloMemberToken { get; set; }
        public string HaloMemberEmailAddress { get; set; }
        public string HaloMemberLanguage { get; set; }
        public string HaloMemberGender { get; set; }
        public string HaloMemberIdtype { get; set; }
        public string HaloMemberDateOfBirth { get; set; }
        public string HaloMemberHomePhoneNumber { get; set; }
        public string HaloMemberWorkPhoneNumber { get; set; }
        public string HaloMemberMedicalAidName { get; set; }
        public string HaloMemberMedicalAidNumber { get; set; }
        public string HaloMemberMedicalAidScheme { get; set; }
        public string HaloMemberHomeAddress { get; set; }
        public string HaloMemberWorkAddress { get; set; }
        public string HaloMemberEmergencyContactName1 { get; set; }
        public string HaloMemberEmergencyContactNumber1 { get; set; }
        public string HaloMemberEmergencyContactName2 { get; set; }
        public string HaloMemberEmergencyContactNumber2 { get; set; }
        public string HaloMemberOccupation { get; set; }
        public string HaloMemberBusinessName { get; set; }
        public string HaloMemberBloodType { get; set; }
        public string HaloMemberBloodDonorNumber { get; set; }
        public string HaloMemberAllergies { get; set; }
        public string HaloMemberHomeLatitude { get; set; }
        public string HaloMemberHomeLongitude { get; set; }
        public string HaloMemberImage { get; set; }
        public short? HaloMemberActive { get; set; }
        public string HaloMemberDataKey { get; set; }
        public DateTimeOffset? HaloMemberLoadDate { get; set; }
        public int? HaloMemberWelcomeEmailSent { get; set; }
        public string HaloMemberHash { get; set; }
        public short? HaloMemberIsHashed { get; set; }
        public string HaloMemberVat { get; set; }
        public DateTimeOffset? HaloMemberActivateDate { get; set; }
        public DateTimeOffset? HaloMemberModifiedDate { get; set; }
        public string HaloMemberFullName { get; set; }

        public virtual ICollection<Halomemberclaims> Halomemberclaims { get; set; }
    }
}
