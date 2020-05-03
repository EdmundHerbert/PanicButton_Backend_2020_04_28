using System;

namespace AdminPortal.HaloMysql
{
    public partial class ClientTokens
    {
        public string ClientId { get; set; }
        public int TokensAvailable { get; set; }
        public int? TokensUsed { get; set; }
        public int? TokensBrought { get; set; }
        public string Type { get; set; }
        public int Id { get; set; }
        public DateTime Date { get; set; }
    }
}
