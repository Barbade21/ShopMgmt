using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagment
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            IsMdiContainer=true;
            WindowState = FormWindowState.Maximized;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            login.MdiParent = this;
         //   login.WindowState = FormWindowState.Maximized;
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegister user = new frmRegister();
            user.Show();
            user.MdiParent = this;
          //  user.WindowState = FormWindowState.Maximized;
        }

        private void productsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddSize products = new frmAddSize();
            products.Show();
            products.MdiParent = this;
          //  products.WindowState = FormWindowState.Maximized;
        }
        private void addTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddType addType = new frmAddType();
            addType.Show();
            addType.MdiParent = this;
           // addType.WindowState = FormWindowState.Maximized;
        }

        private void addPoductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddProduct addProd = new frmAddProduct();
            addProd.Show();
            addProd.MdiParent = this;
          //  addProd.WindowState = FormWindowState.Maximized;
        }
    }
}
