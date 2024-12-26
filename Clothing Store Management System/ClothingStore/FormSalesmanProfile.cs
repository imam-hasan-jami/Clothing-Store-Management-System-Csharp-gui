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
    public partial class FormSalesmanProfile : Form
    {
        public FormSalesmanProfile()
        {
            InitializeComponent();
        }

        private void FormCustomerProfile_Load(object sender, EventArgs e)
        {
            this.lblUsername.Text = Global.username;
            this.lblPassword.Text = Global.password;
            this.lblRole.Text = Global.role;
        }
    }
}
