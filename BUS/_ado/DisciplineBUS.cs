using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class DisciplineBUS
{
    private DisciplineDAO disciplineDAO = new DisciplineDAO();

    public List<Discipline> LayDanhSachPhatTheoNhanVien(int employeeId)
    {
        return disciplineDAO.GetDisciplinesByEmployeeId(employeeId);
    }

    public List<Discipline> LayDanhSachPhat() {
        return disciplineDAO.GetDisciplinesWithEmployeeName();
    }

    public List<Discipline> TimKiemPhat(
        string disciplineID, string fullName, string reason,
        string day, string month, string year, string amount)
    {
        return disciplineDAO.SearchDisciplines(disciplineID, fullName, reason, day, month, year, amount);
    }

    public bool Themphat(string fullName, string reason, string dayStr, string monthStr, string yearStr, decimal amount, ref string error)
    {
        if (string.IsNullOrWhiteSpace(fullName))
        {
            error = "Tên nhân viên không được để trống.";
            return false;
        }

        if (amount < 0)
        {
            error = "Số tiền phạt không hợp lệ.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(reason))
        {
            reason = "Không ghi rõ lý do.";
        }

        if (!int.TryParse(dayStr, out int day) || !int.TryParse(monthStr, out int month) || !int.TryParse(yearStr, out int year))
        {
            error = "Ngày, tháng hoặc năm không hợp lệ.";
            return false;
        }

        DateTime disciplineDate;
        try
        {
            disciplineDate = new DateTime(year, month, day);
        }
        catch
        {
            error = "Ngày tháng năm không tồn tại.";
            return false;
        }

        return disciplineDAO.InsertDiscipline(fullName, reason, disciplineDate, amount, ref error);
    }

    public bool xoaPhat(List<int> rewardIDs, ref string error)
    {
        return disciplineDAO.DeleteDisciplinesByIDs(rewardIDs, ref error);
    }

    public bool CapNhatDiscipline(string disciplineIDStr, string fullName, string reason, string dayStr, string monthStr, string yearStr, decimal amount, ref string error)
    {
        // Ép kiểu DisciplineID
        if (!int.TryParse(disciplineIDStr.Trim(), out int disciplineID))
        {
            error = "DisciplineID không hợp lệ.";
            return false;
        }

        // Ép kiểu ngày tháng năm
        if (!int.TryParse(dayStr.Trim(), out int day) ||
            !int.TryParse(monthStr.Trim(), out int month) ||
            !int.TryParse(yearStr.Trim(), out int year))
        {
            error = "Ngày / tháng / năm không hợp lệ.";
            return false;
        }

        
        // Tạo DateTime
        DateTime disciplineDate;
        try
        {
            disciplineDate = new DateTime(year, month, day);
        }
        catch
        {
            error = "Giá trị ngày tháng không hợp lệ.";
            return false;
        }

        return disciplineDAO.UpdateDisciplineByID(disciplineID, fullName, reason, disciplineDate, amount, ref error);
    }
}
