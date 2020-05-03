using System;

namespace AdminPortal.HaloMysql
{
    public partial class Halovehiclemonitorintegration
    {
        public long Vmiid { get; set; }
        public string Vminame { get; set; }
        public string Vmisurname { get; set; }
        public string VmicellNumber { get; set; }
        public string Vmiidnumber { get; set; }
        public string VmipolicyNumber { get; set; }
        public DateTime? VmiincidentDateTimeUtc { get; set; }
        public string VmiincidentSpeed { get; set; }
        public string VmiincidentLongitude { get; set; }
        public string VmiincidentLatitude { get; set; }
        public string Vmiradius { get; set; }
        public string VmivehichleRegistration { get; set; }
        public DateTimeOffset VmitimeStamp { get; set; }
        public string UnidentifiedContent { get; set; }
        public int? Vmistatus { get; set; }
        public long? VmimemberId { get; set; }
        public string Vmisource { get; set; }
    }
}
