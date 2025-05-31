using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHRManagement.DTO
{
    class Salary
    {
        public string SenderName { get; set; }   // Tên người gửi
        public string Content { get; set; }      // Nội dung
        public DateTime? SentAt { get; set; }    // Thời gian gửi
    }
}
