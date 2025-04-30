using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Models
{
    public class Payroll
    {
        public String Id { get; set; }
        public String EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public DateTime Month { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal Deductions { get; set; }
        public decimal NetSalary { get; set; }
    }
}
