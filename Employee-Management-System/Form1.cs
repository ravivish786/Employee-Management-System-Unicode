using System.Text.RegularExpressions;

namespace Employee_Management_System
{
    public partial class Form1 : Form
    {
        DataAccess dataAccess = new DataAccess();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            if (IsEmployeevalid())
            {
                dataAccess.AddEmployee(GetEmployee());
                RefreshDataView();
            }
        }

        private void UpdateEmployee_Click(object sender, EventArgs e)
        {
            if (IsEmployeevalid())
            {
                dataAccess.UpdateEmployee(GetEmployee());
                RefreshDataView();
            }
        }

        private void DeleteEmployee_Click(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            List<EmployeeModel> employees = dataAccess.GetEmployees();
            dataGridView1.DataSource = employees;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RefreshDataView()
        {
            List<EmployeeModel> employees = dataAccess.GetEmployees();
            dataGridView1.DataSource = employees;
        }


        private EmployeeModel GetEmployee()
        {
            EmployeeModel employee = new EmployeeModel()
            {
                EmployeeID = Convert.ToInt32(EmployeeID.Text),
                Name = EmployeeName.Text,
                Email = EmailID.Text,
                Designation = Designation.Text,
                Department = Department.Text,
                Phone = PhoneNumber.Text,
                JoiningDate = JoiningDate.Value

            };
            return employee;
        }

        private bool IsEmployeevalid()
        {


            if (string.IsNullOrEmpty(EmployeeName.Text))
            {
                MessageBox.Show("Name is required");
            }
            else if (string.IsNullOrEmpty(Designation.Text))
            {
                MessageBox.Show("Designation is required");
            }
            else if (string.IsNullOrEmpty(Department.Text))
            {
                MessageBox.Show("Department is required");
            }
            else if (string.IsNullOrEmpty(PhoneNumber.Text))
            {
                MessageBox.Show("PhoneNumber is required");
            }
            else if (!Regex.IsMatch(PhoneNumber.Text, @"^\d{8,}$"))
            {
                MessageBox.Show("Please enter valid PhoneNumber.");
            }
            else if (string.IsNullOrEmpty(JoiningDate.Text))
            {
                MessageBox.Show("JoiningDate is required");
            }
            else
            if (string.IsNullOrEmpty(EmailID.Text))
            {
                MessageBox.Show("EmailID is required");
            }
            else if (!Regex.IsMatch(EmailID.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Please enter valid EmailID.");
            }
            else
            {
                return true;
            }

            return false;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            List<EmployeeModel> employees = dataAccess.GetEmployees();
            dataGridView1.DataSource = employees;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
