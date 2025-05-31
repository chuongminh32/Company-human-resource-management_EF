using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHRManagement.DAL._ado
{
    public class DashBoard_adminDAO
    {
        //Đếm số lượng phòng ban
        public int CountDepartments()
        {
            string query = "SELECT COUNT(*) FROM Departments";
            object result = DBConnection.ExecuteScalar(query);
            return Convert.ToInt32(result);
        }

        //Đếm tổng số nhân viên
        public int CountAllEmployees()
        {
            string query = "SELECT COUNT(*) FROM Employees WHERE IsFired = 0";
            object result = DBConnection.ExecuteScalar(query);
            return Convert.ToInt32(result);
        }

        //Đếm số nhân viên đang thử việc
        public int CountProbationEmployees()
        {
            string query = "SELECT COUNT(*) FROM Employees WHERE IsProbation = 1 AND IsFired = 0";
            object result = DBConnection.ExecuteScalar(query);
            return Convert.ToInt32(result);
        }
        //Đếm số chức vụ
        public int CountPositions()
        {
            string query = "SELECT COUNT(*) FROM Positions";
            object result = DBConnection.ExecuteScalar(query);
            return Convert.ToInt32(result);
        }
        //Tính tổng thưởng
        public static decimal GetTotalRewards()
        {
            string query = "SELECT SUM(Amount) FROM Rewards";

            object result = DBConnection.ExecuteScalar(query);

            // Chuyển đổi kết quả sang decimal, nếu null hoặc DBNull trả về 0
            if (result == null || result == DBNull.Value)
            {
                return 0;
            }
            else
            {
                return Convert.ToDecimal(result);
            }
        }
        //Đếm số bảo hiểm còn hạn
        public static int CountValidInsurances()
        {
            string query = "SELECT COUNT(*) FROM Insurance WHERE ExpiryDate > GETDATE()";

            object result = DBConnection.ExecuteScalar(query);

            if (result == null || result == DBNull.Value)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(result);
            }
        }







    }
}
