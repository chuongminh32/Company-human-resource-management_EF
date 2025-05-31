using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHRManagement.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public string Content { get; set; }
        public DateTime SentAt { get; set; }
        // Thêm thuộc tính này để hiển thị tên người gửi
        public string SenderName { get; set; }
        // dùng cho tin nhắn đã gửi
        public string ReceiverName { get; set; }  

    }

}
