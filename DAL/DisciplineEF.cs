using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using System.Data;
using CompanyHRManagement;

public class DisciplineEF
{
    DBConnection db = new DBConnection();
    public List<Discipline> GetDisciplinesByEmployeeId(int employeeId)
    {
        List<Discipline> disciplines = new List<Discipline>();

        string query = "SELECT DisciplineID, EmployeeID, Reason, DisciplineDate, Amount " +
                       "FROM Disciplines WHERE EmployeeID = @EmployeeID";

        using (SqlConnection conn = DBConnection.GetConnection())
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Discipline discipline = new Discipline
                    {
                        DisciplineID = (int)reader["DisciplineID"],
                        EmployeeID = (int)reader["EmployeeID"],
                        Reason = reader["Reason"].ToString(),
                        DisciplineDate = (DateTime)reader["DisciplineDate"],
                        Amount = (decimal)reader["Amount"]
                    };
                    disciplines.Add(discipline);
                }
            }
        }

        return disciplines;
    }

    public List<Discipline> GetDisciplinesWithEmployeeName()
    {
        List<Discipline> disciplines = new List<Discipline>();
        string query = @"
        SELECT d.DisciplineID, d.EmployeeID, e.FullName, d.Reason, d.DisciplineDate, d.Amount
        FROM Disciplines d
        JOIN Employees e ON d.EmployeeID = e.EmployeeID";

        using (SqlDataReader reader = DBConnection.ExecuteReader(query))
        {
            while (reader.Read())
            {
                disciplines.Add(new Discipline
                {
                    DisciplineID = reader.GetInt32(0),
                    EmployeeID = reader.GetInt32(1), // <-- sửa chỗ này
                    FullName = reader.GetString(2),
                    Reason = reader.IsDBNull(3) ? null : reader.GetString(3),
                    DisciplineDate = reader.GetDateTime(4),
                    Amount = reader.GetDecimal(5)
                });
            }
        }

        return disciplines;
    }
    //Tìm kiếm
    public List<Discipline> SearchDisciplines(
        string disciplineID, string fullName, string reason,
        string day, string month, string year, string amount)
    {
        List<Discipline> disciplines = new List<Discipline>();
        List<string> conditions = new List<string>();
        List<SqlParameter> parameters = new List<SqlParameter>();

        string query = @"
            SELECT d.DisciplineID, d.EmployeeID, e.FullName, d.Reason, d.DisciplineDate, d.Amount
            FROM Disciplines d
            JOIN Employees e ON d.EmployeeID = e.EmployeeID
            WHERE 1=1";

        if (!string.IsNullOrWhiteSpace(disciplineID))
        {
            conditions.Add("CAST(d.DisciplineID AS NVARCHAR) LIKE @DisciplineID");
            parameters.Add(new SqlParameter("@DisciplineID", "%" + disciplineID + "%"));
        }

        if (!string.IsNullOrWhiteSpace(fullName))
        {
            conditions.Add("e.FullName LIKE @FullName");
            parameters.Add(new SqlParameter("@FullName", "%" + fullName + "%"));
        }

        if (!string.IsNullOrWhiteSpace(reason))
        {
            conditions.Add("d.Reason LIKE @Reason");
            parameters.Add(new SqlParameter("@Reason", "%" + reason + "%"));
        }

        if (!string.IsNullOrWhiteSpace(day))
        {
            conditions.Add("DAY(d.DisciplineDate) = @Day");
            parameters.Add(new SqlParameter("@Day", int.Parse(day)));
        }

        if (!string.IsNullOrWhiteSpace(month))
        {
            conditions.Add("MONTH(d.DisciplineDate) = @Month");
            parameters.Add(new SqlParameter("@Month", int.Parse(month)));
        }

        if (!string.IsNullOrWhiteSpace(year))
        {
            conditions.Add("YEAR(d.DisciplineDate) = @Year");
            parameters.Add(new SqlParameter("@Year", int.Parse(year)));
        }

        if (!string.IsNullOrWhiteSpace(amount))
        {
            conditions.Add("CAST(d.Amount AS NVARCHAR) LIKE @Amount");
            parameters.Add(new SqlParameter("@Amount", "%" + amount + "%"));
        }

        if (conditions.Count > 0)
        {
            query += " AND " + string.Join(" AND ", conditions);
        }

        using (SqlDataReader reader = DBConnection.ExecuteReader(query, parameters.ToArray()))
        {
            while (reader.Read())
            {
                disciplines.Add(new Discipline
                {
                    DisciplineID = reader.GetInt32(0),
                    EmployeeID = reader.GetInt32(1),
                    FullName = reader.GetString(2),
                    Reason = reader.IsDBNull(3) ? null : reader.GetString(3),
                    DisciplineDate = reader.GetDateTime(4),
                    Amount = reader.GetDecimal(5)
                });
            }
        }

        return disciplines;
    }
    //Thêm phạt
    public bool InsertDiscipline(string fullName, string reason, DateTime disciplineDate, decimal amount, ref string error)
    {
        // Lấy EmployeeID từ tên
        string queryEmpID = $"SELECT EmployeeID FROM Employees WHERE FullName = N'{fullName.Replace("'", "''")}'";
        object result = DBConnection.ExecuteScalar(queryEmpID);

        if (result == null || result.ToString() == "0")
        {
            error = "Không tìm thấy nhân viên.";
            return false;
        }

        int employeeID = Convert.ToInt32(result);
        string dateStr = disciplineDate.ToString("yyyy-MM-dd");
        reason = reason.Replace("'", "''");

        string insertQuery = $@"
            INSERT INTO Disciplines (EmployeeID, Reason, DisciplineDate, Amount)
            VALUES ({employeeID}, N'{reason}', '{dateStr}', {amount})";

        return db.MyExecuteNonQuery(insertQuery, CommandType.Text, ref error);
    }

    public bool DeleteDisciplinesByIDs(List<int> disciplineIDs, ref string error)
    {
        if (disciplineIDs == null || disciplineIDs.Count == 0)
        {
            error = "Danh sách ID không hợp lệ.";
            return false;
        }

        string joinedIDs = string.Join(",", disciplineIDs);
        string query = $"DELETE FROM Disciplines WHERE DisciplineID IN ({joinedIDs})";

        return db.MyExecuteNonQuery(query, CommandType.Text, ref error);
    }

    public bool UpdateDisciplineByID(int disciplineID, string fullName, string reason, DateTime disciplineDate, decimal amount, ref string error)
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

        if (!int.TryParse(empIDObj.ToString(), out int employeeID) || employeeID <= 0)
        {
            error = "EmployeeID không hợp lệ.";
            return false;
        }

        string updateQuery = @"
            UPDATE Disciplines
            SET EmployeeID = @EmployeeID,
                Reason = @Reason,
                DisciplineDate = @DisciplineDate,
                Amount = @Amount
            WHERE DisciplineID = @DisciplineID";

        SqlParameter[] parameters = {
            new SqlParameter("@EmployeeID", employeeID),
            new SqlParameter("@Reason", reason),
            new SqlParameter("@DisciplineDate", disciplineDate),
            new SqlParameter("@Amount", amount),
            new SqlParameter("@DisciplineID", disciplineID)
        };

        return db.MyExecuteNonQuery(updateQuery, CommandType.Text, ref error, parameters);
    }
}
