using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Models
{
    public class LeaveRequest
    {
        public String Id { get; set; }
        public String EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string LeaveType { get; set; } // Sick, Vacation, etc.
        public string Status { get; set; } // Pending, Approved, Rejected
        public string Reason { get; set; }
    }
}
