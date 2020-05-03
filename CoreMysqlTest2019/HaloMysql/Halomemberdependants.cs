using System;

namespace AdminPortal.HaloMysql
{
    public partial class Halomemberdependants
    {
        public long HaloDependantId { get; set; }
        public long? HaloMemberId { get; set; }
        public string HaloDependantRelationship { get; set; }
        public string HaloDependantName { get; set; }
        public string HaloDependantSurname { get; set; }
        public string HaloDependantIdnumber { get; set; }
        public string HaloMemberDependantPassword { get; set; }
        public string HaloMemberDependantOtp { get; set; }
        public string HaloMemberDependantToken { get; set; }
        public string HaloDependantEmailAddress { get; set; }
        public string HaloDependantLanguage { get; set; }
        public string HaloDependantGender { get; set; }
        public string HaloDependantIdtype { get; set; }
        public string HaloDependantDateOfBirth { get; set; }
        public string HaloDependantCellPhoneNumber { get; set; }
        public string HaloDependantHomePhoneNumber { get; set; }
        public string HaloDependantWorkPhoneNumber { get; set; }
        public string HaloDependantMedicalAidName { get; set; }
        public string HaloDependantMedicalAidNumber { get; set; }
        public string HaloDependantMedicalAidScheme { get; set; }
        public string HaloDependantHomeAddress { get; set; }
        public string HaloDependantWorkAddress { get; set; }
        public string HaloDependantEmergencyContactName1 { get; set; }
        public string HaloDependantEmergencyContactNumber1 { get; set; }
        public string HaloDependantEmergencyContactName2 { get; set; }
        public string HaloDependantEmergencyContactNumber2 { get; set; }
        public string HaloDependantOccupation { get; set; }
        public string HaloDependantBusinessName { get; set; }
        public string HaloDependantBloodType { get; set; }
        public string HaloDependantBloodDonorNumber { get; set; }
        public string HaloDependantAllergies { get; set; }
        public string HaloDependantHomeLatitude { get; set; }
        public string HaloDependantHomeLongitude { get; set; }
        public string HaloDependantImage { get; set; }
        public string HaloDependantTmpIndex { get; set; }
        public short? HaloDependantActive { get; set; }
        public string HaloDependantHash { get; set; }
        public short? HaloDependantIsHashed { get; set; }
        public string HaloDependantFullName { get; set; }
        public DateTimeOffset? HaloDependantDateAdded { get; set; }
    }
}
