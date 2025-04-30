using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Models
{
    public class User
    {
        public String Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } // Admin, HRManager, Employee
        public String? EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
