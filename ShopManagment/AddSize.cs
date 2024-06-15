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
    public partial class frmAddSize : Form
    {
        public static Double discount;
        public static int PQty;
        public static int PTypeId;
        public static int Productid;
        public static string PName;
        public static string PColor;
        public static string PSize;
        public static float PMRP;
        public static float PRealPrice;
        public frmAddSize()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            clsProduct objProd = new clsProduct();
            DataTable dt = new DataTable();
            dt = objProd.ShowType();
            cmbbxPType.DisplayMember = "TypeName";
            cmbbxPType.ValueMember = "TypeId";
            cmbbxPType.DataSource = dt;
           
        }
 
        private void btnPClear_Click(object sender, EventArgs e)
        {
            cmbbxPType.SelectedItem = null;
            cmbbxPName.SelectedItem = null;
            txtPColor.Clear();
            txtPSize.Text = "";
            txtPQty.Clear();
            txtPMRP.Text="";
          //  txtPDiscount.Clear();
            txtPRealPrice.Clear();
        }

        private void btnPRegister_Click(object sender, EventArgs e)
        {
          //  int typeid = Convert.ToInt32(cmbbxPType.SelectedValue.ToString());
            
            if(cmbbxPType.Text!="")
            {
                PTypeId = Convert.ToInt32(cmbbxPType.SelectedValue.ToString());
                if (cmbbxPName.Text!="")
                {
                    Productid = Convert.ToInt32(cmbbxPName.SelectedValue.ToString());
                    PName = cmbbxPName.Text;
                    if (txtPColor.Text!="")
                    {
                        PColor = txtPColor.Text;
                        if (txtPSize.Text!="")
                        {
                            PSize = txtPSize.Text;
                            if (txtPQty.Text!="")
                            {
                                PQty = Convert.ToInt32(txtPQty.Text);
                                if (txtPMRP.Text!="")
                                {
                                    PMRP = Convert.ToSingle(txtPMRP.Text);                                    
                                    if(txtPRealPrice.Text!="")
                                    {
                                        PRealPrice = Convert.ToSingle(txtPRealPrice.Text);

                                        clsProduct prd = new clsProduct(Productid, PTypeId, PName, PColor, PSize, PQty, PMRP, PRealPrice);
                                        prd.AddSize();
                                        this.Close();
                                        MessageBox.Show("Product inserted successfully...!!");
                                    }
                                    else { MessageBox.Show("Please Insert Real Price of Product"); }
                                }
                                else { MessageBox.Show("Please Insert MRP of Product"); }
                            }
                            else { MessageBox.Show("Please insert Product Quantity"); }
                        }
                        else { MessageBox.Show("Please Insert Product Size"); }
                    }
                    else { MessageBox.Show("Please Insert Product Colour"); }
                }
                else { MessageBox.Show("Please Select Product Name..!"); }

            }
            else{ MessageBox.Show("Please Select Product Type..!"); }
            

        }

        private void cmbbxPType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pType = Convert.ToInt32(cmbbxPType.SelectedValue);
            clsProduct objProd1 = new clsProduct(pType);
            DataTable dt1 = new DataTable();
            dt1 = objProd1.ShowProduct();
            cmbbxPName.DisplayMember = "ProdName";
            cmbbxPName.ValueMember = "ProdId";
            cmbbxPName.DataSource = dt1;
            //SqlDataReader dr2 = clsprod2.ShowProduct();
            //string prodName = "";
            //while (dr2.Read())
            //{
            //    prodName = dr2["ProdName"].ToString();
            //    cmbbxPName.Items.Add(prodName);
            //}
            //dr2.Close();
        }

        private void txtPDiscount_TextChanged(object sender, EventArgs e)
        {
           // float MRP = Convert.ToSingle(txtPMRP.Text);
           // float dis = Convert.ToSingle(txtPDiscount.Text);
          //  float DisPrice = MRP - (MRP * dis / 100);
           // txtPRealPrice.Text = DisPrice.ToString();
        }
    }
}
