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
    public partial class FormAddProduct : Form
    {
        private DataAccess da { get; set; }

        public FormAddProduct()
        {
            InitializeComponent();
            this.da = new DataAccess();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormADUProduct fadup = new FormADUProduct();
            fadup.Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string productCode = this.txtProductCode.Text.Trim();
                string productName = this.txtProductName.Text.Trim();
                string size = this.cmbSize.Text.Trim();
                string category = this.cmbCategory.Text.Trim();
                string origin = this.cmbOrigin.Text.Trim();
                string addingDate = this.dtpAddingDate.Text.Trim();
                string quantity = this.txtQuantity.Text.Trim();
                string price = this.txtPrice.Text.Trim();

                if (string.IsNullOrEmpty(productCode) || string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(size) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(origin) || string.IsNullOrEmpty(addingDate) || string.IsNullOrEmpty(quantity) || string.IsNullOrEmpty(price))
                {
                    MessageBox.Show("Please fill up all the required fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string selectedCategory = this.cmbCategory.SelectedItem.ToString();

                if (selectedCategory == "Men")
                {
                    var sql = "insert into MensProduct values('" + this.txtProductCode.Text + "','" + this.txtProductName.Text + "','" + this.cmbSize.Text + "', '" + this.cmbCategory.Text + "','" + this.cmbOrigin.Text + "','" + this.dtpAddingDate.Value.ToString("yyyy-MM-dd") + "','" + this.txtQuantity.Text + "','" + this.txtPrice.Text + "')";
                    var count = this.da.ExecuteDMLQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Product added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Product couldn't be added. Please try again.");
                    }

                    this.txtProductCode.Clear();
                    this.txtProductName.Clear();
                    this.cmbSize.SelectedIndex = -1;
                    this.cmbCategory.SelectedIndex = -1;
                    this.cmbOrigin.SelectedIndex = -1;
                    this.dtpAddingDate.Value = DateTime.Now;
                    this.txtQuantity.Clear();
                    this.txtPrice.Clear();
                }

                else if (selectedCategory == "Women")
                {
                    var sql = "insert into WomensProduct values('" + this.txtProductCode.Text + "','" + this.txtProductName.Text + "','" + this.cmbSize.Text + "', '" + this.cmbCategory.Text + "','" + this.cmbOrigin.Text + "','" + this.dtpAddingDate.Value.ToString("yyyy-MM-dd") + "','" + this.txtQuantity.Text + "','" + this.txtPrice.Text + "')";
                    var count = this.da.ExecuteDMLQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Product added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Product couldn't be added. Please try again.");
                    }

                    this.txtProductCode.Clear();
                    this.txtProductName.Clear();
                    this.cmbSize.SelectedIndex = -1;
                    this.cmbCategory.SelectedIndex = -1;
                    this.cmbOrigin.SelectedIndex = -1;
                    this.dtpAddingDate.Value = DateTime.Now;
                    this.txtQuantity.Clear();
                    this.txtPrice.Clear();
                }

                else if (selectedCategory == "Kids")
                {
                    var sql = "insert into KidsProduct values('" + this.txtProductCode.Text + "','" + this.txtProductName.Text + "','" + this.cmbSize.Text + "', '" + this.cmbCategory.Text + "','" + this.cmbOrigin.Text + "','" + this.dtpAddingDate.Value.ToString("yyyy-MM-dd") + "','" + this.txtQuantity.Text + "','" + this.txtPrice.Text + "')";
                    var count = this.da.ExecuteDMLQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Product added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Product couldn't be added. Please try again.");
                    }

                    this.txtProductCode.Clear();
                    this.txtProductName.Clear();
                    this.cmbSize.SelectedIndex = -1;
                    this.cmbCategory.SelectedIndex = -1;
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

        private void btnClearTextBoxs_Click(object sender, EventArgs e)
        {
            this.txtProductCode.Clear();
            this.txtProductName.Clear();
            this.cmbSize.SelectedIndex = -1;
            this.cmbCategory.SelectedIndex = -1;
            this.cmbOrigin.SelectedIndex = -1;
            this.dtpAddingDate.Value = DateTime.Now;
            this.txtQuantity.Clear();
            this.txtPrice.Clear();
        }
    }
}
