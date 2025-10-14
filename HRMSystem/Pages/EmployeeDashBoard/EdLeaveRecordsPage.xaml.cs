using System.Windows;
using System.Windows.Controls;
using HRMSystem.Data;

namespace HRMSystem.Pages.EmployeeDashBoard
{
    
    public partial class EdLeaveRecordsPage : Page
    {
        private readonly HrmsDbContext _context;
        private readonly string _loggedInEmail;

        public EdLeaveRecordsPage(string loggedInEmail)
        {
            InitializeComponent();
            _context = new HrmsDbContextFactory().CreateDbContext(null);
            _loggedInEmail = loggedInEmail;

            LoadLeaveRecords();
        }

        private void LoadLeaveRecords()
        {
            try
            {
                var employee = _context.Employees
                    .FirstOrDefault(e => e.Email == _loggedInEmail);

                if (employee == null)
                {
                    MessageBox.Show("Employee not found.");
                    return;
                }

                var leaveRecords = _context.Leaves
                    .Where(l => l.EmployeeId == employee.EmployeeId)
                    .Select(l => new
                    {
                        LeaveType = l.LeaveType,
                        Date = l.LeaveDate.ToString("yyyy-MM-dd"),
                        Status = l.Status
                    })
                    .ToList();

                dataGridLeaveRecords.ItemsSource = leaveRecords;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading leave records: {ex.Message}");
            }
        }

    }
}
