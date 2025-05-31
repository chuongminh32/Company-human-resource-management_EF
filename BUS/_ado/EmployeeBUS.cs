using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

public class EmployeeBUS
{
    private EmployeeDAO employeeDAO = new EmployeeDAO();


    public Employee GetEmployeeById(int employeeID)
    {
        return employeeDAO.GetEmployeeById(employeeID);
    }

    public bool UpdateEmployee(Employee emp)
    {
        return employeeDAO.UpdateEmployee(emp);
    }

    public Employee LayDuLieuNhanVienQuaEmail(string email)
    {
        return employeeDAO.LayDuLieuNhanVienQuaEmail(email);
    }


    public List<Employee> GetAllEmployees()
    {
        return employeeDAO.GetAllEmployees();
    }

    public List<Employee> GetEmployeeStatuses()
    {
        return employeeDAO.GetEmployeeStatus();
    }

    public bool CheckEmailExists(string email)
    {
        return employeeDAO.GetEmailByEmail(email) != null;
    }

    public bool UpdatePassword(string email, string newPassword)
    {
        using (SqlConnection conn = DBConnection.GetConnection())
        {
            string query = "UPDATE Employees SET Password = @Password WHERE Email = @Email";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Password", newPassword);
            cmd.Parameters.AddWithValue("@Email", email);
            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
