using System;

namespace AdminPortal.HaloMysql
{
    public partial class Haloclientapiregister
    {
        public int Apiclientid { get; set; }
        public string Clientname { get; set; }
        public string Clientemail { get; set; }
        public string Passwordhash { get; set; }
        public string Token { get; set; }
        public DateTime? Createdat { get; set; }
    }
}
