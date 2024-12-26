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
    public partial class FormSalesmanSalesHistory : Form
    {
        private DataAccess da { get; set; }

        public FormSalesmanSalesHistory()
        {
            InitializeComponent();

            //creating connection when the form is being created
            this.da = new DataAccess();

            //searchBar
            txtSearch.Text = "Search by Product name";
            txtSearch.ForeColor = Color.Gray;

            txtSearch.GotFocus += txtSearch_GotFocus;
            txtSearch.LostFocus += txtSearch_LostFocus;
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

        private void PopulateGridView(string sql)
        {
            var ds = this.da.ExecuteQuery(sql);
            //this.dgvSoldProduct.AutoGenerateColumns = false;
            this.dgvSoldProduct.DataSource = ds.Tables[0];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSalesmanMen fsm = new FormSalesmanMen();
            fsm.Show();
        }

        private void FormSalesmanSalesHistory_Load(object sender, EventArgs e)
        {
            string sql = "select * from SoldProduct where SoldBy = '"+Global.username+"'";
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
                string sql = "select * from SoldProduct where SoldBy = '" + Global.username + "'";
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
