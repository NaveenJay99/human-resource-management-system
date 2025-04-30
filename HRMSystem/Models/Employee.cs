using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Models
{
    public class Employee
    {
        public String Id { get; set; }
        public string Name { get; set; } 
        public string Position { get; set; }
        public decimal BaseSalary { get; set; }
        public string Contact { get; set; }
        public String DepartmentId { get; set; }
        public Department Department { get; set; }

        public ICollection<LeaveRequest> LeaveRequests { get; set; }
        public ICollection<AttendanceRecord> AttendanceRecords { get; set; }
        public ICollection<Payroll> Payrolls { get; set; }
    }
}
