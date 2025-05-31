using CompanyHRManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;

public class AttendanceBUS
{
    AttendanceEF a = new AttendanceEF();

    // --  User -- 
    public List<Attendance> LayDuLieuChamCongQuaID(int employeeID)
    {
        return a.LayDuLieuChamCongQuaID(employeeID);
    }
    public double layTongGioLamTrongThangHienTaiTheoID(int emID)
    {
        return a.TinhTongGioLamTrongThang(emID);
    }
    public int laySoNgayCongTrongThangHienTaiTheoID(int employeeID)
    {
        return a.laySoNgayCongTrongThangHienTaiTheoID(employeeID);
    }
    public string ChamCong(int employeeId)
    {
        var today = DateTime.Today;
        var now = DateTime.Now.TimeOfDay;

        var ngayCongHomNay = a.KiemTraCongHomNay(employeeId, today);

        if (ngayCongHomNay == null)
        {
            // Chưa check-in
            var newAttendance = new Attendance()
            {
                EmployeeID = employeeId,
                WorkDate = today,
                CheckIn = now,
                CheckOut = null,
                AbsenceStatus = "present",
                OvertimeHours = 0
            };

            a.themCong(newAttendance);
            return " Đã chấm công (Check-in) thành công!";
        }
        else if (ngayCongHomNay.CheckOut == null)
        {
            // Đã check-in, cập nhật check-out
            ngayCongHomNay.CheckOut = now;

            TimeSpan duration = now - ngayCongHomNay.CheckIn.GetValueOrDefault();
            ngayCongHomNay.OvertimeHours = (int)Math.Max(0, duration.TotalHours - 8);

            a.capNhatCong(ngayCongHomNay);
            return " Đã cập nhật giờ ra (Check-out)!";
        }
        else
        {
            return " Bạn đã chấm công xong hôm nay.";
        }
    }




    // -- Admin --
    public DataTable GetAttendanceEF()
    {
        return a.GetAttendanceEF();
    }
    public bool AddAttendance(int AttendanceID, int EmployeeID, DateTime WorkDate, TimeSpan CheckIn, TimeSpan CheckOut, string AbsenceStatus, ref string err)
    {
        return a.AddAttendance(AttendanceID, EmployeeID, WorkDate, CheckIn, CheckOut, AbsenceStatus, ref err);

    }
    public bool DeleteAttendance(ref string err, int AttendanceID)
    {
        return a.DeleteAttendance(ref err, AttendanceID);
    }
    public bool UpdateAttendance(DataTable changedData, ref string err)
    {
        return a.UpdateAttendance(changedData, ref err);
    }
    public List<DateTime> GetWorkDates()
    {
        return a.GetWorkDates();
    }

    public (int tongNV, double tongNCtb, double OTtong) CalculateSummary(DateTime selectedDate)
    {
        return a.CalculateSummary(selectedDate);
    }

    public List<Attendance> GetAttendanceByMonth()
    {
        return a.GetMonthlyWorkDays();
    }
}
