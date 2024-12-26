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
using DGVPrinterHelper;

namespace LogInForm
{
    public partial class FormSellProduct : Form
    {
        private DataAccess da { get; set; }
        //DataSet ds;

        public FormSellProduct()
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
            this.cmbCategory.Items.Insert(0, "");
            this.cmbCategory.SelectedIndex = 0;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSalesmanMen fsm = new FormSalesmanMen();
            fsm.Show();
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
            this.txtSize.Text = this.dgvProduct.CurrentRow.Cells[2].Value.ToString();
            this.txtCategory.Text = this.dgvProduct.CurrentRow.Cells[3].Value.ToString();
            this.txtOrigin.Text = this.dgvProduct.CurrentRow.Cells[4].Value.ToString();
            this.txtPricePerProduct.Text = this.dgvProduct.CurrentRow.Cells[7].Value.ToString();
            //this.dtpAddingDate.Text = this.dgvProduct.CurrentRow.Cells[5].Value.ToString();
            //this.txtQuantity.Text = this.dgvProduct.CurrentRow.Cells[6].Value.ToString();
            //this.txtPrice.Text = this.dgvProduct.CurrentRow.Cells[7].Value.ToString();
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

        private void cmbFilterByOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedCategory = this.cmbCategory.SelectedItem.ToString();
                if (selectedCategory == "Men")
                {
                    if (this.cmbFilterByOrigin.Text != "Default")
                    {
                        string sql = "SELECT * FROM MensProduct where Origin = '" + this.cmbFilterByOrigin.Text + "';";
                        this.PopulateGridView(sql);
                    }
                    else
                    {
                        string sql = "SELECT * FROM MensProduct";
                        this.PopulateGridView(sql);
                    }
                }
                else if (selectedCategory == "Women")
                {
                    if (this.cmbFilterByOrigin.Text != "Default")
                    {
                        string sql = "SELECT * FROM WomensProduct where Origin = '" + this.cmbFilterByOrigin.Text + "';";
                        this.PopulateGridView(sql);
                    }
                    else
                    {
                        string sql = "SELECT * FROM WomensProduct";
                        this.PopulateGridView(sql);
                    }
                }
                else if (selectedCategory == "Kids")
                {
                    if (this.cmbFilterByOrigin.Text != "Default")
                    {
                        string sql = "SELECT * FROM KidsProduct where Origin = '" + this.cmbFilterByOrigin.Text + "';";
                        this.PopulateGridView(sql);
                    }
                    else
                    {
                        string sql = "SELECT * FROM KidsProduct";
                        this.PopulateGridView(sql);
                    }
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = this.txtSearch.Text.Trim();

                //if (string.IsNullOrEmpty(search))
                if(this.txtSearch.Text == "")
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
                else if (selectedCategory == "")
                {
                    this.txtSearch.Clear();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void txtQuantityYouWantToSell_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txtPricePerProduct.Text != "")
                {
                    Int64 pricePerProduct = Int64.Parse(this.txtPricePerProduct.Text);
                    Int64 quantityToSell = Int64.Parse(this.txtQuantityYouWantToSell.Text);
                    Int64 totalPrice = pricePerProduct * quantityToSell;
                    this.txtTotalPrice.Text = totalPrice.ToString();
                }
                else
                {
                    this.txtTotalPrice.Clear();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            this.txtProductCode.Clear();
            this.txtProductName.Clear();
            this.txtSize.Clear();
            this.txtCategory.Clear();
            this.txtOrigin.Clear();
            this.txtPricePerProduct.Clear();
            this.txtQuantityYouWantToSell.Clear();
            this.txtTotalPrice.Clear();
        }

        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;       

        private void FormSellProduct_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedCategory = this.cmbCategory.SelectedItem.ToString();
                if (selectedCategory == "Men")
                {
                    if (this.txtProductCode.Text != "")
                    {
                        string sql = "select Quantity from MensProduct where ProductCode = '" + this.txtProductCode.Text + "'";
                        var ds = da.ExecuteQuery(sql);

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                            newQuantity = quantity - Int64.Parse(this.txtQuantityYouWantToSell.Text);

                            if (newQuantity >= 0)
                            {
                                bool productExists = false;
                                int existingRowIndex = -1;

                                // Check if the product already exists in the DataGridView
                                for (int i = 0; i < dgvCartProduct.Rows.Count; i++)
                                {
                                    string productCode = dgvCartProduct.Rows[i].Cells[0].Value.ToString();

                                    if (productCode == txtProductCode.Text)
                                    {
                                        productExists = true;
                                        existingRowIndex = i;
                                        break;
                                    }
                                }

                                if (productExists)
                                {
                                    // Update the quantity and total price of the existing product
                                    int currentQuantity = int.Parse(dgvCartProduct.Rows[existingRowIndex].Cells[6].Value.ToString());
                                    int quantityToAdd = int.Parse(txtQuantityYouWantToSell.Text);
                                    dgvCartProduct.Rows[existingRowIndex].Cells[6].Value = (currentQuantity + quantityToAdd).ToString();

                                    int totalPrice = int.Parse(dgvCartProduct.Rows[existingRowIndex].Cells[7].Value.ToString());
                                    int pricePerProduct = int.Parse(txtPricePerProduct.Text);
                                    dgvCartProduct.Rows[existingRowIndex].Cells[7].Value = (totalPrice + (pricePerProduct * quantityToAdd)).ToString();
                                }
                                else
                                {
                                    // Add a new row to the DataGridView
                                    int n = this.dgvCartProduct.Rows.Add();
                                    this.dgvCartProduct.Rows[n].Cells[0].Value = this.txtProductCode.Text;
                                    this.dgvCartProduct.Rows[n].Cells[1].Value = this.txtProductName.Text;
                                    this.dgvCartProduct.Rows[n].Cells[2].Value = this.txtSize.Text;
                                    this.dgvCartProduct.Rows[n].Cells[3].Value = this.txtCategory.Text;
                                    this.dgvCartProduct.Rows[n].Cells[4].Value = this.txtOrigin.Text;
                                    this.dgvCartProduct.Rows[n].Cells[5].Value = this.txtPricePerProduct.Text;
                                    this.dgvCartProduct.Rows[n].Cells[6].Value = this.txtQuantityYouWantToSell.Text;
                                    this.dgvCartProduct.Rows[n].Cells[7].Value = this.txtTotalPrice.Text;
                                }

                                // Update the total amount
                                totalAmount += int.Parse(this.txtTotalPrice.Text);
                                this.lblTotalAmount.Text = totalAmount.ToString();

                                // Update the quantity in the table if the product is NOT in the cart
                                sql = "update MensProduct set Quantity = '" + newQuantity + "' where ProductCode = '" + this.txtProductCode.Text + "'";
                                da.ExecuteDMLQuery(sql);

                                // Update the quantity in the table if the product is already in the cart
                                if (productExists)
                                {
                                    sql = "update MensProduct set Quantity = '" + newQuantity + "' where ProductCode = '" + this.txtProductCode.Text + "'";
                                    da.ExecuteDMLQuery(sql);

                                    //updating the quantity of the stored data
                                    //sql = "update SoldProduct set Quantity = '" + newQuantity + "' where ProductCode = '" + this.txtProductCode.Text + "'";
                                    //da.ExecuteDMLQuery(sql);
                                }

                                MessageBox.Show("Product added to cart successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //storing data to SoldProduct when the cart has no duplicate of this product
                                sql = "insert into SoldProduct values('" + this.txtProductCode.Text + "','" + this.txtProductName.Text + "','" + this.txtSize.Text + "', '" + this.txtCategory.Text + "','" + this.txtOrigin.Text + "','" + this.txtPricePerProduct.Text + "','" + this.txtQuantityYouWantToSell.Text + "','" + this.txtTotalPrice.Text + "','"+Global.username+"')";
                                da.ExecuteDMLQuery(sql);

                                //sql = "insert into SoldProduct values('" + this.txtProductCode.Text + "','" + this.txtProductName.Text + "','" + this.txtSize.Text + "', '" + this.txtCategory.Text + "','" + this.txtOrigin.Text + "','" + this.txtPricePerProduct.Text + "','" + this.txtQuantityYouWantToSell.Text + "','" + this.txtTotalPrice.Text + "')";
                                //da.ExecuteDMLQuery(sql);
                            }
                            else
                            {
                                MessageBox.Show("Product is out of stock. \n Only " + quantity + " left.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            sql = "select * from MensProduct";
                            this.PopulateGridView(sql);
                        }
                        else
                        {
                            MessageBox.Show("Select a product first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else if (selectedCategory == "Women")
                {
                    if (this.txtProductCode.Text != "")
                    {
                        string sql = "select Quantity from WomensProduct where ProductCode = '" + this.txtProductCode.Text + "'";
                        var ds = da.ExecuteQuery(sql);

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                            newQuantity = quantity - Int64.Parse(this.txtQuantityYouWantToSell.Text);

                            if (newQuantity >= 0)
                            {
                                bool productExists = false;
                                int existingRowIndex = -1;

                                // Check if the product already exists in the DataGridView
                                for (int i = 0; i < dgvCartProduct.Rows.Count; i++)
                                {
                                    string productCode = dgvCartProduct.Rows[i].Cells[0].Value.ToString();

                                    if (productCode == txtProductCode.Text)
                                    {
                                        productExists = true;
                                        existingRowIndex = i;
                                        break;
                                    }
                                }

                                if (productExists)
                                {
                                    // Update the quantity and total price of the existing product
                                    int currentQuantity = int.Parse(dgvCartProduct.Rows[existingRowIndex].Cells[6].Value.ToString());
                                    int quantityToAdd = int.Parse(txtQuantityYouWantToSell.Text);
                                    dgvCartProduct.Rows[existingRowIndex].Cells[6].Value = (currentQuantity + quantityToAdd).ToString();

                                    int totalPrice = int.Parse(dgvCartProduct.Rows[existingRowIndex].Cells[7].Value.ToString());
                                    int pricePerProduct = int.Parse(txtPricePerProduct.Text);
                                    dgvCartProduct.Rows[existingRowIndex].Cells[7].Value = (totalPrice + (pricePerProduct * quantityToAdd)).ToString();
                                }
                                else
                                {
                                    // Add a new row to the DataGridView
                                    int n = this.dgvCartProduct.Rows.Add();
                                    this.dgvCartProduct.Rows[n].Cells[0].Value = this.txtProductCode.Text;
                                    this.dgvCartProduct.Rows[n].Cells[1].Value = this.txtProductName.Text;
                                    this.dgvCartProduct.Rows[n].Cells[2].Value = this.txtSize.Text;
                                    this.dgvCartProduct.Rows[n].Cells[3].Value = this.txtCategory.Text;
                                    this.dgvCartProduct.Rows[n].Cells[4].Value = this.txtOrigin.Text;
                                    this.dgvCartProduct.Rows[n].Cells[5].Value = this.txtPricePerProduct.Text;
                                    this.dgvCartProduct.Rows[n].Cells[6].Value = this.txtQuantityYouWantToSell.Text;
                                    this.dgvCartProduct.Rows[n].Cells[7].Value = this.txtTotalPrice.Text;
                                }

                                // Update the total amount
                                totalAmount += int.Parse(this.txtTotalPrice.Text);
                                this.lblTotalAmount.Text = totalAmount.ToString();

                                // Update the quantity in the table if the product is not in the cart
                                sql = "update WomensProduct set Quantity = '" + newQuantity + "' where ProductCode = '" + this.txtProductCode.Text + "'";
                                da.ExecuteDMLQuery(sql);

                                // Update the quantity in the table if the product is already in the cart
                                if (productExists)
                                {
                                    sql = "update WomensProduct set Quantity = '" + newQuantity + "' where ProductCode = '" + this.txtProductCode.Text + "'";
                                    da.ExecuteDMLQuery(sql);
                                }

                                MessageBox.Show("Product added to cart successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //storing data to SoldProduct when the cart has no duplicate of this product
                                sql = "insert into SoldProduct values('" + this.txtProductCode.Text + "','" + this.txtProductName.Text + "','" + this.txtSize.Text + "', '" + this.txtCategory.Text + "','" + this.txtOrigin.Text + "','" + this.txtPricePerProduct.Text + "','" + this.txtQuantityYouWantToSell.Text + "','" + this.txtTotalPrice.Text + "','" + Global.username + "')";
                                da.ExecuteDMLQuery(sql);
                            }
                            else
                            {
                                MessageBox.Show("Product is out of stock. \n Only " + quantity + " left.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            sql = "select * from WomensProduct";
                            this.PopulateGridView(sql);
                        }
                        else
                        {
                            MessageBox.Show("Select a product first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else if (selectedCategory == "Kids")
                {
                    if (this.txtProductCode.Text != "")
                    {
                        string sql = "select Quantity from KidsProduct where ProductCode = '" + this.txtProductCode.Text + "'";
                        var ds = da.ExecuteQuery(sql);

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                            newQuantity = quantity - Int64.Parse(this.txtQuantityYouWantToSell.Text);

                            if (newQuantity >= 0)
                            {
                                bool productExists = false;
                                int existingRowIndex = -1;

                                // Check if the product already exists in the DataGridView
                                for (int i = 0; i < dgvCartProduct.Rows.Count; i++)
                                {
                                    string productCode = dgvCartProduct.Rows[i].Cells[0].Value.ToString();

                                    if (productCode == txtProductCode.Text)
                                    {
                                        productExists = true;
                                        existingRowIndex = i;
                                        break;
                                    }
                                }

                                if (productExists)
                                {
                                    // Update the quantity and total price of the existing product
                                    int currentQuantity = int.Parse(dgvCartProduct.Rows[existingRowIndex].Cells[6].Value.ToString());
                                    int quantityToAdd = int.Parse(txtQuantityYouWantToSell.Text);
                                    dgvCartProduct.Rows[existingRowIndex].Cells[6].Value = (currentQuantity + quantityToAdd).ToString();

                                    int totalPrice = int.Parse(dgvCartProduct.Rows[existingRowIndex].Cells[7].Value.ToString());
                                    int pricePerProduct = int.Parse(txtPricePerProduct.Text);
                                    dgvCartProduct.Rows[existingRowIndex].Cells[7].Value = (totalPrice + (pricePerProduct * quantityToAdd)).ToString();
                                }
                                else
                                {
                                    // Add a new row to the DataGridView
                                    int n = this.dgvCartProduct.Rows.Add();
                                    this.dgvCartProduct.Rows[n].Cells[0].Value = this.txtProductCode.Text;
                                    this.dgvCartProduct.Rows[n].Cells[1].Value = this.txtProductName.Text;
                                    this.dgvCartProduct.Rows[n].Cells[2].Value = this.txtSize.Text;
                                    this.dgvCartProduct.Rows[n].Cells[3].Value = this.txtCategory.Text;
                                    this.dgvCartProduct.Rows[n].Cells[4].Value = this.txtOrigin.Text;
                                    this.dgvCartProduct.Rows[n].Cells[5].Value = this.txtPricePerProduct.Text;
                                    this.dgvCartProduct.Rows[n].Cells[6].Value = this.txtQuantityYouWantToSell.Text;
                                    this.dgvCartProduct.Rows[n].Cells[7].Value = this.txtTotalPrice.Text;
                                }

                                // Update the total amount
                                totalAmount += int.Parse(this.txtTotalPrice.Text);
                                this.lblTotalAmount.Text = totalAmount.ToString();

                                // Update the quantity in the table if the product is not in the cart
                                sql = "update KidsProduct set Quantity = '" + newQuantity + "' where ProductCode = '" + this.txtProductCode.Text + "'";
                                da.ExecuteDMLQuery(sql);

                                // Update the quantity in the table if the product is already in the cart
                                if (productExists)
                                {
                                    sql = "update KidsProduct set Quantity = '" + newQuantity + "' where ProductCode = '" + this.txtProductCode.Text + "'";
                                    da.ExecuteDMLQuery(sql);
                                }

                                MessageBox.Show("Product added to cart successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //storing data to SoldProduct when the cart has no duplicate of this product
                                sql = "insert into SoldProduct values('" + this.txtProductCode.Text + "','" + this.txtProductName.Text + "','" + this.txtSize.Text + "', '" + this.txtCategory.Text + "','" + this.txtOrigin.Text + "','" + this.txtPricePerProduct.Text + "','" + this.txtQuantityYouWantToSell.Text + "','" + this.txtTotalPrice.Text + "','" + Global.username + "')";
                                da.ExecuteDMLQuery(sql);
                            }
                            else
                            {
                                MessageBox.Show("Product is out of stock. \n Only " + quantity + " left.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            sql = "select * from KidsProduct";
                            this.PopulateGridView(sql);
                        }
                        else
                        {
                            MessageBox.Show("Select a product first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                this.txtProductCode.Clear();
                this.txtProductName.Clear();
                this.txtSize.Clear();
                this.txtCategory.Clear();
                this.txtOrigin.Clear();
                this.txtPricePerProduct.Clear();
                this.txtQuantityYouWantToSell.Clear();
                this.txtTotalPrice.Clear();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        int valueAmount;
        String valueCode;
        protected Int64 noOfQuantity;

        private void dgvCartProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(this.dgvCartProduct.Rows[e.RowIndex].Cells[7].Value.ToString());
                valueCode = this.dgvCartProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfQuantity = Int64.Parse(this.dgvCartProduct.Rows[e.RowIndex].Cells[6].Value.ToString());
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            string selectedCategory = this.cmbCategory.SelectedItem.ToString();
            if (selectedCategory == "Men")
            {
                if (valueCode != null)
                {
                    try
                    {
                        if (this.dgvCartProduct.SelectedRows.Count > 0)
                        {
                            int selectedRowIndex = this.dgvCartProduct.SelectedRows[0].Index;
                            this.dgvCartProduct.Rows.RemoveAt(selectedRowIndex);
                            this.dgvCartProduct.ClearSelection();

                            string sql = "select Quantity from MensProduct where ProductCode = '" + valueCode + "'";
                            var ds = da.ExecuteQuery(sql);
                            quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                            newQuantity = quantity + noOfQuantity;

                            sql = "update MensProduct set Quantity = '" + newQuantity + "' where ProductCode = '" + valueCode + "'";
                            da.ExecuteDMLQuery(sql);

                            MessageBox.Show("Product removed from the cart successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //deleting the stored data from the SoldProduct table
                            sql = "delete from SoldProduct where ProductCode = '" + valueCode + "';";
                            da.ExecuteDMLQuery(sql);

                            this.totalAmount = this.totalAmount - valueAmount;
                            this.lblTotalAmount.Text = this.totalAmount.ToString();

                            sql = "select * from MensProduct";
                            this.PopulateGridView(sql);
                        }
                        else
                        {
                            MessageBox.Show("Select a product first to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("An error has occurred: " + exc.Message);
                    }
                }
            }
            else if (selectedCategory == "Women")
            {
                if (valueCode != null)
                {
                    try
                    {
                        if (this.dgvCartProduct.SelectedRows.Count > 0)
                        {
                            int selectedRowIndex = this.dgvCartProduct.SelectedRows[0].Index;
                            this.dgvCartProduct.Rows.RemoveAt(selectedRowIndex);
                            this.dgvCartProduct.ClearSelection();

                            string sql = "select Quantity from WomensProduct where ProductCode = '" + valueCode + "'";
                            var ds = da.ExecuteQuery(sql);
                            quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                            newQuantity = quantity + noOfQuantity;

                            sql = "update WomensProduct set Quantity = '" + newQuantity + "' where ProductCode = '" + valueCode + "'";
                            da.ExecuteDMLQuery(sql);

                            MessageBox.Show("Product removed from the cart successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //deleting the stored data from the SoldProduct table
                            sql = "delete from SoldProduct where ProductCode = '" + valueCode + "';";
                            da.ExecuteDMLQuery(sql);

                            this.totalAmount = this.totalAmount - valueAmount;
                            this.lblTotalAmount.Text = this.totalAmount.ToString();

                            sql = "select * from WomensProduct";
                            this.PopulateGridView(sql);
                        }
                        else
                        {
                            MessageBox.Show("Select a product first to remove.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("An error has occurred: " + exc.Message);
                    }
                }
            }
            else if (selectedCategory == "Kids")
            {
                if (valueCode != null)
                {
                    try
                    {
                        if (this.dgvCartProduct.SelectedRows.Count > 0)
                        {
                            int selectedRowIndex = this.dgvCartProduct.SelectedRows[0].Index;
                            this.dgvCartProduct.Rows.RemoveAt(selectedRowIndex);
                            this.dgvCartProduct.ClearSelection();

                            string sql = "select Quantity from KidsProduct where ProductCode = '" + valueCode + "'";
                            var ds = da.ExecuteQuery(sql);
                            quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                            newQuantity = quantity + noOfQuantity;

                            sql = "update KidsProduct set Quantity = '" + newQuantity + "' where ProductCode = '" + valueCode + "'";
                            da.ExecuteDMLQuery(sql);

                            MessageBox.Show("Product removed from the cart successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //deleting the stored data from the SoldProduct table
                            sql = "delete from SoldProduct where ProductCode = '" + valueCode + "';";
                            da.ExecuteDMLQuery(sql);

                            this.totalAmount = this.totalAmount - valueAmount;
                            this.lblTotalAmount.Text = this.totalAmount.ToString();

                            sql = "select * from KidsProduct";
                            this.PopulateGridView(sql);
                        }
                        else
                        {
                            MessageBox.Show("Select a product first to remove.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("An error has occurred: " + exc.Message);
                    }
                }
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvCartProduct.SelectedRows.Count > 0)
                {
                    DGVPrinter print = new DGVPrinter();
                    print.Title = "Product Bill";
                    print.SubTitle = string.Format("Date:- {0}", DateTime.Now.Date);
                    print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    print.PageNumbers = true;
                    print.PageNumberInHeader = false;
                    print.PorportionalColumns = true;
                    print.HeaderCellAlignment = StringAlignment.Near;
                    print.Footer = "Total Payable Amount : TAKA " + this.lblTotalAmount.Text;
                    print.FooterSpacing = 15;
                    print.PrintDataGridView(this.dgvCartProduct);

                    this.totalAmount = 0;
                    this.lblTotalAmount.Text = "0";
                    this.dgvCartProduct.DataSource = 0;

                    MessageBox.Show("Product Sold.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Your cart is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred: " + exc.Message);
            }
        }
    }
}
