using CompanyHRManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CompanyHRManagement.DAL._ado
{
    class MessageEF
    {

        // User 
        // ----- user -----
        // Phương thức dùng để tải danh sách các tin nhắn mà người gửi (sender) đã gửi đi
        // senderId: ID của người gửi
        // Trả về danh sách các đối tượng Message tương ứng
        public List<MessageSend> TaiBangGuiTinNhan(int senderId)
        {
            // Khởi tạo context kết nối tới cơ sở dữ liệu
            using (var context = new CompanyHRManagementEntities())
            {
                // Thực hiện truy vấn LINQ:
                // - Lấy tất cả các bản ghi từ bảng Messages (m)
                // - Join với bảng Employees (e) theo khóa ngoại m.ReceiverID == e.EmployeeID
                //   => mục đích là để đảm bảo người nhận tồn tại trong hệ thống
                // - Lọc những tin nhắn có SenderID trùng với senderId truyền vào
                // - Sắp xếp theo thời gian gửi (SentAt) giảm dần (mới nhất lên đầu)
                // - Dựng đối tượng Message mới cho mỗi bản ghi
                var messages = (from m in context.Messages
                                join e in context.Employees on m.ReceiverID equals e.EmployeeID
                                where m.SenderID == senderId
                                orderby m.SentAt descending
                                select new MessageSend
                                {
                                    MessageID = m.MessageID,     // ID của tin nhắn
                                    SenderID = m.SenderID,       // ID người gửi
                                    ReceiverID = m.ReceiverID,   // ID người nhận
                                    ReceiverName = e.FullName,   // Tên người nhận (lấy từ bảng Employees)
                                    Content = m.Content,         // Nội dung tin nhắn
                                    SentAt = m.SentAt            // Thời gian gửi tin nhắn
                                }).ToList(); // Chuyển kết quả thành danh sách

                // Trả về danh sách tin nhắn đã tìm được
                return messages;
            }
        }

        // Phương thức dùng để tải danh sách các tin nhắn mới mà người nhận (receiver) đã nhận được
        // receiverId: ID của người nhận tin nhắn
        // Trả về danh sách các đối tượng Message chứa thông tin tên người gửi, nội dung và thời gian gửi
        public List<DTO.Salary> TaiBangNhanTinNhanMoi(int receiverId)
        {
            // Tạo một context để kết nối tới cơ sở dữ liệu CompanyHRManagementEntities
            using (var context = new CompanyHRManagementEntities())
            {
                // Truy vấn các tin nhắn có ReceiverID trùng với receiverId truyền vào
                // - Join bảng Messages (m) với bảng Employees (e) để lấy thông tin người gửi
                // - Mối nối: m.SenderID == e.EmployeeID (để lấy tên người gửi)
                // - Sắp xếp các tin nhắn theo thời gian gửi (SentAt) giảm dần (tin mới nhất trước)
                // - Chỉ chọn các trường cần thiết: tên người gửi, nội dung tin nhắn và thời gian gửi
                var messages = (from m in context.Messages
                                join e in context.Employees on m.SenderID equals e.EmployeeID
                                where m.ReceiverID == receiverId
                                orderby m.SentAt descending
                                select new DTO.Salary
                                {
                                    SenderName = e.FullName, // Lấy tên đầy đủ của người gửi
                                    Content = m.Content,     // Nội dung tin nhắn
                                    SentAt = m.SentAt        // Thời gian gửi tin nhắn
                                }).ToList(); // Chuyển kết quả truy vấn thành danh sách List<Message>

                // Trả về danh sách các tin nhắn đã truy vấn được
                return messages;
            }
        }





        // Admin
        public bool GuiTin(int senderId, int receiverId, string content, ref string err)
        {
            using (var context = new CompanyHRManagementEntities())
            {
                try
                {
                    Message newMessage = new Message
                    {
                        SenderID = senderId,
                        ReceiverID = receiverId,
                        Content = content,
                        SentAt = DateTime.Now
                    };

                    context.Messages.Add(newMessage);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    err = ex.Message;
                    return false;
                }
            }
        }
        public DataTable GetMessageEF()
        {
            using (var context = new CompanyHRManagementEntities())
            {
                var query = from m in context.Messages
                            join e in context.Employees on m.ReceiverID equals e.EmployeeID
                            select new
                            {
                                m.MessageID,
                                m.SenderID,
                                m.ReceiverID,
                                ReceiverName = e.FullName,
                                m.Content,
                                m.SentAt
                            };

                DataTable dt = new DataTable();
                dt.Columns.Add("Mã");
                dt.Columns.Add("Mã người gửi");
                dt.Columns.Add("Mã người nhận");
                dt.Columns.Add("Tên người nhận");
                dt.Columns.Add("Nội dung");
                dt.Columns.Add("Thời gian");

                foreach (var item in query)
                {
                    dt.Rows.Add(
                        item.MessageID,
                        item.SenderID,
                        item.ReceiverID,
                        item.ReceiverName,
                        item.Content,
                        item.SentAt
                    );
                }

                return dt;
            }
        }

        public bool CapNhatTinNhanMoi(int messageId, int senderId, int receiverId, string content, ref string err)
        {
            try
            {
                using (var context = new CompanyHRManagementEntities())
                {
                    // Tìm tin nhắn theo ID
                    var message = context.Messages.FirstOrDefault(m => m.MessageID == messageId);
                    if (message == null)
                    {
                        err = "Không tìm thấy tin nhắn cần cập nhật.";
                        return false;
                    }

                    // Cập nhật các thông tin tin nhắn
                    message.SenderID = senderId;
                    message.ReceiverID = receiverId;
                    message.Content = content;
                    message.SentAt = DateTime.Now; // Cập nhật thời gian gửi lại

                    // Lưu thay đổi vào DB
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                err = "Lỗi khi cập nhật tin nhắn: " + ex.Message;
                return false;
            }
        }


        public bool XoaTin(int messageId, ref string err)
        {
            using (var context = new CompanyHRManagementEntities())
            {
                try
                {
                    var message = context.Messages.Find(messageId);
                    if (message != null)
                    {
                        context.Messages.Remove(message);
                        context.SaveChanges();
                        return true;
                    }
                    err = "Message not found";
                    return false;
                }
                catch (Exception ex)
                {
                    err = ex.Message;
                    return false;
                }
            }
        }




        // -- Admin --
        public bool UpdateTinNhanMoi(int messageId, string content, ref string err)
        {
            using (var context = new CompanyHRManagementEntities())
            {
                try
                {
                    var message = context.Messages.Find(messageId);
                    if (message != null)
                    {
                        message.Content = content;
                        message.SentAt = DateTime.Now;
                        context.SaveChanges();
                        return true;
                    }
                    err = "Message not found";
                    return false;
                }
                catch (Exception ex)
                {
                    err = ex.Message;
                    return false;
                }
            }
        }

    }
}
