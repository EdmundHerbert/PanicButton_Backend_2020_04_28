using System;

namespace AdminPortal.HaloMysql
{
    public partial class HalomemberAdditionalClientData
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int ClientId { get; set; }
        public string Programme { get; set; }
        public string ClientIdentifier { get; set; }
        public int VehicleCount { get; set; }
        public int PropCount { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
        public DateTimeOffset? UpdatedOn { get; set; }
    }
}
