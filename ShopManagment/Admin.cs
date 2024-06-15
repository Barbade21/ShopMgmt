using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagment
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            IsMdiContainer = true;
            WindowState = FormWindowState.Maximized;
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            //AdminAllProduct objAllProd = new AdminAllProduct();
            //objAllProd.Show();
            
            //objAllProd.MdiParent = this;
            
        }

        private void allProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminAllProduct objAllProd = new AdminAllProduct();
            objAllProd.Show();
            
            objAllProd.MdiParent=this;
            objAllProd.WindowState = FormWindowState.Maximized;
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmAdminOrder objOrder = new frmAdminOrder();
            objOrder.Show();
            objOrder.MdiParent= this;
            objOrder.WindowState = FormWindowState.Maximized;
        }

        private void unOrderedProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnOrderedProduct objUP = new frmUnOrderedProduct();
            objUP.Show();
            objUP.MdiParent= this;
            objUP.WindowState = FormWindowState.Maximized;
        }

        private void unOrderedUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnOrderedUser objUU = new frmUnOrderedUser();
            objUU.Show();
            objUU.MdiParent= this;
            objUU.WindowState = FormWindowState.Maximized;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

     
    }
}
