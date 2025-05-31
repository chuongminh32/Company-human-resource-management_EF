using CompanyHRManagement.DAL._ado;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHRManagement.BUS._ado
{
    class LeavesBUS
    {
        LeaveEF l = new LeaveEF();
        // -- User --
        public DataTable LayDuLieuNghiPhepTheoIDNhanVien(int idNhanVien)
        {
            return l.LayDuLieuNghiPhepTheoIDNhanVien(idNhanVien);
        }

        public bool ThemNghiPhep(int employeeID, DateTime startDate, DateTime endDate, string reason)
        {
            return l.ThemNghiPhep(employeeID, startDate, endDate, reason);
        }

        public bool XoaNghiPhep(int leaveID)
        {
            return l.XoaNghiPhep(leaveID);
        }
        public bool SuaNghiPhep(Leaf leave)
        {
            return l.UpdateLeave(leave);
        }



        // -- Admin --

        public DataTable GetLeaveEF()
        {
            return l.GetLeaveEF();
        }

        public bool DeleteLeave(ref string err, int leaveID)
        {
            return l.DeleteLeave(ref err, leaveID);
        }

        public bool UpdateLeaveStatus(int leaveId, string newStatus)
        {
            return l.UpdateLeaveStatus(leaveId, newStatus);
        }

    }
}
