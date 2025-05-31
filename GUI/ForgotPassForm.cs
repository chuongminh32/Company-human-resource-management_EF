using CompanyHRManagement.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyHRManagement.GUI.admin
{
    public partial class ForgotPassForm : Form
    {
        private EmployeeBUS employeeBUS = new EmployeeBUS();
        private string currentOTP = "";
        public ForgotPassForm()
        {
            InitializeComponent();
        }

        private void btnGuiOTP_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (employeeBUS.CheckEmailExists(email))
            {
                currentOTP = EmailHelper.SendOTP(email);
                guna2MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                guna2MessageDialog.Show("OTP đã được gửi tới email!", "OK!");
            }
            else
            {
                guna2MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog.Show("Email không tồn tại trong hệ thống!", "Đăng nhập thất bại");
            }
        }

        private void btnXacNhanOTP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentOTP))
            {
                guna2MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog.Show("Vui lòng gửi OTP trước khi xác thực.", "Lỗi!");
                return;
            }

            if (txtOTP.Text.Trim() == currentOTP)
            {
                guna2MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                guna2MessageDialog.Show("Xác thực thành công. Vui lòng nhập mật khẩu mới.", "Thành công!");
                txtNewPassword.Enabled = true;
                txtConfirmPassword.Enabled = true;
                btnDoiMatKhau.Enabled = true;
            }
            else
            {
                guna2MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog.Show("OTP không đúng.", "Lỗi!");
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()) || string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {
                guna2MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                guna2MessageDialog.Show("Vui lòng nhập mật khẩu mới và xác nhận mật khẩu.", "Cảnh báo!");
                return;
            }
            string newPass = txtNewPassword.Text.Trim();
            string confirmPass = txtConfirmPassword.Text.Trim();
            if (newPass != confirmPass)
            {
                guna2MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                guna2MessageDialog.Show("Mật khẩu không khớp.", "!");
                return;
            }

            if (employeeBUS.UpdatePassword(txtEmail.Text.Trim(), newPass))
            {

                guna2MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                guna2MessageDialog.Show("Cập nhật mật khẩu thành công, quay lại đăng nhập.", "Thành công!");
                this.Close();
            }
            else
            {
                guna2MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog.Show("Cập nhật thất bại.", "Lỗi !");
            }
        }


    }
}

