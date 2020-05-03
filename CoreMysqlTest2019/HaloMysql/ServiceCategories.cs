namespace AdminPortal.HaloMysql
{
    public partial class ServiceCategories
    {
        public int ServiceCatagorieId { get; set; }
        public int? ServiceId { get; set; }
        public string ServiceCategorieName { get; set; }
        public string ServiceCategorieDescription { get; set; }
    }
}
