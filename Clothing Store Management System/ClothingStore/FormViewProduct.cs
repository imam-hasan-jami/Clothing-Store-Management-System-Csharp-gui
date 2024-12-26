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
    public partial class FormViewProduct : Form
    {
        private DataAccess da { get; set; }

        public FormViewProduct()
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

        private void PopulateGridView(string sql)
        {
            var ds = this.da.ExecuteQuery(sql);
            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.DataSource = ds.Tables[0];
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

        private void FormViewProduct_Load(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = this.cmbCategory.SelectedItem.ToString();

            if (selectedCategory == "Men")
            {
                string sql = "select * from MensProduct";
                this.PopulateGridView(sql);
            }

            else if (selectedCategory == "Women")
            {
                string sql = "select * from WomensProduct";
                this.PopulateGridView(sql);
            }

            else if (selectedCategory == "Kids")
            {
                string sql = "select * from KidsProduct";
                this.PopulateGridView(sql);
            }
            else if (selectedCategory == "")
            {

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin fa = new FormAdmin();
            fa.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = this.txtSearch.Text.Trim();

                //if (string.IsNullOrEmpty(search))
                if (this.txtSearch.Text == "")
                {
                    MessageBox.Show("Please enter a keyword to search.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string selectedCategory = this.cmbCategory.SelectedItem.ToString();

                if (selectedCategory == "Men")
                {
                    string sql = "SELECT * FROM MensProduct WHERE ProductName like '%" + this.txtSearch.Text + "%';";
                    this.PopulateGridView(sql);
                }
                else if (selectedCategory == "Women")
                {
                    string sql = "SELECT * FROM WomensProduct WHERE ProductName like '%" + this.txtSearch.Text + "%';";
                    this.PopulateGridView(sql);
                }
                else if (selectedCategory == "Kids")
                {
                    string sql = "SELECT * FROM KidsProduct WHERE ProductName like '%" + this.txtSearch.Text + "%';";
                    this.PopulateGridView(sql);
                }
                else if (selectedCategory == "")
                {
                    MessageBox.Show("Select a category first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                string selectedCategory = this.cmbCategory.SelectedItem.ToString();

                if (selectedCategory == "Men")
                {
                    string sql = "select * from MensProduct";
                    this.PopulateGridView(sql);
                    this.txtSearch.Clear();
                }
                else if (selectedCategory == "Women")
                {
                    string sql = "select * from WomensProduct";
                    this.PopulateGridView(sql);
                    this.txtSearch.Clear();
                }
                else if (selectedCategory == "Kids")
                {
                    string sql = "select * from KidsProduct";
                    this.PopulateGridView(sql);
                    this.txtSearch.Clear();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
    }
}
