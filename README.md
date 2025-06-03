# 🧩 Hệ Thống Quản Lý Nhân Sự Công Ty (Company Human Resource Management System)

## 📌 Mô tả dự án
Đây là một phần mềm quản lý nhân sự dành cho công ty, hỗ trợ quản lý thông tin nhân viên, phòng ban, lương thưởng và thống kê thu nhập.  
Hệ thống được phát triển bằng ngôn ngữ **C# WinForms**, sử dụng hai phương pháp truy xuất dữ liệu:

- **Phiên bản 1**: Sử dụng **ADO.NET**
- **Phiên bản 2**: Sử dụng **Entity Framework (EF)**

Ứng dụng tuân theo kiến trúc **3 lớp (3-tier architecture)**:
- **GUI Layer**: Giao diện người dùng (WinForms)
- **BUS Layer**: Xử lý nghiệp vụ
- **DAL Layer**: Truy xuất dữ liệu (ADO.NET / EF)

---

## 🎯 Tính năng chính

### 1. Chức năng quản lý
- Thêm / sửa / xóa thông tin nhân viên, phòng ban, chức vụ
- Quản lý bảng lương, hợp đồng, hệ số lương

### 2. Chức năng tính toán
- Tính lương nhân viên (lương cơ bản + phụ cấp - khấu trừ)
- Tính tổng thu nhập trong tháng, quý, năm

### 3. Chức năng tìm kiếm
- Tìm kiếm nhân viên theo mã, tên, phòng ban, địa chỉ...

### 4. Thống kê – báo cáo
- Thống kê thu nhập nhân viên theo năm
- Thống kê số lượng nhân viên theo phòng ban
- Biểu đồ trực quan hóa (sử dụng biểu đồ trong WinForms)

### 5. Các chức năng nâng cao
- Đăng nhập và phân quyền (Admin / Nhân viên)
- Xuất báo cáo Excel / PDF (tuỳ chọn)
- Tự động cập nhật trạng thái hợp đồng hết hạn


### Phân chia công việc (3 thành viên)
- Chương : làm phần user (FE + BE) :D 
## Chức năng User: 
	1. Chỉnh sửa thông tin cá nhân
	2. Xem thông tin nhân viên
	3. Xem thông tin lương
	4. Chấm công
	5. Xin nghỉ phép
	6. Nhắn tin 
- Minh + Thùy :
##  Minh [1,2] - Giao diện + Backend (Admin)

Thiết kế giao diện Admin (quản trị)

Viết BUS cho Admin:

Quản lý nhân sự (thêm/sửa/xóa)

Duyệt khen thưởng, kỷ luật

Tìm kiếm và thống kê

## Thùy[3,4] - DAL hỗ trợ + Kiểm thử + Báo cáo

Viết DAL cho các chức năng Admin hỗ trợ Minh:

Truy vấn SQL

Stored Procedure, View

Viết test case kiểm thử chức năng User + Admin

Viết báo cáo tổng hợp, hướng dẫn sử dụng
## chi tiết :
	1. Management Operations (Thao tác quản lý: Thêm, sửa, xóa)
	Đây là các chức năng CRUD (Create, Read, Update, Delete) cốt lõi trong mọi hệ thống quản lý:

	Insert (Thêm mới):

	Thêm nhân viên mới, phòng ban, chức vụ, hệ số lương, loại hợp đồng, ...

	Giao diện nhập thông tin chi tiết và nút lưu.

	Update (Cập nhật):

	Cho phép chỉnh sửa thông tin nhân sự khi có thay đổi như địa chỉ, chức vụ, mức lương,...

	Cần kiểm tra hợp lệ và có log nếu cần.

	Delete (Xóa):

	Xóa nhân viên nghỉ việc, phòng ban không còn hoạt động.

	Nên kiểm tra ràng buộc và xác nhận trước khi xóa (soft delete nếu cần giữ lịch sử).

	🔧 Áp dụng công nghệ: WinForms GUI hoặc Web UI + ADO.NET/EF để thao tác với CSDL (SQL Server,...)

	2. Calculation Operations (Tính toán)
	Các chức năng tính toán nghiệp vụ là xương sống của hệ thống nhân sự:

	Tính lương nhân viên:

	Công thức: Lương = Hệ số lương * Lương cơ bản + Phụ cấp - Các khoản khấu trừ

	Kết hợp với dữ liệu chấm công (số ngày làm việc/thưởng/phạt).

	Tính bảo hiểm xã hội, y tế:

	Tính theo phần trăm lương, tuân theo quy định pháp luật.

	Tính thuế TNCN:

	Nếu mức lương đủ điều kiện, cần trừ thuế theo biểu thuế luỹ tiến từng phần.

	🧮 Có thể tạo lớp SalaryCalculator, hoặc stored procedure SQL để tối ưu hiệu suất.

	3. Searching Operations (Tìm kiếm)
	Giúp người dùng dễ dàng truy xuất dữ liệu:

	Tìm kiếm nhân viên theo:

	Tên, mã nhân viên, phòng ban, địa chỉ (VD: HCM), chức vụ, giới tính, trạng thái làm việc, ...

	Tìm kiếm nâng cao:

	Kết hợp nhiều điều kiện (AND/OR): phòng ban A + chức vụ B + đang làm việc.

	Lọc dữ liệu theo tháng/năm:

	Để chuẩn bị báo cáo hoặc thống kê.

	🔍 Sử dụng TextBox + ComboBox lọc + LINQ (Entity Framework) hoặc câu truy vấn SQL động.

	4. Statistical Operations using Reports (Thống kê & Báo cáo)
	Thống kê giúp lãnh đạo đưa ra quyết định:

	Thống kê thu nhập nhân viên theo năm:

	Tổng thu nhập, lương, thưởng trong năm.

	Hiển thị biểu đồ cột, biểu đồ tròn.

	Thống kê số lượng nhân viên theo phòng ban, giới tính, độ tuổi.

	Thống kê ngày công, số giờ làm thêm,...

	Xuất báo cáo:

	PDF, Excel, hoặc in trực tiếp.

	Dùng thư viện như Microsoft Report Viewer, Crystal Reports hoặc EPPlus.

	📊 Biểu đồ hỗ trợ: Pie Chart, Bar Chart, Line Chart (sử dụng thư viện Chart trong WinForms/Web).

	5. Other Advanced Operations (Chức năng nâng cao khác)
	Một hệ thống mạnh mẽ thường có thêm các tính năng sau:

	Phân quyền người dùng:

	Admin, nhân viên, trưởng phòng: mỗi nhóm có quyền hạn khác nhau.

	Mã hóa mật khẩu người dùng:

	Bảo vệ đăng nhập bằng bcrypt, SHA256,...

	Ghi log thao tác người dùng (audit trail):

	Ai đã cập nhật/xoá thông tin gì, khi nào.

	Tự động tính lương cuối tháng / nhắc nhở hợp đồng hết hạn.

	Đồng bộ dữ liệu với hệ thống khác (nếu có):

	Ví dụ: hệ thống chấm công vân tay, HRM hiện tại.

	Tích hợp AI gợi ý/thống kê nâng cao:

	Dự báo nhân sự nghỉ việc, gợi ý tuyển dụng,...

---

## 🔧 Công nghệ sử dụng

- **Ngôn ngữ**: C# (.NET Framework)
- **Giao diện**: thư viện Guna.UI2.WinForms
- **Database**: SQL Server
- **ADO.NET & Entity Framework**
- **Crystal Reports / Chart Control (thống kê)**

---


## 🗂 Cấu trúc thư mục đề xuất


# CompanyHRManagement/
│
│
├── BUS/                       # Tầng nghiệp vụ (Business Logic Layer)
│   │── AttendanceBUS.cs	   # xử lý dữ liệu chấm công
│   │── AuthenticationBUS.cs   # xửa lý cho xác thực đăng nhập	
│   │── DashBoard_adminBUS.cs  # xử lý dữ liệu để hiện lên dashboard admin 
│   │── DashBoardBUS.cs        # xử lý dữ liệu để hiện lên dashboard user 
│   │── DepartmentBUS.cs       # xử lý dữ liệu phòng ban 
│   │── DisciplineBUS.cs       # xử lý dữ liệu phạt 
│   │── EmployeeBUS.cs         # xử lý dữ liệu nhân viên 
│   │── LeavesBUS.cs           # xử lý dữ liệu nghỉ phép
│   │── MessageBUS.cs          # xử lý dữ liệu nhắn tin
│   │── PositionBUS.cs         # xử lý dữ liệu vị trí chức vụ 
│   │── RewardBUS.cs           # xử lý dữ liệu khen thưởng 
│   └── SalaryBUS.cs		   # xử lý dữ liệu lương  
│    
│
├── DAL/                       # Tầng truy xuất dữ liệu (Data Access Layer: Giao tiếp CSDL (chứa DAO)) -  DAO: Data Access Object (	Truy vấn CSDL (chứa SQL))
│   │── AttendanceEF.cs       # truy xuất dữ liệu chấm công	
│   │── DashBoard_adminEF.cs  # truy xuất dữ liệu liên quan để hiện lên dashboard admin 
│   │── DashBoardEF.cs        # truy xuất dữ liệu liên quan để hiện lên dashboard user 
│   │── DepartmentEF.cs       # truy xuất dữ liệu phòng ban
│   │── DisciplineEF.cs       # truy xuất dữ liệu phạt 
│   │── EmployeeEF.cs         # truy xuất dữ liệu nhân viên 
│   │── LeavesEF.cs           # truy xuất dữ liệu nghỉ phép
│   │── MessageEF.cs          # truy xuất dữ liệu nhắn tin
│   │── PositionEF.cs         # truy xuất dữ liệu vị trí chức vụ 
│   │── RewardEF.cs           # truy xuất dữ liệu khen thưởng
│   └── SalaryEF.cs		   # truy xuất dữ liệu lương
│   
├── GUI/                           # Giao diện người dùng (WinForms)
│   ├── admin/			           # Giao diện quản trị viên			   
│   │   |── MainForm_admin.cs      # Giao diện chính cho quản trị viên
│   │   └── Panel_ChamCong.cs 	   # Giao diện chấm công
│   │   └── Panel_Luong.cs 	       # Giao diện quản lý lương
│   │   └── Panel_main.cs          # Giao diện chính của quản trị viên
│   │   └── Panel_Message.cs       # Giao diện nhắn tin
│   │   └── Panel_NhanVien.cs      # Giao diện quản lý nhân viên
│   │   └── Panel_PhongChucVu.cs   # Giao diện quản lý phòng ban và chức vụ
│   │   └── Panel_ThuongPhat.cs    # Giao diện quản lý khen thưởng và kỷ luật
│   │   └── ReportSalaries_Form.cs # Giao diện báo cáo lương
│   │
│   ├── user/					   # Giao diện người dùng thường
│   │   └── MainForm_user.cs       # Giao diện chính cho người dùng
│   │
│   └── ForgotPassForm.cs          # Giao diện quên mật khẩu
│   └── LoginForm.cs               # Giao diện đăng nhập
│   
├── Models/                      # Lớp thực thể dùng chung
│   ├── Attendance.cs			 # Lớp mô tả thông tin chấm công	
│   ├── Department.cs			 # Lớp mô tả thông tin phòng ban
│   ├── Discipline.cs			 # Lớp mô tả thông tin kỷ luật
│   ├── Employee.cs 			 # Lớp mô tả thông tin nhân viên
│   ├── Leave.cs 				 # Lớp mô tả thông tin nghỉ phép
│   ├── Message.cs 		         # Lớp mô tả thông tin nhắn tin
│   ├── Position.cs 			 # Lớp mô tả thông tin chức vụ
│   ├── Reward.cs 			     # Lớp mô tả thông tin khen thưởng
│   └── Salary.cs 			     # Lớp mô tả thông tin lương
│
├── Reports/                     # File .rdlc hoặc báo cáo Excel
│   └── RptSalaries.rdlc	     # Báo cáo lương nhân viên
│
├── Resources/                      # Icon, ảnh, file cấu hình
|
|
├── Scripts/                        # Tạo CSDL
│   └── InitDatabase.sql
│   └── InsertSampleData.sql
│   └── StoredProcedures.sql
|
├── Utils/                        # Các tiện ích chung
│   └── EmailHelper.cs            # Hỗ trợ gửi email
|
│
├── .gitignore                      # Bỏ qua .vs, bin, obj, ...
├── App.config                      # Cấu hình ứng dụng (kết nối CSDL, thư viện)
├── packages.config                 # Danh sách các package NuGet đã cài đặt
└── Program.cs                      # Entry point
├── README.md                       # Mô tả dự án, phân công thành viên




---

## ✅ Yêu cầu triển khai
- [x] Phát triển 2 phiên bản (ADO.NET và EF)
- [x] Áp dụng kiến trúc 3 tầng rõ ràng
- [x] Dùng chung giao diện cho cả 2 phiên bản
- [x] Thực hiện tìm kiếm, thống kê và tính toán trong nghiệp vụ
- [ ] Tối ưu và đóng gói báo cáo (RDLC hoặc Crystal Reports)

---

## 📅 Tiến độ đề xuất

| Tuần | Công việc |
|------|-----------|
| Tuần 1 | Thiết kế CSDL, giao diện, chia task |
| Tuần 2 | Làm phiên bản ADO.NET |
| Tuần 3 | Chuyển sang phiên bản EF |
| Tuần 4 | Thống kê, hoàn thiện báo cáo, kiểm thử |

---

## 📬 Liên hệ nhóm

- Trưởng nhóm: [MinhChuong] – Email: chuongminh3225@gmail.com
- GitHub: https://github.com/chuongminh32/Company-human-resource-management

