namespace AdminPortal.HaloMysql
{
    public partial class Cmsusers
    {
        public long CmsuserId { get; set; }
        public string CmsuserName { get; set; }
        public string CmsuserSurname { get; set; }
        public string CmsuserPassword { get; set; }
        public short CmsuserStatus { get; set; }
        public short? CmsuserRole { get; set; }
    }
}
