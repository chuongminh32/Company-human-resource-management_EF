using System;

public class Attendance
{
    public int AttendanceID { get; set; }
    public int EmployeeID { get; set; }
    public DateTime WorkDate { get; set; }  // Lưu trữ ngày làm việc
    public TimeSpan? CheckIn { get; set; }  // Kiểu TimeSpan? để lưu trữ giờ vào
    public TimeSpan? CheckOut { get; set; } // Kiểu TimeSpan? để lưu trữ giờ ra
    public int OvertimeHours { get; set; }
    public string AbsenceStatus { get; set; }
    public string MonthYear { get; set; }
    public int WorkDays { get; set; }

}
