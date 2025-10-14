namespace HRMSystem.Models
{
    public class Employee
    {
        public string EmployeeId { get; set; } // Primary Key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        //public string NIC { get; set; }
        public string Gender { get; set; }
        public string Position { get; set; }
        public string PasswordHash { get; set; }

        public int BasicSalary { get; set; }

        public bool IsHRManager { get; set; }
        //gonna add attendance


        // Foreign Key
        public int? DepartmentId { get; set; }

        // Navigation
        public Department Department { get; set; }
        public ICollection<Attendance> Attendances { get; set; }
        public ICollection<Leave> Leaves { get; set; }
        public ICollection<Payroll> Payrolls { get; set; }
    }

}
