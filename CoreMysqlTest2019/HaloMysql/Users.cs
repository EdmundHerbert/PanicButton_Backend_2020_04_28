using System;

namespace AdminPortal.HaloMysql
{
    public partial class Users
    {
        public int AutoInc { get; set; }
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Secret { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
