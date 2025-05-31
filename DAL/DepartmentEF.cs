using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHRManagement.DAL._ado
{
    public class DepartmentEF
    {
        DBConnection db = new DBConnection();

        //Lấy danh sách tên trả vào comboBox
        public List<string> GetDepartmentNames()
        {
            List<string> departments = new List<string>();

            string query = "SELECT DepartmentName FROM Departments";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            departments.Add(reader.GetString(0));
                        }
                    }
                }
            }

            return departments;
        }

        public List<Department> GetAllDepartments()
        {
            List<Department> departments = new List<Department>();
            string query = "SELECT DepartmentID, DepartmentName FROM Departments";

            using (SqlDataReader reader = DBConnection.ExecuteReader(query))
            {
                while (reader.Read())
                {
                    Department dept = new Department
                    {
                        DepartmentID = Convert.ToInt32(reader["DepartmentID"]),
                        DepartmentName = reader["DepartmentName"].ToString()
                    };
                    departments.Add(dept);
                }
            }

            return departments;
        }

        // Tìm kiếm phòng ban theo tên
        public List<Department> SearchDepartments(string keyword)
        {
            List<Department> departments = new List<Department>();
            string query = "SELECT DepartmentID, DepartmentName FROM Departments WHERE DepartmentName LIKE @keyword";
            SqlParameter[] parameters = {
            new SqlParameter("@keyword", "%" + keyword + "%")
        };

            using (SqlDataReader reader = DBConnection.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                {
                    departments.Add(new Department
                    {
                        DepartmentID = Convert.ToInt32(reader["DepartmentID"]),
                        DepartmentName = reader["DepartmentName"].ToString()
                    });
                }
            }

            return departments;
        }

        // Thêm phòng ban
        public bool AddDepartment(string departmentName, ref string error)
        {
            string query = "INSERT INTO Departments (DepartmentName) VALUES (@name)";
            SqlParameter[] parameters = {
            new SqlParameter("@name", departmentName)
            };

            return db.MyExecuteNonQuery(query, CommandType.Text, ref error, parameters);
        }


        // Sửa tên phòng ban
        public bool UpdateDepartment(int departmentID, string newName, ref string error)
        {
            string query = "UPDATE Departments SET DepartmentName = @name WHERE DepartmentID = @id";
            SqlParameter[] parameters = {
            new SqlParameter("@name", newName),
            new SqlParameter("@id", departmentID)
            };

            DBConnection db = new DBConnection();
            return db.MyExecuteNonQuery(query, CommandType.Text, ref error, parameters);
        }


        // Xóa phòng ban
        public bool DeleteDepartment(int departmentID, ref string error)
        {
            // Bước 1: Kiểm tra phòng ban có nhân viên hay không
            string checkQuery = "SELECT COUNT(*) FROM Employees WHERE DepartmentID = @id";
            SqlParameter[] checkParams = {
        new SqlParameter("@id", departmentID)
    };

            object result = DBConnection.ExecuteScalar(checkQuery, checkParams);
            int employeeCount = Convert.ToInt32(result);

            if (employeeCount > 0)
            {
                error = "Không thể xóa phòng ban vì vẫn còn nhân viên thuộc phòng ban này.";
                return false;
            }

            // Bước 2: Xóa phòng ban – KHÔNG dùng lại checkParams
            string deleteQuery = "DELETE FROM Departments WHERE DepartmentID = @id";
            SqlParameter[] deleteParams = {
        new SqlParameter("@id", departmentID)  // Tạo mới tham số
    };

            DBConnection db = new DBConnection();
            return db.MyExecuteNonQuery(deleteQuery, CommandType.Text, ref error, deleteParams);
        }

    }
}
