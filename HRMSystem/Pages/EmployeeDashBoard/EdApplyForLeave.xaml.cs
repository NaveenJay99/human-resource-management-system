using System.Windows;
using System.Windows.Controls;
using HRMSystem.Data;
using HRMSystem.Models;

namespace HRMSystem.Pages.EmployeeDashBoard
{

    
    public partial class EdApplyForLeave : Page
    {
        private readonly HrmsDbContext _context;
        private readonly string _loggedInEmail;
        private Employee _currentEmployee;

        public EdApplyForLeave(string loggedInEmail)
        {
            InitializeComponent();
            _context = new HrmsDbContextFactory().CreateDbContext(null);
            _loggedInEmail = loggedInEmail;

            LoadEmployee();
        }

        private void LoadEmployee()
        {
            _currentEmployee = _context.Employees.FirstOrDefault(e => e.Email == _loggedInEmail);
            if (_currentEmployee == null)
            {
                MessageBox.Show("Logged-in employee not found.");
                NavigationService.GoBack();
            }
        }
        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            if (_currentEmployee == null)
            {
                MessageBox.Show("User not identified.");
                return;
            }

            if (datePicker.SelectedDate == null || comboBoxLeaveType.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            var leave = new Leave
            {
                EmployeeId = _currentEmployee.EmployeeId,
                LeaveDate = datePicker.SelectedDate.Value,
                LeaveType = ((ComboBoxItem)comboBoxLeaveType.SelectedItem).Content.ToString(),
                Detail = tbLeaveDetail.Text,
                Status = "Pending"
            };

            _context.Leaves.Add(leave);
            _context.SaveChanges();

            MessageBox.Show("Leave request submitted successfully.");
            ClearFields();
        }

        private void ClearFields()
        {
            datePicker.SelectedDate = null;
            comboBoxLeaveType.SelectedIndex = -1;
            tbLeaveDetail.Text = string.Empty;
        }
    
    }
}
