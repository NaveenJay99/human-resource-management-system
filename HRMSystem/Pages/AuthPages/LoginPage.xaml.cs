using System.Windows;
using System.Windows.Controls;
using HRMSystem.Pages.EmployeeDashBoard;
using HRMSystem.Pages.HRMDashBoard;
using HRMSystem.Services;
using HRMSystem.Models;
using System.Linq;
using System.Windows;
using HRMSystem.Data;

namespace HRMSystem.Pages
{
    public partial class LoginPage : Page
    {
        private readonly Frame _mainFrame;
        private readonly HrmsDbContext _context;


        public LoginPage(Frame mainFrame)
        {
            InitializeComponent();
            _mainFrame = mainFrame;

            var factory = new HrmsDbContextFactory();
            _context = factory.CreateDbContext(null);
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string email = txtUsername.Text.Trim();
            string password = txtPassword.Password;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            // Hardcoded admin check
            if (email == "admin@hrm.com" && password == "admin123")
            {
                _mainFrame.Navigate(new AdminDashBoardPage(_mainFrame));
                return;
            }

            // Look up employee by email
            var employee = _context.Employees.FirstOrDefault(e => e.Email == email);

            if (employee == null || !PasswordHashingService.Verify(password, employee.PasswordHash)
)
            {
                MessageBox.Show("Invalid credentials.");
                return;
            }

            if (employee.IsHRManager)
            {
                _mainFrame.Navigate(new MainHrmDashboardPage(_mainFrame, email));
            }
            else
            {
                _mainFrame.Navigate(new MainEmployeeDashboardPage(_mainFrame, email));
            }
        }
    }
}