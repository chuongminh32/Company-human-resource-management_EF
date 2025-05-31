using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using CompanyHRManagement;

public class EmployeeEF
{
    // Lấy dữ liệu nhân viên qua ID
    public Employee GetEmployeeById(int employeeID)
    {
        using (var context = new CompanyHRManagementEntities())
        {
            // Tìm employee theo ID, chỉ lấy bản ghi đầu tiên (hoặc null nếu không có)
            var employee = context.Employees
                .FirstOrDefault(e => e.EmployeeID == employeeID);

            return employee;
        }
    }
    public DataTable GetEmployees()
    {
        CompanyHRManagementEntities x = new CompanyHRManagementEntities();
        var tps =
                from p in x.Employees
                select p;
        DataTable dt = new DataTable();

        dt.Columns.Add("Mã NV", typeof(int));
        dt.Columns.Add("Họ và Tên", typeof(string));
        dt.Columns.Add("Ngày sinh", typeof(DateTime));
        dt.Columns.Add("GT", typeof(string));
        dt.Columns.Add("Địa chỉ", typeof(string));
        dt.Columns.Add("Số đt", typeof(string));
        dt.Columns.Add("Email", typeof(string));
        dt.Columns.Add("Mã phòng ban", typeof(int));
        dt.Columns.Add("Tên PB", typeof(string));
        dt.Columns.Add("Mã chức vụ", typeof(int));
        dt.Columns.Add("Tên Chức vụ", typeof(string));
        dt.Columns.Add("Ngày TD", typeof(DateTime));
        dt.Columns.Add("Thử việc", typeof(bool));
        dt.Columns.Add("Nghỉ", typeof(bool));
        dt.Columns.Add("Mật khẩu", typeof(string));

        foreach (var p in tps)
        {
            dt.Rows.Add(
                p.EmployeeID,
                p.FullName,
                p.BirthDate,
                p.Gender,
                p.Address,
                p.Phone,
                p.Email,
                p.DepartmentID,
                p.Department?.DepartmentName,
                p.PositionID,
                p.Position?.PositionName,
                p.HireDate,
                p.IsProbation,
                p.IsFired,
                p.Password
            );
        }

        return dt;
    }
    public List<Employee> GetAllEmployeesEF()
    {
        using (var context = new CompanyHRManagementEntities())
        {
            return context.Employees
                .AsEnumerable()
                .Select(e => new Employee
                {
                    EmployeeID = e.EmployeeID,
                    FullName = e.FullName,
                    BirthDate = e.BirthDate ?? DateTime.MinValue,
                    Gender = e.Gender ?? "",
                    Address = e.Address ?? "",
                    Phone = e.Phone ?? "",
                    Email = e.Email ?? "",
                    DepartmentID = e.DepartmentID ?? 0,
                    PositionID = e.PositionID ?? 0,
                    HireDate = e.HireDate ?? DateTime.MinValue,
                    IsProbation = e.IsProbation,
                    IsFired = e.IsFired,
                    Password = e.Password ?? ""
                })
                .ToList();
        }
    }
    public bool InsertEmployee(Employee emp)
    {
        using (var context = new CompanyHRManagementEntities())
        {
            var newEmployee = new Employee
            {
                FullName = emp.FullName,
                BirthDate = emp.BirthDate,
                Gender = emp.Gender,
                Address = emp.Address,
                Phone = emp.Phone,
                Email = emp.Email,
                DepartmentID = emp.DepartmentID,
                PositionID = emp.PositionID,
                HireDate = emp.HireDate,
                IsProbation = emp.IsProbation,
                IsFired = emp.IsFired,
                Password = emp.Password
            };

            context.Employees.Add(newEmployee);
            int rowsAffected = context.SaveChanges();
            return rowsAffected > 0;
        }
    }
    public bool DeleteEmployee(int empID)
    {
        using (var context = new CompanyHRManagementEntities())
        {
            var employeeToDelete = context.Employees.Find(empID);
            if (employeeToDelete != null)
            {
                context.Employees.Remove(employeeToDelete);
                int rowsAffected = context.SaveChanges();
                return rowsAffected > 0;
            }
            return false;
        }
    }
    public bool UpdateEmployee(Employee emp)
    {
        using (var context = new CompanyHRManagementEntities())
        {
            var employeeToUpdate = context.Employees.Find(emp.EmployeeID);
            if (employeeToUpdate != null)
            {
                employeeToUpdate.FullName = emp.FullName;
                employeeToUpdate.BirthDate = emp.BirthDate;
                employeeToUpdate.Gender = emp.Gender;
                employeeToUpdate.Address = emp.Address;
                employeeToUpdate.Phone = emp.Phone;
                employeeToUpdate.Email = emp.Email;
                employeeToUpdate.DepartmentID = emp.DepartmentID;
                employeeToUpdate.PositionID = emp.PositionID;
                employeeToUpdate.HireDate = emp.HireDate;
                employeeToUpdate.IsProbation = emp.IsProbation;
                employeeToUpdate.IsFired = emp.IsFired;
                employeeToUpdate.Password = emp.Password;

                int rowsAffected = context.SaveChanges();
                return rowsAffected > 0;
            }
            return false;
        }
    }
    public Employee LayDuLieuNhanVienQuaEmail(string email)
    {
        using (var context = new CompanyHRManagementEntities())
        {
            var employee = context.Employees.FirstOrDefault(e => e.Email == email);
            return employee;
        }
    }

    // -- fotgot password  -- 
    public string GetEmailByEmail(string email)
    {
        using (var context = new CompanyHRManagementEntities())
        {
            var employee = context.Employees.FirstOrDefault(e => e.Email == email);
            return employee?.Email;
        }
    }

    public bool UpdatePassword(string email, string newPassword)
    {
        using (var context = new CompanyHRManagementEntities())
        {
            var employee = context.Employees.FirstOrDefault(e => e.Email == email);
            if (employee == null)
                return false;

            employee.Password = newPassword;
            context.SaveChanges();
            return true;
        }
    }

    // chart admin 
    public List<Employee> GetEmployeeStatus()
    {
        using (var context = new CompanyHRManagementEntities())
        {
            var result = context.Employees
                .Select(e => new
                {
                    TrangThai = e.IsFired == true ? "Nghỉ việc" :
                                e.IsProbation == true ? "Thử việc" : "Đang làm việc"
                })
                .GroupBy(e => e.TrangThai)
                .Select(g => new Employee
                {
                    Status = g.Key,
                    Count = g.Count()
                })
                .ToList();

            return result;
        }
    }


}
