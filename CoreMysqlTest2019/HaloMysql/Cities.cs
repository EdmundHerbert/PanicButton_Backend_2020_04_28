namespace AdminPortal.HaloMysql
{
    public partial class Cities
    {
        public int CityId { get; set; }
        public int? RegionId { get; set; }
        public string CityName { get; set; }
        public string CityDescription { get; set; }
    }
}
