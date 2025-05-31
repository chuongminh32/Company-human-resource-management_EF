using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHRManagement.Models;

namespace CompanyHRManagement.DAL._ado
{
    class LeaveDAO
    {
        DBConnection db = null;
        public LeaveDAO()
        {
            db = new DBConnection();
        }
        public DataTable LayDuLieuNghiPhepTheoIDNhanVien(int employeeID)
        {
            string query = "SELECT * FROM Leaves WHERE employeeID = @id";
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", employeeID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // cập nhật nghỉ phép
        public bool ThemNghiPhep(int employeeID, DateTime startDate, DateTime endDate, string reason)
        {
            // Không thêm cột 'status' vào câu lệnh INSERT để dùng DEFAULT trong SQL
            string query = "INSERT INTO Leaves (employeeID, startDate, endDate, reason) " +
                           "VALUES (@employeeID, @startDate, @endDate, @reason)";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@employeeID", employeeID);
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);
                cmd.Parameters.AddWithValue("@reason", reason);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0; // true nếu thêm thành công
            }
        }


        public bool XoaNghiPhep(int leaveID)
        {
            string query = "DELETE FROM Leaves WHERE leaveID = @leaveID";
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@leaveID", leaveID);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }


        public bool UpdateLeave(Leave leave)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"UPDATE Leaves 
                             SET reason = @reason, startDate = @startDate, endDate = @endDate 
                             WHERE leaveID = @leaveID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@reason", leave.Reason);
                    cmd.Parameters.AddWithValue("@startDate", leave.StartDate);
                    cmd.Parameters.AddWithValue("@endDate", leave.EndDate);
                    cmd.Parameters.AddWithValue("@leaveID", leave.LeaveID);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
        public DataSet GetLeave()
        {
            string sql = @"
                SELECT 
                    l.leaveID,
                    l.employeeID,
                    e.FullName AS EmployeeName, 
                    l.startDate,
                    l.endDate,
                    l.reason,
                    l.status
                FROM 
                    Leaves l
                JOIN 
                    Employees e ON l.employeeID = e.EmployeeID
                ORDER BY
                    l.startDate DESC"; 


    return db.ExecuteQueryDataSet(sql, CommandType.Text);

        }

        public bool UpdateLeaveStatus(int leaveId, string newStatus)
         {
            var sql = @"UPDATE Leaves SET Status = @Status WHERE LeaveID = @LID";
            using (var conn = DBConnection.GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                 cmd.Parameters.AddWithValue("@Status", newStatus);
                 cmd.Parameters.AddWithValue("@LID", leaveId);
                 conn.Open();
                 return cmd.ExecuteNonQuery() > 0;
            }
         }
  

    }
}
