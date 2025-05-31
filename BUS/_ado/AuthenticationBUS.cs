using CompanyHRManagement.Models;
using System;
using CompanyHRManagement.DAL._ado;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;

namespace CompanyHRManagement.BUS
{
    public class AuthenticationBUS
    {
        private EmployeeBUS em_BUS = new EmployeeBUS();


        public bool ValidateUser(string email, string password)
        {

            // Lấy thông tin người dùng từ UserDAO
            Employee e = em_BUS.LayDuLieuNhanVienQuaEmail(email);

            if (e != null && e.password == password) // So sánh mật khẩu
            {
                return true; // Đăng nhập thành công
            }
            return false; // Đăng nhập thất bại
        }


    }
}
