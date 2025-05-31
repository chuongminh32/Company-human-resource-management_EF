using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CompanyHRManagement;
using CompanyHRManagement.DTO;

public class RewardBUS
{
    private RewardEF r = new RewardEF();

    public DataTable LayDanhSachThuongTheoNhanVien(int employeeId)
    {
        return r.LayDanhSachThuongTheoNhanVien(employeeId);
    }

    public List<RewardDTO> LayDanhSachKhenThuong()
    {
        return r.GetRewardsWithEmployeeName();
    }
    public List<RewardDTO> TimKiemThuong(
        string rewardID, string fullName, string reason,
        string day, string month, string year, string amount)
    {
        return r.SearchRewards(rewardID, fullName, reason, day, month, year, amount);
    }

    public bool ThemThuong(string fullName, string reason, string dayStr, string monthStr, string yearStr, decimal amount, ref string error)
    {
        if (string.IsNullOrWhiteSpace(fullName))
        {
            error = "Tên nhân viên không được để trống.";
            return false;
        }

        if (amount < 0)
        {
            error = "Số tiền không hợp lệ.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(reason))
        {
            reason = "Không ghi rõ lý do.";
        }

        // Kiểm tra và chuyển đổi ngày/tháng/năm
        if (!int.TryParse(dayStr, out int day) || !int.TryParse(monthStr, out int month) || !int.TryParse(yearStr, out int year))
        {
            error = "Ngày, tháng hoặc năm không hợp lệ.";
            return false;
        }

        DateTime rewardDate;
        try
        {
            rewardDate = new DateTime(year, month, day);
        }
        catch
        {
            error = "Ngày tháng năm không tồn tại.";
            return false;
        }

        return r.InsertReward(fullName, reason, rewardDate, amount, ref error);
    }

    public bool xoaThuong(List<int> rewardIDs, ref string error)
    {
        return r.DeleteRewardsByIDs(rewardIDs, ref error);
    }

    public bool CapNhatReward(string rewardIDStr, string fullName, string reason, string dayStr, string monthStr, string yearStr, decimal amount, ref string error)
    {
        // Chuyển RewardID
        if (!int.TryParse(rewardIDStr.Trim(), out int rewardID))
        {
            error = "RewardID không hợp lệ.";
            return false;
        }

        // Chuyển ngày tháng năm
        if (!int.TryParse(dayStr.Trim(), out int day) ||
            !int.TryParse(monthStr.Trim(), out int month) ||
            !int.TryParse(yearStr.Trim(), out int year))
        {
            error = "Ngày, tháng hoặc năm không hợp lệ.";
            return false;
        }


        // Tạo DateTime
        DateTime rewardDate;
        try
        {
            rewardDate = new DateTime(year, month, day);
        }
        catch
        {
            error = "Giá trị ngày tháng không hợp lệ.";
            return false;
        }

        // Gọi DAO để cập nhật
        return r.UpdateRewardByID(rewardID, fullName, reason, rewardDate, amount, ref error);
    }


}
