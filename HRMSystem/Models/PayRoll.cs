namespace HRMSystem.Models
{
    public class Payroll
    {
        public int PayrollId { get; set; } // Primary Key
        public decimal BasicSalary { get; set; }
        public decimal AttendanceAllowance { get; set; }
        public decimal Deductions { get; set; }
        public decimal NetSalary { get; set; }
        //public DateTime PayrollDate { get; set; }
        public string Month { get; set; }
        // Foreign Key
        public string EmployeeId { get; set; }

        // Navigation
        public Employee Employee { get; set; }
    }

}
