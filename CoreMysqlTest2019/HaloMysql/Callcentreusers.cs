namespace AdminPortal.HaloMysql
{
    public partial class Callcentreusers
    {
        public long CallCentreUserId { get; set; }
        public string CallCentreUserName { get; set; }
        public string CallCentreUserFirstName { get; set; }
        public string CallCentreUserSurname { get; set; }
        public string CallCentreUserPassword { get; set; }
        public short CallCentreUserStatus { get; set; }
        public short? CallCentreUserRole { get; set; }
        public string CallCentreUserHash { get; set; }
        public short? CallCentreUserIsHashed { get; set; }
    }
}
