using System.Windows;
using System.Windows.Controls;

namespace HRMS_App.Views
{
    
    public partial class HRManagerMainPage : Page
    {
        private Frame _mainFrame;
        public HRManagerMainPage(Frame mainFrame)
        {
            InitializeComponent();
            _mainFrame = mainFrame;
        }

        private void EmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new EmployeePage());
        }

        private void DepartmentBtn_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new DepartmentPage());
        }

        private void LeaveBtn_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new LeavePage());
        }

        private void AttendanceBtn_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new AttendancePage());
        }

        private void PayrollBtn_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new PayrollPage());
        }

        private void ReportingBtn_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new ReportingPage());
        }
    }
}
