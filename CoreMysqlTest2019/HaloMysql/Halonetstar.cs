using System;

namespace AdminPortal.HaloMysql
{
    public partial class Halonetstar
    {
        public long HaloNetStarId { get; set; }
        public string HaloNetStarName { get; set; }
        public string HaloNetStarSurname { get; set; }
        public string HaloNetStarCellNumber { get; set; }
        public string HaloNetStarIdnumber { get; set; }
        public string HaloNetStarPolicyNumber { get; set; }
        public string HaloNetStarIncidentDateTimeUtc { get; set; }
        public string HaloNetStarIncidentSpeed { get; set; }
        public string HaloNetStarIncidentLongitude { get; set; }
        public string HaloNetStarIncidentLatitude { get; set; }
        public string HaloNetStarVehichleRegistration { get; set; }
        public DateTimeOffset? HaloNetStarTimeStamp { get; set; }
    }
}
