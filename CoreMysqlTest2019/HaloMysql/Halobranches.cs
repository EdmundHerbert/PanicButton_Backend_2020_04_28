namespace AdminPortal.HaloMysql
{
    public partial class Halobranches
    {
        public long HaloBranchId { get; set; }
        public long? HaloClientId { get; set; }
        public string HaloBranchName { get; set; }
        public string HaloBranchPhoneNumbers { get; set; }
        public string HaloBranchEmailAddress { get; set; }
        public string HaloBranchPhysicalAddress { get; set; }
        public string HaloBranchPostalAddress { get; set; }

        public virtual Haloclients HaloClient { get; set; }
    }
}
