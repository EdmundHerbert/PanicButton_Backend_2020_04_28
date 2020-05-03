namespace AdminPortal.HaloMysql
{
    public partial class Haloinappapplications
    {
        public int Id { get; set; }
        public long? ClientId { get; set; }
        public string ProjectId { get; set; }
        public string RestApiKey { get; set; }
    }
}
