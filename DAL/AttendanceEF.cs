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
    /// <summary>
    /// Lấy danh sách chấm công (Attendance) của 1 nhân viên (employeeId),
    /// trả về dạng DataTable với các cột cần thiết để hiển thị trong DataGridView.
    /// Các cột sẽ là: "Mã Attendance", "Mã nhân viên", "Ngày làm việc", "CheckIn", "CheckOut", "Giờ tăng ca", "Trạng thái vắng mặt".
    /// (Nếu hiển thị thêm tên nhân viên, có thể join Employees để lấy emp.FullName rồi thêm cột "Tên nhân viên".)
    /// </summary>
    public DataTable LayDuLieuChamCongQuaID(int employeeId)
    {
        using (var context = new CompanyHRManagementEntities())
        {
            // 1) Tạo query để lấy các trường primitive cần hiển thị
            var query = from a in context.Attendances
                            // Nếu  muốn show tên NV, uncomment 2 dòng dưới:
                            // join emp in context.Employees on a.EmployeeID equals emp.EmployeeID
                            // where a.EmployeeID == employeeId && emp.EmployeeID == employeeId
                        where a.EmployeeID == employeeId
                        select new
                        {
                            AttendanceID = a.AttendanceID,
                            EmployeeID = a.EmployeeID,
                            WorkDate = a.WorkDate,       // kiểu DateTime?
                            CheckIn = a.CheckIn,        // TimeSpan?
                            CheckOut = a.CheckOut,       // TimeSpan?
                            OvertimeHours = a.OvertimeHours,   // int?
                            AbsenceStatus = a.AbsenceStatus    // string
                                                               // Nếu cần tên NV, thêm: EmployeeName = emp.FullName
                        };

            // 2) Khởi tạo DataTable và thêm cột tương ứng
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Attendance", typeof(int));
            dt.Columns.Add("Mã nhân viên", typeof(int));
            dt.Columns.Add("Ngày làm việc", typeof(DateTime));
            dt.Columns.Add("CheckIn", typeof(TimeSpan));
            dt.Columns.Add("CheckOut", typeof(TimeSpan));
            dt.Columns.Add("Giờ tăng ca", typeof(int));
            dt.Columns.Add("Trạng thái vắng", typeof(string));
            // Nếu có thêm tên NV: dt.Columns.Add("Tên nhân viên", typeof(string));

            // 3) Đổ dữ liệu vào DataTable
            foreach (var item in query)
            {
                // Chuyển các giá trị nullable về giá trị mặc định nếu null
                DateTime workDate = item.WorkDate ?? DateTime.MinValue;
                TimeSpan checkIn = item.CheckIn ?? TimeSpan.Zero;
                TimeSpan checkOut = item.CheckOut ?? TimeSpan.Zero;
                int overtimeHours = item.OvertimeHours ?? 0;
                string absenceStatus = item.AbsenceStatus ?? String.Empty;

                dt.Rows.Add(
                    item.AttendanceID,
                    item.EmployeeID,
                    workDate,
                    checkIn,
                    checkOut,
                    overtimeHours,
                    absenceStatus
                // Nếu thêm tên NV: item.EmployeeName
                );
            }

            return dt;
        }
    }



    public int LaySoNgayCongTrongThangHienTaiTheoID(int employeeID)
    {
        using (var context = new CompanyHRManagementEntities())
        {
            var today = DateTime.Today;
            int month = today.Month;
            int year = today.Year;

            // Đếm số ngày công (WorkDate) khác nhau trong tháng hiện tại,
            // chỉ tính những bản ghi có CheckIn và CheckOut khác null.
            int daysWorked = context.Attendances
                .Where(a =>
                    a.EmployeeID == employeeID &&
                    a.WorkDate.HasValue &&
                    a.WorkDate.Value.Month == month &&
                    a.WorkDate.Value.Year == year &&
                    a.CheckIn != null &&
                    a.CheckOut != null
                )
                // TruncateTime(a.WorkDate) trả về chỉ phần ngày (bỏ giờ), EF sẽ translate sang CONVERT(date, ...)
                .Select(a => DbFunctions.TruncateTime(a.WorkDate))
                .Distinct()
                .Count();

            return daysWorked;
        }
    }

    public double TinhTongGioLamTrongThang(int employeeId)
    {
        double tongGioLam = 0;

        // 1) Xác định ngày đầu và ngày cuối của tháng hiện tại
        DateTime today = DateTime.Today;
        DateTime ngayDauThang = new DateTime(today.Year, today.Month, 1);
        DateTime ngayCuoiThang = ngayDauThang.AddMonths(1).AddDays(-1);

        using (var context = new CompanyHRManagementEntities())
        {
            // 2) Lọc các attendance hợp lệ trong khoảng [ngayDauThang, ngayCuoiThang]
            //    → Đảm bảo WorkDate có giá trị và nằm trong tháng, cùng CheckIn/CheckOut không null
            var attendances = context.Attendances
                .Where(a =>
                    a.EmployeeID == employeeId &&
                    a.WorkDate.HasValue &&
                    // So sánh trực tiếp WorkDate với khoảng [ngayDauThang, ngayCuoiThang]
                    a.WorkDate.Value >= ngayDauThang &&
                    a.WorkDate.Value <= ngayCuoiThang &&
                    a.CheckIn != null &&
                    a.CheckOut != null
                )
                .Select(a => new
                {
                    CheckIn = a.CheckIn.Value,
                    CheckOut = a.CheckOut.Value
                })
                .ToList(); // Ở đây dữ liệu đã về C#, có thể tính TimeSpan

            // 3) Tính tổng số giờ làm: sum((CheckOut - CheckIn).TotalHours)
            foreach (var at in attendances)
            {
                TimeSpan duration = at.CheckOut - at.CheckIn;
                // Chỉ cộng nếu duration dương, để tránh trường hợp check-in > check-out
                if (duration.TotalHours > 0)
                {
                    tongGioLam += duration.TotalHours;
                }
            }
        }

        // 4) Nếu muốn làm tròn đến 2 chữ số sau dấu thập phân, dùng Math.Round
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
            dt.Rows.Add(p.AttendanceID, p.Employee.FullName, p.EmployeeID, p.WorkDate, p.CheckIn, p.CheckOut, p.AbsenceStatus);
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
    public bool UpdateAttendance(DataTable changedData, ref string err)
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
            // 1. Lấy danh sách anonymous type { Year, Month, WorkDays }
            var raw = context.Attendances
                // Chỉ lấy những bản ghi có WorkDate != null
                .Where(a => a.WorkDate.HasValue)
                // Group theo cặp (Year, Month)
                .GroupBy(a => new
                {
                    Year = a.WorkDate.Value.Year,
                    Month = a.WorkDate.Value.Month
                })
                // Sắp xếp theo năm → tháng
                .OrderBy(g => g.Key.Year)
                .ThenBy(g => g.Key.Month)
                // Trong mỗi nhóm g, đếm số ngày khác nhau (dùng TruncateTime để chỉ xét phần date)
                .Select(g => new
                {
                    Year = g.Key.Year,
                    Month = g.Key.Month,
                    WorkDays = g
                        .Select(x => DbFunctions.TruncateTime(x.WorkDate))
                        .Distinct()
                        .Count()
                })
                .ToList(); // EF thực thi SQL tại đây

            // 2. Chuyển từ anonymous type sang List<Attendance>
            //    (chỉ gán MonthYear & WorkDays, các thuộc tính khác để null/giá trị mặc định)
            var result = raw
                .Select(x => new Attendance
                {
                    MonthYear = x.Month.ToString("D2") + "/" + x.Year, // "MM/yyyy"
                    WorkDays = x.WorkDays
                })
                .ToList();

            return result;
        }
    }



}
