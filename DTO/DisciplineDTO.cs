using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHRManagement.DTO
{
    public class DisciplineDTO
    {
        public int DisciplineID { get; set; }
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Reason { get; set; }
        public DateTime DisciplineDate { get; set; }
        public decimal Amount { get; set; }
    }
}
