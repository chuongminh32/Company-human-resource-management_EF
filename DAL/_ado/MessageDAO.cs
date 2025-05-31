using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHRManagement.Models;


namespace CompanyHRManagement.DAL._ado
{
    class MessageDAO
    {
        DBConnection db = null;
        public MessageDAO()
        {
            db = new DBConnection();
        }

        public List<Message> TaiBangGuiTinNhan(int senderId)
        {
            List<Message> messages = new List<Message>();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = @"
                SELECT 
                    M.MessageID,
                    M.SenderID,
                    M.ReceiverID,
                    E.FullName AS ReceiverName,
                    M.Content,
                    M.SentAt
                FROM Messages M
                JOIN Employees E ON M.ReceiverID = E.EmployeeID
                WHERE M.SenderID = @sender
                ORDER BY M.SentAt DESC";


                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@sender", senderId);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Message msg = new Message
                    {
                        MessageID = Convert.ToInt32(reader["MessageID"]),
                        SenderID = Convert.ToInt32(reader["SenderID"]),
                        ReceiverID = Convert.ToInt32(reader["ReceiverID"]),
                        ReceiverName = reader["ReceiverName"].ToString(),
                        Content = reader["Content"].ToString(),
                        SentAt = Convert.ToDateTime(reader["SentAt"])
                    };

                    messages.Add(msg);
                }
            }
            return messages;
        }


        public List<Message> TaiBangNhanTinNhanMoi(int receiverId)
        {
            List<Message> messages = new List<Message>();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                string query = @"
            SELECT E.FullName AS SenderName, M.Content, M.SentAt
            FROM Messages M
            JOIN Employees E ON M.SenderID = E.EmployeeID
            WHERE M.ReceiverID = @receiverId
            ORDER BY M.SentAt DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@receiverId", receiverId);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Message msg = new Message
                    {
                        SenderName = reader["SenderName"].ToString(),
                        Content = reader["Content"].ToString(),
                        SentAt = Convert.ToDateTime(reader["SentAt"])
                    };

                    messages.Add(msg);
                }
            }

            return messages;
        }

        public bool GuiTin(int senderId, int receiverId, string content)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"INSERT INTO Messages (SenderID, ReceiverID, Content, SentAt) 
                         VALUES (@senderId, @receiverId, @content, GETDATE())";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@senderId", senderId);
                    cmd.Parameters.AddWithValue("@receiverId", receiverId);
                    cmd.Parameters.AddWithValue("@content", content);

                    conn.Open();

                    int result = cmd.ExecuteNonQuery();

                    return result > 0; // true nếu insert thành công
                }
            }
        }

        public bool XoaTin(int messageId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Messages WHERE MessageID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", messageId);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }


        public bool CapNhatTinNhanMoi(int messageId, int senderId, int receiverId, string content)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = @"
            UPDATE Messages 
            SET SenderID = @senderId,
                ReceiverID = @receiverId,
                Content = @content,
                SentAt = GETDATE()  -- cập nhật thời gian gửi lại
            WHERE MessageID = @messageId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@senderId", senderId);
                cmd.Parameters.AddWithValue("@receiverId", receiverId);
                cmd.Parameters.AddWithValue("@content", content);
                cmd.Parameters.AddWithValue("@messageId", messageId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataSet GetMessage()
        {
            string sql = @"
        SELECT 
             a.MessageID,
             a.SenderID,
             a.ReceiverID,
             e.FullName AS ReceiverName,
             a.Content,
             a.SentAt
        FROM 
            Messages a
        JOIN 
            Employees e ON a.ReceiverID = e.EmployeeID";

            return db.ExecuteQueryDataSet(sql, CommandType.Text);

        }

        public bool UpdateTinNhanMoi(int messageId, string content)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = @"
            UPDATE Messages 
            SET Content = @content,
                SentAt  = GETDATE()
            WHERE MessageID = @messageId";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@content", content);
                    cmd.Parameters.AddWithValue("@messageId", messageId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }


    }
}
