using CompanyHRManagement.DAL._ado;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHRManagement.Models;

namespace CompanyHRManagement.BUS._ado
{
    class LeavesBUS
    {
        LeaveDAO leaveDAO = new LeaveDAO();
        public DataTable LayDuLieuNghiPhepTheoIDNhanVien(int idNhanVien)
        {
            return leaveDAO.LayDuLieuNghiPhepTheoIDNhanVien(idNhanVien);
        }

        public bool ThemNghiPhep(int employeeID, DateTime startDate, DateTime endDate, string reason)
        {
            return leaveDAO.ThemNghiPhep(employeeID, startDate, endDate, reason);
        }

        public bool XoaNghiPhep(int leaveID)
        {
            LeaveDAO dao = new LeaveDAO();
            return dao.XoaNghiPhep(leaveID);
        }


        public bool SuaNghiPhep(Leave leave)
        {
            return leaveDAO.UpdateLeave(leave);
        }

    }
}
