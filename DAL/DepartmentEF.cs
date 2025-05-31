using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHRManagement.DAL._ado
{
    public class DepartmentEF
    {
        private CompanyHRManagementEntities context = new CompanyHRManagementEntities();

        // Lấy danh sách tên phòng ban (dùng cho ComboBox)
        public List<string> GetDepartmentNames()
        {
            return context.Departments
                          .Select(d => d.DepartmentName)
                          .ToList();
        }

        // Lấy toàn bộ danh sách phòng ban
        public List<Department> GetAllDepartments()
        {
            return context.Departments.ToList();
        }

        // Tìm kiếm phòng ban theo tên
        public List<Department> SearchDepartments(string keyword)
        {
            return context.Departments
                          .Where(d => d.DepartmentName.Contains(keyword))
                          .ToList();
        }

        // Thêm phòng ban
        public bool AddDepartment(string departmentName, ref string error)
        {
            try
            {
                var dept = new Department { DepartmentName = departmentName };
                context.Departments.Add(dept);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        // Sửa tên phòng ban
        public bool UpdateDepartment(int departmentID, string newName, ref string error)
        {
            try
            {
                var dept = context.Departments.FirstOrDefault(d => d.DepartmentID == departmentID);
                if (dept == null)
                {
                    error = "Không tìm thấy phòng ban.";
                    return false;
                }

                dept.DepartmentName = newName;
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        // Xóa phòng ban nếu không có nhân viên
        public bool DeleteDepartment(int departmentID, ref string error)
        {
            try
            {
                var department = context.Departments.FirstOrDefault(d => d.DepartmentID == departmentID);
                if (department == null)
                {
                    error = "Không tìm thấy phòng ban.";
                    return false;
                }

                bool hasEmployees = context.Employees.Any(e => e.DepartmentID == departmentID);
                if (hasEmployees)
                {
                    error = "Không thể xóa phòng ban vì vẫn còn nhân viên thuộc phòng ban này.";
                    return false;
                }

                context.Departments.Remove(department);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}
