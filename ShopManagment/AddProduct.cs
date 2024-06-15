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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShopManagment
{
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            clsProduct objProd = new clsProduct();
            DataTable dt = new DataTable();
            dt = objProd.ShowType();
            cmbbxType.DisplayMember = "TypeName";
            cmbbxType.ValueMember = "TypeId";
            cmbbxType.DataSource = dt;
            
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if(cmbbxType.Text!="" && txtProductName.Text!="")
            {
                int typeid = Convert.ToInt32(cmbbxType.SelectedValue.ToString());
                clsProduct objProd = new clsProduct(typeid, txtProductName.Text);
                objProd.AddProduct();
                this.Close();
                MessageBox.Show("Product Added Successfully...!!");
            }
            else {
                erpProdName.SetError(txtProductName,"Enter Product Name");
                MessageBox.Show("Please Enter Product Name..!"); }
           
        }

        private void cmbbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
