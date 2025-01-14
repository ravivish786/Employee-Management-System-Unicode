using System.Data.SqlClient;
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
                RefreshEmployee();
                MessageBox.Show("Employee Added Successfully", "Infomation");
            }
        }

        private void UpdateEmployee_Click(object sender, EventArgs e)
        {
            if (IsEmployeevalid())
            {
                dataAccess.UpdateEmployee(GetEmployee());
                RefreshDataView();
                RefreshEmployee();
                MessageBox.Show("Employee Updated Successfully", "Infomation");
            }
        }

        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            IList<int> ids = new List<int>();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                ids.Add(id);
                dataGridView1.Rows.Remove(row);
            }
            if (ids.Count > 0)
            {
                dataAccess.DeleteEmployee(ids);
                MessageBox.Show("Employee Deleted Successfully", "Infomation");
            }

            RefreshEmployee();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            List<EmployeeModel> employees = dataAccess.GetEmployees();
            dataGridView1.DataSource = employees;
        }

        private void RefreshDataView()
        {
            List<EmployeeModel> employees = dataAccess.GetEmployees();
            RefreshDataView(employees);
        }

        private void RefreshDataView(List<EmployeeModel> employeeModels)
        {
            dataGridView1.DataSource = employeeModels;
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

        private void RefreshEmployee()
        {
            EmployeeID.Text = EmployeeName.Text = EmailID.Text = Designation.Text = Department.Text = PhoneNumber.Text = string.Empty;
            JoiningDate.Value = DateTime.Now;
        }

        private bool IsEmployeevalid()
        {

            if (string.IsNullOrEmpty(EmployeeID.Text))
            {
                MessageBox.Show("EmployeeID is required", "Infomation");
            }else if (string.IsNullOrEmpty(EmployeeName.Text))
            {
                MessageBox.Show("Name is required", "Infomation");
            }
            else if (string.IsNullOrEmpty(Designation.Text))
            {
                MessageBox.Show("Designation is required", "Infomation");
            }
            else if (string.IsNullOrEmpty(Department.Text))
            {
                MessageBox.Show("Department is required", "Infomation");
            }
            else if (string.IsNullOrEmpty(PhoneNumber.Text))
            {
                MessageBox.Show("PhoneNumber is required", "Infomation");
            }
            else if (!Regex.IsMatch(PhoneNumber.Text, @"^\d{8,}$"))
            {
                MessageBox.Show("Please enter valid PhoneNumber.", "Infomation");
            }
            else if (string.IsNullOrEmpty(JoiningDate.Text))
            {
                MessageBox.Show("JoiningDate is required", "Infomation");
            }
            else if (string.IsNullOrEmpty(EmailID.Text))
            {
                MessageBox.Show("EmailID is required", "Infomation");
            }
            else if (!Regex.IsMatch(EmailID.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Please enter valid EmailID.", "Infomation");
            }
            else
            {
                return true;
            }

            return false;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            RefreshDataView();
        }
         
        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {

            List<EmployeeModel> employees = dataAccess.SearchEmployee(this.Search.Text);
            RefreshDataView(employees);
        }

        private void FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<EmployeeModel> employees = dataAccess.SearchEmployeeWithOrder(this.Search.Text,
                FilterBy.SelectedItem.ToString());
            RefreshDataView(employees);
        }

        private void OrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<EmployeeModel> employees = dataAccess.SearchEmployeeWithOrderWithSort(this.Search.Text,
                FilterBy.SelectedItem.ToString(),
                OrderBy.SelectedItem.ToString());
            RefreshDataView(employees);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataGridView = this.dataGridView1.Rows[e.RowIndex];
                EmployeeID.Text = dataGridView.Cells[0].Value.ToString();
                EmployeeName.Text = dataGridView.Cells[1].Value.ToString();
                Designation.Text = dataGridView.Cells[2].Value.ToString();
                Department.Text = dataGridView.Cells[3].Value.ToString();
                EmailID.Text = dataGridView.Cells[4].Value.ToString();
                PhoneNumber.Text = dataGridView.Cells[5].Value.ToString();
                JoiningDate.Text = dataGridView.Cells[6].Value.ToString();

            }
        }
    }
}
 