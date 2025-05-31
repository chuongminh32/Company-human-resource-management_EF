using CompanyHRManagement.DAL._ado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CompanyHRManagement.DTO;

namespace CompanyHRManagement.BUS._ado
{
    class MessageBUS
    {
        private MessageEF m = new MessageEF();

        // -- User --
        // Lấy bảng tin nhắn đã gửi của người dùng
        public List<MessageSend> TaiBangGuiTinNhan(int senderId) => m.TaiBangGuiTinNhan(senderId);
        // Lấy bảng tin nhắn đã nhận của người dùng
        public List<DTO.Salary> TaiBangNhanTinNhanMoi(int receiverId) => m.TaiBangNhanTinNhanMoi(receiverId);

        public bool GuiTin(int senderId, int receiverId, string content, ref string err)
        {
            return m.GuiTin(senderId, receiverId, content, ref err);
        }

        public bool CapNhatTinNhanMoi(int messageId, int senderId, int receiverId, string content, ref string err)
        {
            return m.CapNhatTinNhanMoi(messageId, senderId, receiverId, content, ref err);
        }

        public bool XoaTin(int messageId, ref string err)
        {
            return m.XoaTin(messageId, ref err);
        }




        // Admin
        public bool UpdateTinNhanMoi(int messageId, string content, ref string err)
        {
            return m.UpdateTinNhanMoi(messageId, content, ref err);
        }


        public DataTable GetMessageEF()
        {
            return m.GetMessageEF();
        }

    }
}
