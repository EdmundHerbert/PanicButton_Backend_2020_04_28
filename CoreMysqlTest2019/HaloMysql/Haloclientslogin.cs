namespace AdminPortal.HaloMysql
{
    public partial class Haloclientslogin
    {
        public long HaloClientLoginId { get; set; }
        public long? HaloClientId { get; set; }
        public string HaloClientUserName { get; set; }
        public string HaloClientUserSurname { get; set; }
        public string HaloClientPassword { get; set; }
        public short? HaloClientStatus { get; set; }
    }
}
