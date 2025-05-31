using System;
using System.Collections.Generic;
using System.Web.UI;

public class AttendanceBUS
{

    private AttendanceDAO attendanceDAO = new AttendanceDAO();

    public List<Attendance> LayDuLieuChamCongQuaID(int employeeID)
    {
        return attendanceDAO.LayDuLieuChamCongQuaID(employeeID);
    }

    public int laySoNgayCongTrongThangHienTaiTheoID(int employeeID)
    {
        return attendanceDAO.laySoNgayCongTrongThangHienTaiTheoID(employeeID);
    }

    public Attendance KiemTraCongHomNay(int employeeId, DateTime workDate)
    {
        return attendanceDAO.KiemTraCongHomNay(employeeId, workDate);
    }

    public bool themCong(Attendance attendance)
    {
        return attendanceDAO.themCong(attendance);
    }

    public bool capNhatCong(Attendance attendance)
    {
        return attendanceDAO.capNhatCong(attendance);
    }

    public string ChamCong(int employeeId)
    {
        var today = DateTime.Today;
        var now = DateTime.Now.TimeOfDay;

        var ngayCongHomNay = attendanceDAO.KiemTraCongHomNay(employeeId, today);

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

            attendanceDAO.themCong(newAttendance);
            return " Đã chấm công (Check-in) thành công!";
        }
        else if (ngayCongHomNay.CheckOut == null)
        {
            // Đã check-in, cập nhật check-out
            ngayCongHomNay.CheckOut = now;

            TimeSpan duration = now - ngayCongHomNay.CheckIn.GetValueOrDefault();
            ngayCongHomNay.OvertimeHours = (int)Math.Max(0, duration.TotalHours - 8);

            attendanceDAO.capNhatCong(ngayCongHomNay);
            return " Đã cập nhật giờ ra (Check-out)!";
        }
        else
        {
            return " Bạn đã chấm công xong hôm nay.";
        }
    }

    public double layTongGioLamTrongThangHienTaiTheoID(int emID)
    {
        return attendanceDAO.TinhTongGioLamTrongThang(emID);
    }

    public List<Attendance> GetAttendanceByMonth()
    {
        return attendanceDAO.GetMonthlyWorkDays();
    }
}
