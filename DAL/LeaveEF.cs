using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHRManagement.DAL._ado
{
    class LeaveEF
    {
        // -- User --
        // ---- user  functions ----
        public List<Leaf> LayDuLieuNghiPhepTheoIDNhanVien(int EmployeeID)
        {
            using (var context = new CompanyHRManagementEntities())
            {
                return context.Leaves
                    .Where(l => l.EmployeeID == EmployeeID)
                    .ToList();
            }
        }

        public bool ThemNghiPhep(int EmployeeID, DateTime StartDate, DateTime EndDate, string Reason)
        {
            using (var context = new CompanyHRManagementEntities())
            {
                var leave = new Leaf
                {
                    EmployeeID = EmployeeID,
                    StartDate = StartDate,
                    EndDate = EndDate,
                    Reason = Reason
                    // Không set `Status` nếu cột đó dùng DEFAULT trong CSDL
                };

                context.Leaves.Add(leave);
                return context.SaveChanges() > 0; // true nếu thêm thành công
            }
        }

        public bool XoaNghiPhep(int LeaveID)
        {
            using (var context = new CompanyHRManagementEntities())
            {
                var leave = context.Leaves.FirstOrDefault(l => l.LeaveID == LeaveID);
                if (leave != null)
                {
                    context.Leaves.Remove(leave);
                    return context.SaveChanges() > 0; // true nếu xoá thành công
                }
                return false; // Không tìm thấy bản ghi để xoá
            }
        }
        public bool UpdateLeave(Leaf leave)
        {
            using (var context = new CompanyHRManagementEntities())
            {
                // Tìm bản ghi nghỉ phép cần cập nhật theo LeaveID
                var existingLeave = context.Leaves.FirstOrDefault(l => l.LeaveID == leave.LeaveID);
                if (existingLeave != null)
                {
                    // Cập nhật các thuộc tính
                    existingLeave.Reason = leave.Reason;
                    existingLeave.StartDate = leave.StartDate;
                    existingLeave.EndDate = leave.EndDate;

                    // Lưu thay đổi vào cơ sở dữ liệu
                    return context.SaveChanges() > 0;
                }

                // Không tìm thấy bản ghi để cập nhật
                return false;
            }
        }







        // -- Admin --

        public DataTable GetLeaveEF()
        {
            CompanyHRManagementEntities x = new CompanyHRManagementEntities();
            var query = from leaf in x.Leaves
                        join employee in x.Employees on leaf.EmployeeID equals employee.EmployeeID
                        select new
                        {
                            leaf.LeaveID,
                            leaf.EmployeeID,
                            EmployeeName = employee.FullName,
                            leaf.StartDate,
                            leaf.EndDate,
                            leaf.Reason,
                            leaf.status
                        };
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã");
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Tên Nhân viên");
            dt.Columns.Add("Từ Ngày");
            dt.Columns.Add("Đến Ngày");
            dt.Columns.Add("Lý do");
            dt.Columns.Add("Trạng thái");

            foreach (var p in query)
            {
                dt.Rows.Add(p.LeaveID, p.EmployeeID, p.StartDate, p.EndDate, p.Reason, p.status);
            }
            return dt;
        }

        public bool DeleteLeave(ref string err, int LeaveID)
        {
            CompanyHRManagementEntities x = new CompanyHRManagementEntities();
            Leaf a = new Leaf();
            a.LeaveID = LeaveID;
            x.Leaves.Attach(a);
            x.Leaves.Remove(a);
            x.SaveChanges();
            return true;
        }

        public bool UpdateLeaveStatus(int LeaveID, string newStatus)
        {
            using (var context = new CompanyHRManagementEntities())
            {
                try
                {
                    var leave = context.Leaves.Find(LeaveID);
                    if (leave != null)
                    {
                        leave.status = newStatus;
                        context.SaveChanges();
                        return true;
                    }
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

    }
}
