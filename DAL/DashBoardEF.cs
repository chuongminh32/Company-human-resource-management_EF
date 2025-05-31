using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CompanyHRManagement.DAL._ado
{
    public class DashBoardEF
    {

        //---------- Employee DashBoard - USER -----------
        // Lấy tên vị trí chức vụ theo ID 
        public string LayVitriChucVuTheoID(int userID)
        {
            using (var context = new CompanyHRManagementEntities())
            {
                // Giả sử lớp Employee có navigation property: Position
                var positionName = context.Employees
                    .Where(e => e.EmployeeID == userID)
                    .Select(e => e.Position.PositionName)
                    .FirstOrDefault();

                return positionName;
            }
        }


        public string LayTenPhongBanQuaID(int idDepartment)
        {
            using (var context = new CompanyHRManagementEntities())
            {
                var departmentName = context.Departments
                    .Where(d => d.DepartmentID == idDepartment)
                    .Select(d => d.DepartmentName)
                    .FirstOrDefault();

                return departmentName;
            }
        }
        // Tổng lương theo tháng của 1 nhân viên
        public List<(int Month, int Year, decimal TotalSalary)> TongLuongTheoThang(int employeeId)
        {
            using (var context = new CompanyHRManagementEntities())
            {
                var result = context.Salaries
                    .Where(s => s.EmployeeID == employeeId)
                    .OrderBy(s => s.SalaryYear)
                    .ThenBy(s => s.SalaryMonth)
                    .Select(s => new
                    {
                        Month = s.SalaryMonth,
                        Year = s.SalaryYear,
                        TotalSalary = s.BaseSalary + s.Allowance + s.Bonus - s.Penalty
                    })
                    .ToList()
                    .Select(s => (
                    Month: s.Month ?? 0,
                    Year: s.Year ?? 0,
                    TotalSalary: s.TotalSalary ?? 0m))
                    .ToList();

                return result;
            }
        }


        // Số ngày công theo tháng
        public List<(int Month, int Year, int WorkDays)> SoNgayCongTheoThang(int employeeId)
        {
            using (var context = new CompanyHRManagementEntities())
            {
                var result = context.Attendances
                    .Where(a => a.EmployeeID == employeeId)
                    .GroupBy(a => new { a.WorkDate.Month, a.WorkDate.Year })
                    .OrderBy(g => g.Key.Year)
                    .ThenBy(g => g.Key.Month)
                    .Select(g => (
                        Month: g.Key.Month,
                        Year: g.Key.Year,
                        WorkDays: g.Count()
                    ))
                    .ToList();

                return result;
            }
        }




    }
}
