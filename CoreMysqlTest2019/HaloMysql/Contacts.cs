namespace AdminPortal.HaloMysql
{
    public partial class Contacts
    {
        public long ContactId { get; set; }
        public string ContactName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactNumber { get; set; }
        public long HaloMemberId { get; set; }
        public int? ContactStatus { get; set; }
    }
}
