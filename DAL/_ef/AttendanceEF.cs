using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHRManagement.DAL._ef
{
    internal class AttendanceEF
    {
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
    }
}
