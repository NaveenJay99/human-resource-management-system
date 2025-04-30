

namespace HRMSystem.Models
{
    public class Department
    {
        public String Id { get; set; }
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}

