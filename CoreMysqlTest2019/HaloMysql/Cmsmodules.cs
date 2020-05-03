namespace AdminPortal.HaloMysql
{
    public partial class Cmsmodules
    {
        public short CmsmoduleId { get; set; }
        public string CmsmoduleName { get; set; }
        public string CmsmoduleSubNames { get; set; }
        public string CmsmoduleHtml { get; set; }
        public string CmsmoduleScript { get; set; }
        public int? CmsmoduleOrder { get; set; }
    }
}
