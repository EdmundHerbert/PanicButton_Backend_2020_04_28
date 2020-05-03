namespace AdminPortal.HaloMysql
{
    public partial class Suburbs
    {
        public int SuburbId { get; set; }
        public int? CityId { get; set; }
        public string SuburbName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostalCode { get; set; }
        public string ContactName { get; set; }
        public string ContactCellNo { get; set; }
        public string ContactEmailAddress { get; set; }
        public string BranchName { get; set; }
        public string BranchTelephoneNumber { get; set; }
        public string BranchEmailAddress { get; set; }
        public string BranchLatitude { get; set; }
        public string BranchLongitude { get; set; }
        public string BeeLevel { get; set; }
        public string DateBeeLevel { get; set; }
        public string CreditCheck { get; set; }
        public string DateCreditCheck { get; set; }
    }
}
