using System.Windows.Controls;
using HRMSystem.Data;
namespace HRMSystem.Pages.EmployeeDashBoard
{
  
    public partial class EdViewMyDetailsPage : Page
    {
      
        private readonly string _loggedInEmail;
        public EdViewMyDetailsPage(Frame mainFrame, string loggedInEmail)
        {
            InitializeComponent();
            _loggedInEmail = loggedInEmail;
            LoadEmployeeDetails();
        }

        private void LoadEmployeeDetails()
        {
            // Create the DbContext using the factory
            var dbContextFactory = new HrmsDbContextFactory();
            using var context = dbContextFactory.CreateDbContext(null);

            var employee = context.Employees
                                  .Where(e => e.Email == _loggedInEmail)
                                  .Select(e => new
                                  {
                                      e.FirstName,
                                      e.LastName,
                                      e.ContactNumber,
                                      e.Gender,
                                      e.Email,
                                      e.EmployeeId,
                                      e.BasicSalary,
                                      e.Position,
                                      DepartmentName = e.Department != null ? e.Department.Name : "N/A"
                                  })
                                  .FirstOrDefault();

            if (employee != null)
            {
                tbFirstName.Text = employee.FirstName;
                tbLastName.Text = employee.LastName;
                tbContactNumber.Text = employee.ContactNumber;
                tbGender.Text = employee.Gender;
                tbEmail.Text = employee.Email;
                tbEmployeeId.Text = employee.EmployeeId;
                tbBasicSalary.Text = $"{employee.BasicSalary}/=";
                tbPosition.Text = employee.Position;
                tbDepartment.Text = employee.DepartmentName;
            }
            else
            {
                tbFirstName.Text = "Employee not found.";
            }
        }
    }
}
