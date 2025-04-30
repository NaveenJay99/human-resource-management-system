using System.Windows;
using HRMSystem.Pages;

namespace HRMSystem
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new LoginPage(MainFrame));
        }
    }

}