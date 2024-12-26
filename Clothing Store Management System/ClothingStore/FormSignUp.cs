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
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();

            //comboBox
            this.cmbRole.Items.Insert(0, "customer");
            this.cmbRole.SelectedIndex = 0;
        }

        string connectionString = @"Data Source=LAPTOP-D680VSNF\SQLEXPRESS;Initial Catalog=jamidb;Integrated Security=True";

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text.Trim();
            string password = this.txtPassword.Text.Trim();
            string retypePassword = this.txtRetypePassword.Text.Trim();
            string role = this.cmbRole.SelectedItem.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(retypePassword))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }

            if (password != retypePassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

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
                        this.Hide();
                        FormLogin formlogin = new FormLogin();
                        formlogin.Show();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtUsername.Clear();
            this.txtPassword.Clear();
            this.txtRetypePassword.Clear();
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {
            this.pnlSmall.Parent = this.pbSignUp;
            this.pnlSmall.BackColor = Color.Transparent;
        }

        private void btnGoBackToLoginPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formlogin = new FormLogin();
            formlogin.Show();
        }
    }
}
