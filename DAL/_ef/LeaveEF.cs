using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHRManagement.DAL._ef
{
    internal class LeaveEF
    {

        public DataTable GetLeaveEF()
        {
            CompanyHRManagementEntities x = new CompanyHRManagementEntities();
            var tps =
                    from p in x.Leaves
                    select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã");
            dt.Columns.Add("Mã nhân viên");
            //dt.Columns.Add("Tên Nhân viên");
            dt.Columns.Add("Từ Ngày");
            dt.Columns.Add("Đến Ngày");
            dt.Columns.Add("Lý do");
            dt.Columns.Add("Trạng thái");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.leaveID, p.employeeID, p.startDate, p.endDate, p.reason, p.status);
            }
            return dt;
        }

        public bool DeleteLeave(ref string err, int leaveID)
        {
            CompanyHRManagementEntities x = new CompanyHRManagementEntities();
            Leaf a = new Leaf();
            a.leaveID = leaveID;
            x.Leaves.Attach(a);
            x.Leaves.Remove(a);
            x.SaveChanges();
            return true;
        }

        public bool UpdateLeaveStatus(int leaveId, string newStatus)
        {
            using (var context = new CompanyHRManagementEntities())
            {
                try
                {
                    var leave = context.Leaves.Find(leaveId);
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
