using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

public class AttendanceDAO
{
    DBConnection db = null;
    public AttendanceDAO()
    {
        db = new DBConnection();
    }
    private DBConnection dbConnection = new DBConnection();

    // lấy thông tin chấm công của nhân viên theo ID
    public List<Attendance> LayDuLieuChamCongQuaID(int employeeID)
    {
        List<Attendance> attendances = new List<Attendance>();
        string query = "SELECT * FROM Attendance WHERE EmployeeID = @EmployeeID";

        using (var conn = DBConnection.GetConnection())
        {
            conn.Open();
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        Attendance attendance = new Attendance()
                        {
                            AttendanceID = reader.GetInt32(0),  // Lấy AttendanceID
                            EmployeeID = reader.GetInt32(1),    // Lấy EmployeeID
                            WorkDate = reader.GetDateTime(2),    // Lấy WorkDate (ngày làm việc)
                            CheckIn = reader.IsDBNull(3) ? (TimeSpan?)null : reader.GetTimeSpan(3),  // Lấy CheckIn (giờ vào)
                            CheckOut = reader.IsDBNull(4) ? (TimeSpan?)null : reader.GetTimeSpan(4),  // Lấy CheckOut (giờ ra)
                            OvertimeHours = reader.GetInt32(5),  // Trả về giá trị mặc định nếu NULL (cho kiểu int)
                            AbsenceStatus = reader.GetString(6)  // Trả về giá trị mặc định nếu NULL (cho kiểu string)
                        };

                        attendances.Add(attendance);

                    }
                    catch (InvalidCastException ex)
                    {
                        // Xử lý ngoại lệ khi kiểu dữ liệu không hợp lệ, ví dụ như dữ liệu không phải là DateTime
                        Console.WriteLine($"Lỗi khi chuyển đổi kiểu dữ liệu: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        // Xử lý các lỗi chung khác
                        Console.WriteLine($"Lỗi khi xử lý dữ liệu attendance: {ex.Message}");
                    }
                }
            }
        }
        return attendances;
    }

    // lấy số ngày công trong tháng hiện tại của nhân viên
    public int laySoNgayCongTrongThangHienTaiTheoID(int employeeID)
    {
        int daysWorked = 0;
        string query = @"
        SELECT COUNT(DISTINCT WorkDate) AS DaysWorked
        FROM Attendance
        WHERE EmployeeID = @EmployeeID
        AND MONTH(WorkDate) = MONTH(GETDATE()) 
        AND YEAR(WorkDate) = YEAR(GETDATE())
        AND CheckIn IS NOT NULL AND CheckOut IS NOT NULL;
    ";

        using (var conn = DBConnection.GetConnection())
        {
            conn.Open();
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                var result = cmd.ExecuteScalar();
                daysWorked = result != DBNull.Value ? Convert.ToInt32(result) : 0;
            }
        }
        return daysWorked;
    }

    // -- chấm công ----
    // hàm kiểm tra ngày hôm nay có chấm công hay chưa 
    public Attendance KiemTraCongHomNay(int idNhanVien, DateTime ngayLam)
    {
        Attendance attendance = null;
        string query = "SELECT * FROM Attendance WHERE EmployeeID = @EmployeeID AND WorkDate = @WorkDate";

        using (var conn = DBConnection.GetConnection())
        {
            conn.Open();
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@EmployeeID", idNhanVien);
                cmd.Parameters.AddWithValue("@WorkDate", ngayLam);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    attendance = new Attendance()
                    {
                        AttendanceID = reader.GetInt32(0),
                        EmployeeID = reader.GetInt32(1),
                        WorkDate = reader.GetDateTime(2),
                        CheckIn = reader.IsDBNull(3) ? (TimeSpan?)null : reader.GetTimeSpan(3),  // Lấy CheckIn (giờ vào)
                        CheckOut = reader.IsDBNull(4) ? (TimeSpan?)null : reader.GetTimeSpan(4),  // Lấy CheckOut (giờ ra)
                        OvertimeHours = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                        AbsenceStatus = reader.IsDBNull(6) ? "" : reader.GetString(6)
                    };
                }
            }
        }
        return attendance;
    }

    // hàm chấm công cho nhân viên
    public bool themCong(Attendance attendance)
    {
        string query = "INSERT INTO Attendance (EmployeeID, WorkDate, CheckIn, CheckOut, OvertimeHours, AbsenceStatus) " +
                       "VALUES (@EmployeeID, @WorkDate, @CheckIn, @CheckOut, @OvertimeHours, @AbsenceStatus)";

        using (var conn = DBConnection.GetConnection())
        {
            conn.Open();
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@EmployeeID", attendance.EmployeeID);
                cmd.Parameters.AddWithValue("@WorkDate", attendance.WorkDate);
                cmd.Parameters.AddWithValue("@CheckIn", attendance.CheckIn ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@CheckOut", attendance.CheckOut ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@OvertimeHours", attendance.OvertimeHours);
                cmd.Parameters.AddWithValue("@AbsenceStatus", attendance.AbsenceStatus ?? "");

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }

    // hàm cập nhật giờ ra và số giờ tăng ca
    public bool capNhatCong(Attendance attendance)
    {
        string query = "UPDATE Attendance SET CheckOut = @CheckOut, OvertimeHours = @OvertimeHours WHERE AttendanceID = @AttendanceID";

        using (var conn = DBConnection.GetConnection())
        {
            conn.Open();
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CheckOut", attendance.CheckOut ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@OvertimeHours", attendance.OvertimeHours);
                cmd.Parameters.AddWithValue("@AttendanceID", attendance.AttendanceID);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }

    // Hàm tính tổng giờ làm việc trong tháng hiện tại của nhân viên
    public double TinhTongGioLamTrongThang(int employeeId)
    {
        double tongGioLam = 0;

        // Xác định ngày đầu và cuối tháng hiện tại
        DateTime ngayDauThang = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
        DateTime ngayCuoiThang = ngayDauThang.AddMonths(1).AddDays(-1); // lấy ngày đầu tháng kế tiếp - 1 -> ngày cuối tháng hiện tại
        string query = @"
        SELECT CheckIn, CheckOut 
        FROM Attendance
        WHERE EmployeeID = @EmployeeID 
            AND WorkDate >= @TuNgay 
            AND WorkDate <= @DenNgay
            AND CheckIn IS NOT NULL 
            AND CheckOut IS NOT NULL";
        using (var conn = DBConnection.GetConnection())
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                cmd.Parameters.AddWithValue("@TuNgay", ngayDauThang);
                cmd.Parameters.AddWithValue("@DenNgay", ngayCuoiThang);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TimeSpan checkIn = reader.GetTimeSpan(0);     // Cột CheckIn
                        TimeSpan checkOut = reader.GetTimeSpan(1);    // Cột CheckOut
                        TimeSpan duration = checkOut - checkIn;

                        tongGioLam += duration.TotalHours;
                    }
                }
            }
            return Math.Round(tongGioLam, 2);

        }
    }

    public DataSet GetAttendance()
    {
        string sql = @"
        SELECT 
            a.AttendanceID,
            a.EmployeeID,
            e.FullName AS EmployeeName,
            a.WorkDate,
            a.CheckIn,
            a.CheckOut,
            a.OvertimeHours,
            a.AbsenceStatus
        FROM 
            Attendance a
        JOIN 
            Employees e ON a.EmployeeID = e.EmployeeID";

        return db.ExecuteQueryDataSet(sql, CommandType.Text);

    }
    public (int tongNV, double tongNCtb, double OTtong) GetAttendanceSummary(DateTime date)
    {
        int tongNV = 0;
        double tongNCtb = 0;
        double OTtong = 0;

        const string sql = @"
         SELECT CheckIn, CheckOut, OvertimeHours
         FROM [Attendance]
         WHERE WorkDate = @date
         AND CheckIn IS NOT NULL
         AND CheckOut IS NOT NULL;
                        ";

        using (var conn = DBConnection.GetConnection())
        using (var cmd = new SqlCommand(sql, conn))
        {
            cmd.Parameters.AddWithValue("@date", date.Date);
            conn.Open();

            using (var reader = cmd.ExecuteReader())
            {
                int idxCheckIn = reader.GetOrdinal("CheckIn");
                int idxCheckOut = reader.GetOrdinal("CheckOut");
                int idxOT = reader.GetOrdinal("OvertimeHours");

                while (reader.Read())
                {
                    var checkIn = reader.GetTimeSpan(idxCheckIn);
                    var checkOut = reader.GetTimeSpan(idxCheckOut);
                    var dur = (checkOut - checkIn).TotalHours;

                    tongNV++;
                    tongNCtb += dur;

                    if (!reader.IsDBNull(idxOT))
                    {
                        // Try different ways to read the overtime hours
                        try
                        {
                            OTtong += Convert.ToDouble(reader.GetDecimal(idxOT));
                        }
                        catch (InvalidCastException)
                        {
                            try
                            {
                                OTtong += reader.GetDouble(idxOT);
                            }
                            catch (InvalidCastException)
                            {
                                OTtong += Convert.ToDouble(reader.GetValue(idxOT));
                            }
                        }
                    }
                }
            }
        }

        return (tongNV, tongNCtb, OTtong);
    }
    public List<DateTime> GetWorkDates()
    {
        var list = new List<DateTime>();
        string query = "SELECT DISTINCT WorkDate FROM Attendance ORDER BY WorkDate DESC";

        using (var conn = DBConnection.GetConnection())
        using (var cmd = new SqlCommand(query, conn))
        {
            conn.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(reader.GetDateTime(0));
                }
            }
        }
        return list;
    }

    public bool UpdateAttendance(DataTable changes)
    {
        try
        {
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();

                // Setup SELECT command to get schema
                SqlCommand selectCmd = new SqlCommand("SELECT * FROM Attendance WHERE 1=0", conn);
                da.SelectCommand = selectCmd;

                // Setup UPDATE command
                SqlCommand updateCmd = new SqlCommand(
                    @"UPDATE Attendance SET 
                    EmployeeID = @EmployeeID, 
                    WorkDate = @WorkDate, 
                    CheckIn = @CheckIn, 
                    CheckOut = @CheckOut, 
                    OvertimeHours = @OvertimeHours,
                    AbsenceStatus = @AbsenceStatus
                  WHERE AttendanceID = @AttendanceID", conn);

                updateCmd.Parameters.Add("@EmployeeID", SqlDbType.Int, 0, "EmployeeID");
                updateCmd.Parameters.Add("@WorkDate", SqlDbType.Date, 0, "WorkDate");
                updateCmd.Parameters.Add("@CheckIn", SqlDbType.Time, 0, "CheckIn");
                updateCmd.Parameters.Add("@CheckOut", SqlDbType.Time, 0, "CheckOut");
                updateCmd.Parameters.Add("@OvertimeHours", SqlDbType.Float, 0, "OvertimeHours");
                updateCmd.Parameters.Add("@AbsenceStatus", SqlDbType.NVarChar, 50, "AbsenceStatus");
                updateCmd.Parameters.Add("@AttendanceID", SqlDbType.Int, 0, "AttendanceID");

                da.UpdateCommand = updateCmd;

                // Perform the update
                da.Update(changes);
                return true;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error updating attendance: {ex.Message}");
            return false;
        }
    }

    public bool DeleteAttendance(int attendanceID)
    {
        string sql = "DELETE FROM Attendance WHERE AttendanceID = @AttendanceID";

        using (var conn = DBConnection.GetConnection())
        using (var cmd = new SqlCommand(sql, conn))
        {
            cmd.Parameters.AddWithValue("@AttendanceID", attendanceID);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }
    }

    public List<Attendance> GetMonthlyWorkDays()
    {
        // Khởi tạo danh sách để lưu kết quả trả về kiểu Attendance
        var list = new List<Attendance>();

        // Câu truy vấn SQL:
        // 1. Lấy định dạng tháng và năm từ cột WorkDate theo kiểu MM/yyyy, đặt tên là ThangNam
        // 2. Đếm số ngày công (số ngày làm việc) khác nhau trong từng tháng, dùng COUNT(DISTINCT)
        // 3. Nhóm theo ThangNam (tháng-năm)
        // 4. Sắp xếp theo ngày nhỏ nhất trong nhóm (để tháng năm đúng thứ tự)
        string query = @"
        SELECT FORMAT(WorkDate, 'MM/yyyy') AS ThangNam,
               COUNT(DISTINCT CAST(WorkDate AS DATE)) AS SoNgayCong
        FROM Attendance
        GROUP BY FORMAT(WorkDate, 'MM/yyyy')
        ORDER BY MIN(WorkDate)";

        // Sử dụng SqlConnection lấy kết nối từ DBConnection.GetConnection() (phương thức riêng của bạn)
        using (SqlConnection conn = DBConnection.GetConnection())
        // Tạo SqlCommand để thực thi câu truy vấn trên kết nối conn
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            conn.Open(); // Mở kết nối đến database

            // Thực thi truy vấn và trả về SqlDataReader để đọc dữ liệu
            SqlDataReader reader = cmd.ExecuteReader();

            // Đọc từng dòng dữ liệu trong kết quả truy vấn
            while (reader.Read())
            {
                // Tạo đối tượng Attendance mới, gán dữ liệu từ cột 0 (ThangNam) và cột 1 (SoNgayCong)
                list.Add(new Attendance
                {
                    MonthYear = reader.GetString(0), // Lấy chuỗi tháng-năm dạng "MM/yyyy"
                    WorkDays = reader.GetInt32(1)    // Lấy số ngày công làm việc trong tháng
                });
            }
        }

        // Trả về danh sách Attendance chứa số ngày công theo từng tháng
        return list;
    }
}
