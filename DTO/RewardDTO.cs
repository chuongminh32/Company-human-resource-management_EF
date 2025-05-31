using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHRManagement.DTO
{
    public class RewardDTO
    {
        public int RewardID { get; set; }
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Reason { get; set; }
        public DateTime RewardDate { get; set; }
        public decimal Amount { get; set; }
    }
}
