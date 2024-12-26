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
    public partial class FormAdmin : Form
    {
        private DataAccess da { get; set; }

        public FormAdmin()
        {
            InitializeComponent();

            //creating connection when the form is being created
            this.da = new DataAccess();

            //searchBar
            txtSearch.Text = "What are you looking for?";
            txtSearch.ForeColor = Color.Gray;

            txtSearch.GotFocus += txtSearch_GotFocus;
            txtSearch.LostFocus += txtSearch_LostFocus;
        }

        //searchBar
        private void txtSearch_GotFocus(object sender, EventArgs e)
        {
            if (txtSearch.Text == "What are you looking for?")
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
                txtSearch.Text = "What are you looking for?";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        //private void PopulateGridView(string sql)
        //{
        //    var ds = this.da.ExecuteQuery(sql);
        //    this.dgvSoldProduct.AutoGenerateColumns = false;
        //    this.dgvSoldProduct.DataSource = ds.Tables[0];
        //}
        private void PopulateGridView(string sql)
        {
            var ds = this.da.ExecuteQuery(sql);
            //this.dgvSoldProduct.AutoGenerateColumns = false;
            this.dgvSoldProduct.DataSource = ds.Tables[0];
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            FormAdminProfile formAdminProfile = new FormAdminProfile();
            formAdminProfile.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formlogin = new FormLogin();
            formlogin.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormADUProduct fadup = new FormADUProduct();
            fadup.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormADUUser faduu = new FormADUUser();
            faduu.Show(); 
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormViewProduct fvp = new FormViewProduct();
            fvp.Show();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            string sql = "select * from SoldProduct";
            this.PopulateGridView(sql);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = this.txtSearch.Text.Trim();

                if (string.IsNullOrEmpty(search))
                {
                    MessageBox.Show("Please enter a keyword to search.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sql = "select * from SoldProduct where ProductName like '%" + this.txtSearch.Text + "%';";
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
                string sql = "select * from SoldProduct";
                this.PopulateGridView(sql);
                this.txtSearch.Clear();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
    }
}
