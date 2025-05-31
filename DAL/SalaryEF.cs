using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using CompanyHRManagement;
using CompanyHRManagement.DTO;

public class SalaryEF
{
    public decimal TinhTongLuongTheoThangNam(int employeeId, int month, int year)
    {
        using (var context = new CompanyHRManagementEntities()) // hoặc tên DbContext của bạn
        {
            var total = context.Salaries
                .Where(s => s.EmployeeID == employeeId && s.SalaryMonth == month && s.SalaryYear == year)
                .Select(s => s.BaseSalary + s.Allowance + s.Bonus - s.Penalty + (s.OvertimeHours * 50000))
                .DefaultIfEmpty(0)
                .Sum();

            return (decimal)total;
        }
    }

    /// Lấy thông tin lương của một nhân viên (theo employeeId),
    /// bao gồm mã lương, mã NV, tên NV, lương cơ bản, phụ cấp, thưởng,
    /// phạt, giờ tăng ca, tháng, năm, tổng lương.
    /// Trả về DataTable để binding lên DataGridView hoặc xuất báo cáo.
    /// </summary>
    public DataTable LayLuongTheoNhanVien(int employeeId)
    {
        using (var context = new CompanyHRManagementEntities())
        {
            // 1) Query LINQ to Entities: join bảng Salaries và Employees, có thêm điều kiện WHERE để lọc theo employeeId
            var query = from s in context.Salaries
                        join emp in context.Employees
                          on s.EmployeeID equals emp.EmployeeID
                        where s.EmployeeID == employeeId   // Thêm điều kiện lọc
                        select new
                        {
                            SalaryID = s.SalaryID,
                            EmployeeID = s.EmployeeID,
                            EmployeeName = emp.FullName,
                            BaseSalary = s.BaseSalary ?? 0m,
                            Allowance = s.Allowance ?? 0m,
                            Bonus = s.Bonus ?? 0m,
                            Penalty = s.Penalty ?? 0m,
                            OvertimeHours = s.OvertimeHours ?? 0,
                            SalaryMonth = s.SalaryMonth ?? 0,
                            SalaryYear = s.SalaryYear ?? 0,
                            TotalSalary = (s.BaseSalary ?? 0m)
                                          + (s.Allowance ?? 0m)
                                          + (s.Bonus ?? 0m)
                                          - (s.Penalty ?? 0m)
                        };

            // 2) Tạo DataTable và thêm các cột tương ứng
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã lương", typeof(int));
            dt.Columns.Add("Mã nhân viên", typeof(int));
            dt.Columns.Add("Tên nhân viên", typeof(string));
            dt.Columns.Add("Lương cơ bản", typeof(decimal));
            dt.Columns.Add("Phụ cấp", typeof(decimal));
            dt.Columns.Add("Thưởng", typeof(decimal));
            dt.Columns.Add("Phạt", typeof(decimal));
            dt.Columns.Add("Giờ tăng ca", typeof(int));
            dt.Columns.Add("Tháng", typeof(int));
            dt.Columns.Add("Năm", typeof(int));
            dt.Columns.Add("Tổng lương", typeof(decimal));

            // 3) Đổ dữ liệu từ query vào DataTable
            foreach (var item in query)
            {
                dt.Rows.Add(
                    item.SalaryID,
                    item.EmployeeID,
                    item.EmployeeName,
                    item.BaseSalary,
                    item.Allowance,
                    item.Bonus,
                    item.Penalty,
                    item.OvertimeHours,
                    item.SalaryMonth,
                    item.SalaryYear,
                    item.TotalSalary
                );
            }

            return dt;
        }
    }
    public List<SalaryDTO> LayTatCaThongTinLuong_Admin()
    {
        using (var context = new CompanyHRManagementEntities())
        {
            var list = (from s in context.Salaries
                        join e in context.Employees on s.EmployeeID equals e.EmployeeID
                        select new SalaryDTO
                        {
                            SalaryID = s.SalaryID,
                            EmployeeID = (int)s.EmployeeID,
                            FullName = e.FullName,
                            BaseSalary = (decimal)s.BaseSalary,
                            Allowance = (decimal)s.Allowance,
                            Bonus = (decimal)s.Bonus,
                            Penalty = (decimal)s.Penalty,
                            OvertimeHours = (int)s.OvertimeHours,
                            SalaryMonth = (int)s.SalaryMonth,
                            SalaryYear = (int)s.SalaryYear
                        }).ToList();

            return list;
        }
    }
    public DataTable GetAllSalaries(int month, int year)
    {
        using (var context = new CompanyHRManagementEntities())
        {
            var query = from e in context.Employees
                        where e.IsFired == false
                        join s in context.Salaries
                        .Where(s => s.SalaryMonth == month && s.SalaryYear == year)
                        on e.EmployeeID equals s.EmployeeID into salGroup
                        from sal in salGroup.DefaultIfEmpty()
                        select new SalaryDTO
                        {
                            SalaryID = sal != null ? sal.SalaryID : 0,
                            EmployeeID = e.EmployeeID,
                            FullName = e.FullName,
                            SalaryMonth = (int)(sal != null ? sal.SalaryMonth : month),
                            SalaryYear = (int)(sal != null ? sal.SalaryYear : year),
                            BaseSalary = (int)(sal != null ? sal.BaseSalary : 0),
                            Allowance = (decimal)(sal != null ? sal.Allowance : 0),
                            Bonus = (decimal)(sal != null ? sal.Bonus : 0),
                            Penalty = (decimal)(sal != null ? sal.Penalty : 0),
                            OvertimeHours = (int)(sal != null ? sal.OvertimeHours : 0),
                        };

            var list = query.ToList();

            // Chuyển List<SalaryDTO> sang DataTable
            return ConvertToDataTable(list);
        }
    }

    // Hàm tiện ích chuyển List<T> thành DataTable
    private DataTable ConvertToDataTable<T>(List<T> items)
    {
        var dt = new DataTable(typeof(T).Name);

        // Lấy tất cả properties của T
        var props = typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

        foreach (var prop in props)
        {
            // Thêm cột DataTable tương ứng
            dt.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
        }

        foreach (var item in items)
        {
            var values = new object[props.Length];
            for (int i = 0; i < props.Length; i++)
            {
                values[i] = props[i].GetValue(item, null) ?? DBNull.Value;
            }
            dt.Rows.Add(values);
        }

        return dt;
    }




    //Cập nhật thông tin trong bảng lương theo các bảng
    public bool UpdateSalaries()
    {
        string errorMessage = string.Empty;

        try
        {
            using (var context = new CompanyHRManagementEntities())
            {
                var salaries = context.Salaries.ToList();

                foreach (var salary in salaries)
                {
                    // Lấy base salary từ Position của nhân viên

                    var employee = context.Employees
                     .Include("Position")
                     .FirstOrDefault(e => e.EmployeeID == salary.EmployeeID);


                    salary.BaseSalary = employee?.Position?.BaseSalary ?? 0;

                    // Tổng thưởng theo tháng/năm
                    salary.Bonus = context.Rewards
                        .Where(r => r.EmployeeID == salary.EmployeeID &&
                                    r.RewardDate.Value.Year == salary.SalaryYear &&
                                    r.RewardDate.Value.Month == salary.SalaryMonth)
                        .Sum(r => (decimal?)r.Amount) ?? 0;

                    // Tổng phạt theo tháng/năm
                    salary.Penalty = context.Disciplines
                        .Where(d => d.EmployeeID == salary.EmployeeID &&
                                    d.DisciplineDate.Value.Year == salary.SalaryYear &&
                                    d.DisciplineDate.Value.Month == salary.SalaryMonth)
                        .Sum(d => (decimal?)d.Amount) ?? 0;

                    // Tổng giờ làm thêm theo tháng/năm
                    salary.OvertimeHours = context.Attendances
                        .Where(a => a.EmployeeID == salary.EmployeeID &&
                                    a.WorkDate.Value.Year == salary.SalaryYear &&
                                    a.WorkDate.Value.Month == salary.SalaryMonth)
                        .Sum(a => (int?)a.OvertimeHours) ?? 0;
                }

                context.SaveChanges();
                return true;
            }
        }
        catch (Exception ex)
        {
            errorMessage = ex.Message;
            return false;
        }
    }


    //Xóa các bản ghi trùng lặp
    public bool DeleteDuplicateSalariesKeepFirst()
    {
        string errorMessage = string.Empty;

        try
        {
            using (var context = new CompanyHRManagementEntities()) // hoặc DbContext của bạn
            {
                // Nhóm theo EmployeeID, SalaryMonth, SalaryYear
                var duplicates = context.Salaries
                    .GroupBy(s => new { s.EmployeeID, s.SalaryMonth, s.SalaryYear })
                    .Where(g => g.Count() > 1)
                    .ToList();

                foreach (var group in duplicates)
                {
                    // Giữ bản ghi đầu tiên (theo SalaryID nhỏ nhất), xóa các bản ghi còn lại
                    var salariesToDelete = group
                        .OrderBy(s => s.SalaryID)
                        .Skip(1) // Bỏ qua bản ghi đầu tiên
                        .ToList();

                    context.Salaries.RemoveRange(salariesToDelete);
                }

                context.SaveChanges();
                return true;
            }
        }
        catch (Exception ex)
        {
            errorMessage = ex.Message;
            return false;
        }
    }


    //Trả về danh sách các năm có trong bảng
    public List<int> GetDistinctSalaryYears()
    {
        using (var context = new CompanyHRManagementEntities())
        {
            var distinctYears = context.Salaries
                .Select(s => s.SalaryYear)
                .Where(y => y.HasValue)
                .Select(y => y.Value)
                .Distinct()
                .OrderByDescending(y => y)
                .ToList();

            return distinctYears;
        }
    }
    //Hàm Lọc + Tìm kiếm
    public List<SalaryDTO> SearchSalaries(
    int? salaryID,
    string fullName,
    decimal? baseSalary,
    decimal? allowance,
    decimal? bonus,
    decimal? penalty,
    int? overtimeHours,
    string salaryMonthStr,
    string salaryYearStr,
    string departmentName,
    string positionName)
    {
        using (var context = new CompanyHRManagementEntities())
        {
            int? salaryMonth = null;
            if (!string.IsNullOrEmpty(salaryMonthStr) && salaryMonthStr != "Tất cả" && int.TryParse(salaryMonthStr, out int m))
                salaryMonth = m;

            int? salaryYear = null;
            if (!string.IsNullOrEmpty(salaryYearStr) && salaryYearStr != "Tất cả" && int.TryParse(salaryYearStr, out int y))
                salaryYear = y;

            if (!string.IsNullOrEmpty(departmentName) && departmentName == "Tất cả")
                departmentName = null;

            if (!string.IsNullOrEmpty(positionName) && positionName == "Tất cả")
                positionName = null;

            var query = context.Salaries.AsQueryable();

            if (salaryID.HasValue)
                query = query.Where(s => s.SalaryID == salaryID.Value);

            if (!string.IsNullOrEmpty(fullName))
                query = query.Where(s => s.Employee.FullName.Contains(fullName));

            if (baseSalary.HasValue)
                query = query.Where(s => s.BaseSalary == baseSalary.Value);

            if (allowance.HasValue)
                query = query.Where(s => s.Allowance == allowance.Value);

            if (bonus.HasValue)
                query = query.Where(s => s.Bonus == bonus.Value);

            if (penalty.HasValue)
                query = query.Where(s => s.Penalty == penalty.Value);

            if (overtimeHours.HasValue)
                query = query.Where(s => s.OvertimeHours == overtimeHours.Value);

            if (salaryMonth.HasValue)
                query = query.Where(s => s.SalaryMonth == salaryMonth.Value);

            if (salaryYear.HasValue)
                query = query.Where(s => s.SalaryYear == salaryYear.Value);

            if (!string.IsNullOrEmpty(departmentName))
                query = query.Where(s => s.Employee.Department.DepartmentName.Contains(departmentName));

            if (!string.IsNullOrEmpty(positionName))
                query = query.Where(s => s.Employee.Position.PositionName.Contains(positionName));

            var list = query
                .Select(s => new SalaryDTO
                {
                    SalaryID = s.SalaryID,
                    EmployeeID = (int)s.EmployeeID,
                    FullName = s.Employee.FullName,
                    BaseSalary = (decimal)s.BaseSalary,
                    Allowance = (decimal)s.Allowance,
                    Bonus = (decimal)s.Bonus,
                    Penalty = (decimal)s.Penalty,
                    OvertimeHours = (int)s.OvertimeHours,
                    SalaryMonth = (int)s.SalaryMonth,
                    SalaryYear = (int)s.SalaryYear
                })
                .ToList();

            return list;
        }
    }


    public bool InsertSalary(string employeeName, int month, int year,
    decimal allowance, decimal bonus, decimal penalty, int overtimeHours, ref string error)
    {
        try
        {
            using (var context = new CompanyHRManagementEntities())
            {
                // Lấy Employee theo tên
                var employee = context.Employees
                    .Include("Position")    // Include nhận string chứ không phải lambda
                    .FirstOrDefault(e => e.FullName == employeeName);

                if (employee == null)
                {
                    error = "Tên nhân viên không tồn tại.";
                    return false;
                }

                if (employee.Position == null)
                {
                    error = "Nhân viên không có chức vụ hoặc không tìm thấy lương cơ bản.";
                    return false;
                }

                decimal baseSalary = employee.Position.BaseSalary;

                // Tạo đối tượng Salary mới
                CompanyHRManagement.Salary newSalary = new CompanyHRManagement.Salary
                {
                    EmployeeID = employee.EmployeeID,
                    BaseSalary = baseSalary,
                    Allowance = allowance,
                    Bonus = bonus,
                    Penalty = penalty,
                    OvertimeHours = overtimeHours,
                    SalaryMonth = month,
                    SalaryYear = year
                };

                // Thêm vào DbSet và lưu thay đổi
                context.Salaries.Add(newSalary);
                context.SaveChanges();

                return true;
            }
        }
        catch (Exception ex)
        {
            error = ex.Message;
            return false;
        }
    }


    public bool DeleteSalariesByIDs(List<int> salaryIDs, ref string error)
    {
        if (salaryIDs == null || salaryIDs.Count == 0)
        {
            error = "Danh sách ID không hợp lệ.";
            return false;
        }

        try
        {
            using (var context = new CompanyHRManagementEntities())
            {
                // Lấy các bản ghi Salary có trong danh sách ID
                var salariesToDelete = context.Salaries
                    .Where(s => salaryIDs.Contains(s.SalaryID))
                    .ToList();

                if (salariesToDelete.Count == 0)
                {
                    error = "Không tìm thấy bản ghi nào để xóa.";
                    return false;
                }

                context.Salaries.RemoveRange(salariesToDelete);
                context.SaveChanges();

                return true;
            }
        }
        catch (Exception ex)
        {
            error = ex.Message;
            return false;
        }
    }

    public bool UpdateSalaryByID(int salaryID, string fullName, decimal allowance, int month, int year, ref string error)
    {
        try
        {
            using (var context = new CompanyHRManagementEntities())
            {
                // Lấy Employee theo tên
                var employee = context.Employees.FirstOrDefault(e => e.FullName == fullName);
                if (employee == null)
                {
                    error = "Tên nhân viên không tồn tại.";
                    return false;
                }

                // Lấy Salary cần update
                var salary = context.Salaries.FirstOrDefault(s => s.SalaryID == salaryID);
                if (salary == null)
                {
                    error = "Bảng lương không tồn tại.";
                    return false;
                }

                // Cập nhật thông tin
                salary.EmployeeID = employee.EmployeeID;
                salary.Allowance = allowance;
                salary.SalaryMonth = month;
                salary.SalaryYear = year;

                context.SaveChanges();
                return true;
            }
        }
        catch (Exception ex)
        {
            error = ex.Message;
            return false;
        }
    }

}
