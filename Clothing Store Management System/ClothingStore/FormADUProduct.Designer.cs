
namespace LogInForm
{
    partial class FormADUProduct
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
            this.btnDeleteProduct = new Guna.UI.WinForms.GunaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdateProduct = new Guna.UI.WinForms.GunaButton();
            this.btnAddProduct = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 79);
            this.panel1.TabIndex = 1;
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
            this.btnBack.Location = new System.Drawing.Point(35, 8);
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
            this.label1.Location = new System.Drawing.Point(296, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(695, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add / Delete / Update Product";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.AnimationHoverSpeed = 0.07F;
            this.btnDeleteProduct.AnimationSpeed = 0.03F;
            this.btnDeleteProduct.BaseColor = System.Drawing.Color.Crimson;
            this.btnDeleteProduct.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteProduct.FocusedColor = System.Drawing.Color.Empty;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Image = global::LogInForm.Properties.Resources.delete;
            this.btnDeleteProduct.ImageOffsetX = 17;
            this.btnDeleteProduct.ImageSize = new System.Drawing.Size(50, 50);
            this.btnDeleteProduct.Location = new System.Drawing.Point(877, 221);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnDeleteProduct.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDeleteProduct.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.OnHoverImage = null;
            this.btnDeleteProduct.OnPressedColor = System.Drawing.Color.Black;
            this.btnDeleteProduct.Size = new System.Drawing.Size(394, 133);
            this.btnDeleteProduct.TabIndex = 12;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.TextOffsetX = 30;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeleteProduct);
            this.panel2.Controls.Add(this.btnUpdateProduct);
            this.panel2.Controls.Add(this.btnAddProduct);
            this.panel2.Location = new System.Drawing.Point(1, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1284, 637);
            this.panel2.TabIndex = 14;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.AnimationHoverSpeed = 0.07F;
            this.btnUpdateProduct.AnimationSpeed = 0.03F;
            this.btnUpdateProduct.BaseColor = System.Drawing.Color.BlueViolet;
            this.btnUpdateProduct.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdateProduct.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProduct.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProduct.Image = global::LogInForm.Properties.Resources.update;
            this.btnUpdateProduct.ImageOffsetX = 12;
            this.btnUpdateProduct.ImageSize = new System.Drawing.Size(50, 60);
            this.btnUpdateProduct.Location = new System.Drawing.Point(444, 221);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.OnHoverBaseColor = System.Drawing.Color.Indigo;
            this.btnUpdateProduct.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdateProduct.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdateProduct.OnHoverImage = null;
            this.btnUpdateProduct.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdateProduct.Size = new System.Drawing.Size(394, 133);
            this.btnUpdateProduct.TabIndex = 13;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.TextOffsetX = 30;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AnimationHoverSpeed = 0.07F;
            this.btnAddProduct.AnimationSpeed = 0.03F;
            this.btnAddProduct.BaseColor = System.Drawing.Color.Teal;
            this.btnAddProduct.BorderColor = System.Drawing.Color.Black;
            this.btnAddProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddProduct.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddProduct.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Image = global::LogInForm.Properties.Resources.add;
            this.btnAddProduct.ImageOffsetX = 15;
            this.btnAddProduct.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddProduct.Location = new System.Drawing.Point(11, 221);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.OnHoverBaseColor = System.Drawing.Color.CadetBlue;
            this.btnAddProduct.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddProduct.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddProduct.OnHoverImage = null;
            this.btnAddProduct.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddProduct.Size = new System.Drawing.Size(394, 133);
            this.btnAddProduct.TabIndex = 11;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.TextOffsetX = 30;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // FormADUProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormADUProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Delete / Update Product";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btnBack;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnAddProduct;
        private Guna.UI.WinForms.GunaButton btnDeleteProduct;
        private Guna.UI.WinForms.GunaButton btnUpdateProduct;
        private System.Windows.Forms.Panel panel2;
    }
}