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
    public partial class FormADUProduct : Form
    {
        public FormADUProduct()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin fa = new FormAdmin();
            fa.Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddProduct fap = new FormAddProduct();
            fap.Show();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateProduct fup = new FormUpdateProduct();
            fup.Show();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDeleteProduct fdp = new FormDeleteProduct();
            fdp.Show();
        }
    }
}
