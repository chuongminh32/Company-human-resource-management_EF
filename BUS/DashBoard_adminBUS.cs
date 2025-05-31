using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHRManagement.DAL._ado;
namespace CompanyHRManagement.BUS._ado
{
    public class DashBoard_adminBUS
    {
        private DashBoard_adminEF dao = new DashBoard_adminEF();
        public int GetDepartmentCount()
        {
            return dao.CountDepartments();
        }

        public int GetAllEmployeeCount()
        {
            return dao.CountAllEmployees();
        }

        public int GetProbationEmployeeCount()
        {
            return dao.CountProbationEmployees();
        }

        public int GetPositionCount()
        {
            return dao.CountPositions();
        }

        public decimal GetTotalRewardAmount()
        {
            return dao.GetTotalRewards();
        }

    }
}
