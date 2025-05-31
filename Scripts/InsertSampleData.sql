-- InsertSampleData.sql - Thêm dữ liệu mẫu cho hệ thống quản lý nhân sự

-- Thêm phòng ban
INSERT INTO Departments (DepartmentName) VALUES 
(N'Phòng Kế Toán'),
(N'Phòng Nhân Sự'),
(N'Phòng IT');

-- Thêm chức vụ / bộ phận
INSERT INTO Positions (PositionName) VALUES 
(N'Nhân viên'),
(N'Trưởng phòng'),
(N'Giám đốc');

-- Thêm nhân viên
INSERT INTO Employees (FullName, BirthDate, Gender, Address, Phone, Email, DepartmentID, PositionID, HireDate, IsProbation, IsFired)
VALUES 
(N'Nguyễn Văn A', '1995-01-01', N'Nam', N'123 Lê Lợi, HCM', '0909123456', 'a.nguyen@email.com', 1, 1, '2020-03-15', 0, 0),
(N'Trần Thị B', '1998-05-20', N'Nữ', N'456 Trần Hưng Đạo, HCM', '0911223344', 'b.tran@email.com', 2, 2, '2022-07-01', 1, 0);

-- Thêm tài khoản người dùng
INSERT INTO Users (Username, PasswordHash, Role, EmployeeID)
VALUES 
('admin', 'hashed_password_1', 'Admin', 1),
('employee_b', 'hashed_password_2', 'Employee', 2);

-- Thêm bảng lương
INSERT INTO Salaries (EmployeeID, BaseSalary, Allowance, Bonus, Penalty, OvertimeHours, SalaryMonth, SalaryYear)
VALUES 
(1, 15000000, 2000000, 500000, 0, 10, 4, 2025),
(2, 10000000, 1000000, 0, 500000, 5, 4, 2025);

-- Thêm dữ liệu chấm công
INSERT INTO Attendance (EmployeeID, WorkDate, CheckIn, CheckOut)
VALUES 
(1, '2025-04-01', '08:00:00', '17:00:00'),
(2, '2025-04-01', '08:30:00', '17:15:00');

-- Thêm khen thưởng
INSERT INTO Rewards (EmployeeID, Reason, RewardDate, Amount)
VALUES 
(1, N'Hoàn thành dự án đúng hạn', '2025-03-30', 1000000);

-- Thêm kỷ luật
INSERT INTO Disciplines (EmployeeID, Reason, DisciplineDate, Amount)
VALUES 
(2, N'Đi làm trễ nhiều lần', '2025-03-25', 300000);

-- Thêm dữ liệu bảo hiểm
INSERT INTO Insurance (EmployeeID, InsuranceType, RegistrationDate, ExpiryDate)
VALUES 
(1, N'Bảo hiểm y tế', '2023-01-01', '2025-12-31');

-- Thêm tham số hệ thống
INSERT INTO Parameters (ParamName, ParamValue)
VALUES 
('LuongToiThieu', '5000000'),
('HeSoTangCa', '1.5');
