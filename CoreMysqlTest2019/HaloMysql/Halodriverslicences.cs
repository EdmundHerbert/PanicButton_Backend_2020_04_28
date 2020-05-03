namespace AdminPortal.HaloMysql
{
    public partial class Halodriverslicences
    {
        public long HaloDriversLicenceId { get; set; }
        public long? HaloMemberId { get; set; }
        public long? HaloDependantId { get; set; }
        public string Idnumber { get; set; }
        public string Surname { get; set; }
        public string Initials { get; set; }
        public string Gender { get; set; }
        public string DriverRestrictions1 { get; set; }
        public string DriverRestrictions2 { get; set; }
        public string DateOfBirth { get; set; }
        public string CertificateNumber { get; set; }
        public string CountryOfIssue { get; set; }
        public string IssueNumber { get; set; }
        public string ValidFrom { get; set; }
        public string ValidTo { get; set; }
        public string Pdpcategory { get; set; }
        public string PdpvalidTo { get; set; }
        public string Class1VehicleCode { get; set; }
        public string Class1VehicleRestrictions { get; set; }
        public string Class1FirstIssueDate { get; set; }
        public string Class2VehicleCode { get; set; }
        public string Class2VehicleRestrictions { get; set; }
        public string Class2FirstIssueDate { get; set; }
        public string Class3VehicleCode { get; set; }
        public string Class3VehicleRestrictions { get; set; }
        public string Class3FirstIssueDate { get; set; }
        public string LicencePhoto { get; set; }
    }
}
