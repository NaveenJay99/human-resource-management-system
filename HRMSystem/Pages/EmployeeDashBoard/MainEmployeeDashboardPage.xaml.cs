using System.Windows;
using System.Windows.Controls;
using HRMSystem.Pages.HRMDashBoard;

namespace HRMSystem.Pages.EmployeeDashBoard
{
  
    public partial class MainEmployeeDashboardPage : Page
    {
        private Frame _mainFrame;
        private string _loggedInEmail;
        public MainEmployeeDashboardPage(Frame mainFrame, string loggedInEmail)
        {
            InitializeComponent();
            _mainFrame = mainFrame;
            _loggedInEmail = loggedInEmail;
           
        }

        private void btnAttendanceRecords_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new EdAttendanceRecordPage(_loggedInEmail));
        }

       

        private void btnLeaveManagement_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new EdApplyForLeave(_loggedInEmail));
        }

       

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            _mainFrame.Navigate(new LoginPage(_mainFrame));
        }

        private void btnLeaveRecord_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new EdLeaveRecordsPage(_loggedInEmail));
        }

        private void btnViewMyDetails_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new EdViewMyDetailsPage(_mainFrame, _loggedInEmail));
        }

        private void btnChangePassword_Click(object sender, RoutedEventArgs e)
        {
            //ContentFrame.Navigate(new EdChangePasswordPage());
            ContentFrame.Navigate(new HrChangePasswordPage(_loggedInEmail));
        }

        











    }
}
