using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using CompanyHRManagement;
using CompanyHRManagement.DTO;

public class RewardEF
{
    DBConnection db = new DBConnection();

    /// <summary>
    /// Lấy thông tin Reward của một nhân viên (theo employeeId), trả về DataTable.
    /// </summary>
    public DataTable LayDanhSachThuongTheoNhanVien(int employeeId)
    {
        using (var context = new CompanyHRManagementEntities())
        {
            var query = from r in context.Rewards
                        join emp in context.Employees
                            on r.EmployeeID equals emp.EmployeeID
                        where r.EmployeeID == employeeId
                        select new
                        {
                            RewardID = r.RewardID,
                            EmployeeID = r.EmployeeID,
                            EmployeeName = emp.FullName,
                            Reason = r.Reason,
                            RewardDate = r.RewardDate,
                            Amount = r.Amount ?? 0m
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Reward", typeof(int));
            dt.Columns.Add("Mã nhân viên", typeof(int));
            dt.Columns.Add("Tên nhân viên", typeof(string));
            dt.Columns.Add("Lý do", typeof(string));
            dt.Columns.Add("Ngày thưởng", typeof(DateTime));
            dt.Columns.Add("Số tiền thưởng", typeof(decimal));

            foreach (var item in query)
            {
                dt.Rows.Add(
                    item.RewardID,
                    item.EmployeeID,
                    item.EmployeeName,
                    item.Reason,
                    item.RewardDate,
                    item.Amount
                );
            }

            return dt;
        }
    }

    public List<RewardDTO> GetRewardsWithEmployeeName()
    {
        using (var context = new CompanyHRManagementEntities())
        {
            return context.Rewards
                .Include("Employee")
                .Select(r => new RewardDTO
                {
                    RewardID = r.RewardID,
                    EmployeeID = (int)r.EmployeeID,
                    FullName = r.Employee.FullName,
                    Reason = r.Reason,
                    RewardDate = (DateTime)r.RewardDate,
                    Amount = (decimal)r.Amount
                })
                .ToList();
        }
    }
    //Tìm kiếm Thưởng
    public List<RewardDTO> SearchRewards(string rewardID, string fullName, string reason,
                                     string day, string month, string year, string amount)
    {
        using (var context = new CompanyHRManagementEntities())
        {
            var query = context.Rewards.Include("Employee").AsQueryable();

            if (!string.IsNullOrWhiteSpace(rewardID) && int.TryParse(rewardID, out int rid))
            {
                query = query.Where(r => r.RewardID == rid);
            }

            if (!string.IsNullOrWhiteSpace(fullName))
            {
                query = query.Where(r => r.Employee.FullName.Contains(fullName));
            }

            if (!string.IsNullOrWhiteSpace(reason))
            {
                query = query.Where(r => r.Reason.Contains(reason));
            }

            if (int.TryParse(day, out int d))
            {
                query = query.Where(r => r.RewardDate.Value.Day == d);
            }

            if (int.TryParse(month, out int m))
            {
                query = query.Where(r => r.RewardDate.Value.Month == m);
            }

            if (int.TryParse(year, out int y))
            {
                query = query.Where(r => r.RewardDate.Value.Year == y);
            }

            if (!string.IsNullOrWhiteSpace(amount) && decimal.TryParse(amount, out decimal amt))
            {
                query = query.Where(r => r.Amount == amt);
            }

            return query.Select(r => new RewardDTO
            {
                RewardID = r.RewardID,
                EmployeeID = (int)r.EmployeeID,
                FullName = r.Employee.FullName,
                Reason = r.Reason,
                RewardDate = (DateTime)r.RewardDate,
                Amount = (decimal)r.Amount
            }).ToList();
        }
    }

    //Thêm bản ghi thưởng
    public bool InsertReward(string fullName, string reason, DateTime rewardDate, decimal amount, ref string error)
    {
        using (var context = new CompanyHRManagementEntities())
        {
            var employee = context.Employees.FirstOrDefault(e => e.FullName == fullName);
            if (employee == null)
            {
                error = "Không tìm thấy nhân viên.";
                return false;
            }

            var reward = new Reward
            {
                EmployeeID = employee.EmployeeID,
                Reason = reason,
                RewardDate = rewardDate,
                Amount = amount
            };

            context.Rewards.Add(reward);
            context.SaveChanges();

            return true;
        }
    }


    public bool DeleteRewardsByIDs(List<int> rewardIDs, ref string error)
    {
        if (rewardIDs == null || rewardIDs.Count == 0)
        {
            error = "Danh sách ID không hợp lệ.";
            return false;
        }

        using (var context = new CompanyHRManagementEntities())
        {
            var rewards = context.Rewards.Where(r => rewardIDs.Contains(r.RewardID)).ToList();

            if (rewards.Count == 0)
            {
                error = "Không tìm thấy bản ghi để xóa.";
                return false;
            }

            context.Rewards.RemoveRange(rewards);
            context.SaveChanges();

            return true;
        }
    }


    public bool UpdateRewardByID(int rewardID, string fullName, string reason, DateTime rewardDate, decimal amount, ref string error)
    {
        using (var context = new CompanyHRManagementEntities())
        {
            var reward = context.Rewards.Find(rewardID);
            if (reward == null)
            {
                error = "Bản ghi không tồn tại.";
                return false;
            }

            var employee = context.Employees.FirstOrDefault(e => e.FullName == fullName);
            if (employee == null)
            {
                error = "Tên nhân viên không tồn tại.";
                return false;
            }

            reward.EmployeeID = employee.EmployeeID;
            reward.Reason = reason;
            reward.RewardDate = rewardDate;
            reward.Amount = amount;

            context.SaveChanges();
            return true;
        }
    }
}
