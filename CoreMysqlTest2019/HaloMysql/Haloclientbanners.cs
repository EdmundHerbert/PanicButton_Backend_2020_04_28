namespace AdminPortal.HaloMysql
{
    public partial class Haloclientbanners
    {
        public long HaloClientBannerId { get; set; }
        public long? HaloClientId { get; set; }
        public string HaloClientBannerPath { get; set; }

        public virtual Haloclients HaloClient { get; set; }
    }
}
