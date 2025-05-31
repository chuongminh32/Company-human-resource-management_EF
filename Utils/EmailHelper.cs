using System.Net.Mail;
using System.Net;
using System;

namespace CompanyHRManagement.Utils
{
    public class EmailHelper
    {
        public static string SendOTP(string toEmail)
        {
            string otp = new Random().Next(100000, 999999).ToString();

            MailMessage mail = new MailMessage("chuongminh3225@gmail.com", toEmail);
            mail.Subject = "Mã xác thực khôi phục mật khẩu";
            mail.Body = $"Mã OTP của bạn là: {otp}";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("chuongminh3225@gmail.com", "jwcp vomk bdpi fduz");
            smtp.EnableSsl = true;
            smtp.Send(mail);

            return otp; // Trả lại để lưu trữ tạm và xác minh
        }
    }
}
