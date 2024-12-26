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
    public partial class FormLogin : Form
    {   
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "select * from Login_Table where Username = '" + this.txtUsername.Text + "' and Password = '" + this.txtPassword.Text + "';";
            SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-D680VSNF\SQLEXPRESS;Initial Catalog=jamidb;Integrated Security=True");
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Successfully logged in");
                if (ds.Tables[0].Rows[0][2].ToString() == "admin")
                {
                    Global.username = ds.Tables[0].Rows[0]["Username"].ToString();
                    Global.password = ds.Tables[0].Rows[0]["Password"].ToString();
                    Global.role = ds.Tables[0].Rows[0]["Role"].ToString();
                    this.Hide();
                    FormAdmin formadmin = new FormAdmin();
                    formadmin.Show();
                }
                else
                {
                    Global.username = ds.Tables[0].Rows[0]["Username"].ToString();
                    Global.password = ds.Tables[0].Rows[0]["Password"].ToString();
                    Global.role = ds.Tables[0].Rows[0]["Role"].ToString();
                    this.Hide();
                    FormSalesmanMen formcustomer = new FormSalesmanMen();
                    formcustomer.Show();
                }
            }
            else
            {
                MessageBox.Show("Incorrect password or username");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUsername.Clear();
            this.txtPassword.Clear();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //this.btnShow.Parent = this.pbBackground;
            //this.btnShow.BackColor = Color.Transparent;
            this.pnlLogin.Parent = this.pbBackground;
            this.pnlLogin.BackColor = Color.Transparent;
            this.label1.Parent = this.pbBackground;
            this.label1.BackColor = Color.Transparent;
            this.label2.Parent = this.pbBackground;
            this.label2.BackColor = Color.Transparent;
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                this.txtPassword.UseSystemPasswordChar = false;
                this.btnShowPassword.Image = Image.FromFile(@"E:\Sadi\C# Project\Icons\eye closed.png");
                //this.btnShow.Text = "Hide";
            }
            else
            {
                this.txtPassword.UseSystemPasswordChar = true;
                this.btnShowPassword.Image = Image.FromFile(@"E:\Sadi\C# Project\Icons\eye open.png");
                //this.btnShow.Text = "Show";
            }
        }
    }
}
