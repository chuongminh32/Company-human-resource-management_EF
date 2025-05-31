using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using CompanyHRManagement;
using static System.ComponentModel.Design.ObjectSelectorEditor;

public class AttendanceEF
{

    // -- User -- 
    public List<Attendance> LayDuLieuChamCongQuaID(int employeeID)
    {
        using (var context = new CompanyHRManagementEntities())
        {
            return context.Attendances
                .Where(a => a.EmployeeID == employeeID)
                .ToList();
        }
    }

    public int laySoNgayCongTrongThangHienTaiTheoID(int employeeID)
    {
        using (var context = new CompanyHRManagementEntities())
        {
            var today = DateTime.Today;
            int month = today.Month;
            int year = today.Year;

            // Đếm số ngày công (WorkDate) khác nhau trong tháng hiện tại
            int daysWorked = context.Attendances
                 .Where(a => a.EmployeeID == employeeID
                             && a.WorkDate.HasValue
                             && a.WorkDate.Value.Month == month
                             && a.WorkDate.Value.Year == year
                             && a.CheckIn != null
                             && a.CheckOut != null)
                 .Select(a => a.WorkDate.Value.Date)
                 .Distinct()
                 .Count();

            return daysWorked;
        }
    }

    public double TinhTongGioLamTrongThang(int employeeId)
    {
        double tongGioLam = 0;

        DateTime ngayDauThang = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
        DateTime ngayCuoiThang = ngayDauThang.AddMonths(1).AddDays(-1);

        using (var context = new CompanyHRManagementEntities())
        {
            // Lấy danh sách attendance hợp lệ trong tháng
            var attendances = context.Attendances
                .Where(a => a.EmployeeID == employeeId
                         && a.WorkDate.HasValue
                         && a.WorkDate.Value.Date >= ngayDauThang
                         && a.WorkDate.Value.Date <= ngayCuoiThang
                         && a.CheckIn != null
                         && a.CheckOut != null)
                .Select(a => new
                {
                    CheckIn = a.CheckIn.Value,
                    CheckOut = a.CheckOut.Value
                })
                .ToList();

            foreach (var att in attendances)
            {
                TimeSpan duration = att.CheckOut - att.CheckIn;
                tongGioLam += duration.TotalHours;
            }
        }

        return Math.Round(tongGioLam, 2);
    }

    // Kiểm tra công hôm nay của nhân viên theo ID và ngày làm việc
    public Attendance KiemTraCongHomNay(int idNhanVien, DateTime ngayLam)
    {
        using (var context = new CompanyHRManagementEntities())
        {
            // Lấy Attendance có EmployeeID và WorkDate đúng ngày (so sánh ngày không tính giờ)
            return context.Attendances
                .FirstOrDefault(a => a.EmployeeID == idNhanVien
                                  && a.WorkDate.HasValue
                                  && DbFunctions.TruncateTime(a.WorkDate) == ngayLam.Date);
        }
    }

    // Thêm công cho nhân viên
    public bool themCong(Attendance attendance)
    {
        using (var context = new CompanyHRManagementEntities())
        {
            context.Attendances.Add(attendance);
            return context.SaveChanges() > 0;
        }
    }

    // Cập nhật giờ ra và số giờ tăng ca
    public bool capNhatCong(Attendance attendance)
    {
        using (var context = new CompanyHRManagementEntities())
        {
            var att = context.Attendances.Find(attendance.AttendanceID);
            if (att == null)
                return false;

            att.CheckOut = attendance.CheckOut;
            att.OvertimeHours = attendance.OvertimeHours;

            return context.SaveChanges() > 0;
        }
    }





    // -- ----- Admin ------ --

    public DataTable GetAttendanceEF()
    {
        CompanyHRManagementEntities x = new CompanyHRManagementEntities();
        var tps =
                from p in x.Attendances
                select p;
        DataTable dt = new DataTable();
        dt.Columns.Add("Mã");
        dt.Columns.Add("Mã nhân viên");
        dt.Columns.Add("Tên Nhân viên");
        dt.Columns.Add("Ngày làm");
        dt.Columns.Add("Từ");
        dt.Columns.Add("Đến");
        dt.Columns.Add("Tăng ca");
        dt.Columns.Add("Trạng thái");

        foreach (var p in tps)
        {
            dt.Rows.Add(p.AttendanceID, p.EmployeeID, p.Employee.FullName, p.WorkDate, p.CheckIn, p.CheckOut, p.OvertimeHours, p.AbsenceStatus);
        }
        return dt;
    }
    public bool AddAttendance(int AttendanceID, int EmployeeID, DateTime WorkDate, TimeSpan CheckIn, TimeSpan CheckOut, string AbsenceStatus, ref string err)
    {
        CompanyHRManagementEntities x = new CompanyHRManagementEntities();

        Attendance a = new Attendance();
        a.AttendanceID = AttendanceID;
        a.EmployeeID = EmployeeID;
        a.WorkDate = WorkDate;
        a.CheckIn = CheckIn;
        a.CheckOut = CheckOut;
        a.AbsenceStatus = AbsenceStatus;
        x.Attendances.Add(a);
        x.SaveChanges();

        return true;

    }
    public bool DeleteAttendance(ref string err, int AttendanceID)
    {
        CompanyHRManagementEntities x = new CompanyHRManagementEntities();
        Attendance a = new Attendance();
        a.AttendanceID = AttendanceID;
        x.Attendances.Attach(a);
        x.Attendances.Remove(a);
        x.SaveChanges();
        return true;
    }
    public bool UpdateAttendanceEF(int id, DateTime date, TimeSpan from, TimeSpan to, int overtime, string status, ref string err)
    {
        using (var context = new CompanyHRManagementEntities())
        {
            try
            {
                var record = context.Attendances.Find(id);
                if (record != null)
                {
                    record.WorkDate = date;
                    record.CheckIn = from;
                    record.CheckOut = to;
                    record.OvertimeHours = overtime;
                    record.AbsenceStatus = status;
                    context.SaveChanges();
                    return true;
                }
                err = "Không tìm thấy bản ghi.";
                return false;
            }
            catch (Exception ex)
            {
                err = "Lỗi khi cập nhật: " + ex.Message;
                return false;
            }
        }
    }

    public bool UpdateAttendances(DataTable changedData, ref string err)
    {
        using (var context = new CompanyHRManagementEntities())
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    foreach (DataRow row in changedData.Rows)
                    {
                        if (row.RowState == DataRowState.Modified)
                        {
                            int attendanceId = Convert.ToInt32(row["Mã"]);
                            var attendance = context.Attendances.Find(attendanceId);

                            if (attendance != null)
                            {
                                // Update properties from DataRow
                                attendance.EmployeeID = Convert.ToInt32(row["Mã nhân viên"]);
                                attendance.WorkDate = Convert.ToDateTime(row["Ngày làm"]);
                                attendance.CheckIn = TimeSpan.Parse(row["Từ"].ToString());
                                attendance.CheckOut = TimeSpan.Parse(row["Đến"].ToString());
                                attendance.AbsenceStatus = row["Trạng thái"].ToString();

                                // If you have OvertimeHours column
                                if (changedData.Columns.Contains("Tăng ca") && row["Tăng ca"] != DBNull.Value)
                                {
                                    attendance.OvertimeHours = Convert.ToInt32(row["Tăng ca"]);
                                }
                            }
                        }
                    }

                    context.SaveChanges();
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    err = ex.Message;
                    return false;
                }
            }
        }
    }
    public List<DateTime> GetWorkDates()
    {
        using (var x = new CompanyHRManagementEntities())
        {
            return x.Attendances
                .Where(a => a.WorkDate.HasValue)
                .Select(a => a.WorkDate.Value)
                .Distinct()
                .OrderByDescending(d => d)
                .ToList();
        }
    }

    public (int tongNV, double tongNCtb, double OTtong) CalculateSummary(DateTime selectedDate)
    {
        using (var x = new CompanyHRManagementEntities())
        {
            var attendances = x.Attendances
        .Where(a => a.WorkDate == selectedDate.Date
                && a.CheckIn.HasValue
                && a.CheckOut.HasValue)
        .ToList();

            int tongNV = attendances.Count;
            double tongNCtb = 0;
            double OTtong = 0;

            foreach (var a in attendances)
            {
                var duration = (a.CheckOut.Value - a.CheckIn.Value).TotalHours;
                tongNCtb += duration;

                OTtong += a.OvertimeHours.GetValueOrDefault();
            }

            return (tongNV, tongNV > 0 ? tongNCtb / tongNV : 0, OTtong);
        }
    }

    // chart admin dashboard
    public List<Attendance> GetMonthlyWorkDays()
    {
        using (var context = new CompanyHRManagementEntities())
        {
            var result = context.Attendances
                .Where(a => a.WorkDate.HasValue) // lọc ra các dòng có WorkDate
                .GroupBy(a => new { Month = a.WorkDate.Value.Month, Year = a.WorkDate.Value.Year })
                .OrderBy(g => g.Key.Year)
                .ThenBy(g => g.Key.Month)
                .Select(g => new Attendance
                {
                    MonthYear = g.Key.Month.ToString("D2") + "/" + g.Key.Year,
                    WorkDays = g.Select(x => x.WorkDate.Value.Date).Distinct().Count()
                })
                .ToList();

            return result;
        }
    }



}
