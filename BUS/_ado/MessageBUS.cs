using CompanyHRManagement.DAL._ado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHRManagement.Models;

namespace CompanyHRManagement.BUS._ado
{
    class MessageBUS
    {
        private MessageDAO dao = new MessageDAO();

        public List<Message> TaiBangGuiTinNhan(int senderId) => dao.TaiBangGuiTinNhan(senderId);
        public List<Message> TaiBangNhanTinNhanMoi(int receiverId) => dao.TaiBangNhanTinNhanMoi(receiverId);

        public bool GuiTin(int senderId, int receiverId, string content)
        {
            return dao.GuiTin(senderId, receiverId, content);
        }

        public bool XoaTin(int messageId)
        {
            return dao.XoaTin(messageId);
        }

        public bool CapNhatTinNhan(int messageId, int senderId, int receiverId, string content)
        {
            return dao.CapNhatTinNhanMoi(messageId, senderId, receiverId, content);
        }


    }
}
