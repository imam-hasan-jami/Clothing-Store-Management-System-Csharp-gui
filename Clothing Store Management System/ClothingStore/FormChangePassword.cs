using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInForm
{
    public partial class FormChangePassword : Form
    {
        private DataAccess da { get; set; }

        public FormChangePassword()
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

        private void dgvUser_DoubleClick(object sender, EventArgs e)
        {
            this.txtUsername.Text = this.dgvUser.CurrentRow.Cells[0].Value.ToString();
            this.txtPassword.Text = this.dgvUser.CurrentRow.Cells[1].Value.ToString();
            this.cmbRole.Text = this.dgvUser.CurrentRow.Cells[2].Value.ToString();
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
            MessageBox.Show(@"1) FIrst select and double click on the user you want to change password.
2) Press the update button to update the password.");
        }
    }
}
