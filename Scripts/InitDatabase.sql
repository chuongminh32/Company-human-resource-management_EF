-- CreateTables.sql - Tạo cấu trúc bảng CSDL cho hệ thống quản lý nhân sự

-- Bảng nhân viên
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    BirthDate DATE,
    Gender NVARCHAR(10),
    Address NVARCHAR(255),
    Phone NVARCHAR(20),
    Email NVARCHAR(100),
    DepartmentID INT,
    PositionID INT,
    HireDate DATE,
    IsProbation BIT,
    IsFired BIT DEFAULT 0,
    password NVARCHAR(255) NOT NULL,  -- Mật khẩu đã mã hóa (hash)
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID),
    FOREIGN KEY (PositionID) REFERENCES Positions(PositionID)
);

-- Bảng chấm công
CREATE TABLE Attendance (
    AttendanceID INT PRIMARY KEY IDENTITY(1,1),
    EmployeeID INT,
    WorkDate DATE,  
    CheckIn TIME,
    CheckOut TIME,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- Bảng phòng ban
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY IDENTITY(1,1),
    DepartmentName NVARCHAR(100) NOT NULL
);

-- Bảng kỷ luật
CREATE TABLE Disciplines (
    DisciplineID INT PRIMARY KEY IDENTITY(1,1),
    EmployeeID INT,
    Reason NVARCHAR(255),
    DisciplineDate DATE,   -- Ngày kỷ luật
    Amount DECIMAL(18,2),  -- Số tiền phạt
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- Bảng nghỉ phép	
CREATE TABLE Leaves (
    leaveID INT PRIMARY KEY,       -- Mã nghỉ phép (tự tăng - sẽ được thêm thủ công ở đây)
    employeeID INT NOT NULL,       -- Mã nhân viên (liên kết tới bảng Employee)
    startDate DATE NOT NULL,       -- Ngày bắt đầu nghỉ
    endDate DATE NOT NULL,         -- Ngày kết thúc nghỉ
    reason NVARCHAR(255),           -- Lý do nghỉ
    status NVARCHAR(50) DEFAULT 'chờ duyệt',  -- Trạng thái (chờ duyệt, đã duyệt, từ chối)
    FOREIGN KEY (employeeID) REFERENCES Employees(EmployeeID)
);

-- Bảng thông báo 
CREATE TABLE Messages (
    MessageID INT IDENTITY(1,1) PRIMARY KEY,
    SenderID INT NOT NULL,
    ReceiverID INT NOT NULL,
    Content NVARCHAR(MAX) NOT NULL,
    SentAt DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (SenderID) REFERENCES Employees(EmployeeID),
    FOREIGN KEY (ReceiverID) REFERENCES Employees(EmployeeID)
);


-- Bảng chức vụ / bộ phận
CREATE TABLE Positions (
    PositionID INT PRIMARY KEY IDENTITY(1,1),
    PositionName NVARCHAR(100) NOT NULL
);



-- Bảng lương cơ bản và hệ số
CREATE TABLE Salaries (
    SalaryID INT PRIMARY KEY IDENTITY(1,1),
    EmployeeID INT,
    BaseSalary DECIMAL(18,2),
    Allowance DECIMAL(18,2), -- Trợ cấp
    Bonus DECIMAL(18,2), 
    Penalty DECIMAL(18,2),   -- Tiền phạt
    OvertimeHours INT,      -- Giờ tăng ca
    SalaryMonth INT, 
    SalaryYear INT,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- Bảng khen thưởng
CREATE TABLE Rewards (
    RewardID INT PRIMARY KEY IDENTITY(1,1),
    EmployeeID INT,
    Reason NVARCHAR(255),
    RewardDate DATE,
    Amount DECIMAL(18,2),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);


-- Bảng bảo hiểm
CREATE TABLE Insurance (
    InsuranceID INT PRIMARY KEY IDENTITY(1,1),
    EmployeeID INT,
    InsuranceType NVARCHAR(100),
    RegistrationDate DATE,
    ExpiryDate DATE,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- Bảng tham số hệ thống
CREATE TABLE Parameters (
    ParameterID INT PRIMARY KEY IDENTITY(1,1),
    ParamName NVARCHAR(100),
    ParamValue NVARCHAR(100)
);
