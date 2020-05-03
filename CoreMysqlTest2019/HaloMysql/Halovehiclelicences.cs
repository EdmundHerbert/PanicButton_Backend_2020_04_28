namespace AdminPortal.HaloMysql
{
    public partial class Halovehiclelicences
    {
        public long HaloVehicleLicenceId { get; set; }
        public long? HaloMemberId { get; set; }
        public long? HaloDependantId { get; set; }
        public string ControlNumber { get; set; }
        public string LicenceNumber { get; set; }
        public string RegisterNumber { get; set; }
        public string VehicleDescription { get; set; }
        public string VehicleMake { get; set; }
        public string SeriesName { get; set; }
        public string VehicleColour { get; set; }
        public string VinNumber { get; set; }
        public string EngineNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string VehicleYear { get; set; }
    }
}
