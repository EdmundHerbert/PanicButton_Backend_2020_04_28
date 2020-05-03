namespace AdminPortal.HaloMysql
{
    public partial class Haloclientpartners
    {
        public long HaloClientPartnerId { get; set; }
        public long? HaloClientId { get; set; }
        public long? HaloPartnerId { get; set; }

        public virtual Haloclients HaloClient { get; set; }
    }
}
