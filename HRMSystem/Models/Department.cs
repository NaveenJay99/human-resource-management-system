namespace HRMSystem.Models
{
    public class Department
    {
        public int DepartmentId { get; set; } // Primary Key
        public string Name { get; set; }

        // Optional HR Manager (also an Employee)
        public string? HRManagerId { get; set; }

        // Navigation
        public Employee HRManager { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }

}
