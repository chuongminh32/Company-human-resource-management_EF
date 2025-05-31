using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using System.Data;

public class RewardDAO
{
    DBConnection db = new DBConnection();

    public List<Reward> GetRewardsByEmployeeId(int employeeId)
        {
        List<Reward> rewards = new List<Reward>();

        string query = "SELECT RewardID, EmployeeID, Reason, RewardDate, Amount " +
                       "FROM Rewards WHERE EmployeeID = @EmployeeID";

        using (SqlConnection conn = DBConnection.GetConnection())
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Reward reward = new Reward
                    {
                        RewardID = (int)reader["RewardID"],
                        EmployeeID = (int)reader["EmployeeID"],
                        Reason = reader["Reason"].ToString(),
                        RewardDate = (DateTime)reader["RewardDate"],
                        Amount = (decimal)reader["Amount"]
                    };
                    rewards.Add(reward);
                }
            }
        }

        return rewards;
        }
    public List<Reward> GetRewardsWithEmployeeName()
    {
        List<Reward> rewards = new List<Reward>();
        string query = @"
            SELECT r.RewardID, r.EmployeeID, e.FullName, r.Reason, r.RewardDate, r.Amount
            FROM Rewards r
            JOIN Employees e ON r.EmployeeID = e.EmployeeID";

        using (SqlDataReader reader = DBConnection.ExecuteReader(query))
        {
            while (reader.Read())
            {
                rewards.Add(new Reward
                {
                    RewardID = reader.GetInt32(0),
                    EmployeeID = reader.GetInt32(0),
                    FullName = reader.GetString(2),
                    Reason = reader.IsDBNull(3) ? null : reader.GetString(3),
                    RewardDate = reader.GetDateTime(4),
                    Amount = reader.GetDecimal(5)
                });
            }
        }

        return rewards;
    }
    //Tìm kiếm Thưởng
    public List<Reward> SearchRewards(
    string rewardID, string fullName, string reason,
    string day, string month, string year, string amount)
    {
        List<Reward> rewards = new List<Reward>();
        List<string> conditions = new List<string>();
        List<SqlParameter> parameters = new List<SqlParameter>();

        string query = @"
        SELECT r.RewardID, r.EmployeeID, e.FullName, r.Reason, r.RewardDate, r.Amount
        FROM Rewards r
        JOIN Employees e ON r.EmployeeID = e.EmployeeID
        WHERE 1=1";

        if (!string.IsNullOrWhiteSpace(rewardID))
        {
            conditions.Add("CAST(r.RewardID AS NVARCHAR) LIKE @RewardID");
            parameters.Add(new SqlParameter("@RewardID", "%" + rewardID + "%"));
        }

        if (!string.IsNullOrWhiteSpace(fullName))
        {
            conditions.Add("e.FullName LIKE @FullName");
            parameters.Add(new SqlParameter("@FullName", "%" + fullName + "%"));
        }

        if (!string.IsNullOrWhiteSpace(reason))
        {
            conditions.Add("r.Reason LIKE @Reason");
            parameters.Add(new SqlParameter("@Reason", "%" + reason + "%"));
        }

        if (!string.IsNullOrWhiteSpace(day))
        {
            conditions.Add("DAY(r.RewardDate) = @Day");
            parameters.Add(new SqlParameter("@Day", int.Parse(day)));
        }

        if (!string.IsNullOrWhiteSpace(month))
        {
            conditions.Add("MONTH(r.RewardDate) = @Month");
            parameters.Add(new SqlParameter("@Month", int.Parse(month)));
        }

        if (!string.IsNullOrWhiteSpace(year))
        {
            conditions.Add("YEAR(r.RewardDate) = @Year");
            parameters.Add(new SqlParameter("@Year", int.Parse(year)));
        }

        if (!string.IsNullOrWhiteSpace(amount))
        {
            conditions.Add("CAST(r.Amount AS NVARCHAR) LIKE @Amount");
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
                rewards.Add(new Reward
                {
                    RewardID = reader.GetInt32(0),
                    EmployeeID = reader.GetInt32(1),
                    FullName = reader.GetString(2),
                    Reason = reader.IsDBNull(3) ? null : reader.GetString(3),
                    RewardDate = reader.GetDateTime(4),
                    Amount = reader.GetDecimal(5)
                });
            }
        }

        return rewards;
    }
    //Thêm bản ghi thưởng
    public bool InsertReward(string fullName, string reason, DateTime rewardDate, decimal amount, ref string error)
    {
        // Lấy EmployeeID từ tên nhân viên
        string queryEmpID = $"SELECT EmployeeID FROM Employees WHERE FullName = N'{fullName.Replace("'", "''")}'";
        object result = DBConnection.ExecuteScalar(queryEmpID);

        if (result == null || result.ToString() == "0")
        {
            error = "Không tìm thấy nhân viên.";
            return false;
        }

        int employeeID = Convert.ToInt32(result);
        string dateStr = rewardDate.ToString("yyyy-MM-dd");
        reason = reason.Replace("'", "''"); // Tránh lỗi do dấu nháy đơn

        string insertQuery = $@"
            INSERT INTO Rewards (EmployeeID, Reason, RewardDate, Amount)
            VALUES ({employeeID}, N'{reason}', '{dateStr}', {amount})";

        return db.MyExecuteNonQuery(insertQuery, CommandType.Text, ref error);
    }

    public bool DeleteRewardsByIDs(List<int> rewardIDs, ref string error)
    {
        if (rewardIDs == null || rewardIDs.Count == 0)
        {
            error = "Danh sách ID không hợp lệ.";
            return false;
        }

        string joinedIDs = string.Join(",", rewardIDs);
        string query = $"DELETE FROM Rewards WHERE RewardID IN ({joinedIDs})";

        return db.MyExecuteNonQuery(query, CommandType.Text, ref error);
    }

    public bool UpdateRewardByID(int rewardID, string fullName, string reason, DateTime rewardDate, decimal amount, ref string error)
    {
        // 1. Lấy EmployeeID từ FullName
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

        if (!int.TryParse(empIDObj.ToString(), out int employeeID) || employeeID == 0)
        {
            error = "Tên nhân viên không hợp lệ.";
            return false;
        }

        // 2. Câu truy vấn cập nhật
        string updateQuery = @"
        UPDATE Rewards
        SET EmployeeID = @EmployeeID,
            Reason = @Reason,
            RewardDate = @RewardDate,
            Amount = @Amount
        WHERE RewardID = @RewardID";

        SqlParameter[] parameters = {
        new SqlParameter("@EmployeeID", employeeID),
        new SqlParameter("@Reason", SqlDbType.NVarChar, 250) { Value = (object)reason ?? DBNull.Value },
        new SqlParameter("@RewardDate", rewardDate),
        new SqlParameter("@Amount", amount),
        new SqlParameter("@RewardID", rewardID)
    };

        return db.MyExecuteNonQuery(updateQuery, CommandType.Text, ref error, parameters);
    }


}
