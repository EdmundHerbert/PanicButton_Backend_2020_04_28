namespace AdminPortal.HaloMysql
{
    public partial class Haloclientprogramproducts
    {
        public long HaloClientProgramProductId { get; set; }
        public long? HaloClientProgramId { get; set; }
        public long? HaloClientProgramProductIndex { get; set; }
        public string HaloClientProgramProductName { get; set; }
        public string HaloClientProgramProductIcon { get; set; }
        public string HaloClientProgramProductDescription { get; set; }
        public string HaloClientProgramProductTerms { get; set; }
        public decimal? HaloClientProgramProductPrice { get; set; }
        public string HaloClientProgramProductPhone { get; set; }
        public int? HaloClientProgramProductOrder { get; set; }
    }
}
