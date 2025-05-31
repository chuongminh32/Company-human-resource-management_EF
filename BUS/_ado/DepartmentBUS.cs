using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHRManagement.DAL._ado;
using CompanyHRManagement.Models;
namespace CompanyHRManagement.BUS._ado
{
    public class DepartmentBUS
    {
        private DepartmentDAO departmentDAO = new DepartmentDAO();
        public List<string> LayDSTenPhongBan()
        {
            return departmentDAO.GetDepartmentNames();
        }
    }
}
