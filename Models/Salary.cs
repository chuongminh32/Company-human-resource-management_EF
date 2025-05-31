public class Salary
{
    public int SalaryID { get; set; }
    public int EmployeeID { get; set; }
    public decimal BaseSalary { get; set; }
    public decimal Allowance { get; set; }
    public decimal Bonus { get; set; }
    public decimal Penalty { get; set; }
    public int OvertimeHours { get; set; }
    public int SalaryMonth { get; set; }
    public int SalaryYear { get; set; }

    public string FullName { get; set; }

    public decimal TotalSalary
    {
        get
        {
            return BaseSalary + Allowance + Bonus - Penalty + (OvertimeHours * 50000);
        }
    }
}
