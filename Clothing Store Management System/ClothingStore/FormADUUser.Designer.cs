
namespace LogInForm
{
    partial class FormADUUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteUser = new Guna.UI.WinForms.GunaButton();
            this.btnViewUser = new Guna.UI.WinForms.GunaButton();
            this.btnAddUser = new Guna.UI.WinForms.GunaButton();
            this.btnBack = new Guna.UI.WinForms.GunaButton();
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
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add / Delete / Update User";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeleteUser);
            this.panel2.Controls.Add(this.btnViewUser);
            this.panel2.Controls.Add(this.btnAddUser);
            this.panel2.Location = new System.Drawing.Point(1, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1284, 637);
            this.panel2.TabIndex = 15;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.AnimationHoverSpeed = 0.07F;
            this.btnDeleteUser.AnimationSpeed = 0.03F;
            this.btnDeleteUser.BaseColor = System.Drawing.Color.Crimson;
            this.btnDeleteUser.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnDeleteUser.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Image = global::LogInForm.Properties.Resources.delete;
            this.btnDeleteUser.ImageOffsetX = 17;
            this.btnDeleteUser.ImageSize = new System.Drawing.Size(50, 50);
            this.btnDeleteUser.Location = new System.Drawing.Point(866, 221);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnDeleteUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDeleteUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.OnHoverImage = null;
            this.btnDeleteUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnDeleteUser.Size = new System.Drawing.Size(394, 133);
            this.btnDeleteUser.TabIndex = 12;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.TextOffsetX = 30;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnViewUser
            // 
            this.btnViewUser.AnimationHoverSpeed = 0.07F;
            this.btnViewUser.AnimationSpeed = 0.03F;
            this.btnViewUser.BaseColor = System.Drawing.Color.Maroon;
            this.btnViewUser.BorderColor = System.Drawing.Color.Black;
            this.btnViewUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnViewUser.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUser.ForeColor = System.Drawing.Color.White;
            this.btnViewUser.Image = global::LogInForm.Properties.Resources.view_user;
            this.btnViewUser.ImageOffsetX = 15;
            this.btnViewUser.ImageSize = new System.Drawing.Size(50, 50);
            this.btnViewUser.Location = new System.Drawing.Point(22, 221);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.btnViewUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnViewUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnViewUser.OnHoverImage = null;
            this.btnViewUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnViewUser.Size = new System.Drawing.Size(394, 133);
            this.btnViewUser.TabIndex = 11;
            this.btnViewUser.Text = "View User";
            this.btnViewUser.TextOffsetX = 30;
            this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.AnimationHoverSpeed = 0.07F;
            this.btnAddUser.AnimationSpeed = 0.03F;
            this.btnAddUser.BaseColor = System.Drawing.Color.Teal;
            this.btnAddUser.BorderColor = System.Drawing.Color.Black;
            this.btnAddUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddUser.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Image = global::LogInForm.Properties.Resources.add;
            this.btnAddUser.ImageOffsetX = 15;
            this.btnAddUser.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddUser.Location = new System.Drawing.Point(439, 221);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.OnHoverBaseColor = System.Drawing.Color.CadetBlue;
            this.btnAddUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddUser.OnHoverImage = null;
            this.btnAddUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddUser.Size = new System.Drawing.Size(394, 133);
            this.btnAddUser.TabIndex = 11;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.TextOffsetX = 30;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
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
            // FormADUUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormADUUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Delete / Update User";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton btnDeleteUser;
        private Guna.UI.WinForms.GunaButton btnAddUser;
        private Guna.UI.WinForms.GunaButton btnViewUser;
    }
}