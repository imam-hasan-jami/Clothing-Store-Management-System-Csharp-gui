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
    public partial class FormSalesmanKids : Form
    {
        private DataAccess da { get; set; }
        public FormSalesmanKids()
        {
            InitializeComponent();

            //creating connection when the form is being created
            this.da = new DataAccess();

            //searchBar
            txtSearch.Text = "Search by Product name";
            txtSearch.ForeColor = Color.Gray;

            txtSearch.GotFocus += txtSearch_GotFocus;
            txtSearch.LostFocus += txtSearch_LostFocus;

            //comboBox
            this.cmbOrigin.Items.Insert(0, "Default");
            this.cmbOrigin.SelectedIndex = 0;

            this.cmbSize.Items.Insert(0, "Default");
            this.cmbSize.SelectedIndex = 0;

            this.cmbPrice.Items.Insert(0, "Default");
            this.cmbPrice.SelectedIndex = 0;
        }

        private void PopulateGridView(string sql)
        {
            var ds = this.da.ExecuteQuery(sql);
            this.dgvKidsProduct.AutoGenerateColumns = false;
            this.dgvKidsProduct.DataSource = ds.Tables[0];
        }

        //searchBar
        private void txtSearch_GotFocus(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search by Product name")
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
                txtSearch.Text = "Search by Product name";
                txtSearch.ForeColor = Color.Gray;
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formlogin = new FormLogin();
            formlogin.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            FormSalesmanProfile fcp = new FormSalesmanProfile();
            fcp.Show();
        }

        

        private void btnMen_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSalesmanMen fc = new FormSalesmanMen();
            fc.Show();
        }

        private void btnWomen_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSalesmanWomen fcw = new FormSalesmanWomen();
            fcw.Show();
        }

        private void FormCustomerKids_Load(object sender, EventArgs e)
        {
            //grid view
            string sql = "select * from KidsProduct";
            this.PopulateGridView(sql);
        }
        private void cmbOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = this.cmbOrigin.SelectedItem.ToString();

            if (this.cmbOrigin.Text != "Default")
            {
                string sql = "SELECT * FROM KidsProduct where Origin = '" + this.cmbOrigin.Text + "';";
                this.PopulateGridView(sql);
            }
            else
            {
                string sql = "SELECT * FROM KidsProduct";
                this.PopulateGridView(sql);
            }
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = this.cmbSize.SelectedItem.ToString();

            if (this.cmbSize.Text != "Default")
            {
                string sql = "SELECT * FROM KidsProduct where Size = '" + this.cmbSize.Text + "';";
                this.PopulateGridView(sql);
            }
            else
            {
                string sql = "SELECT * FROM KidsProduct";
                this.PopulateGridView(sql);
            }
        }

        private void cmbPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = this.cmbPrice.SelectedItem.ToString();

            if (this.cmbPrice.Text == "under 499")
            {
                string sql = "SELECT * FROM KidsProduct WHERE Price BETWEEN 0 AND 499";
                this.PopulateGridView(sql);
            }
            else if (this.cmbPrice.Text == "500 to 999")
            {
                string sql = "SELECT * FROM KidsProduct WHERE Price BETWEEN 500 AND 999";
                this.PopulateGridView(sql);
            }
            else if (this.cmbPrice.Text == "1000 to 1499")
            {
                string sql = "SELECT * FROM KidsProduct WHERE Price BETWEEN 1000 AND 1499";
                this.PopulateGridView(sql);
            }
            else if (this.cmbPrice.Text == "over 1500")
            {
                string sql = "SELECT * FROM KidsProduct WHERE Price > 1500";
                this.PopulateGridView(sql);
            }
            else
            {
                string sql = "SELECT * FROM KidsProduct";
                this.PopulateGridView(sql);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM KidsProduct WHERE ProductName like '%" + this.txtSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtSearch.Clear();
            string sql = "SELECT * FROM KidsProduct WHERE ProductName like '%" + this.txtSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnSellProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSellProduct fsp = new FormSellProduct();
            fsp.Show();
        }

        private void btnYourSalesHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSalesmanSalesHistory fssh = new FormSalesmanSalesHistory();
            fssh.Show();
        }
    }
}
