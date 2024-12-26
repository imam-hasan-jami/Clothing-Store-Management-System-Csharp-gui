using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LogInForm
{
    public partial class FormAddUser : Form
    {
        public FormAddUser()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=LAPTOP-D680VSNF\SQLEXPRESS;Initial Catalog=jamidb;Integrated Security=True";

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string retypePassword = txtRetypePassword.Text.Trim();
            string role = this.cmbRole.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(retypePassword) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill up all the required fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != retypePassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string query = "select count(*) from Login_Table where Username = @Username";
                int count = 0;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    connection.Open();
                    count = (int)command.ExecuteScalar();
                }
                if (count > 0)
                {
                    MessageBox.Show("Username already exists. Please choose a different one.");
                }
                else
                {
                    // Insert the new username and password into the database
                    string insertQuery = "insert into Login_Table (Username, Password, Role) values (@Username, @Password,@Role)";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(insertQuery, connection);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Role", role);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account created successfully.");
                        }

                        this.txtUsername.Clear();
                        this.txtPassword.Clear();
                        this.txtRetypePassword.Clear();
                        this.cmbRole.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUsername.Clear();
            this.txtPassword.Clear();
            this.txtRetypePassword.Clear();
            this.cmbRole.SelectedIndex = -1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormADUUser faduu = new FormADUUser();
            faduu.Show();
        }
    }
}