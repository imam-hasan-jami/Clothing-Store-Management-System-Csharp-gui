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
    public partial class FormADUUser : Form
    {
        public FormADUUser()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddUser fau = new FormAddUser();
            fau.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin fa = new FormAdmin();
            fa.Show();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDeleteUser fdu = new FormDeleteUser();
            fdu.Show();
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormViewUser fvu = new FormViewUser();
            fvu.Show();
        }
    }
}
