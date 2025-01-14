using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    internal class DataAccess 
    {
        public string connectionString = "Data Source=LAPTOP-I1TDCOQU\\SQLEXPRESS;Initial Catalog=Employee-Mangement;Integrated Security=True";

        public List<EmployeeModel> GetEmployees()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Employee";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    EmployeeModel employee = new EmployeeModel();
                    employee.EmployeeID = reader.GetInt32(0);
                    employee.Name = reader.GetString(1);
                    employee.Designation = reader.GetString(2);
                    employee.Department = reader.GetString(3);
                    employee.Email = reader.GetString(4);
                    employee.Phone = reader.GetString(5);
                    employee.JoiningDate = reader.GetDateTime(6);
                    employees.Add(employee);
                }
            }
            return employees;
        }   


        public void AddEmployee(EmployeeModel employee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Employee (EmployeeID, Name, Designation, Department, Email, Phone, JoiningDate) VALUES (@EmployeeID, @Name, @Designation, @Department, @Email, @Phone, @JoiningDate)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
                command.Parameters.AddWithValue("@Name", employee.Name);
                command.Parameters.AddWithValue("@Designation", employee.Designation);
                command.Parameters.AddWithValue("@Department", employee.Department);
                command.Parameters.AddWithValue("@Email", employee.Email);
                command.Parameters.AddWithValue("@Phone", employee.Phone);
                command.Parameters.AddWithValue("@JoiningDate", employee.JoiningDate);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateEmployee(EmployeeModel employee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Employee SET Name = @Name, Designation = @Designation, Department = @Department, Email = @Email, Phone = @Phone, JoiningDate = @JoiningDate WHERE EmployeeID = @EmployeeID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", employee.Name);
                command.Parameters.AddWithValue("@Designation", employee.Designation);
                command.Parameters.AddWithValue("@Department", employee.Department);
                command.Parameters.AddWithValue("@Email", employee.Email);
                command.Parameters.AddWithValue("@Phone", employee.Phone);
                command.Parameters.AddWithValue("@JoiningDate", employee.JoiningDate);
                command.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
                command.ExecuteNonQuery();
            }
        }


        public void DeleteEmployee(int employeeID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeID", employeeID);
                command.ExecuteNonQuery();
            }
        }
    }
}
