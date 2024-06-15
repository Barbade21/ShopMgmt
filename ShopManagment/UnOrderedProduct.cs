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
    public partial class frmUnOrderedProduct : Form
    {
        public frmUnOrderedProduct()
        {
            InitializeComponent();
        }

        private void frmUnOrderedProduct_Load(object sender, EventArgs e)
        {
            clsProduct objAllProd = new clsProduct();
            DataTable dt = new DataTable();
            dt = objAllProd.ShowUnOrderedProduct();

            grdViewUnOrderedProd.DataSource = dt;
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            //string searchValue = txtSearchProduct.Text;
            (grdViewUnOrderedProd.DataSource as DataTable).DefaultView.RowFilter = string.Format("ProductName LIKE '%{0}%'", txtSearchProduct.Text);

        }

        private void txtSearchType_TextChanged(object sender, EventArgs e)
        {
            //string searchValue = txtSearchType.Text;
            (grdViewUnOrderedProd.DataSource as DataTable).DefaultView.RowFilter = string.Format("TypeName LIKE '%{0}%'", txtSearchType.Text);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearchProduct.Clear();
            txtSearchType.Clear();
        }
    }
}
