namespace AdminPortal.HaloMysql
{
    public partial class Cartrack
    {
        public long CarTrackId { get; set; }
        public string CarTrackClientNo { get; set; }
        public string CarTrackClientName { get; set; }
        public string CarTrackPolicyNumber { get; set; }
        public string CarTrackIdNumber { get; set; }
        public string CarTrackCellphoneNumber { get; set; }
        public string CarTrackEmail { get; set; }
        public string CarTrackEngineNumber { get; set; }
        public string CarTrackModel { get; set; }
        public string CarTrackRegistrationNumber { get; set; }
        public string CarTrackVehicleMake { get; set; }
        public string CarTrackVinNumber { get; set; }
        public long? CarTrackHaloMemberId { get; set; }
    }
}
