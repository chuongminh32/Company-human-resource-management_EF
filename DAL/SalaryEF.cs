using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using CompanyHRManagement;
public class SalaryEF
{
    DBConnection db = new DBConnection();
    public decimal TinhTongLuongTheoThangNam(int employeeId, int month, int year)
    {
        string query = @"
    SELECT 
        SUM(BaseSalary + Allowance + Bonus - Penalty + (OvertimeHours * 50000)) AS TotalSalary
    FROM 
        Salaries
    WHERE 
        EmployeeID = @EmployeeID AND SalaryMonth = @Month AND SalaryYear = @Year";

        using (SqlConnection conn = DBConnection.GetConnection())
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
            cmd.Parameters.AddWithValue("@Month", month);
            cmd.Parameters.AddWithValue("@Year", year);

            conn.Open();
            var result = cmd.ExecuteScalar();
            return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
        }
    }


    public List<Salary> LayThongTinLuongTheoID(int employeeId)
    {
        List<Salary> list = new List<Salary>();
        string query = @"
        SELECT SalaryID, EmployeeID, BaseSalary, Allowance, Bonus, Penalty, 
               OvertimeHours, SalaryMonth, SalaryYear
        FROM Salaries
        WHERE EmployeeID = @EmployeeID";

        using (SqlConnection conn = DBConnection.GetConnection())
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@EmployeeID", employeeId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Salary s = new Salary()
                        {
                            SalaryID = reader.GetInt32(0),
                            EmployeeID = reader.GetInt32(1),
                            BaseSalary = reader.GetDecimal(2),
                            Allowance = reader.GetDecimal(3),
                            Bonus = reader.GetDecimal(4),
                            Penalty = reader.GetDecimal(5),
                            OvertimeHours = reader.GetInt32(6),
                            SalaryMonth = reader.GetInt32(7),
                            SalaryYear = reader.GetInt32(8)
                        };
                        list.Add(s);
                    }
                }
            }
        }

        return list;
    }

    public List<Salary> LayTatCaThongTinLuong_Admin()
    {
        List<Salary> list = new List<Salary>();
        string query = @"
        SELECT s.SalaryID, s.EmployeeID, e.FullName, s.BaseSalary, s.Allowance, s.Bonus,
               s.Penalty, s.OvertimeHours, s.SalaryMonth, s.SalaryYear
        FROM Salaries s
        INNER JOIN Employees e ON s.EmployeeID = e.EmployeeID";

        using (SqlDataReader reader = DBConnection.ExecuteReader(query))
        {
            while (reader.Read())
            {
                Salary s = new Salary()
                {
                    SalaryID = reader.GetInt32(0),
                    EmployeeID = reader.GetInt32(1),
                    FullName = reader.GetString(2),
                    BaseSalary = reader.GetDecimal(3),
                    Allowance = reader.GetDecimal(4),
                    Bonus = reader.GetDecimal(5),
                    Penalty = reader.GetDecimal(6),
                    OvertimeHours = reader.GetInt32(7),
                    SalaryMonth = reader.GetInt32(8),
                    SalaryYear = reader.GetInt32(9)
                };
                list.Add(s);
            }
        }

        return list;
    }

    //Cập nhật thông tin trong bảng lương theo các bảng
    public bool UpdateSalaries(ref string error)
    {
        string updateQuery = @"
        UPDATE S
        SET 
            BaseSalary = ISNULL(P.BaseSalary, 0),
            Penalty = ISNULL(DP.TotalPenalty, 0),
            Bonus = ISNULL(RW.TotalBonus, 0),
            OvertimeHours = ISNULL(AT.TotalOvertime, 0)
        FROM Salaries S
        INNER JOIN Employees E ON S.EmployeeID = E.EmployeeID
        LEFT JOIN Positions P ON E.PositionID = P.PositionID

        LEFT JOIN (
            SELECT EmployeeID, YEAR(DisciplineDate) AS SalaryYear, MONTH(DisciplineDate) AS SalaryMonth, SUM(Amount) AS TotalPenalty
            FROM [dbo].[Disciplines]
            GROUP BY EmployeeID, YEAR(DisciplineDate), MONTH(DisciplineDate)
        ) DP ON S.EmployeeID = DP.EmployeeID AND S.SalaryYear = DP.SalaryYear AND S.SalaryMonth = DP.SalaryMonth

        LEFT JOIN (
            SELECT EmployeeID, YEAR(RewardDate) AS SalaryYear, MONTH(RewardDate) AS SalaryMonth, SUM(Amount) AS TotalBonus
            FROM [dbo].[Rewards]
            GROUP BY EmployeeID, YEAR(RewardDate), MONTH(RewardDate)
        ) RW ON S.EmployeeID = RW.EmployeeID AND S.SalaryYear = RW.SalaryYear AND S.SalaryMonth = RW.SalaryMonth

        LEFT JOIN (
            SELECT EmployeeID, YEAR(WorkDate) AS SalaryYear, MONTH(WorkDate) AS SalaryMonth, SUM(OvertimeHours) AS TotalOvertime
            FROM [dbo].[Attendance]
            GROUP BY EmployeeID, YEAR(WorkDate), MONTH(WorkDate)
        ) AT ON S.EmployeeID = AT.EmployeeID AND S.SalaryYear = AT.SalaryYear AND S.SalaryMonth = AT.SalaryMonth;
    ";

        return db.MyExecuteNonQuery(updateQuery, CommandType.Text, ref error);
    }
    //Xóa các bản ghi trùng lặp
    public bool DeleteDuplicateSalariesKeepFirst()
    {
        string query = @"
        WITH CTE AS (
            SELECT 
                SalaryID,
                ROW_NUMBER() OVER (PARTITION BY EmployeeID, SalaryMonth, SalaryYear ORDER BY SalaryID) AS rn
            FROM Salaries
        )
        DELETE FROM CTE WHERE rn > 1;
    ";

        string error = "";
        bool success = db.MyExecuteNonQuery(query, CommandType.Text, ref error);

        if (!success)
        {
            // Xử lý lỗi hoặc log
            Console.WriteLine("Lỗi khi xóa bản ghi trùng: " + error);
        }

        return success;
    }


    //Trả về danh sách các năm có trong bảng
    public List<int> GetDistinctSalaryYears()
    {
        List<int> years = new List<int>();
        string query = "SELECT DISTINCT SalaryYear FROM Salaries ORDER BY SalaryYear DESC";

        using (SqlDataReader reader = DBConnection.ExecuteReader(query))
        {
            while (reader.Read())
            {
                years.Add(reader.GetInt32(0));
            }
        }

        return years;
    }
    //Hàm Lọc + Tìm kiếm
    public List<Salary> SearchSalaries(
    int? salaryID,
    string fullName,
    decimal? baseSalary,
    decimal? allowance,
    decimal? bonus,
    decimal? penalty,
    int? overtimeHours,
    string salaryMonthStr,
    string salaryYearStr,
    string departmentName,
    string positionName
)
    {
        List<Salary> list = new List<Salary>();

        // Chuyển chuỗi tháng năm thành số, hoặc null nếu không hợp lệ hoặc là "Tất cả"
        int? salaryMonth = null;
        if (!string.IsNullOrEmpty(salaryMonthStr) && salaryMonthStr != "Tất cả")
        {
            if (int.TryParse(salaryMonthStr, out int temp))
                salaryMonth = temp;
        }

        int? salaryYear = null;
        if (!string.IsNullOrEmpty(salaryYearStr) && salaryYearStr != "Tất cả")
        {
            if (int.TryParse(salaryYearStr, out int temp))
                salaryYear = temp;
        }

        // Nếu là "Tất cả", bỏ qua lọc (truyền null)
        if (!string.IsNullOrEmpty(departmentName) && departmentName == "Tất cả")
        {
            departmentName = null;
        }

        if (!string.IsNullOrEmpty(positionName) && positionName == "Tất cả")
        {
            positionName = null;
        }

        string query = @"
    SELECT s.SalaryID, e.FullName, s.BaseSalary, s.Allowance, s.Bonus, 
           s.Penalty, s.OvertimeHours, s.SalaryMonth, s.SalaryYear
    FROM Salaries s
    INNER JOIN Employees e ON s.EmployeeID = e.EmployeeID
    INNER JOIN Departments d ON e.DepartmentID = d.DepartmentID
    INNER JOIN Positions p ON e.PositionID = p.PositionID
    WHERE (@SalaryID IS NULL OR s.SalaryID = @SalaryID)
      AND (@FullName IS NULL OR e.FullName COLLATE SQL_Latin1_General_CP1_CI_AS LIKE '%' + @FullName + '%')
      AND (@BaseSalary IS NULL OR s.BaseSalary = @BaseSalary)
      AND (@Allowance IS NULL OR s.Allowance = @Allowance)
      AND (@Bonus IS NULL OR s.Bonus = @Bonus)
      AND (@Penalty IS NULL OR s.Penalty = @Penalty)
      AND (@OvertimeHours IS NULL OR s.OvertimeHours = @OvertimeHours)
      AND (@SalaryMonth IS NULL OR s.SalaryMonth = @SalaryMonth)
      AND (@SalaryYear IS NULL OR s.SalaryYear = @SalaryYear)
      AND (@DepartmentName IS NULL OR d.DepartmentName COLLATE SQL_Latin1_General_CP1_CI_AS LIKE '%' + @DepartmentName + '%')
      AND (@PositionName IS NULL OR p.PositionName COLLATE SQL_Latin1_General_CP1_CI_AS LIKE '%' + @PositionName + '%')
    ";

        SqlParameter[] parameters = new SqlParameter[]
        {
        new SqlParameter("@SalaryID", SqlDbType.Int) { Value = salaryID.HasValue ? (object)salaryID.Value : DBNull.Value },
        new SqlParameter("@FullName", SqlDbType.NVarChar, 100) { Value = string.IsNullOrEmpty(fullName) ? (object)DBNull.Value : fullName },
        new SqlParameter("@BaseSalary", SqlDbType.Decimal) { Value = baseSalary.HasValue ? (object)baseSalary.Value : DBNull.Value },
        new SqlParameter("@Allowance", SqlDbType.Decimal) { Value = allowance.HasValue ? (object)allowance.Value : DBNull.Value },
        new SqlParameter("@Bonus", SqlDbType.Decimal) { Value = bonus.HasValue ? (object)bonus.Value : DBNull.Value },
        new SqlParameter("@Penalty", SqlDbType.Decimal) { Value = penalty.HasValue ? (object)penalty.Value : DBNull.Value },
        new SqlParameter("@OvertimeHours", SqlDbType.Int) { Value = overtimeHours.HasValue ? (object)overtimeHours.Value : DBNull.Value },
        new SqlParameter("@SalaryMonth", SqlDbType.Int) { Value = salaryMonth.HasValue ? (object)salaryMonth.Value : DBNull.Value },
        new SqlParameter("@SalaryYear", SqlDbType.Int) { Value = salaryYear.HasValue ? (object)salaryYear.Value : DBNull.Value },
        new SqlParameter("@DepartmentName", SqlDbType.NVarChar, 100) { Value = string.IsNullOrEmpty(departmentName) ? (object)DBNull.Value : departmentName },
        new SqlParameter("@PositionName", SqlDbType.NVarChar, 100) { Value = string.IsNullOrEmpty(positionName) ? (object)DBNull.Value : positionName }
        };

        using (SqlDataReader reader = DBConnection.ExecuteReader(query, parameters))
        {
            while (reader.Read())
            {
                Salary sal = new Salary();

                sal.SalaryID = reader.GetInt32(reader.GetOrdinal("SalaryID"));
                sal.FullName = reader.IsDBNull(reader.GetOrdinal("FullName")) ? "" : reader.GetString(reader.GetOrdinal("FullName"));
                sal.BaseSalary = reader.IsDBNull(reader.GetOrdinal("BaseSalary")) ? 0 : reader.GetDecimal(reader.GetOrdinal("BaseSalary"));
                sal.Allowance = reader.IsDBNull(reader.GetOrdinal("Allowance")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Allowance"));
                sal.Bonus = reader.IsDBNull(reader.GetOrdinal("Bonus")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Bonus"));
                sal.Penalty = reader.IsDBNull(reader.GetOrdinal("Penalty")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Penalty"));
                sal.OvertimeHours = reader.IsDBNull(reader.GetOrdinal("OvertimeHours")) ? 0 : reader.GetInt32(reader.GetOrdinal("OvertimeHours"));
                sal.SalaryMonth = reader.IsDBNull(reader.GetOrdinal("SalaryMonth")) ? 0 : reader.GetInt32(reader.GetOrdinal("SalaryMonth"));
                sal.SalaryYear = reader.IsDBNull(reader.GetOrdinal("SalaryYear")) ? 0 : reader.GetInt32(reader.GetOrdinal("SalaryYear"));

                list.Add(sal);
            }
        }

        return list;
    }


    public bool InsertSalary(string employeeName, int month, int year,
    decimal allowance, decimal bonus, decimal penalty, int overtimeHours, ref string error)
    {
        // Lấy EmployeeID từ tên
        string queryGetID = "SELECT EmployeeID FROM Employees WHERE FullName = @FullName";
        SqlParameter[] paramGetID = {
        new SqlParameter("@FullName", SqlDbType.NVarChar, 100) { Value = employeeName }
    };

        object result = DBConnection.ExecuteScalar(queryGetID, paramGetID);
        if (result == null || result == DBNull.Value)
        {
            error = "Tên nhân viên không tồn tại.";
            return false;
        }

        int employeeID = Convert.ToInt32(result);

        // Lấy BaseSalary từ bảng Positions qua PositionID
        string queryGetSalary = @"
        SELECT P.BaseSalary
        FROM Employees E
        JOIN Positions P ON E.PositionID = P.PositionID
        WHERE E.EmployeeID = @EmployeeID";

        SqlParameter[] paramSalary = {
        new SqlParameter("@EmployeeID", employeeID)
    };

        object baseSalaryResult = DBConnection.ExecuteScalar(queryGetSalary, paramSalary);
        if (baseSalaryResult == null || baseSalaryResult == DBNull.Value)
        {
            error = "Không tìm thấy lương cơ bản từ chức vụ.";
            return false;
        }

        decimal baseSalary = Convert.ToDecimal(baseSalaryResult);

        // Chèn dữ liệu vào bảng Salaries
        string queryInsert = @"
        INSERT INTO Salaries (EmployeeID, BaseSalary, Allowance, Bonus, Penalty, OvertimeHours, SalaryMonth, SalaryYear)
        VALUES (@EmployeeID, @BaseSalary, @Allowance, @Bonus, @Penalty, @OvertimeHours, @SalaryMonth, @SalaryYear)";

        SqlParameter[] insertParams = {
        new SqlParameter("@EmployeeID", employeeID),
        new SqlParameter("@BaseSalary", baseSalary),
        new SqlParameter("@Allowance", allowance),
        new SqlParameter("@Bonus", bonus),
        new SqlParameter("@Penalty", penalty),
        new SqlParameter("@OvertimeHours", overtimeHours),
        new SqlParameter("@SalaryMonth", month),
        new SqlParameter("@SalaryYear", year)
    };

        return db.MyExecuteNonQuery(queryInsert, CommandType.Text, ref error, insertParams);
    }

    public bool DeleteSalariesByIDs(List<int> salaryIDs, ref string error)
    {
        if (salaryIDs == null || salaryIDs.Count == 0)
        {
            error = "Danh sách ID không hợp lệ.";
            return false;
        }

        string joinedIDs = string.Join(",", salaryIDs);
        string query = $"DELETE FROM Salaries WHERE SalaryID IN ({joinedIDs})";

        return db.MyExecuteNonQuery(query, CommandType.Text, ref error);
    }

    public bool UpdateSalaryByID(int salaryID, string fullName, decimal allowance, int month, int year, ref string error)
    {
        // Lấy EmployeeID từ FullName
        string queryGetEmployeeID = "SELECT EmployeeID FROM Employees WHERE FullName = @FullName";
        SqlParameter[] paramGetEmp = {
        new SqlParameter("@FullName", SqlDbType.NVarChar, 100) { Value = fullName }
    };
        object empIDObj = DBConnection.ExecuteScalar(queryGetEmployeeID, paramGetEmp);

        if (empIDObj == null || empIDObj == DBNull.Value)
        {
            error = "Tên nhân viên không tồn tại.";
            return false;
        }

        int employeeID;
        if (!int.TryParse(empIDObj.ToString(), out employeeID) || employeeID == 0)
        {
            error = "Tên nhân viên không hợp lệ.";
            return false;
        }

        string updateQuery = @"
        UPDATE Salaries
        SET EmployeeID = @EmployeeID,
            Allowance = @Allowance,
            SalaryMonth = @SalaryMonth,
            SalaryYear = @SalaryYear
        WHERE SalaryID = @SalaryID";

        SqlParameter[] parameters = {
        new SqlParameter("@EmployeeID", employeeID),
        new SqlParameter("@Allowance", allowance),
        new SqlParameter("@SalaryMonth", month),
        new SqlParameter("@SalaryYear", year),
        new SqlParameter("@SalaryID", salaryID)
    };

        return db.MyExecuteNonQuery(updateQuery, CommandType.Text, ref error, parameters);
    }

    //Lấy lương của tháng này
    public DataTable GetAllSalaries(int month, int year)
    {
        string query = $@"
    SELECT
        ISNULL(s.SalaryID, 0) AS SalaryID,
        e.EmployeeID,
        e.FullName,
        ISNULL(s.SalaryMonth, {month}) AS SalaryMonth,
        ISNULL(s.SalaryYear, {year}) AS SalaryYear,
        ISNULL(s.BaseSalary, 0) AS BaseSalary,
        ISNULL(s.Allowance, 0) AS Allowance,
        ISNULL(s.Bonus, 0) AS Bonus,
        ISNULL(s.Penalty, 0) AS Penalty,
        ISNULL(s.OvertimeHours, 0) AS OvertimeHours,
        (ISNULL(s.BaseSalary, 0) + ISNULL(s.Allowance, 0) + ISNULL(s.Bonus, 0) 
         - ISNULL(s.Penalty, 0) + (ISNULL(s.OvertimeHours, 0) * 50000)) AS TotalSalary
    FROM 
        Employees e
    LEFT JOIN 
        Salaries s ON e.EmployeeID = s.EmployeeID AND s.SalaryMonth = {month} AND s.SalaryYear = {year}
    WHERE 
        e.isFired = 0";  // chưa nghỉ việc (false)

        DataSet ds = db.ExecuteQueryDataSet(query, CommandType.Text);
        return ds.Tables[0];
    }

}
