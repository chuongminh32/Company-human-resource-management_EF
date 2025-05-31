using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CompanyHRManagement.Models;

public class EmployeeDAO
{
    DBConnection db = null;
    public EmployeeDAO()
    {
        db = new DBConnection();
    }
    private DBConnection dbConnection = new DBConnection();

    // lấy nhân viên theo ID - dùng cho bảng thông tin của employee 
    public Employee GetEmployeeById(int employeeID)
    {
        string query = "SELECT * FROM Employees WHERE EmployeeID = @EmployeeID";
        using (var conn = DBConnection.GetConnection())
        {
            conn.Open();
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Employee()
                    {
                        EmployeeID = reader.GetInt32(0),
                        FullName = reader.GetString(1),
                        DateOfBirth = reader.GetDateTime(2),
                        Gender = reader.GetString(3),
                        Address = reader.GetString(4),
                        Phone = reader.GetString(5),
                        Email = reader.GetString(6),
                        DepartmentID = reader.GetInt32(7),
                        PositionID = reader.GetInt32(8),
                        HireDate = reader.GetDateTime(9),
                        isProbation = reader.GetBoolean(10) ? 1 : 0,
                        isFired = reader.GetBoolean(11) ? 1 : 0,
                        password = reader.GetString(12),
                    };

                }
            }
        }
        return null;
    }


    // lấy nhân viên theo email 
    public Employee LayDuLieuNhanVienQuaEmail(string email)
    {
        string query = "SELECT * FROM Employees WHERE Email = @Email";
        using (var conn = DBConnection.GetConnection())
        {
            conn.Open();
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Employee()
                    {
                        EmployeeID = reader.GetInt32(0),
                        FullName = reader.GetString(1),
                        DateOfBirth = reader.GetDateTime(2),
                        Gender = reader.GetString(3),
                        Address = reader.GetString(4),
                        Phone = reader.GetString(5),
                        Email = reader.GetString(6),
                        DepartmentID = reader.GetInt32(7),
                        PositionID = reader.GetInt32(8),
                        HireDate = reader.GetDateTime(9),
                        isProbation = reader.GetBoolean(10) ? 1 : 0,
                        isFired = reader.GetBoolean(11) ? 1 : 0,
                        password = reader.GetString(12),
                    };

                }
            }
        }
        return null;
    }

    // Cập nhật thông tin nhân viên theo ID
    public bool UpdateEmployee(Employee emp)
    {
        string query = @"
        UPDATE Employees SET 
            FullName = @FullName,
            BirthDate = @DateOfBirth,
            Gender = @Gender,
            Address = @Address,
            Phone = @Phone,
            Email = @Email,
            DepartmentID = @DepartmentID,
            PositionID = @PositionID,
            HireDate = @HireDate,
            IsProbation = @IsProbation,
            IsFired = @IsFired
        WHERE EmployeeID = @EmployeeID";

        using (var conn = DBConnection.GetConnection())
        {
            conn.Open();
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@FullName", emp.FullName);
                cmd.Parameters.AddWithValue("@DateOfBirth", emp.DateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", emp.Gender);
                cmd.Parameters.AddWithValue("@Address", emp.Address);
                cmd.Parameters.AddWithValue("@Phone", emp.Phone);
                cmd.Parameters.AddWithValue("@Email", emp.Email);
                cmd.Parameters.AddWithValue("@DepartmentID", emp.DepartmentID);
                cmd.Parameters.AddWithValue("@PositionID", emp.PositionID);
                cmd.Parameters.AddWithValue("@HireDate", emp.HireDate);
                cmd.Parameters.AddWithValue("@IsProbation", emp.isProbation); // bool
                cmd.Parameters.AddWithValue("@IsFired", emp.isFired);         // bool
                cmd.Parameters.AddWithValue("@EmployeeID", emp.EmployeeID);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }


    // Lấy danh sách nhân viên
    public List<Employee> GetAllEmployees()
    {
        List<Employee> list = new List<Employee>();

        using (SqlConnection conn = DBConnection.GetConnection())
        {
            conn.Open();
            string query = "SELECT * FROM employees";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Employee emp = new Employee
                {
                    EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                    FullName = reader["FullName"].ToString(),
                    DateOfBirth = reader["BirthDate"] != DBNull.Value ? Convert.ToDateTime(reader["BirthDate"]) : DateTime.MinValue,
                    Gender = reader["Gender"]?.ToString() ?? "",
                    Address = reader["Address"]?.ToString() ?? "",
                    Phone = reader["Phone"]?.ToString() ?? "",
                    Email = reader["Email"]?.ToString() ?? "",
                    DepartmentID = reader["DepartmentID"] != DBNull.Value ? Convert.ToInt32(reader["DepartmentID"]) : 0,
                    PositionID = reader["PositionID"] != DBNull.Value ? Convert.ToInt32(reader["PositionID"]) : 0,
                    HireDate = reader["HireDate"] != DBNull.Value ? Convert.ToDateTime(reader["HireDate"]) : DateTime.MinValue,
                    isProbation = reader["isProbation"] != DBNull.Value ? Convert.ToInt32(reader["isProbation"]) : 0,
                    isFired = reader["isFired"] != DBNull.Value ? Convert.ToInt32(reader["isFired"]) : 0,
                    password = reader["Password"]?.ToString() ?? "",

                };
                list.Add(emp);
            }

            reader.Close();
        }

        return list;
    }

    public DataSet GetEmployee()
    {
        string sql = @"
            SELECT 
                e.EmployeeID,
                e.FullName,
                e.BirthDate,
                e.Gender,
                e.Address,
                e.Phone,
                e.Email,
                e.DepartmentID,
                d.DepartmentName,
                e.PositionID,
                p.PositionName,
                e.HireDate,
                e.IsProbation,
                e.IsFired,
                e.Password
            FROM 
                Employees e
            LEFT JOIN 
                Departments d ON e.DepartmentID = d.DepartmentID
            LEFT JOIN 
                Positions p ON e.PositionID = p.PositionID
            ";
        return db.ExecuteQueryDataSet(sql, CommandType.Text);


    }

    public bool InsertEmployee(Employee emp)
    {
        string query = @"INSERT INTO Employees
                (FullName, BirthDate, Gender, Address, Phone, Email, DepartmentID, PositionID, HireDate, IsProbation, IsFired, Password)
            VALUES
                (@FullName, @BirthDate, @Gender, @Address, @Phone, @Email, @DepartmentID, @PositionID, @HireDate, @IsProbation, @IsFired, @Password)";

        using (var conn = DBConnection.GetConnection())
        {
            conn.Open();
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@FullName", emp.FullName);
                cmd.Parameters.AddWithValue("@BirthDate", emp.DateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", emp.Gender);
                cmd.Parameters.AddWithValue("@Address", emp.Address);
                cmd.Parameters.AddWithValue("@Phone", emp.Phone);
                cmd.Parameters.AddWithValue("@Email", emp.Email);
                cmd.Parameters.AddWithValue("@DepartmentID", emp.DepartmentID);
                cmd.Parameters.AddWithValue("@PositionID", emp.PositionID);
                cmd.Parameters.AddWithValue("@HireDate", emp.HireDate);
                cmd.Parameters.AddWithValue("@IsProbation", emp.isProbation); // bool
                cmd.Parameters.AddWithValue("@IsFired", emp.isFired);         // bool
                cmd.Parameters.AddWithValue("@EmployeeID", emp.EmployeeID);
                cmd.Parameters.AddWithValue("@Password", emp.password);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }

    public bool DeleteEmployee(int empID)
    {
        string query = "DELETE FROM Employees WHERE EmployeeID = @ID";
        using (SqlConnection conn = DBConnection.GetConnection())
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", empID);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            return rows > 0;
        }
    }

    public bool UpdateEmp(Employee emp)
    {
        string query = @"
        UPDATE Employees SET 
            FullName = @FullName,
            BirthDate = @DateOfBirth,
            Gender = @Gender,
            Address = @Address,
            Phone = @Phone,
            Email = @Email,
            DepartmentID = @DepartmentID,
            PositionID = @PositionID,
            HireDate = @HireDate,
            IsProbation = @IsProbation,
            IsFired = @IsFired,
            Password = @Password
        WHERE EmployeeID = @EmployeeID";

        using (var conn = DBConnection.GetConnection())
        {
            conn.Open();
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@FullName", emp.FullName);
                cmd.Parameters.AddWithValue("@DateOfBirth", emp.DateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", emp.Gender);
                cmd.Parameters.AddWithValue("@Address", emp.Address);
                cmd.Parameters.AddWithValue("@Phone", emp.Phone);
                cmd.Parameters.AddWithValue("@Email", emp.Email);
                cmd.Parameters.AddWithValue("@DepartmentID", emp.DepartmentID);
                cmd.Parameters.AddWithValue("@PositionID", emp.PositionID);
                cmd.Parameters.AddWithValue("@HireDate", emp.HireDate);
                cmd.Parameters.AddWithValue("@IsProbation", emp.isProbation); // bool
                cmd.Parameters.AddWithValue("@IsFired", emp.isFired);         // bool
                cmd.Parameters.AddWithValue("@EmployeeID", emp.EmployeeID);
                cmd.Parameters.AddWithValue("@Password", emp.password);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }


    // Phương thức lấy thống kê số lượng nhân viên theo trạng thái
    public List<Employee> GetEmployeeStatus()
    {
        // Tạo danh sách lưu kết quả trả về
        var list = new List<Employee>();

        // Câu truy vấn SQL:
        // - Truy vấn con lấy trạng thái nhân viên theo điều kiện cột IsFired, IsProbation
        // - Nhóm theo trạng thái rồi đếm số lượng
        string query = @"
            SELECT TrangThai, COUNT(*) AS SoLuong
            FROM (
                SELECT
                    CASE 
                        WHEN IsFired = 1 THEN N'Nghỉ việc'
                        WHEN IsProbation = 1 THEN N'Thử việc'
                        ELSE N'Đang làm việc'
                    END AS TrangThai
                FROM Employees
            ) AS Derived
            GROUP BY TrangThai";

        // Sử dụng SqlConnection và SqlCommand để thực thi truy vấn
        using (SqlConnection conn = DBConnection.GetConnection())
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            conn.Open(); // Mở kết nối đến database
            SqlDataReader reader = cmd.ExecuteReader(); // Thực thi truy vấn và lấy dữ liệu

            // Đọc từng dòng kết quả trả về
            while (reader.Read())
            {
                // Tạo đối tượng Employee, gán Status và Count từ dữ liệu đọc được
                list.Add(new Employee
                {
                    Status = reader.GetString(0),   // Cột TrangThai
                    Count = reader.GetInt32(1)      // Cột SoLuong
                });
            }
        }

        // Trả về danh sách thống kê
        return list;
    }


    public string GetEmailByEmail(string email)
    {
        using (SqlConnection conn = DBConnection.GetConnection())
        {
            string query = "SELECT Email FROM Employees WHERE Email = @Email";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Email", email);
            conn.Open();
            var result = cmd.ExecuteScalar();
            return result?.ToString();
        }
    }
}
