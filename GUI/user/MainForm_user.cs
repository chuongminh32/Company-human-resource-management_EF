using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CompanyHRManagement.BUS;
using CompanyHRManagement.BUS._ado;
using Guna.UI2.WinForms;
using OfficeOpenXml;
using System.IO;
using OfficeOpenXml.Style;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using CompanyHRManagement.DAL._ado;
using static Guna.UI2.Native.WinApi;
using System.Text.RegularExpressions;


namespace CompanyHRManagement.GUI.user
{
    public partial class MainForm_user : Form
    {
        private readonly DashBoardBUS db_BUS = new DashBoardBUS();
        private readonly EmployeeBUS employeeBUS = new EmployeeBUS();
        private AttendanceBUS attendanceBUS = new AttendanceBUS();
        private SalaryBUS salaryBUS = new SalaryBUS();
        private LeavesBUS leaveBUS = new LeavesBUS();
        private MessageBUS messageBUS = new MessageBUS();
        private RewardBUS rewardBUS = new RewardBUS();
        private DisciplineBUS disciplineBUS = new DisciplineBUS();
        private LoginForm login = new LoginForm();

        private string fullname;
        private int user_id;
        private string email;
        private string name_dapartment;
        private string name_position;
        private List<Guna2Button> navButtons;

        private int editingLeaveID = -1;
        private int editingMessageID = -1;



        // Constructor
        public MainForm_user(string email, LoginForm login)
        {
            Employee emp = employeeBUS.LayDuLieuNhanVienQuaEmail(email);
            this.email = email;
            this.user_id = emp.EmployeeID;
            this.fullname = emp.FullName;
            this.name_dapartment = db_BUS.LayTenPhongBanQuaID(emp.EmployeeID);
            this.name_position = db_BUS.LayTenViTriChucVu(emp.EmployeeID);
            this.login = login;

            InitializeComponent();
        }

        // Load form
        private void MainForm_Load(object sender, EventArgs e)
        {
            TaiDuLieuNhanVienVaoCBB();
            TaiTinNhanGuiDi();
            TaiTinNhanMoiNhan();
            TaiLaiTatCaDuLieu();

            lblUsername.Text = fullname;
            lblRole.Text = "Quyền hạn: USER";
            lblXinChao.Text = "Xin chào: " + fullname + " !";

            // Gán mặc định là hôm nay
            dtpNgayBatDau.Value = DateTime.Today;
            dtpNgayKetThuc.Value = DateTime.Today;

            // Gán luôn cho label tương ứng
            lblNgayBatDau.Text = dtpNgayBatDau.Value.ToString("dd/MM/yyyy");
            lblNgayKetThuc.Text = dtpNgayKetThuc.Value.ToString("dd/MM/yyyy");


            timerClock.Start();
            KhoiTaoDanhSachNutDieuHuong();
        }


        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            var result = guna2MessageDialog.Show("Bạn thực sự muốn đăng xuất ?", "Xác nhận thoát");
            if (result == DialogResult.Yes)
            {
                login.ResetFields();
                this.Close(); // Đóng MainForm (sẽ kích hoạt sự kiện FormClosed ở LoginForm)
            }

        }


        // --------- BUTTON ---------
        // Khởi tạo các nút điều hướng
        private void KhoiTaoDanhSachNutDieuHuong()
        {
            navButtons = new List<Guna2Button> { btnThongTin, btnTrangChu, btnNghiPhep, btnNhanTin, btnDangXuat };
            navButtons.ForEach(btn => btn.Click += NavButton_Click);
        }

        // Xử lý sự kiện khi nhấn nút điều hướng
        private void NavButton_Click(object sender, EventArgs e)
        {
            var clickedBtn = sender as Guna2Button;

            navButtons.ForEach(btn =>
            {
                btn.FillColor = Color.Transparent;
                btn.ForeColor = Color.Black;
                btn.Font = new Font(btn.Font, FontStyle.Regular);
            });

            clickedBtn.FillColor = Color.LightBlue;
            clickedBtn.ForeColor = Color.White;
            clickedBtn.Font = new Font(clickedBtn.Font, FontStyle.Bold);
        }


        // -------- LOAD DATA DASHBOARD---------
        private void TaiThongTinNhanVien(int employeeID)
        {
            Employee emp = employeeBUS.GetEmployeeById(employeeID);
            if (emp == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblIDNhanVien.Text = emp.EmployeeID.ToString();
            lblIDChucVu.Text = emp.PositionID.ToString();
            lbIDPhongBan.Text = emp.DepartmentID.ToString();
            txtTen.Text = emp.FullName;
            txtEmail.Text = emp.Email;
            txtSDT.Text = emp.Phone;
            txtGioiTinh.Text = emp.Gender;
            txtDiaChi.Text = emp.Address;
            lblNgayVaoLam.Text = emp.HireDate.HasValue ? emp.HireDate.Value.ToString("dd/MM/yyyy") : "N/A";
            lblNgaySinh.Text = emp.BirthDate.HasValue ? emp.BirthDate.Value.ToString("dd/MM/yyyy") : "N/A";
            lblThuViec.Text = emp.IsProbation == true ? "Có" : "Không";
            lblDaNghiViec.Text = emp.IsFired == true ? "Có" : "Không";
        }

        private void TaiDuLieuLenDashBoard()
        {
            lblUsername.Text = fullname;
            lblXinChao.Text = "Xin chào: " + fullname + " !";
            lblHoTen.Text = "Họ tên: " + fullname;
            lblChucVu.Text = "Chức vụ: " + name_position;
            lblPhongBan.Text = "Phòng ban: " + name_dapartment;
        }

        private void TaiBieuDoLuong()
        {
            var data = db_BUS.LayDuLieuLuong(user_id);

            chartSalary.Series.Clear();
            chartSalary.ChartAreas.Clear();
            chartSalary.ChartAreas.Add(new ChartArea("Area"));

            var area = chartSalary.ChartAreas[0];
            area.AxisY.LabelStyle.Format = "#,##0 'VNĐ'";
            area.AxisY.Title = "Tổng lương (VNĐ)";
            area.AxisY.TitleFont = new Font("Arial", 10, FontStyle.Bold);
            area.AxisY.TitleForeColor = Color.DarkGreen;
            area.AxisX.Title = "Tháng";
            area.AxisX.TitleFont = new Font("Arial", 10, FontStyle.Bold);

            var series = new Series("Tổng lương") { ChartType = SeriesChartType.Column, Color = Color.Orange };
            data.ForEach(item => series.Points.AddXY(item.MonthYear, item.TotalSalary));
            chartSalary.Series.Add(series);
        }

        private void TaiBieuDoCong()
        {
            var data = db_BUS.LayDuLieuChamCong(user_id);
            chartAttendance.Series.Clear();
            chartAttendance.ChartAreas.Clear();
            chartAttendance.ChartAreas.Add(new ChartArea("Area"));

            var series = new Series("Ngày công") { ChartType = SeriesChartType.Column };
            data.ForEach(item => series.Points.AddXY(item.MonthYear, item.WorkDays));

            chartAttendance.Series.Add(series);
            chartAttendance.ChartAreas[0].AxisY.Title = "Số ngày công";
        }

        private void TaiDuLieuMoiCapNhat()
        {
            Employee emp = employeeBUS.LayDuLieuNhanVienQuaEmail(email);
            fullname = emp.FullName;
            name_dapartment = db_BUS.LayTenPhongBanQuaID((int)emp.DepartmentID);
            name_position = db_BUS.LayTenViTriChucVu(emp.EmployeeID);

            TaiDuLieuLenDashBoard();

        }

        private void TaiLaiTatCaDuLieu()
        {
            // Reset panel giao diện
            AnTatCaPanel();
            TaiBieuDoLuong();  // Tải lại biểu đồ lương
            TaiBieuDoCong();  // Tải lại biểu đồ ngày công
            TaiDuLieuLenDashBoard();  // Tải lại các thông tin tổng quan như tên, chức vụ
            TaiThongTinNhanVien(user_id); // Tải lại thông tin nhân viên

            panelTrangChu_user.Visible = true;
        }


        // Đồng hồ
        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "Time:  " + DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = "Today:  " + DateTime.Now.ToString("dd/MM/yyyy");
        }


        // -------- BUTTON - CLICK --------- 
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            AnTatCaPanel();
            panelTrangChu_user.Visible = true;

        }




        // ---------- TRANG THÔNG TIN CÁ NHÂN -----------
        private void btnThongTin_Click(object sender, EventArgs e)
        {
            AnTatCaPanel();
            panelThongTin.Visible = true;
            panelThongTin_CaNhan.Visible = true;

        }

        // Click nút lưu thông tin cá nhân 
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra định dạng Email
            string email = txtEmail.Text.Trim();
            string phone = txtSDT.Text.Trim();

            // Regex kiểm tra email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Regex kiểm tra số điện thoại Việt Nam (10 chữ số, bắt đầu bằng 03, 05, 07, 08, 09)
            string phonePattern = @"^(03|05|07|08|09)\d{8}$";

            if (!Regex.IsMatch(email, emailPattern))
            {
                guna2MessageDialog2.Icon = MessageDialogIcon.Warning;
                guna2MessageDialog2.Show("Email không hợp lệ. Vui lòng nhập lại.", "Thông báo");
                return;
            }

            if (!Regex.IsMatch(phone, phonePattern))
            {
                guna2MessageDialog2.Icon = MessageDialogIcon.Warning;
                guna2MessageDialog2.Show("Số điện thoại không hợp lệ. Vui lòng nhập lại.", "Thông báo");
                return;
            }
            var emp = new Employee
            {
                EmployeeID = int.Parse(lblIDNhanVien.Text),
                PositionID = int.Parse(lblIDChucVu.Text),
                DepartmentID = int.Parse(lbIDPhongBan.Text),
                FullName = txtTen.Text,
                Email = txtEmail.Text,
                Phone = txtSDT.Text,
                Gender = txtGioiTinh.Text,
                Address = txtDiaChi.Text,
                HireDate = DateTime.ParseExact(lblNgayVaoLam.Text, "dd/MM/yyyy", null),
                BirthDate = dtbNgaySinh.Value,
                IsProbation = lblThuViec.Text == "Có" ? true : false,
                IsFired = lblDaNghiViec.Text == "Có" ? true : false
            };

            bool success = employeeBUS.UpdateEmployee(emp);
            guna2MessageDialog2.Icon = success ?
                MessageDialogIcon.Information :
                MessageDialogIcon.Error;

            guna2MessageDialog2.Show(
                success ? "Cập nhật thành công" : "Cập nhật thất bại",
                success ? "OK!" : "Lỗi rồi!"
            );


            if (success)
            {
                // Load lại dữ liệu mới nhất từ DB
                TaiDuLieuMoiCapNhat();
            }
        }

        // click nút làm mới ở trang thông tin cá nhân 
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            TaiLaiTatCaDuLieu();
            panelThongTin.Visible = true;
            panelThongTin_CaNhan.Visible = true;
        }

        // click icon reload    
        private void btnReload_Click(object sender, EventArgs e)
        {

            TaiLaiTatCaDuLieu();
        }





        // ------------ CHỨC NĂNG CHẤM CÔNG ------------
        private void btnChamCong_Click(object sender, EventArgs e)
        {
            AnTatCaPanel();
            panelThongTin.Visible = true;
            panelThongTin_ChamCong.Visible = true;
            TaiDuLieuBangChamCong();  // Tải lại bảng dữ liệu chấm công
            DinhDangDGV(dgvBangChamCong);
        }

        private void TaiDuLieuBangChamCong()
        {
            // 1) Lấy DataTable thay vì List<Attendance>
            var dt = attendanceBUS.LayDuLieuChamCongQuaID(user_id);
            dgvBangChamCong.AutoGenerateColumns = true;
            dgvBangChamCong.DataSource = dt;

            // 2) Cập nhật các label
            lblID.Text = user_id.ToString();
            lblNgayHomNay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblSoNgayCong.Text = attendanceBUS.laySoNgayCongTrongThangHienTaiTheoID(user_id).ToString();
            lblTongGioLam.Text = attendanceBUS.layTongGioLamTrongThangHienTaiTheoID(user_id).ToString();

            // 3) Đổi tiêu đề cột (phải trùng đúng với tên cột trong DataTable)
            // Ví dụ DataTable thêm cột "MãAttendance", "MãNhânViên", v.v...
            if (dgvBangChamCong.Columns.Contains("MãAttendance"))
                dgvBangChamCong.Columns["MãAttendance"].HeaderText = "Mã chấm công";
            if (dgvBangChamCong.Columns.Contains("MãNhânViên"))
                dgvBangChamCong.Columns["MãNhânViên"].HeaderText = "Mã nhân viên";
            if (dgvBangChamCong.Columns.Contains("NgàyLàmViệc"))
                dgvBangChamCong.Columns["NgàyLàmViệc"].HeaderText = "Ngày";
            if (dgvBangChamCong.Columns.Contains("CheckIn"))
                dgvBangChamCong.Columns["CheckIn"].HeaderText = "Giờ vào";
            if (dgvBangChamCong.Columns.Contains("CheckOut"))
                dgvBangChamCong.Columns["CheckOut"].HeaderText = "Giờ ra";
            if (dgvBangChamCong.Columns.Contains("GiờTăngCa"))
                dgvBangChamCong.Columns["GiờTăngCa"].HeaderText = "Giờ tăng ca";
            if (dgvBangChamCong.Columns.Contains("TrạngTháiVắng"))
                dgvBangChamCong.Columns["TrạngTháiVắng"].HeaderText = "Trạng thái";

            // 4) (Tùy chọn) Định dạng cột
            if (dgvBangChamCong.Columns.Contains("CheckIn"))
                dgvBangChamCong.Columns["CheckIn"].DefaultCellStyle.Format = @"hh\:mm";
            if (dgvBangChamCong.Columns.Contains("CheckOut"))
                dgvBangChamCong.Columns["CheckOut"].DefaultCellStyle.Format = @"hh\:mm";

            // 5) (Tùy chọn) Ẩn cột nếu không cần
            // if (dgvBangChamCong.Columns.Contains("MãNhânViên"))
            //     dgvBangChamCong.Columns["MãNhânViên"].Visible = false;

        }

        private void btnChamCongHomNay_Click(object sender, EventArgs e)
        {
            string ketQua = attendanceBUS.ChamCong(user_id);

            // Hiển thị thông báo tùy vào nội dung trả về
            if (ketQua.ToLower().Contains("check-in"))
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                guna2MessageDialog2.Show("Bạn đã Check - in, nhớ Check - out nha !", "Thành công!");
                btnChamCongHomNay.Text = "Check - out";
            }
            else if (ketQua.ToLower().Contains("check-out"))
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                guna2MessageDialog2.Show("Check - out thành công, Bạn đã chấm công ngày hôm nay !", "Thành công!");
                btnChamCongHomNay.Text = "Đã chấm công !";
                btnChamCongHomNay.Enabled = false;
                lblTrangThai.Text = "Đã chấm công";
            }
            else
            {
                // Nếu đã chấm công cả hai lần
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                guna2MessageDialog2.Show("Bạn đã chấm công xong hôm nay.", "Thông báo");
                btnChamCongHomNay.Enabled = false;
                lblTrangThai.Text = "Đã chấm công";
            }

            // Load lại bảng dữ liệu
            TaiDuLieuBangChamCong();
        }



        // ------------ CHỨC NĂNG TÍNH LƯƠNG ------------
        private void btnBangLuongCaNhan_Click(object sender, EventArgs e)
        {
            AnTatCaPanel();
            panelThongTin.Visible = true;
            panelThongTin_BangLuong.Visible = true;
            TaiLuongNhanVien(user_id);
            TaiThuongNhanVien(user_id);
            TaiPhatNhanVien(user_id);
            DinhDangDGV(dgvLuong);
            DinhDangDGV(dgvPhat);
            DinhDangDGV(dgvThuong);


        }
        private void MainForm_user_Load(object sender, EventArgs e)
        {
            // Bắt DataError để không hiển thị dialog mặc định
            dgvLuong.DataError += DgvLuong_DataError;
        }

        private void DgvLuong_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Chặn dialog, bạn có thể log e.Exception nếu cần
            e.ThrowException = false;
        }

        private void TaiThuongNhanVien(int employeeId)
        {
            // 1) Lấy DataTable từ BUS
            DataTable dataReward = rewardBUS.LayDanhSachThuongTheoNhanVien(employeeId);

            // 2) Bind DataTable vào DataGridView
            dgvThuong.AutoGenerateColumns = true;
            dgvThuong.DataSource = dataReward;

            // 3) Đổi HeaderText (nếu bạn muốn hiển thị khác, mặc dù tên cột đã rõ rồi)
            if (dgvThuong.Columns.Contains("Mã Reward"))
                dgvThuong.Columns["Mã Reward"].HeaderText = "Mã thưởng";
            if (dgvThuong.Columns.Contains("Mã nhân viên"))
                dgvThuong.Columns["Mã nhân viên"].HeaderText = "Mã nhân viên";
            if (dgvThuong.Columns.Contains("Tên nhân viên"))
                dgvThuong.Columns["Tên nhân viên"].HeaderText = "Họ tên";
            if (dgvThuong.Columns.Contains("Lý do"))
                dgvThuong.Columns["Lý do"].HeaderText = "Lý do";
            if (dgvThuong.Columns.Contains("Ngày thưởng"))
                dgvThuong.Columns["Ngày thưởng"].HeaderText = "Ngày thưởng";
            if (dgvThuong.Columns.Contains("Số tiền thưởng"))
            {
                dgvThuong.Columns["Số tiền thưởng"].HeaderText = "Số tiền thưởng";
                dgvThuong.Columns["Số tiền thưởng"].DefaultCellStyle.Format = "N0";
            }
        }


        private void TaiPhatNhanVien(int employeeId)
        {
            // 1) Lấy DataTable từ BUS
            DataTable dataPhat = disciplineBUS.LayDanhSachPhatTheoNhanVien(employeeId);

            // 2) Bind DataTable
            dgvPhat.AutoGenerateColumns = true;
            dgvPhat.DataSource = dataPhat;

            // 3) Đổi HeaderText nếu muốn
            if (dgvPhat.Columns.Contains("Mã kỷ luật"))
                dgvPhat.Columns["Mã kỷ luật"].HeaderText = "Mã kỷ luật";
            if (dgvPhat.Columns.Contains("Mã nhân viên"))
                dgvPhat.Columns["Mã nhân viên"].HeaderText = "Mã nhân viên";
            if (dgvPhat.Columns.Contains("Tên nhân viên"))
                dgvPhat.Columns["Tên nhân viên"].HeaderText = "Họ tên";
            if (dgvPhat.Columns.Contains("Lý do"))
                dgvPhat.Columns["Lý do"].HeaderText = "Lý do";
            if (dgvPhat.Columns.Contains("Ngày kỷ luật"))
                dgvPhat.Columns["Ngày kỷ luật"].HeaderText = "Ngày kỷ luật";
            if (dgvPhat.Columns.Contains("Số tiền phạt"))
            {
                dgvPhat.Columns["Số tiền phạt"].HeaderText = "Số tiền phạt";
                dgvPhat.Columns["Số tiền phạt"].DefaultCellStyle.Format = "N0";
            }
        }

        private void TaiLuongNhanVien(int employeeId)
        {
            // Khi form load – hoặc khi click nút “Tải lương”
            var dtSalary = salaryBUS.LayLuongTheoNhanVien(employeeId);
            dgvLuong.DataSource = dtSalary;

            // Nếu muốn set thêm style, HeaderText, format cột:
            // Ví dụ: căn phải các cột số, định dạng 2 chữ số thập phân cho Lương cơ bản
            dgvLuong.Columns["Lương cơ bản"].DefaultCellStyle.Format = "N2";
            dgvLuong.Columns["Phụ cấp"].DefaultCellStyle.Format = "N2";
            dgvLuong.Columns["Thưởng"].DefaultCellStyle.Format = "N2";
            dgvLuong.Columns["Phạt"].DefaultCellStyle.Format = "N2";
            dgvLuong.Columns["Tổng lương"].DefaultCellStyle.Format = "N2";

            // Thay tên Header nếu thích (nếu bạn muốn đổi)
            dgvLuong.Columns["Mã lương"].HeaderText = "Mã lương";
            dgvLuong.Columns["Mã nhân viên"].HeaderText = "Mã NV";
            dgvLuong.Columns["Tên nhân viên"].HeaderText = "Họ tên";
            // … tương tự với các cột khác …
        }



        private void btnTinhTongLuong_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy tháng và năm từ ComboBox
                int thang = Convert.ToInt32(cbbThang.SelectedItem);
                int nam = Convert.ToInt32(cbbNam.SelectedItem);

                if (thang.ToString() == "0" || nam.ToString() == "0")
                {
                    guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                    guna2MessageDialog2.Show("Bạn chưa chọn tháng hoặc năm!", "Cảnh báo");
                    return;
                }
                // Tính tổng lương
                decimal tongLuong = salaryBUS.TinhTongLuongTheoThangNam(user_id, thang, nam);

                // Hiển thị tổng lương định dạng theo tiền Việt
                lblTongLuong.Text = $"{tongLuong.ToString("C0", new System.Globalization.CultureInfo("vi-VN"))}";
            }
            catch (Exception ex)
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog2.Show("Đã xảy ra lỗi khi tính tổng lương:\n" + ex.Message, "Lỗi");
            }

        }





        // ------------ CHỨC NĂNG NGHỈ PHÉP ------------
        private void btnNghiPhep_Click(object sender, EventArgs e)
        {
            AnTatCaPanel();
            panelNghiPhep.Visible = true;

            TaiDuLuNghiPhepNhanVien();
            DinhDangDGV(dgvNghiPhep);
        }

        // tải dữ liệu nghỉ phép của nhân viên
        public void TaiDuLuNghiPhepNhanVien()
        {
            // Lấy dữ liệu dạng DataTable
            DataTable dt = leaveBUS.LayDuLieuNghiPhepTheoIDNhanVien(user_id);

            // Gán datasource trực tiếp cho DataGridView
            dgvNghiPhep.DataSource = dt;

            // Hiển thị thông tin nhân viên
            lbl_ID.Text = user_id.ToString();
            lblHoVaTen.Text = fullname;

            // Đổi tên cột hiển thị
            dgvNghiPhep.Columns["LeaveID"].HeaderText = "STT";
            dgvNghiPhep.Columns["EmployeeID"].HeaderText = "Mã nhân viên";
            dgvNghiPhep.Columns["StartDate"].HeaderText = "Ngày bắt đầu";
            dgvNghiPhep.Columns["EndDate"].HeaderText = "Ngày kết thúc";
            dgvNghiPhep.Columns["Reason"].HeaderText = "Lý do";
            dgvNghiPhep.Columns["Status"].HeaderText = "Trạng thái";
        }

        private void btnDangKyNghiPhep_Click(object sender, EventArgs e)
        {
            string lyDo = txtLyDo.Text;

            DateTime ngayBatDau = dtpNgayBatDau.Value;
            DateTime ngayKetThuc = dtpNgayKetThuc.Value;

            if (lyDo.Equals(""))
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                guna2MessageDialog2.Show("Bạn chưa nhập lý do nghỉ phép!", "Cảnh báo");
                return;
            }
            // Kiểm tra xem ngày bắt đầu và ngày kết thúc có hợp lệ không
            if (ngayBatDau > ngayKetThuc)
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                guna2MessageDialog2.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Cảnh báo");
                return;
            }
            TimeSpan timeSpan = ngayKetThuc - ngayBatDau;
            if (timeSpan.Days > 30)
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                guna2MessageDialog2.Show("Thời gian nghỉ phép không được quá 30 ngày!", "Cảnh báo");
                return;
            }

            // Gọi hàm cập nhật
            bool ketQua = leaveBUS.ThemNghiPhep(user_id, ngayBatDau, ngayKetThuc, lyDo);

            if (ketQua)
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                guna2MessageDialog2.Show("Đăng kí nghỉ phép thành công!", "Thông báo");
                TaiDuLuNghiPhepNhanVien();
                ;
            }
            else
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog2.Show("Cập nhật thất bại. Vui lòng kiểm tra lại!", "Lỗi");
            }

        }

        private void dgvNghiPhep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đảm bảo không click vào header
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvNghiPhep.Rows[e.RowIndex];

            try
            {
                // --- Lấy dữ liệu dòng click và hiển thị lên control ---
                txtLyDo.Text = row.Cells["reason"].Value?.ToString() ?? "";
                lblNgayBatDau.Text = Convert.ToDateTime(row.Cells["startDate"].Value).ToString("dd/MM/yyyy");
                lblNgayKetThuc.Text = Convert.ToDateTime(row.Cells["endDate"].Value).ToString("dd/MM/yyyy");
            }
            catch (Exception ex)
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog2.Show("Lỗi khi hiển thị dữ liệu: " + ex.Message, "Lỗi");
                return;
            }

            string columnName = dgvNghiPhep.Columns[e.ColumnIndex].Name;

            // --- Nếu click vào nút Sửa ---
            if (columnName == "btnEdit")
            {
                try
                {
                    txtLyDo.Text = row.Cells["reason"].Value?.ToString() ?? "";
                    dtpNgayBatDau.Value = Convert.ToDateTime(row.Cells["startDate"].Value);
                    dtpNgayKetThuc.Value = Convert.ToDateTime(row.Cells["endDate"].Value);
                    // Ghi nhớ ID để cập nhật sau
                    editingLeaveID = Convert.ToInt32(row.Cells["leaveID"].Value);
                }
                catch (Exception ex)
                {
                    guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    guna2MessageDialog2.Show("Lỗi khi sửa dữ liệu: " + ex.Message, "Lỗi");
                }
            }

            // --- Nếu click vào nút Xóa ---
            if (columnName == "btnDelete")
            {
                try
                {
                    int leaveID = Convert.ToInt32(row.Cells["leaveID"].Value);

                    // Hiển thị hộp thoại xác nhận
                    guna2MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                    guna2MessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                    var result = guna2MessageDialog.Show("Bạn thực sự muốn xóa ?", "Xác nhận xóa");

                    if (result == DialogResult.Yes)
                    {
                        // Thực hiện xóa
                        bool success = leaveBUS.XoaNghiPhep(leaveID);
                        if (success)
                        {
                            guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                            guna2MessageDialog2.Show("Xóa thành công!", "Thành công");
                            TaiDuLuNghiPhepNhanVien(); // reload lại DataGridView
                        }
                        else
                        {
                            guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                            guna2MessageDialog2.Show("Xóa thất bại", "Lỗi");
                        }
                    }
                }
                catch (Exception ex)
                {
                    guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    guna2MessageDialog2.Show("Lỗi khi xóa: " + ex.Message, "Lỗi");
                }
            }
        }

        private void dtpNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            lblNgayBatDau.Text = dtpNgayBatDau.Value.ToString("dd/MM/yyyy");

        }

        private void dtpNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
            lblNgayKetThuc.Text = dtpNgayKetThuc.Value.ToString("dd/MM/yyyy");

        }

        private void btnSua_NghiPhep_Click(object sender, EventArgs e)
        {
            if (editingLeaveID == -1)
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog2.Show("Vui lòng chọn dòng cần sửa!", "Cảnh báo");
                return;
            }

            // Lấy dữ liệu từ form
            string lyDo = txtLyDo.Text.Trim();
            DateTime ngayBatDau = dtpNgayBatDau.Value.Date;
            DateTime ngayKetThuc = dtpNgayKetThuc.Value.Date;

            // Kiểm tra dữ liệu
            if (string.IsNullOrEmpty(lyDo))
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                guna2MessageDialog2.Show("Lý do không được để trống!", "Cảnh báo");
                return;
            }

            // Tạo đối tượng mới để cập nhật
            Leaf leave = new Leaf
            {
                leaveID = editingLeaveID,
                reason = lyDo,
                startDate = ngayBatDau,
                endDate = ngayKetThuc
            };

            // Gọi hàm cập nhật từ BUS
            bool success = leaveBUS.SuaNghiPhep(leave);

            if (success)
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                guna2MessageDialog2.Show("Cập nhật thành công!", "Thành công");

                // Làm mới lại bảng và form
                TaiDuLuNghiPhepNhanVien();
                editingLeaveID = -1;
            }
            else
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog2.Show("Cập nhật thất bại!", "Lỗi");
            }
        }




        // ------------ CHỨC NĂNG CHAT ------------
        private void btnNhanTin_Click(object sender, EventArgs e)
        {
            AnTatCaPanel();
            panelChat.Visible = true;
        }
        private void TaiDuLieuNhanVienVaoCBB()
        {
            List<Employee> employees = employeeBUS.GetAllEmployeesEF();
            cbbNhanVien.DataSource = employees;
            cbbNhanVien.DisplayMember = "FullName";
            cbbNhanVien.ValueMember = "EmployeeID";
        }

        private void TaiTinNhanGuiDi()
        {
            // Lấy danh sách tin nhắn đã gửi (phải là từ SenderID)
            var list = messageBUS.TaiBangGuiTinNhan(user_id);

            // Gán dữ liệu vào DataGridView hiển thị tin nhắn đã gửi
            dgvTinNhanGui.DataSource = list;

            // Đặt lại tên các cột hiển thị
            dgvTinNhanGui.Columns["ReceiverName"].HeaderText = "Người nhận";
            dgvTinNhanGui.Columns["Content"].HeaderText = "Nội dung";
            dgvTinNhanGui.Columns["SentAt"].HeaderText = "Thời điểm";

            // Ẩn các cột không cần thiết
            if (dgvTinNhanGui.Columns.Contains("SenderID"))
                dgvTinNhanGui.Columns["SenderID"].Visible = false;
            if (dgvTinNhanGui.Columns.Contains("ReceiverID"))
                dgvTinNhanGui.Columns["ReceiverID"].Visible = false;
            if (dgvTinNhanGui.Columns.Contains("MessageID"))
                dgvTinNhanGui.Columns["MessageID"].Visible = false;
            if (dgvTinNhanGui.Columns.Contains("SenderName"))
                dgvTinNhanGui.Columns["SenderName"].Visible = false;

            DinhDangDGV(dgvTinNhanGui);
            ThemCotChucNangChoDGV();

        }

        private void TaiTinNhanMoiNhan()
        {
            // Lấy danh sách tin nhắn đã nhận
            var list = messageBUS.TaiBangNhanTinNhanMoi(user_id);

            // Gán dữ liệu vào DataGridView hiển thị tin nhắn nhận
            dgvTinNhanNhan.DataSource = list;

            // Đặt lại tên các cột hiển thị
            dgvTinNhanNhan.Columns["SenderName"].HeaderText = "Người gửi";
            dgvTinNhanNhan.Columns["Content"].HeaderText = "Nội dung";
            dgvTinNhanNhan.Columns["SentAt"].HeaderText = "Thời điểm";

            // Ẩn các cột không cần hiển thị nếu có
            if (dgvTinNhanNhan.Columns.Contains("SenderID"))
                dgvTinNhanNhan.Columns["SenderID"].Visible = false;
            if (dgvTinNhanNhan.Columns.Contains("ReceiverID"))
                dgvTinNhanNhan.Columns["ReceiverID"].Visible = false;
            if (dgvTinNhanNhan.Columns.Contains("ReceiverName"))
                dgvTinNhanNhan.Columns["ReceiverName"].Visible = false;
            if (dgvTinNhanNhan.Columns.Contains("MessageID"))
                dgvTinNhanNhan.Columns["MessageID"].Visible = false;

            // Gọi hàm định dạng giao diện bảng
            DinhDangDGV(dgvTinNhanNhan);
        }

        // Xử lý sự kiện click vào nút gửi tin nhắn(có thể thêm/sửa)
        private void btnGui_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                guna2MessageDialog2.Show("Vui lòng nhập nội dung.", "Thông báo");
                return;
            }

            int senderId = user_id;
            int receiverId = Convert.ToInt32(cbbNhanVien.SelectedValue);
            if (receiverId == 0)
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                guna2MessageDialog2.Show("Vui lòng chọn người nhận.", "Thông báo");
                return;
            }

            if (senderId == receiverId)
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                guna2MessageDialog2.Show("Bạn không thể gửi tin nhắn cho chính mình.", "Thông báo");
                return;
            }

            string content = txtNoiDung.Text.Trim();

            bool success = false;

            //  Nếu đang ở chế độ chỉnh sửa tin nhắn
            if (editingMessageID != -1)
            {
                string err = string.Empty; // Biến lưu lỗi
                success = messageBUS.CapNhatTinNhanMoi(editingMessageID, senderId, receiverId, content, ref err);

                if (success)
                {
                    guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    guna2MessageDialog2.Show("Cập nhật tin nhắn thành công!", "Thông báo");
                    editingMessageID = -1; // reset về chế độ gửi mới
                    txtNoiDung.Clear();
                    TaiTinNhanGuiDi();
                }
                else
                {
                    guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    guna2MessageDialog2.Show("Cập nhật thất bại! " + err, "Lỗi");
                }
            }

            else
            {
                string err = string.Empty; // tạo biến lỗi
                success = messageBUS.GuiTin(senderId, receiverId, content, ref err); // truyền lỗi

                if (success)
                {
                    guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    guna2MessageDialog2.Show("Gửi thành công!", "Thông báo");
                    txtNoiDung.Clear();
                    TaiTinNhanGuiDi();
                }
                else
                {
                    guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    guna2MessageDialog2.Show("Gửi thất bại! " + err, "Thông báo");
                }
            }

        }

        private void ThemCotChucNangChoDGV()
        {
            // Xóa cột nút nếu đã tồn tại để tránh thêm nhiều lần
            if (dgvTinNhanGui.Columns.Contains("btnEdit"))
                dgvTinNhanGui.Columns.Remove("btnEdit");
            if (dgvTinNhanGui.Columns.Contains("btnDelete"))
                dgvTinNhanGui.Columns.Remove("btnDelete");

            // Tạo cột nút Sửa
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "btnEdit";
            btnEdit.HeaderText = "Sửa";
            btnEdit.Text = "✏";
            btnEdit.UseColumnTextForButtonValue = true;
            dgvTinNhanGui.Columns.Add(btnEdit);

            // Tạo cột nút Xóa
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "btnDelete";
            btnDelete.HeaderText = "Xóa";
            btnDelete.Text = "❌";
            btnDelete.UseColumnTextForButtonValue = true;
            dgvTinNhanGui.Columns.Add(btnDelete);
        }

        private void dgvTinNhanGui_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đảm bảo không click vào header
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvTinNhanGui.Rows[e.RowIndex];

            try
            {
                // Hiển thị nội dung và người nhận
                txtNoiDung.Text = row.Cells["Content"].Value?.ToString() ?? "";
                // Gán người nhận dựa trên ID
                int receiverID = Convert.ToInt32(row.Cells["ReceiverID"].Value);
                cbbNhanVien.SelectedValue = receiverID;  // sẽ hiện FullName trong ComboBox
            }
            catch (Exception ex)
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog2.Show("Lỗi khi hiển thị dữ liệu: " + ex.Message, "Lỗi");
                return;
            }

            string columnName = dgvTinNhanGui.Columns[e.ColumnIndex].Name;

            // --- Nếu click nút Sửa ---
            if (columnName == "btnEdit")
            {
                try
                {
                    // Hiển thị nội dung và người nhận
                    txtNoiDung.Text = row.Cells["content"].Value?.ToString() ?? "";
                    cbbNhanVien.SelectedValue = Convert.ToInt32(row.Cells["receiverID"].Value);

                    // biến toàn cục để lưu ID đang sửa -> click nút sửa sẽ cập nhật
                    editingMessageID = Convert.ToInt32(row.Cells["messageID"].Value);
                }
                catch (Exception ex)
                {
                    guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    guna2MessageDialog2.Show("Lỗi khi sửa dữ liệu: " + ex.Message, "Lỗi");
                }
            }

            // --- Nếu click nút Xóa ---
            if (columnName == "btnDelete")
            {
                try
                {
                    int messageID = Convert.ToInt32(row.Cells["messageID"].Value);

                    guna2MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                    guna2MessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                    var result = guna2MessageDialog.Show($"Bạn có chắc muốn xóa tin nhắn này? {messageID}", "Xác nhận xóa");

                    if (result == DialogResult.Yes)
                    {
                        string err = string.Empty;  // tạo biến chứa lỗi
                        bool success = messageBUS.XoaTin(messageID, ref err); // truyền ref err

                        if (success)
                        {
                            guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                            guna2MessageDialog2.Show("Xóa thành công!", "Thành công");
                            TaiTinNhanGuiDi();
                        }
                        else
                        {
                            guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                            guna2MessageDialog2.Show("Xóa thất bại! " + err, "Lỗi");
                        }
                    }
                }
                catch (Exception ex)
                {
                    guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    guna2MessageDialog2.Show("Lỗi khi xóa: " + ex.Message, "Lỗi");
                }
            }

        }


        // Định dạng DataGridView
        private void DinhDangDGV(DataGridView dgv)
        {
            // Tạo kiểu định dạng dùng chung
            DataGridViewCellStyle commonStyle = new DataGridViewCellStyle();
            commonStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            commonStyle.ForeColor = Color.Black;
            commonStyle.BackColor = Color.White;
            commonStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            commonStyle.SelectionBackColor = Color.LightSkyBlue;

            // Áp dụng cho dòng lẻ
            dgv.RowsDefaultCellStyle = commonStyle;

            // Áp dụng giống hệt cho dòng chẵn
            dgv.AlternatingRowsDefaultCellStyle = commonStyle;

            // Header
            dgv.ColumnHeadersHeight = 64;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Grid và border
            dgv.GridColor = Color.DarkGray;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            // Khóa sửa
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;


        }


        // Ẩn tất cả các panel
        private void AnTatCaPanel()
        {
            panelThongTin_CaNhan.Visible = false;
            panelThongTin_BangLuong.Visible = false;
            panelThongTin_ChamCong.Visible = false;
            panelTrangChu_user.Visible = false;
            panelThongTin.Visible = false;
            panelNghiPhep.Visible = false;
            panelChat.Visible = false;
        }


    }
}
