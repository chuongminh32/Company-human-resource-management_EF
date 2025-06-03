using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CompanyHRManagement;

public class EmployeeBUS
{

    EmployeeEF e = new EmployeeEF();
    // --  User -- 
    public Employee GetEmployeeById(int employeeID)
    {
        return e.GetEmployeeById(employeeID);
    }

    public DataTable GetEmployees()
    {
        return e.GetEmployees();
    }
    public List<Employee> GetAllEmployeesEF()
    {
        return e.GetAllEmployeesEF();
    }
    public bool InsertEmployee(Employee emp, ref string err)
    {
        return e.InsertEmployee(emp, ref err);
    }
    public bool DeleteEmployee(int empID)
    {
        return e.DeleteEmployee(empID);
    }
    public bool UpdateEmployee(Employee emp)
    {
        return e.UpdateEmployee(emp);
    }
    public Employee LayDuLieuNhanVienQuaEmail(string email)
    {
        return e.LayDuLieuNhanVienQuaEmail(email);
    }

    // -- fotgot password
    public bool CheckEmailExists(string email)
    {
        return e.GetEmailByEmail(email) != null;
    }

    public bool UpdatePassword(string email, string pass)
    {
        return e.UpdatePassword(email, pass);
    }


    // chart dashboard admin 
    public List<Employee> GetEmployeeStatuses()
    {
        return e.GetEmployeeStatus();
    }

}
