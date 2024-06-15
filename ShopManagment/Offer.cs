using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagment
{
    public partial class frmOffer : Form
    {
        public float newDiscount;
        public float newDiscountPrice { get; set; }
        public frmOffer()
        {
            InitializeComponent();
            
        }

        private void frmOffer_Load(object sender, EventArgs e)
        {
            
            //frmAdminOrder objAOrder = new frmAdminOrder();
            //string name = objAOrder.grdViewAllOrder.CurrentRow.Cells["ProductName"].Value.ToString();
            lblProductName.Text=frmAdminOrder.name;
            lblOriPrice.Text=frmAdminOrder.oPrice;  
        }

        private void cmbbxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnNewPrice_Click(object sender, EventArgs e)
        {
            //txtNewPrice.Text = (Convert.ToInt32(lblOriPrice.Text)-(Convert.ToInt32(lblOriPrice.Text) * Convert.ToInt32(txtDiscount.Text)/100)).ToString();
            //newPrice = Convert.ToInt32(txtNewPrice.Text.ToString());
        }

        private void btnUpdatedPrice_Click(object sender, EventArgs e)
        {
            if (txtNewPrice.Text == "")
            {
                MessageBox.Show("Please Calculate Price After Discount by Pressing below button");
            }
            else
            {
                newDiscount = float.Parse(txtDiscount.Text.ToString());
                clsProduct objprod = new clsProduct(newDiscount, frmAdminOrder.cartId);
                objprod.Discount();
                MessageBox.Show("Discount to " + lblProductName.Text + " is " + newDiscount + " % Updated");

                // newDiscountPrice = float.Parse(txtNewPrice.Text);
                this.Close();
                // frmAdminOrder.ActiveForm.Refresh();
                frmAdminOrder objAOrder = new frmAdminOrder();
                objAOrder.Show();
                objAOrder.MdiParent = this.MdiParent;
                objAOrder.WindowState = FormWindowState.Maximized;
            }
        }

        private void txtNewPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            txtNewPrice.Text = (Convert.ToInt32(lblOriPrice.Text) - (Convert.ToInt32(lblOriPrice.Text) * Convert.ToInt32(txtDiscount.Text) / 100)).ToString();
        }
    }
}
