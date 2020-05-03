namespace AdminPortal.HaloMysql
{
    public partial class Region
    {
        public int RegionId { get; set; }
        public int? ProvinceId { get; set; }
        public string RegionName { get; set; }
        public string RegionDescription { get; set; }
    }
}
