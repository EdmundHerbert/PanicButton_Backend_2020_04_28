namespace AdminPortal.HaloMysql
{
    public partial class Haloclientprograms
    {
        public long HaloClientProgramId { get; set; }
        public long? HaloClientProgramClientId { get; set; }
        public string HaloClientProgramCode { get; set; }

        public virtual Haloclients HaloClientProgramClient { get; set; }
    }
}
