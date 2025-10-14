using System.Windows;
using System.Windows.Controls;
using HRMSystem.Data;
using HRMSystem.Models;

namespace HRMSystem.Pages.EmployeeDashBoard
{
    public partial class EdAttendanceRecordPage : Page
    {
        private readonly HrmsDbContext _context;
        private readonly string _loggedInEmail;
        private List<Attendance> _allRecords;

        public EdAttendanceRecordPage(string loggedInEmail)
        {
            InitializeComponent();
            _context = new HrmsDbContextFactory().CreateDbContext(null);
            _loggedInEmail = loggedInEmail;

            LoadAttendanceRecords();
            FromDate.SelectedDateChanged += FilterDatesChanged;
            ToDate.SelectedDateChanged += FilterDatesChanged;
        }

        private void LoadAttendanceRecords()
        {
            try
            {
                var employee = _context.Employees.FirstOrDefault(e => e.Email == _loggedInEmail);

                if (employee == null)
                {
                    MessageBox.Show("Employee not found.");
                    return;
                }

                _allRecords = _context.Attendances
                    .Where(a => a.EmployeeId == employee.EmployeeId)
                    .ToList();

                DisplayFilteredRecords(_allRecords); // Show all by default
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading attendance records: {ex.Message}");
            }
        }

        private void DisplayFilteredRecords(List<Attendance> records)
        {
            var display = records.Select(a => new
            {
                Date = a.Date.ToString("yyyy-MM-dd"),
                CheckInTime = a.CheckInTime.ToString(@"hh\:mm"),
                CheckOutTime = a.CheckOutTime.ToString(@"hh\:mm")
            }).ToList();

            dataGridAttendanceRecords.ItemsSource = display;

            // Calculate total working hours
            TimeSpan totalHours = new TimeSpan();
            foreach (var record in records)
            {
                totalHours += (record.CheckOutTime - record.CheckInTime);
            }

            tbTotalWorkingHours.Text = $"{totalHours.TotalHours:F2} hrs";
        }
        private void FilterDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FromDate.SelectedDate == null || ToDate.SelectedDate == null)
                return;

            DateTime from = FromDate.SelectedDate.Value.Date;
            DateTime to = ToDate.SelectedDate.Value.Date;

            var filtered = _allRecords
                .Where(a => a.Date.Date >= from && a.Date.Date <= to)
                .ToList();

            DisplayFilteredRecords(filtered);
        }

    }
}