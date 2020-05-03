using System;

namespace AdminPortal.HaloMysql
{
    public partial class EdmundsTest
    {
        public int Id { get; set; }
        public string EdmundsName { get; set; }
        public string EdmundsSurname { get; set; }
        public string EdmundsAddress1 { get; set; }
        public string EdmundsAddress2 { get; set; }
        public string EdmundsCity { get; set; }
        public string EdmundsProvince { get; set; }
        public string EdmundsSalary { get; set; }
        public DateTimeOffset? EdmundsPayDate { get; set; }
        public string EdmundsYearsWorked { get; set; }
    }
}
