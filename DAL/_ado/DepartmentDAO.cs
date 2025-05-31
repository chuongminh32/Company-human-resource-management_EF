using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHRManagement.DAL._ado
{
    public class DepartmentDAO
    {
        //Lấy danh sách tên trả vào comboBox
        public List<string> GetDepartmentNames()
        {
            List<string> departments = new List<string>();

            string query = "SELECT DepartmentName FROM Departments";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            departments.Add(reader.GetString(0));
                        }
                    }
                }
            }

            return departments;
        }
    }
}
