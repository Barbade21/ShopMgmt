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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ShopManagment
{
    public partial class frmOrder : Form
    {
        DataTable dtGrd;
       
        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmProductList_Load(object sender, EventArgs e)
        {
           
            // frmLogin objlog = new frmLogin();

            lblName1.Text = frmLogin.LUName;
            lblEmail.Text = frmLogin.LUEmail;
            lblUserId.Text = frmLogin.UserId.ToString();


            clsProduct objProd = new clsProduct();
            DataTable dt=new DataTable();
            dt = objProd.ShowType();
            
            cmbbxPType.DisplayMember = "TypeName";
            cmbbxPType.ValueMember = "TypeId";
            cmbbxPType.DataSource = dt;

            lstView2.Columns.Clear();
            lstView2.Columns.Add("SizeId").Width = 0; 
            lstView2.Columns.Add("UserId").Width=0;
            lstView2.Columns.Add("ProductId");            
            lstView2.Columns.Add("ProductType");
            lstView2.Columns.Add("ProductName");
            lstView2.Columns.Add("ProductColor");
            lstView2.Columns.Add("ProductSize");
            lstView2.Columns.Add("ProductQty");
            lstView2.Columns.Add("ProductMRP");

            

            lstView2.View = View.Details;

            //  grdView2.DataSource=grdPView.DataSource;

        }

        private void cmbbxPType_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsProduct objProd1 = new clsProduct(Convert.ToInt32(cmbbxPType.SelectedValue));
            DataTable dt1 = new DataTable();
            dt1 = objProd1.ShowProduct();
            cmbbxPName.DisplayMember = "ProdName";
            cmbbxPName.ValueMember = "ProdId";
            cmbbxPName.DataSource = dt1;
        }

        private void cmbbxPName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TypeId=Convert.ToInt32(cmbbxPType.SelectedValue.ToString());
            clsProduct objOrder = new clsProduct(TypeId,cmbbxPName.Text);
            DataTable dt2 = new DataTable();
            dt2 = objOrder.ShowSize();
           //string Size = dt2.Rows[0].Field<string>("ProductSize");
             
            // grdPView.DataSource = dt2.Columns.("ProductSize");
            grdPView.DataSource = dt2;

            //  this.grdPView.Columns[].Visible = false;
            grdPView.Columns["SizeId"].Visible = false;
            grdPView.Columns["ProductId"].Visible = false;
            grdPView.Columns["TypeId"].Visible = false;
            grdPView.Columns["ProductName"].Visible = false;
           // grdPView.Columns["ProductColor"].Visible = false;
            grdPView.Columns["ProductQty"].Visible = false;
            grdPView.Columns["ProductMRP"].Visible = false;
            grdPView.Columns["ProductRealPrice"].Visible = false;

            
            grdPView.Show();
           
            txtPrice.Text = null;           
        }

        private void grdPView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPrice.Text = grdPView.CurrentRow.Cells["ProductRealPrice"].Value.ToString();
            
        }

        private void btnPRegister_Click(object sender, EventArgs e)
        {
            
            frmLogin objLog = new frmLogin();
            objLog.Show();
            this.Close();
            //frmHome objHome = new frmHome();
            objLog.MdiParent = this.MdiParent;

        }

        private void btnPClear_Click(object sender, EventArgs e)
        {
            cmbbxPName.Text = null;
            cmbbxPType.SelectedItem= null;         
            grdPView.DataSource= null;
            txtPrice.Text= null;
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {


            // int SizeId = Convert.ToInt32(grdPView.CurrentRow.Cells["SizeId"].Value.ToString());
            // //DataTable dt = new DataTable();
            // //foreach (DataRow row in dt.Rows)
            // //{
            //     ListViewItem item = new ListViewItem(grdPView.CurrentRow.Cells["SizeId"].ToString());
            //     //for (int i = 1; i < dt.Columns.Count; i++)
            //     //{
            //     item.SubItems.Add(grdPView.CurrentRow.Cells["ProductId"].ToString());
            //     item.SubItems.Add(grdPView.CurrentRow.Cells["ProductType"].ToString());
            //     item.SubItems.Add(grdPView.CurrentRow.Cells["ProductName"].ToString());
            //     item.SubItems.Add(grdPView.CurrentRow.Cells["ProductColor"].ToString());
            //     item.SubItems.Add(grdPView.CurrentRow.Cells["ProductColor"].ToString());
            //     item.SubItems.Add(grdPView.CurrentRow.Cells["ProductQty"].ToString());
            //     item.SubItems.Add(grdPView.CurrentRow.Cells["ProductMRP"].ToString());
            //     item.SubItems.Add(grdPView.CurrentRow.Cells["ProductRealPrice"].ToString());
            //     //     }                                 
            //     lstView2.Items.Add(item);
            //// }
         ////////////   int SizeId = Convert.ToInt32(grdPView.CurrentRow.Cells["SizeId"].Value.ToString());
           // clsProduct objOrder = new clsProduct(SizeId);
         ///////   DataTable dt = new DataTable();
            // dt = objOrder.ShowCart();

            //lstView2.Columns.Clear();
            //foreach (DataColumn column in dt.Columns)
            //{
            //    lstView2.Columns.Add(column.ColumnName);

            //}


            //foreach (DataRow row in grdPView.SelectedRows)
            //{
                ListViewItem item = new ListViewItem(grdPView.CurrentRow.Cells["SizeId"].Value.ToString());
            //for (int i = 0; i <= lstView2.Columns.Count; i++)
            //{
               // item.SubItems.Add(grdPView.CurrentRow.Cells["SizeId"].Value.ToString());
                item.SubItems.Add(lblUserId.Text);
                item.SubItems.Add(grdPView.CurrentRow.Cells["ProductId"].Value.ToString());
                item.SubItems.Add(grdPView.CurrentRow.Cells["TypeId"].Value.ToString());
                item.SubItems.Add(cmbbxPName.Text);
                item.SubItems.Add(grdPView.CurrentRow.Cells["ProductColor"].Value.ToString());
                item.SubItems.Add(grdPView.CurrentRow.Cells["ProductSize"].Value.ToString());
                item.SubItems.Add("1");
                item.SubItems.Add(txtPrice.Text);

            

            //}                                 
            lstView2.Items.Add(item);
            //    }
            

            //   --Show Cart Item Total
            float lblTotal = 0F;

            for (int i = 0; i < lstView2.Items.Count; i++)
            {
                ListViewItem item1 = lstView2.Items[i];

                lblTotal = lblTotal + float.Parse(item1.SubItems[8].Text);
            }

            txtTotal.Text = lblTotal.ToString();

        }

        private void btnRemoveCart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstView2.Items.Count; i++)
            {
                if (lstView2.Items[i].Selected)
                {
                    lstView2.Items[i].Remove();
                    i--;
                }
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
          
        }

        private void btnOrderConfirm_Click(object sender, EventArgs e)
        {
           

                    DataTable dt = new DataTable();
                    foreach (ColumnHeader column in lstView2.Columns)
                    {
                        dt.Columns.Add(column.Text);
                    }
                    int j = 0;
            
            foreach (ListViewItem item in lstView2.Items)
                    {

                        DataRow row = dt.NewRow();

                        for (int i = 0; i < item.SubItems.Count; i++)
                        {
                            if (i < 6)
                                row[i] = item.SubItems[i].Text;
                        }
                        dt.Rows.Add(row);
                     
                string Status = "Confirm";
                        int userId = Convert.ToInt32(lblUserId.Text);
                        int sizeId = Convert.ToInt32(dt.Rows[j].Field<string>("SizeId").ToString());
                        clsProduct objProd = new clsProduct(sizeId, userId,Status);
                        objProd.AddtoCart();
                        j++;

                    }
            
            MessageBox.Show("Data inserted successfully in Cart ..! Total Purchase Amount is " +txtTotal.Text);

            

        }

        //for (int i = 0; i < dt.Rows.Count; i++)
        //{
        //    DataRow dr = dt.Rows[i];
        //    if (dr.RowState != DataRowState.Deleted)
        //    {
        //        ListViewItem listitem = new ListViewItem(dr["SizeId"].ToString());

        //        listitem.SubItems.Add(dr["ProductType"].ToString());
        //        listitem.SubItems.Add(dr["ProductName"].ToString());
        //        listitem.SubItems.Add(dr["ProductColor"].ToString());
        //        listitem.SubItems.Add(dr["ProductQty"].ToString());
        //        listitem.SubItems.Add(dr["ProductMRP"].ToString());
        //        listitem.SubItems.Add(dr["ProductRealPrice"].ToString());

        //        lstView2.Items.Add(listitem);
        //    }
        //}
    }
        
}
