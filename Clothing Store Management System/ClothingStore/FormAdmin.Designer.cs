
namespace LogInForm
{
    partial class FormAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblRMXClothingTore = new Guna.UI.WinForms.GunaLabel();
            this.lblLogout = new System.Windows.Forms.Label();
            this.btnProfile = new Guna.UI.WinForms.GunaButton();
            this.btnLogout = new Guna.UI.WinForms.GunaButton();
            this.btnSearch = new Guna.UI.WinForms.GunaButton();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.pnlHeaderContainer = new Guna.UI.WinForms.GunaPanel();
            this.pnlButtonContainer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnViewProduct = new Guna.UI.WinForms.GunaButton();
            this.btnSalesHistory = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUser = new Guna.UI.WinForms.GunaButton();
            this.btnProduct = new Guna.UI.WinForms.GunaButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new Guna.UI.WinForms.GunaButton();
            this.dgvSoldProduct = new Guna.UI.WinForms.GunaDataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlButtonContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblAccount);
            this.pnlHeader.Controls.Add(this.lblRMXClothingTore);
            this.pnlHeader.Controls.Add(this.lblLogout);
            this.pnlHeader.Controls.Add(this.btnProfile);
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Location = new System.Drawing.Point(0, 11);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1284, 57);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblAccount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.ForeColor = System.Drawing.Color.Crimson;
            this.lblAccount.Location = new System.Drawing.Point(1146, 39);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(44, 15);
            this.lblAccount.TabIndex = 11;
            this.lblAccount.Text = "Profile";
            // 
            // lblRMXClothingTore
            // 
            this.lblRMXClothingTore.AutoSize = true;
            this.lblRMXClothingTore.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRMXClothingTore.Location = new System.Drawing.Point(51, 4);
            this.lblRMXClothingTore.Name = "lblRMXClothingTore";
            this.lblRMXClothingTore.Size = new System.Drawing.Size(75, 48);
            this.lblRMXClothingTore.TabIndex = 9;
            this.lblRMXClothingTore.Text = "RMX\r\nCLOTHING\r\nSTORE";
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.Color.Transparent;
            this.lblLogout.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.Crimson;
            this.lblLogout.Location = new System.Drawing.Point(1210, 40);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(49, 15);
            this.lblLogout.TabIndex = 8;
            this.lblLogout.Text = "Log out";
            // 
            // btnProfile
            // 
            this.btnProfile.AnimationHoverSpeed = 0.07F;
            this.btnProfile.AnimationSpeed = 0.03F;
            this.btnProfile.BaseColor = System.Drawing.Color.Transparent;
            this.btnProfile.BorderColor = System.Drawing.Color.Transparent;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProfile.FocusedColor = System.Drawing.Color.Empty;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = global::LogInForm.Properties.Resources.user_png_copy1;
            this.btnProfile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnProfile.ImageSize = new System.Drawing.Size(30, 30);
            this.btnProfile.Location = new System.Drawing.Point(1144, 4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnProfile.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnProfile.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btnProfile.OnHoverImage = null;
            this.btnProfile.OnPressedColor = System.Drawing.Color.WhiteSmoke;
            this.btnProfile.Size = new System.Drawing.Size(47, 35);
            this.btnProfile.TabIndex = 10;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BaseColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::LogInForm.Properties.Resources.logout_copy;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogout.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLogout.Location = new System.Drawing.Point(1209, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btnLogout.OnHoverImage = null;
            this.btnLogout.OnPressedColor = System.Drawing.Color.White;
            this.btnLogout.Size = new System.Drawing.Size(47, 35);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AnimationHoverSpeed = 0.07F;
            this.btnSearch.AnimationSpeed = 0.03F;
            this.btnSearch.BaseColor = System.Drawing.Color.Crimson;
            this.btnSearch.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 11F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::LogInForm.Properties.Resources.search;
            this.btnSearch.ImageOffsetX = -3;
            this.btnSearch.ImageSize = new System.Drawing.Size(15, 15);
            this.btnSearch.Location = new System.Drawing.Point(651, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Size = new System.Drawing.Size(83, 30);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSearch.TextOffsetX = -2;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.Crimson;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.Crimson;
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(97, 61);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(548, 30);
            this.txtSearch.TabIndex = 6;
            // 
            // pnlHeaderContainer
            // 
            this.pnlHeaderContainer.BackColor = System.Drawing.Color.Crimson;
            this.pnlHeaderContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderContainer.Name = "pnlHeaderContainer";
            this.pnlHeaderContainer.Size = new System.Drawing.Size(1286, 68);
            this.pnlHeaderContainer.TabIndex = 3;
            // 
            // pnlButtonContainer
            // 
            this.pnlButtonContainer.Controls.Add(this.label2);
            this.pnlButtonContainer.Controls.Add(this.btnViewProduct);
            this.pnlButtonContainer.Controls.Add(this.btnSalesHistory);
            this.pnlButtonContainer.Controls.Add(this.label1);
            this.pnlButtonContainer.Controls.Add(this.btnUser);
            this.pnlButtonContainer.Controls.Add(this.btnProduct);
            this.pnlButtonContainer.Location = new System.Drawing.Point(0, 74);
            this.pnlButtonContainer.Name = "pnlButtonContainer";
            this.pnlButtonContainer.Size = new System.Drawing.Size(357, 638);
            this.pnlButtonContainer.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Crimson;
            this.label2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(101, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "View / Add / Delete";
            // 
            // btnViewProduct
            // 
            this.btnViewProduct.AnimationHoverSpeed = 0.07F;
            this.btnViewProduct.AnimationSpeed = 0.03F;
            this.btnViewProduct.BaseColor = System.Drawing.Color.Crimson;
            this.btnViewProduct.BorderColor = System.Drawing.Color.Black;
            this.btnViewProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewProduct.FocusedColor = System.Drawing.Color.Empty;
            this.btnViewProduct.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.btnViewProduct.ForeColor = System.Drawing.Color.White;
            this.btnViewProduct.Image = global::LogInForm.Properties.Resources.View_product;
            this.btnViewProduct.ImageOffsetX = 14;
            this.btnViewProduct.ImageSize = new System.Drawing.Size(60, 60);
            this.btnViewProduct.Location = new System.Drawing.Point(6, 169);
            this.btnViewProduct.Name = "btnViewProduct";
            this.btnViewProduct.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnViewProduct.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnViewProduct.OnHoverForeColor = System.Drawing.Color.White;
            this.btnViewProduct.OnHoverImage = null;
            this.btnViewProduct.OnPressedColor = System.Drawing.Color.Black;
            this.btnViewProduct.Size = new System.Drawing.Size(351, 110);
            this.btnViewProduct.TabIndex = 17;
            this.btnViewProduct.Text = "View Product";
            this.btnViewProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnViewProduct.TextOffsetX = 30;
            this.btnViewProduct.Click += new System.EventHandler(this.btnViewProduct_Click);
            // 
            // btnSalesHistory
            // 
            this.btnSalesHistory.AnimationHoverSpeed = 0.07F;
            this.btnSalesHistory.AnimationSpeed = 0.03F;
            this.btnSalesHistory.BaseColor = System.Drawing.Color.Crimson;
            this.btnSalesHistory.BorderColor = System.Drawing.Color.Black;
            this.btnSalesHistory.Cursor = System.Windows.Forms.Cursors.No;
            this.btnSalesHistory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSalesHistory.FocusedColor = System.Drawing.Color.Empty;
            this.btnSalesHistory.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.btnSalesHistory.ForeColor = System.Drawing.Color.White;
            this.btnSalesHistory.Image = global::LogInForm.Properties.Resources.History;
            this.btnSalesHistory.ImageOffsetX = 14;
            this.btnSalesHistory.ImageSize = new System.Drawing.Size(60, 60);
            this.btnSalesHistory.Location = new System.Drawing.Point(6, 21);
            this.btnSalesHistory.Name = "btnSalesHistory";
            this.btnSalesHistory.OnHoverBaseColor = System.Drawing.Color.Crimson;
            this.btnSalesHistory.OnHoverBorderColor = System.Drawing.Color.Crimson;
            this.btnSalesHistory.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSalesHistory.OnHoverImage = null;
            this.btnSalesHistory.OnPressedColor = System.Drawing.Color.Crimson;
            this.btnSalesHistory.Size = new System.Drawing.Size(351, 110);
            this.btnSalesHistory.TabIndex = 17;
            this.btnSalesHistory.Text = "Sales History";
            this.btnSalesHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSalesHistory.TextOffsetX = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add / Delete / Update";
            // 
            // btnUser
            // 
            this.btnUser.AnimationHoverSpeed = 0.07F;
            this.btnUser.AnimationSpeed = 0.03F;
            this.btnUser.BaseColor = System.Drawing.Color.Crimson;
            this.btnUser.BorderColor = System.Drawing.Color.Black;
            this.btnUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnUser.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = global::LogInForm.Properties.Resources.view_user;
            this.btnUser.ImageOffsetX = 25;
            this.btnUser.ImageSize = new System.Drawing.Size(50, 50);
            this.btnUser.Location = new System.Drawing.Point(6, 484);
            this.btnUser.Name = "btnUser";
            this.btnUser.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUser.OnHoverImage = null;
            this.btnUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnUser.Size = new System.Drawing.Size(351, 110);
            this.btnUser.TabIndex = 17;
            this.btnUser.Text = "User";
            this.btnUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnUser.TextOffsetX = 130;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.AnimationHoverSpeed = 0.07F;
            this.btnProduct.AnimationSpeed = 0.03F;
            this.btnProduct.BaseColor = System.Drawing.Color.Crimson;
            this.btnProduct.BorderColor = System.Drawing.Color.Black;
            this.btnProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProduct.FocusedColor = System.Drawing.Color.Empty;
            this.btnProduct.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = global::LogInForm.Properties.Resources.product;
            this.btnProduct.ImageOffsetX = 20;
            this.btnProduct.ImageSize = new System.Drawing.Size(50, 50);
            this.btnProduct.Location = new System.Drawing.Point(6, 322);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnProduct.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnProduct.OnHoverForeColor = System.Drawing.Color.White;
            this.btnProduct.OnHoverImage = null;
            this.btnProduct.OnPressedColor = System.Drawing.Color.Black;
            this.btnProduct.Size = new System.Drawing.Size(351, 110);
            this.btnProduct.TabIndex = 17;
            this.btnProduct.Text = "Product";
            this.btnProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnProduct.TextOffsetX = 100;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Crimson;
            this.panel4.Location = new System.Drawing.Point(363, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 629);
            this.panel4.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSoldProduct);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(363, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 638);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 34);
            this.label3.TabIndex = 15;
            this.label3.Text = "Sales History";
            // 
            // btnClear
            // 
            this.btnClear.AnimationHoverSpeed = 0.07F;
            this.btnClear.AnimationSpeed = 0.03F;
            this.btnClear.BaseColor = System.Drawing.Color.Crimson;
            this.btnClear.BorderColor = System.Drawing.Color.Black;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClear.FocusedColor = System.Drawing.Color.Empty;
            this.btnClear.Font = new System.Drawing.Font("Arial", 11F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = null;
            this.btnClear.ImageOffsetX = -3;
            this.btnClear.ImageSize = new System.Drawing.Size(15, 15);
            this.btnClear.Location = new System.Drawing.Point(740, 61);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClear.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClear.OnHoverImage = null;
            this.btnClear.OnPressedColor = System.Drawing.Color.Black;
            this.btnClear.Size = new System.Drawing.Size(83, 30);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClear.TextOffsetX = -2;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvSoldProduct
            // 
            this.dgvSoldProduct.AllowUserToAddRows = false;
            this.dgvSoldProduct.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.dgvSoldProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSoldProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSoldProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvSoldProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSoldProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSoldProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSoldProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSoldProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSoldProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSoldProduct.EnableHeadersVisualStyles = false;
            this.dgvSoldProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(184)))));
            this.dgvSoldProduct.Location = new System.Drawing.Point(38, 124);
            this.dgvSoldProduct.Name = "dgvSoldProduct";
            this.dgvSoldProduct.ReadOnly = true;
            this.dgvSoldProduct.RowHeadersVisible = false;
            this.dgvSoldProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSoldProduct.Size = new System.Drawing.Size(855, 470);
            this.dgvSoldProduct.TabIndex = 16;
            this.dgvSoldProduct.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Red;
            this.dgvSoldProduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.dgvSoldProduct.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSoldProduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSoldProduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSoldProduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSoldProduct.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSoldProduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(184)))));
            this.dgvSoldProduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.dgvSoldProduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSoldProduct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvSoldProduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSoldProduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoldProduct.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvSoldProduct.ThemeStyle.ReadOnly = true;
            this.dgvSoldProduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            this.dgvSoldProduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSoldProduct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvSoldProduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSoldProduct.ThemeStyle.RowsStyle.Height = 22;
            this.dgvSoldProduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            this.dgvSoldProduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlButtonContainer);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlHeaderContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin View";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlButtonContainer.ResumeLayout(false);
            this.pnlButtonContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private Guna.UI.WinForms.GunaLabel lblRMXClothingTore;
        private System.Windows.Forms.Label lblLogout;
        private Guna.UI.WinForms.GunaButton btnSearch;
        private Guna.UI.WinForms.GunaButton btnLogout;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private Guna.UI.WinForms.GunaPanel pnlHeaderContainer;
        private System.Windows.Forms.Panel pnlButtonContainer;
        private Guna.UI.WinForms.GunaButton btnSalesHistory;
        private Guna.UI.WinForms.GunaButton btnUser;
        private Guna.UI.WinForms.GunaButton btnProduct;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblAccount;
        private Guna.UI.WinForms.GunaButton btnProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btnViewProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaButton btnClear;
        private Guna.UI.WinForms.GunaDataGridView dgvSoldProduct;
    }
}