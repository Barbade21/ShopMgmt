using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShopManagment
{
    public partial class AdminAllProduct : Form
    {
        public AdminAllProduct()
        {
            InitializeComponent();
           
        }

        private void frmAllProducts_Load(object sender, EventArgs e)
        {
            clsProduct objAllProd = new clsProduct();
            DataTable dt = new DataTable();
            dt= objAllProd.ShowAllProduct();
            
            grdViewAllProd.DataSource = dt;
            this.grdViewAllProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            // grdViewAllProd.Columns.Add

            //    grdViewAllProd.Columns["ProductQty"].Visible = false;
            //    grdViewAllProd.Columns["ProductId"].Visible = false;
        }

        private void btnSearchByProduct_Click(object sender, EventArgs e)
        {
            txtSearchProduct.Clear();
            txtSearchType.Clear();
        }

        private void btnSearchByType_Click(object sender, EventArgs e)
        {
            
           // (grdViewAllProd.DataSource as DataTable).DefaultView.RowFilter = string.Format("ProductType LIKE '%{0}%'", txtSearchType.Text);

        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchProduct.Text;
            (grdViewAllProd.DataSource as DataTable).DefaultView.RowFilter = string.Format("ProductName LIKE '%{0}%'", txtSearchProduct.Text);

        }

        private void txtSearchType_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchType.Text;
            (grdViewAllProd.DataSource as DataTable).DefaultView.RowFilter = string.Format("TypeName LIKE '%{0}%'", txtSearchType.Text);

        }
    }
}
