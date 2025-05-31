using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using CompanyHRManagement;
using CompanyHRManagement.DTO;

public class DisciplineEF
{
    private CompanyHRManagementEntities context = new CompanyHRManagementEntities();
    DBConnection db = new DBConnection();
    /// <summary>
    /// Lấy danh sách kỷ luật của một nhân viên (employeeId), trả về DataTable.
    /// DataTable sẽ có các cột: Mã kỷ luật, Mã nhân viên, Tên nhân viên, Lý do, Ngày kỷ luật, Số tiền phạt.
    /// </summary>
    public DataTable LayDanhSachPhatTheoNhanVien(int employeeId)
    {
        using (var context = new CompanyHRManagementEntities())
        {
            var query = from d in context.Disciplines
                        join emp in context.Employees
                          on d.EmployeeID equals emp.EmployeeID
                        where d.EmployeeID == employeeId
                        select new
                        {
                            DisciplineID = d.DisciplineID,
                            EmployeeID = d.EmployeeID,
                            EmployeeName = emp.FullName,
                            Reason = d.Reason,
                            DisciplineDate = d.DisciplineDate,
                            Amount = d.Amount ?? 0m
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã kỷ luật", typeof(int));
            dt.Columns.Add("Mã nhân viên", typeof(int));
            dt.Columns.Add("Tên nhân viên", typeof(string));
            dt.Columns.Add("Lý do", typeof(string));
            dt.Columns.Add("Ngày kỷ luật", typeof(DateTime));
            dt.Columns.Add("Số tiền phạt", typeof(decimal));

            foreach (var item in query)
            {
                dt.Rows.Add(
                    item.DisciplineID,
                    item.EmployeeID,
                    item.EmployeeName,
                    item.Reason,
                    item.DisciplineDate,
                    item.Amount
                );
            }

            return dt;
        }
    }

    public List<DisciplineDTO> GetDisciplinesWithEmployeeName()
    {
        return context.Disciplines
            .Include("Employee")
            .Select(d => new DisciplineDTO
            {
                DisciplineID = d.DisciplineID,
                EmployeeID = (int)d.EmployeeID,
                FullName = d.Employee.FullName,
                Reason = d.Reason,
                DisciplineDate = (DateTime)d.DisciplineDate,
                Amount = (decimal)d.Amount
            })
            .ToList();
    }
    //Tìm kiếm
    public List<DisciplineDTO> SearchDisciplines(string disciplineID, string fullName, string reason,
        string day, string month, string year, string amount)
    {
        var query = context.Disciplines.Include("Employee").AsQueryable();

        if (!string.IsNullOrWhiteSpace(disciplineID))
        {
            int id;
            if (int.TryParse(disciplineID, out id))
                query = query.Where(d => d.DisciplineID == id);
        }

        if (!string.IsNullOrWhiteSpace(fullName))
            query = query.Where(d => d.Employee.FullName.Contains(fullName));

        if (!string.IsNullOrWhiteSpace(reason))
            query = query.Where(d => d.Reason.Contains(reason));

        if (int.TryParse(day, out int dDay))
            query = query.Where(d => d.DisciplineDate.Value.Day == dDay);

        if (int.TryParse(month, out int dMonth))
            query = query.Where(d => d.DisciplineDate.Value.Month == dMonth);

        if (int.TryParse(year, out int dYear))
            query = query.Where(d => d.DisciplineDate.Value.Year == dYear);

        if (!string.IsNullOrWhiteSpace(amount) && decimal.TryParse(amount, out decimal amt))
            query = query.Where(d => d.Amount == amt);

        return query.Select(d => new DisciplineDTO
        {
            DisciplineID = d.DisciplineID,
            EmployeeID = (int)d.EmployeeID,
            FullName = d.Employee.FullName,
            Reason = d.Reason,
            DisciplineDate = (DateTime)d.DisciplineDate,
            Amount = (decimal)d.Amount
        }).ToList();
    }

    //Thêm phạt
    public bool InsertDiscipline(string fullName, string reason, DateTime disciplineDate, decimal amount, ref string error)
    {
        var employee = context.Employees.FirstOrDefault(e => e.FullName == fullName);
        if (employee == null)
        {
            error = "Không tìm thấy nhân viên.";
            return false;
        }

        var discipline = new Discipline
        {
            EmployeeID = employee.EmployeeID,
            Reason = reason,
            DisciplineDate = disciplineDate,
            Amount = amount
        };

        context.Disciplines.Add(discipline);
        context.SaveChanges();
        return true;
    }


    public bool UpdateDisciplineByID(int disciplineID, string fullName, string reason, DateTime disciplineDate, decimal amount, ref string error)
    {
        var discipline = context.Disciplines.FirstOrDefault(d => d.DisciplineID == disciplineID);
        if (discipline == null)
        {
            error = "Không tìm thấy bản ghi.";
            return false;
        }

        var employee = context.Employees.FirstOrDefault(e => e.FullName == fullName);
        if (employee == null)
        {
            error = "Không tìm thấy nhân viên.";
            return false;
        }

        discipline.EmployeeID = employee.EmployeeID;
        discipline.Reason = reason;
        discipline.DisciplineDate = disciplineDate;
        discipline.Amount = amount;

        context.SaveChanges();
        return true;
    }

    public bool DeleteDisciplinesByIDs(List<int> disciplineIDs, ref string error)
    {
        var disciplinesToRemove = context.Disciplines.Where(d => disciplineIDs.Contains(d.DisciplineID)).ToList();
        if (disciplinesToRemove.Count == 0)
        {
            error = "Không tìm thấy bản ghi để xóa.";
            return false;
        }

        context.Disciplines.RemoveRange(disciplinesToRemove);
        context.SaveChanges();
        return true;
    }
}
