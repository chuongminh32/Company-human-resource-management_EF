using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHRManagement.DAL._ado
{
    public class PositionEF
    {
        DBConnection db = new DBConnection();

        // Lấy tên vai  trò theo ID 
        public string GetPositionNameById(int positionId)
        {
            string positionName = string.Empty;
            string query = "SELECT PositionName FROM Positions WHERE PositionID = @PositionID";
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PositionID", positionId);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        positionName = result.ToString();
                    }
                }
            }
            return positionName;
        }

        //Lấy danh sách tên trả vào comboBox
        public List<string> GetPositionNames()
        {
            List<string> position = new List<string>();

            string query = "SELECT PositionName FROM Positions";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            position.Add(reader.GetString(0));
                        }
                    }
                }
            }

            return position;
        }

        public List<Position> GetAllPositions()
        {
            List<Position> positions = new List<Position>();

            string query = "SELECT PositionID, PositionName, BaseSalary FROM Positions";
            SqlDataReader reader = DBConnection.ExecuteReader(query);

            while (reader.Read())
            {
                Position pos = new Position
                {
                    PositionID = reader.GetInt32(0),
                    PositionName = reader.GetString(1),
                    BaseSalary = reader.GetDecimal(2)
                };
                positions.Add(pos);
            }

            reader.Close(); // Đảm bảo đóng reader (vì connection đóng theo reader)
            return positions;
        }


        public bool InsertPosition(string name, decimal baseSalary, ref string error)
        {
            string query = "INSERT INTO Positions (PositionName, BaseSalary) VALUES (@name, @salary)";
            SqlParameter[] parameters = {
        new SqlParameter("@name", name),
        new SqlParameter("@salary", baseSalary)
    };

            return db.MyExecuteNonQuery(query, CommandType.Text, ref error, parameters);
        }

        public bool UpdatePosition(int id, string name, decimal baseSalary, ref string error)
        {
            string query = "UPDATE Positions SET PositionName = @name, BaseSalary = @salary WHERE PositionID = @id";
            SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@name", name),
        new SqlParameter("@salary", baseSalary)
    };

            return db.MyExecuteNonQuery(query, CommandType.Text, ref error, parameters);
        }

        public bool DeletePosition(int id, ref string error)
        {
            // Bước 1: Kiểm tra có nhân viên nào giữ chức vụ này không
            string checkQuery = "SELECT COUNT(*) FROM Employees WHERE PositionID = @id";
            SqlParameter[] checkParams = {
        new SqlParameter("@id", id)
    };

            object result = DBConnection.ExecuteScalar(checkQuery, checkParams);
            int employeeCount = Convert.ToInt32(result);

            if (employeeCount > 0)
            {
                error = "Không thể xóa chức vụ này vì vẫn còn nhân viên đang giữ chức vụ này.";
                return false;
            }

            // Bước 2: Xóa nếu không có nhân viên nào liên quan
            string deleteQuery = "DELETE FROM Positions WHERE PositionID = @id";
            SqlParameter[] deleteParams = {
        new SqlParameter("@id", id)
    };

            return db.MyExecuteNonQuery(deleteQuery, CommandType.Text, ref error, deleteParams);
        }


    }
}
