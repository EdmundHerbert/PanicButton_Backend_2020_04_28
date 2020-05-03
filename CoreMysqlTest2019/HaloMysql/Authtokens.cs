namespace AdminPortal.HaloMysql
{
    public partial class Authtokens
    {
        public int AtId { get; set; }
        public string AtUserName { get; set; }
        public string AtPassword { get; set; }
        public string AtJwt { get; set; }
        public int? AtClientId { get; set; }
    }
}
