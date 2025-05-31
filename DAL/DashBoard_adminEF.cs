using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHRManagement.DAL._ado
{
    public class DashBoard_adminEF
    {
        //Đếm số lượng phòng ban
        public int CountDepartments()
        {
            using (var context = new CompanyHRManagementEntities())
            {
                return context.Departments.Count();
            }
        }

        //Đếm tổng số nhân viên
        public int CountAllEmployees()
        {
            using (var context = new CompanyHRManagementEntities())
            {
                return context.Employees.Count(e => e.IsFired == false);
            }
        }

        //Đếm số nhân viên đang thử việc
        public int CountProbationEmployees()
        {
            using (var context = new CompanyHRManagementEntities())
            {
                return context.Employees.Count(e => e.IsProbation == true && e.IsFired == false);
            }
        }
        //Đếm số chức vụ
        public int CountPositions()
        {
            using (var context = new CompanyHRManagementEntities())
            {
                return context.Positions.Count();
            }
        }
        //Tính tổng thưởng
        public decimal GetTotalRewards()
        {
            using (var context = new CompanyHRManagementEntities())
            {
                return context.Rewards.Sum(r => (decimal?)r.Amount) ?? 0;
            }
        }








    }
}
