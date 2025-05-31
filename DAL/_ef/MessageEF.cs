using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHRManagement.DAL._ef
{
    internal class MessageEF
    {
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
                dt.Columns.Add("MessageID");
                dt.Columns.Add("SenderID");
                dt.Columns.Add("ReceiverID");
                dt.Columns.Add("ReceiverName");
                dt.Columns.Add("Content");
                dt.Columns.Add("SentAt");

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
    }
}
