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
    public partial class FormAdminProfile : Form
    {
        public FormAdminProfile()
        {
            InitializeComponent();
        }

        private void FormAdminProfile_Load(object sender, EventArgs e)
        {
            this.lblUsername.Text = Global.username;
            this.lblPassword.Text = Global.password;
            this.lblRole.Text = Global.role;
        }
    }
}
