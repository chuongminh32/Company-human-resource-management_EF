using System;
using System.Windows.Forms;
using CompanyHRManagement.BUS;
using CompanyHRManagement.GUI.user;
using CompanyHRManagement.GUI.admin;
using CompanyHRManagement.BUS._ado;

namespace CompanyHRManagement.GUI
{
    public partial class LoginForm : Form
    {

        private AuthenticationBUS authenticationBUS = new AuthenticationBUS();
        private DashBoardBUS db_BUS = new DashBoardBUS();
        private EmployeeBUS employeeBUS = new EmployeeBUS();
        Employee emp = new Employee();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            txtEmail.Focus();
        }

        public void ResetFields()
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtEmail.Focus(); // Đặt con trỏ về ô Email
        }


        public void check_role(string email)
        {
            string name_position = db_BUS.LayTenViTriChucVu(emp.EmployeeID);
            if (name_position == "Admin")
            {

                MainForm_admin mainForm = new MainForm_admin(email, this); // Tạo MainForm
                mainForm.FormClosed += (s, args) => this.Show(); // Khi MainForm đóng, hiện lại Login
                mainForm.Show();
            }
            else
            {
                MainForm_user mainForm_user = new MainForm_user(email, this); // Tạo MainForm
                mainForm_user.FormClosed += (s, args) => this.Show(); // Khi MainForm đóng, hiện lại Login
                mainForm_user.Show();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            emp = employeeBUS.LayDuLieuNhanVienQuaEmail(email);

            // Kiểm tra xem email có tồn tại trong hệ thống không
            if (emp == null)
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog2.Show("Email không tồn tại trong hệ thống!", "Đăng nhập thất bại");
                return;
            }

            bool isValid = authenticationBUS.ValidateUser(email, password);// Kiểm tra tên đăng nhập và mật khẩu
                                                                           //  bỏ trống email và password
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                guna2MessageDialog2.Show("Bạn vui lòng nhập cả mật khẩu và Email nha.", "Nhập thiếu rồi!");
                return;
            }

            // Kiểm tra email đăng nhập và mật khẩu
            if (isValid)
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                guna2MessageDialog2.Show("Chào bạn đã quay lại ", " Đăng nhập thành công !");
                check_role(email); // kiểm tra quyền của người dùng
            }
            else
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog2.Show("Sai Email hoặc mật khẩu rồi.", "Lỗi rồi!");
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Tạo Guna2MessageDialog và cài đặt các thuộc tính
            var result = guna2MessageDialog.Show("Bạn thực sự muốn thoát ?", "Xác nhận thoát");

            // xử lý kết quả
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy bỏ việc đóng form
            }
            else
            {
                // Thoát toàn bộ ứng dụng sau khi form đóng xong
                this.BeginInvoke(new Action(() =>
                {
                    Application.Exit();
                }));
            }

        }

        private void btnForgotpass_Click(object sender, EventArgs e)
        {
            ForgotPassForm forgotForm = new ForgotPassForm();
            forgotForm.FormClosed += (s, args) => this.Show(); // khi form forgot đóng, show lại LoginForm
            forgotForm.Show();
        }
    }
}

