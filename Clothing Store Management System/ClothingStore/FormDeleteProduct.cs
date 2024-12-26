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
    public partial class FormDeleteProduct : Form
    {
        private DataAccess da { get; set; }

        public FormDeleteProduct()
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

        private void dgvProduct_DoubleClick(object sender, EventArgs e)
        {
            this.txtProductCode.Text = this.dgvProduct.CurrentRow.Cells[0].Value.ToString();
            this.txtProductName.Text = this.dgvProduct.CurrentRow.Cells["ProductName"].Value.ToString();
            this.cmbSize.Text = this.dgvProduct.CurrentRow.Cells[2].Value.ToString();
            this.cmbCategory.Text = this.dgvProduct.CurrentRow.Cells[3].Value.ToString();
            this.cmbOrigin.Text = this.dgvProduct.CurrentRow.Cells[4].Value.ToString();
            this.dtpAddingDate.Text = this.dgvProduct.CurrentRow.Cells[5].Value.ToString();
            this.txtQuantity.Text = this.dgvProduct.CurrentRow.Cells[6].Value.ToString();
            this.txtPrice.Text = this.dgvProduct.CurrentRow.Cells[7].Value.ToString();
        }

        private void dgvProduct_DoubleClick_1(object sender, EventArgs e)
        {
            this.txtProductCode.Text = this.dgvProduct.CurrentRow.Cells[0].Value.ToString();
            this.txtProductName.Text = this.dgvProduct.CurrentRow.Cells["ProductName"].Value.ToString();
            this.cmbSize.Text = this.dgvProduct.CurrentRow.Cells[2].Value.ToString();
            this.cmbCategory.Text = this.dgvProduct.CurrentRow.Cells[3].Value.ToString();
            this.cmbOrigin.Text = this.dgvProduct.CurrentRow.Cells[4].Value.ToString();
            this.dtpAddingDate.Text = this.dgvProduct.CurrentRow.Cells[5].Value.ToString();
            this.txtQuantity.Text = this.dgvProduct.CurrentRow.Cells[6].Value.ToString();
            this.txtPrice.Text = this.dgvProduct.CurrentRow.Cells[7].Value.ToString();
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

        private void FormDeleteProduct_Load(object sender, EventArgs e)
        {
            this.dgvProduct.ClearSelection();
            this.dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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

        private void btnClearTextBoxs_Click(object sender, EventArgs e)
        {
            this.txtProductCode.Clear();
            this.txtProductName.Clear();
            this.cmbSize.SelectedIndex = -1;
            //this.cmbCategory.SelectedIndex = -1;
            this.cmbOrigin.SelectedIndex = -1;
            this.dtpAddingDate.Value = DateTime.Now;
            this.txtQuantity.Clear();
            this.txtPrice.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string productCode1 = this.txtProductCode.Text.Trim();
                string productName1 = this.txtProductName.Text.Trim();
                string size = this.cmbSize.Text.Trim();
                string category = this.cmbCategory.Text.Trim();
                string origin = this.cmbOrigin.Text.Trim();
                string addingDate = this.dtpAddingDate.Text.Trim();
                string quantity = this.txtQuantity.Text.Trim();
                string price = this.txtPrice.Text.Trim();

                if (string.IsNullOrEmpty(productCode1) || string.IsNullOrEmpty(productName1) || string.IsNullOrEmpty(size) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(origin) || string.IsNullOrEmpty(addingDate) || string.IsNullOrEmpty(quantity) || string.IsNullOrEmpty(price))
                {
                    MessageBox.Show("Please double click on a row first to delete the data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string selectedCategory = this.cmbCategory.SelectedItem.ToString();

                if (selectedCategory == "Men")
                {
                    var productCode = this.dgvProduct.CurrentRow.Cells[0].Value.ToString();
                    var productName = this.dgvProduct.CurrentRow.Cells[1].Value.ToString();

                    DialogResult d = MessageBox.Show($"Are you sure you want to delete {productName}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.No)
                    {
                        return;
                    }

                    var sql = "delete from MensProduct where ProductCode = '" + productCode + "';";
                    var count = this.da.ExecuteDMLQuery(sql);
                    
                    if (count == 1)
                    {
                        MessageBox.Show(productName + " has been deleted successfully.");

                        sql = "select * from MensProduct";
                        this.PopulateGridView(sql);     //refresh or update the gridview immediately
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the product. Please try again.");
                    }

                    this.txtProductCode.Clear();
                    this.txtProductName.Clear();
                    this.cmbSize.SelectedIndex = -1;
                    //this.cmbCategory.SelectedIndex = -1;
                    this.cmbOrigin.SelectedIndex = -1;
                    this.dtpAddingDate.Value = DateTime.Now;
                    this.txtQuantity.Clear();
                    this.txtPrice.Clear();
                }
                else if (selectedCategory == "Women")
                {
                    var productCode = this.dgvProduct.CurrentRow.Cells[0].Value.ToString();
                    var productName = this.dgvProduct.CurrentRow.Cells[1].Value.ToString();

                    DialogResult d = MessageBox.Show($"Are you sure you want to delete {productName}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.No)
                    {
                        return;
                    }

                    var sql = "delete from WomensProduct where ProductCode = '" + productCode + "';";
                    var count = this.da.ExecuteDMLQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show(productName + " has been deleted successfully.");

                        sql = "select * from WomensProduct";
                        this.PopulateGridView(sql);     //refresh or update the gridview immediately
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the product. Please try again.");
                    }

                    this.txtProductCode.Clear();
                    this.txtProductName.Clear();
                    this.cmbSize.SelectedIndex = -1;
                    //this.cmbCategory.SelectedIndex = -1;
                    this.cmbOrigin.SelectedIndex = -1;
                    this.dtpAddingDate.Value = DateTime.Now;
                    this.txtQuantity.Clear();
                    this.txtPrice.Clear();
                }
                else if (selectedCategory == "Kids")
                {
                    var productCode = this.dgvProduct.CurrentRow.Cells[0].Value.ToString();
                    var productName = this.dgvProduct.CurrentRow.Cells[1].Value.ToString();

                    DialogResult d = MessageBox.Show($"Are you sure you want to delete {productName}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.No)
                    {
                        return;
                    }

                    var sql = "delete from KidsProduct where ProductCode = '" + productCode + "';";
                    var count = this.da.ExecuteDMLQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show(productName + " has been deleted successfully.");

                        sql = "select * from KidsProduct";
                        this.PopulateGridView(sql);     //refresh or update the gridview immediately
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the product. Please try again.");
                    }

                    this.txtProductCode.Clear();
                    this.txtProductName.Clear();
                    this.cmbSize.SelectedIndex = -1;
                    //this.cmbCategory.SelectedIndex = -1;
                    this.cmbOrigin.SelectedIndex = -1;
                    this.dtpAddingDate.Value = DateTime.Now;
                    this.txtQuantity.Clear();
                    this.txtPrice.Clear();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormADUProduct fadup = new FormADUProduct();
            fadup.Show();
        }

        private void btnTips_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"1) FIrst select an item from category to see the product list.
2) When the product list will be visible, double click on any item to get the item info on the required fields.
3) Press the Delete button to delete the product.");
        }
    }
}
