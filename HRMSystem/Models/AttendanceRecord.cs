using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Models
{
    public class AttendanceRecord
        {
            public String Id { get; set; }
            public String EmployeeId { get; set; }
            public Employee Employee { get; set; }

            public DateTime Date { get; set; }
            public DateTime? CheckInTime { get; set; }
            public DateTime? CheckOutTime { get; set; }
        }
}
