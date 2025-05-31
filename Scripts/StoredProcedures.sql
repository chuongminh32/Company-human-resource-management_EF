-- StoredProcedures.sql - Các thủ tục lưu trữ hỗ trợ hệ thống quản lý nhân sự

-- 1. Tính tổng lương thực nhận cho 1 nhân viên theo tháng
CREATE PROCEDURE sp_CalculateSalary
    @EmployeeID INT,
    @Month INT,
    @Year INT
AS
BEGIN
    SELECT 
        e.EmployeeID,
        e.FullName,
        s.BaseSalary,
        s.Allowance,
        s.Bonus,
        s.Penalty,
        s.OvertimeHours,
        (s.BaseSalary + s.Allowance + s.Bonus + (s.OvertimeHours * 30000) - s.Penalty) AS TotalSalary
    FROM Salaries s
    JOIN Employees e ON s.EmployeeID = e.EmployeeID
    WHERE s.EmployeeID = @EmployeeID AND s.SalaryMonth = @Month AND s.SalaryYear = @Year;
END;
GO

-- 2. Tìm kiếm nhân viên theo tên và phòng ban
CREATE PROCEDURE sp_SearchEmployee
    @Keyword NVARCHAR(100),
    @DepartmentID INT = NULL
AS
BEGIN
    SELECT 
        e.EmployeeID, e.FullName, d.DepartmentName, e.Email, e.Phone
    FROM Employees e
    JOIN Departments d ON e.DepartmentID = d.DepartmentID
    WHERE e.FullName LIKE '%' + @Keyword + '%'
        AND (@DepartmentID IS NULL OR e.DepartmentID = @DepartmentID);
END;
GO

-- 3. Đổi mật khẩu người dùng
CREATE PROCEDURE sp_ChangePassword
    @Username NVARCHAR(50),
    @OldPasswordHash NVARCHAR(255),
    @NewPasswordHash NVARCHAR(255)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Users WHERE Username = @Username AND PasswordHash = @OldPasswordHash)
    BEGIN
        UPDATE Users SET PasswordHash = @NewPasswordHash WHERE Username = @Username;
        SELECT 'Success' AS Status;
    END
    ELSE
    BEGIN
        SELECT 'Invalid credentials' AS Status;
    END
END;
GO

--- check: 
-- Kiểm tra thủ tục sp_CalculateSalary
EXEC sp_helptext 'sp_CalculateSalary';

-- Kiểm tra thủ tục sp_SearchEmployee
EXEC sp_helptext 'sp_SearchEmployee';

-- Kiểm tra thủ tục sp_ChangePassword
EXEC sp_helptext 'sp_ChangePassword';


-- cách dùng :
-- Tính lương nhân viên với EmployeeID = 1, tháng 5, năm 2025
EXEC sp_CalculateSalary @EmployeeID = 1, @Month = 5, @Year = 2025;

-- Tìm kiếm nhân viên tên "Nguyen" trong phòng ban ID = 2
EXEC sp_SearchEmployee @Keyword = 'Nguyen', @DepartmentID = 2;

-- Đổi mật khẩu cho người dùng với tên "user123"
EXEC sp_ChangePassword @Username = 'user123', @OldPasswordHash = 'oldHash123', @NewPasswordHash = 'newHash456';
