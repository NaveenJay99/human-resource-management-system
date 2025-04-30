using System.Windows;
using System.Windows.Controls;
using HRMS_App.Views;

namespace HRMSystem.Pages
{
    public partial class LoginPage : Page
    {
        private readonly Frame _mainFrame;

        // Hardcoded admin credentials
        private readonly string adminUsername = "admin";
        private readonly string adminPassword = "admin123";

        public LoginPage(Frame mainFrame)
        {
            InitializeComponent();
            _mainFrame = mainFrame;
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Password;

            // Simple validation
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Hardcoded admin login
            if (username == adminUsername && password == adminPassword)
            {
                // Navigate to Admin Dashboard 
                //_mainFrame.Navigate(new AdminDashBoardPage(_mainFrame));
                _mainFrame.Navigate(new HRManagerMainPage(_mainFrame));

            }
            else
            {
                MessageBox.Show("Invalid credentials!", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
