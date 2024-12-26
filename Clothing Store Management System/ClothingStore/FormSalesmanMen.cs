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
    public partial class FormSalesmanMen : Form
    {
        private DataAccess da { get; set; }

        public FormSalesmanMen()
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
            this.dgvMensProduct.AutoGenerateColumns = false;
            this.dgvMensProduct.DataSource = ds.Tables[0];
        }

        private void FormSalesmanMen_Load(object sender, EventArgs e)
        {
            this.lblAccount.Parent = this.pnlHeader;
            this.lblAccount.BackColor = Color.Transparent;
            this.lblCart.Parent = this.pnlHeader;
            this.lblCart.BackColor = Color.Transparent;
            this.lblLogout.Parent = this.pnlHeader;
            this.lblLogout.BackColor = Color.Transparent;
            this.btnAccount.Parent = this.pnlHeader;
            this.btnAccount.BackColor = Color.Transparent;
            this.btnLogout.Parent = this.pnlHeader;
            this.btnLogout.BackColor = Color.Transparent;

            //grid view
            string sql = "select * from MensProduct";
            this.PopulateGridView(sql);
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

        private void btnAccount_Click(object sender, EventArgs e)
        {
            FormSalesmanProfile fsp = new FormSalesmanProfile();
            fsp.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formlogin = new FormLogin();
            formlogin.Show();
        }

        private void btnWomen_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSalesmanWomen fsw = new FormSalesmanWomen();
            fsw.Show();
        }

        private void btnKids_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSalesmanKids fsk = new FormSalesmanKids();
            fsk.Show();
        }

        private void cmbOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbOrigin.Text != "Default")
            {
                string sql = "SELECT * FROM MensProduct where Origin = '" + this.cmbOrigin.Text + "';";
                this.PopulateGridView(sql);
            }
            else
            {
                string sql = "SELECT * FROM MensProduct";
                this.PopulateGridView(sql);
            }
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbSize.Text != "Default")
            {
                string sql = "SELECT * FROM MensProduct where Size = '" + this.cmbSize.Text + "';";
                this.PopulateGridView(sql);
            }
            else
            {
                string sql = "SELECT * FROM MensProduct";
                this.PopulateGridView(sql);
            }
        }

        private void cmbPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbPrice.Text == "under 499")
            {
                string sql = "SELECT * FROM MensProduct WHERE Price BETWEEN 0 AND 499";
                this.PopulateGridView(sql);
            }
            else if (this.cmbPrice.Text == "500 to 999")
            {
                string sql = "SELECT * FROM MensProduct WHERE Price BETWEEN 500 AND 999";
                this.PopulateGridView(sql);
            }
            else if (this.cmbPrice.Text == "1000 to 1499")
            {
                string sql = "SELECT * FROM MensProduct WHERE Price BETWEEN 1000 AND 1499";
                this.PopulateGridView(sql);
            }
            else if (this.cmbPrice.Text == "over 1500")
            {
                string sql = "SELECT * FROM MensProduct WHERE Price > 1500";
                this.PopulateGridView(sql);
            }
            else
            {
                string sql = "SELECT * FROM MensProduct";
                this.PopulateGridView(sql);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM MensProduct WHERE ProductName like '%" + this.txtSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtSearch.Clear();
            string sql = "SELECT * FROM MensProduct WHERE ProductName like '%" + this.txtSearch.Text + "%';";
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
