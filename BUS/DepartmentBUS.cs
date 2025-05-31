using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHRManagement.DAL._ado;
namespace CompanyHRManagement.BUS._ado
{
    public class DepartmentBUS
    {
        private DepartmentEF departmentDAO = new DepartmentEF();
        public List<string> LayDSTenPhongBan()
        {
            return departmentDAO.GetDepartmentNames();
        }

        public List<Department> LayTatCaPhongBan()
        {
            return departmentDAO.GetAllDepartments();
        }

        public List<Department> TimTenPhongBan(string keyword)
        {
            return departmentDAO.SearchDepartments(keyword);
        }

        public bool ThemPhongBan(string name, ref string error)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                error = "Tên phòng ban không được để trống.";
                return false;
            }

            return departmentDAO.AddDepartment(name, ref error);
        }

        public bool UpdateTen(int id, string name, ref string error)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                error = "Tên phòng ban không được để trống.";
                return false;
            }

            return departmentDAO.UpdateDepartment(id, name, ref error);
        }

        public bool XoaPhongban(int id, ref string error)
        {
            return departmentDAO.DeleteDepartment(id, ref error);
        }
    }
}
