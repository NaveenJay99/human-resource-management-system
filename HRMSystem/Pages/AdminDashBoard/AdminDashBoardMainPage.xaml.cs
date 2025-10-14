using System.Windows;
using System.Windows.Controls;
using HRMSystem.Pages.AdminDashBoard;
using HRMSystem.Pages.AdminDashBoard.AddEmployee;
using HRMSystem.Pages.AdminDashBoard.DepartmentManagement;
using HRMSystem.Pages.HRMDashBoard;



namespace HRMSystem.Pages
{
    public partial class AdminDashBoardPage : Page
    {
        private Frame _mainFrame;

        public AdminDashBoardPage(Frame mainFrame)
        {
            InitializeComponent();
            _mainFrame = mainFrame;
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            _mainFrame.Navigate(new LoginPage(_mainFrame));
        }

        private void btnEmployeeManagement_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new AdAddEmployeePage());
        }

        private void btnDepartmentManagement_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new AdDepartmentManagementPage());
        }
        

        private void btnHrmManagement_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new AdHrmManagementPage());
        }

        private void btnPayrollManagement_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new HrPayrollManagementPage());
        }
        private void btnReports_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new AdReportsPage());
        } 

        
    
    }
}
