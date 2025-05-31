using CompanyHRManagement.DAL._ado;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHRManagement.BUS
{

    public class DashBoardBUS
    {
        private DashBoardDAO db_DAO = new DashBoardDAO();

        // chart nhân viên theo phòng ban
        public Dictionary<string, int> GetEmployeeStats()
        {
            return db_DAO.GetEmployeeCountByDepartment();
        }

        // chart lương nhân viên 
        public DataTable GetSalaryStructureThisYear()
        {
            int year = DateTime.Now.Year;
            return db_DAO.GetSalaryStructureThisYear(year);
        }


        // lấy dữ liệu để hiển thị lên dashboard
        public int GetTotalValidInsurances() => db_DAO.GetTotalValidInsurances();
        public int GetToTalRewardSalary() => db_DAO.GetToTalRewardSalary();
        public int GetTotalEmployees() => db_DAO.GetTotalEmployees();
        public int GetTotalDepartments() => db_DAO.GetTotalDepartments();
        public int GetTotalPositions() => db_DAO.GetTotalPositions();
        public int GetProbationCount() => db_DAO.GetProbationCount();
        public string LayTenPhongBanQuaID(int idDeparment)
        {
            return db_DAO.LayTenPhongBanQuaID(idDeparment);
        }
        public string LayTenViTriChucVu(int userID)
        {
            return db_DAO.LayVitriChucVuTheoID(userID);
        }


        // Employee dashboard  - USER
        //  lương theo tháng 
        public List<(string MonthYear, decimal TotalSalary)> LayDuLieuLuong(int employeeId)
        {
            var raw = db_DAO.TongLuongTheoThang(employeeId);
            return raw.Select(r => ($"{r.Month}/{r.Year}", r.TotalSalary)).ToList();
        }

        // công theo tháng
        public List<(string MonthYear, int WorkDays)> LayDuLieuChamCong(int employeeId)
        {
            var raw = db_DAO.SoNgayCongTheoThang(employeeId);
            return raw.Select(r => ($"{r.Month}/{r.Year}", r.WorkDays)).ToList();
        }
    }
}
