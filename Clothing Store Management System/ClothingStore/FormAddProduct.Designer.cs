
namespace LogInForm
{
    partial class FormAddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClearTextBoxs = new Guna.UI2.WinForms.Guna2Button();
            this.cmbSize = new Guna.UI.WinForms.GunaComboBox();
            this.cmbCategory = new Guna.UI.WinForms.GunaComboBox();
            this.dtpAddingDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnAddProduct = new Guna.UI.WinForms.GunaButton();
            this.cmbOrigin = new Guna.UI.WinForms.GunaComboBox();
            this.txtPrice = new Guna.UI.WinForms.GunaTextBox();
            this.txtQuantity = new Guna.UI.WinForms.GunaTextBox();
            this.txtProductName = new Guna.UI.WinForms.GunaTextBox();
            this.txtProductCode = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 79);
            this.panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.AnimationHoverSpeed = 0.07F;
            this.btnBack.AnimationSpeed = 0.03F;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BaseColor = System.Drawing.Color.Crimson;
            this.btnBack.BorderColor = System.Drawing.Color.Black;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.FocusedColor = System.Drawing.Color.Empty;
            this.btnBack.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::LogInForm.Properties.Resources._340_copy;
            this.btnBack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBack.ImageSize = new System.Drawing.Size(35, 35);
            this.btnBack.Location = new System.Drawing.Point(34, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBack.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBack.OnHoverImage = null;
            this.btnBack.OnPressedColor = System.Drawing.Color.Black;
            this.btnBack.Radius = 25;
            this.btnBack.Size = new System.Drawing.Size(81, 62);
            this.btnBack.TabIndex = 18;
            this.btnBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBack.TextOffsetX = 50;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Product";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.btnClearTextBoxs);
            this.panel2.Controls.Add(this.cmbSize);
            this.panel2.Controls.Add(this.cmbCategory);
            this.panel2.Controls.Add(this.dtpAddingDate);
            this.panel2.Controls.Add(this.btnAddProduct);
            this.panel2.Controls.Add(this.cmbOrigin);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.txtProductName);
            this.panel2.Controls.Add(this.txtProductCode);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1284, 636);
            this.panel2.TabIndex = 1;
            // 
            // btnClearTextBoxs
            // 
            this.btnClearTextBoxs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearTextBoxs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearTextBoxs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearTextBoxs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearTextBoxs.FillColor = System.Drawing.Color.Crimson;
            this.btnClearTextBoxs.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTextBoxs.ForeColor = System.Drawing.Color.White;
            this.btnClearTextBoxs.Location = new System.Drawing.Point(1034, 500);
            this.btnClearTextBoxs.Name = "btnClearTextBoxs";
            this.btnClearTextBoxs.Size = new System.Drawing.Size(124, 47);
            this.btnClearTextBoxs.TabIndex = 25;
            this.btnClearTextBoxs.Text = "Clear";
            this.btnClearTextBoxs.Click += new System.EventHandler(this.btnClearTextBoxs_Click);
            // 
            // cmbSize
            // 
            this.cmbSize.AutoCompleteCustomSource.AddRange(new string[] {
            "S",
            "M",
            "L",
            "XL"});
            this.cmbSize.BackColor = System.Drawing.Color.Transparent;
            this.cmbSize.BaseColor = System.Drawing.Color.White;
            this.cmbSize.BorderColor = System.Drawing.Color.Crimson;
            this.cmbSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.FocusedColor = System.Drawing.Color.Empty;
            this.cmbSize.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSize.ForeColor = System.Drawing.Color.Black;
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.cmbSize.Location = new System.Drawing.Point(61, 245);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.OnHoverItemBaseColor = System.Drawing.Color.Red;
            this.cmbSize.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbSize.Size = new System.Drawing.Size(281, 26);
            this.cmbSize.TabIndex = 22;
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategory.BaseColor = System.Drawing.Color.White;
            this.cmbCategory.BorderColor = System.Drawing.Color.Crimson;
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCategory.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.Color.Black;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Men",
            "Women",
            "Kids"});
            this.cmbCategory.Location = new System.Drawing.Point(61, 430);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.OnHoverItemBaseColor = System.Drawing.Color.Red;
            this.cmbCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbCategory.Size = new System.Drawing.Size(281, 26);
            this.cmbCategory.TabIndex = 22;
            // 
            // dtpAddingDate
            // 
            this.dtpAddingDate.BorderRadius = 5;
            this.dtpAddingDate.BorderThickness = 1;
            this.dtpAddingDate.Checked = true;
            this.dtpAddingDate.FillColor = System.Drawing.Color.Crimson;
            this.dtpAddingDate.Font = new System.Drawing.Font("Arial", 11.25F);
            this.dtpAddingDate.ForeColor = System.Drawing.Color.White;
            this.dtpAddingDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpAddingDate.Location = new System.Drawing.Point(504, 204);
            this.dtpAddingDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpAddingDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpAddingDate.Name = "dtpAddingDate";
            this.dtpAddingDate.Size = new System.Drawing.Size(234, 36);
            this.dtpAddingDate.TabIndex = 21;
            this.dtpAddingDate.Value = new System.DateTime(2023, 5, 3, 0, 0, 0, 0);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AnimationHoverSpeed = 0.07F;
            this.btnAddProduct.AnimationSpeed = 0.03F;
            this.btnAddProduct.BaseColor = System.Drawing.Color.Crimson;
            this.btnAddProduct.BorderColor = System.Drawing.Color.Black;
            this.btnAddProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddProduct.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddProduct.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Image = null;
            this.btnAddProduct.ImageOffsetX = 5;
            this.btnAddProduct.ImageSize = new System.Drawing.Size(17, 17);
            this.btnAddProduct.Location = new System.Drawing.Point(978, 378);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnAddProduct.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddProduct.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddProduct.OnHoverImage = null;
            this.btnAddProduct.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddProduct.Size = new System.Drawing.Size(237, 78);
            this.btnAddProduct.TabIndex = 10;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cmbOrigin
            // 
            this.cmbOrigin.BackColor = System.Drawing.Color.Transparent;
            this.cmbOrigin.BaseColor = System.Drawing.Color.White;
            this.cmbOrigin.BorderColor = System.Drawing.Color.Crimson;
            this.cmbOrigin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigin.FocusedColor = System.Drawing.Color.Empty;
            this.cmbOrigin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrigin.ForeColor = System.Drawing.Color.Black;
            this.cmbOrigin.FormattingEnabled = true;
            this.cmbOrigin.Items.AddRange(new object[] {
            "CHINA",
            "USA",
            "BANGLADESH",
            "INDIA"});
            this.cmbOrigin.Location = new System.Drawing.Point(504, 58);
            this.cmbOrigin.Name = "cmbOrigin";
            this.cmbOrigin.OnHoverItemBaseColor = System.Drawing.Color.Red;
            this.cmbOrigin.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbOrigin.Size = new System.Drawing.Size(234, 26);
            this.cmbOrigin.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.BaseColor = System.Drawing.Color.White;
            this.txtPrice.BorderColor = System.Drawing.Color.Crimson;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPrice.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(504, 527);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(281, 40);
            this.txtPrice.TabIndex = 7;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BaseColor = System.Drawing.Color.White;
            this.txtQuantity.BorderColor = System.Drawing.Color.Crimson;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.FocusedBaseColor = System.Drawing.Color.White;
            this.txtQuantity.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtQuantity.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(504, 416);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(281, 40);
            this.txtQuantity.TabIndex = 7;
            // 
            // txtProductName
            // 
            this.txtProductName.BaseColor = System.Drawing.Color.White;
            this.txtProductName.BorderColor = System.Drawing.Color.Crimson;
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtProductName.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtProductName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProductName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(61, 148);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.SelectedText = "";
            this.txtProductName.Size = new System.Drawing.Size(281, 40);
            this.txtProductName.TabIndex = 7;
            // 
            // txtProductCode
            // 
            this.txtProductCode.BaseColor = System.Drawing.Color.White;
            this.txtProductCode.BorderColor = System.Drawing.Color.Crimson;
            this.txtProductCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductCode.FocusedBaseColor = System.Drawing.Color.White;
            this.txtProductCode.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtProductCode.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProductCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCode.Location = new System.Drawing.Point(61, 49);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.PasswordChar = '\0';
            this.txtProductCode.SelectedText = "";
            this.txtProductCode.Size = new System.Drawing.Size(281, 40);
            this.txtProductCode.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(504, 500);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(504, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(500, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Origin of Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Product Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Size";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(500, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Adding Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product Code";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(501, 459);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(229, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "# Please enter a numeric value in this Text Box";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(501, 570);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "# Please enter a numeric value in this Text Box";
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product (MEN)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtQuantity;
        private Guna.UI.WinForms.GunaTextBox txtProductName;
        private Guna.UI.WinForms.GunaTextBox txtProductCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaComboBox cmbOrigin;
        private Guna.UI.WinForms.GunaTextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpAddingDate;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaButton btnAddProduct;
        private Guna.UI.WinForms.GunaComboBox cmbCategory;
        private Guna.UI.WinForms.GunaComboBox cmbSize;
        private Guna.UI2.WinForms.Guna2Button btnClearTextBoxs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
    }
}