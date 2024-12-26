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
    public partial class FormDeleteUser : Form
    {
        private DataAccess da { get; set; }

        public FormDeleteUser()
        {
            InitializeComponent();

            //creating connection when the form is being created
            this.da = new DataAccess();

            //searchBar
            txtSearch.Text = "Search by Username";
            txtSearch.ForeColor = Color.Gray;

            txtSearch.GotFocus += txtSearch_GotFocus;
            txtSearch.LostFocus += txtSearch_LostFocus;
        }

        private void PopulateGridView(string sql)
        {
            var ds = this.da.ExecuteQuery(sql);
            this.dgvUser.AutoGenerateColumns = false;
            this.dgvUser.DataSource = ds.Tables[0];
        }

        private void dgvUser_DoubleClick(object sender, EventArgs e)
        {
            this.txtUsername.Text = this.dgvUser.CurrentRow.Cells[0].Value.ToString();
            //this.txtPassword.Text = this.dgvUser.CurrentRow.Cells[1].Value.ToString();
            this.cmbRole.Text = this.dgvUser.CurrentRow.Cells[2].Value.ToString();
        }

        //searchBar
        private void txtSearch_GotFocus(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search by Username")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }
        //searchBar
        private void txtSearch_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search by Username";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void btnClearTextBoxs_Click(object sender, EventArgs e)
        {
            this.txtUsername.Clear();
            this.txtPassword.Clear();
            this.cmbRole.SelectedIndex = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string username1 = this.txtUsername.Text.Trim();
                //string password = this.txtPassword.Text.Trim();       // || string.IsNullOrEmpty(password)
                string role = this.cmbRole.Text.Trim();

                if (string.IsNullOrEmpty(username1) || string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Please double click on a row first to delete the data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var username = this.dgvUser.CurrentRow.Cells[0].Value.ToString();

                DialogResult d = MessageBox.Show($"Are you sure you want to delete {username}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.No)
                {
                    return;
                }

                var sql = "delete from Login_Table where Username = '" + username + "';";
                var count = this.da.ExecuteDMLQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show(username + " has been deleted successfully.");

                    sql = "select * from Login_Table";
                    this.PopulateGridView(sql);     //refresh or update the gridview immediately
                }
                else
                {
                    MessageBox.Show("Failed to delete the user. Please try again.");
                }

                this.txtUsername.Clear();
                this.txtPassword.Clear();
                this.cmbRole.SelectedIndex = -1;
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM Login_Table WHERE Username like '%" + this.txtSearch.Text + "%';";
                this.PopulateGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Login_Table";
                this.PopulateGridView(sql);
                this.txtSearch.Clear();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnTips_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"1) FIrst select and double click on the user you want to delete.
2) Press the delete button to delete the user.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormADUUser faduu = new FormADUUser();
            faduu.Show();
        }

        private void FormUpdateUser_Load(object sender, EventArgs e)
        {
            string sql = "select * from Login_Table";
            this.PopulateGridView(sql);
        }
    }
}
