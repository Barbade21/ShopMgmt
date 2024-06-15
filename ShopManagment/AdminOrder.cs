using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShopManagment
{
    public partial class frmAdminOrder : Form
    {
        public static string name;
        public static string oPrice;
        public static int cartId;

        public frmAdminOrder()
        {
            InitializeComponent();
           
        }

        private void btnSearchByProduct_Click(object sender, EventArgs e)
        {
            txtSearchProduct.Clear();
            txtSearchType.Clear();  
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchProduct.Text;
            (grdViewAllOrder.DataSource as DataTable).DefaultView.RowFilter = string.Format("ProductName LIKE '%{0}%'", txtSearchProduct.Text);

        }

        private void AdminOrder_Load(object sender, EventArgs e)
        {
            clsProduct objAllProd = new clsProduct();
            DataTable dt = new DataTable();
            dt = objAllProd.ShowAllOrder();

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            DataGridViewCheckBoxColumn chkCol = new DataGridViewCheckBoxColumn();
            chkCol.Name = "Delete";
            chkCol.HeaderText = "Delete";
            grdViewAllOrder.Columns.Add(chkCol);


            //  grdViewAllOrder.Columns["DiscountPrice"].Visible = false;
            // grdViewAllOrder.Columns.Add("DiscountPrice", "DiscountPrice");

            buttonColumn.HeaderText = "Discount";
            buttonColumn.Text = "Offer";            
            buttonColumn.UseColumnTextForButtonValue = true; // Set to true to use Text property for the button
            grdViewAllOrder.Columns.Add(buttonColumn);

            //chkCol.HeaderText = "";
            

            grdViewAllOrder.DataSource = dt;
        //    grdViewAllOrder.Columns["SizeId"].Visible = false;
        //    grdViewAllOrder.Columns["ProductId"].Visible = false;
            grdViewAllOrder.Columns["CartId"].Visible = false;
        //    grdViewAllOrder.Columns["Discount In %"].Visible = false;
            grdViewAllOrder.Columns["IsDelete"].Visible = false;
            grdViewAllOrder.Columns["OrderStatus"].Visible = false;
            this.grdViewAllOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            

            

        }

        private void txtSearchType_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchType.Text;
            (grdViewAllOrder.DataSource as DataTable).DefaultView.RowFilter = string.Format("TypeName LIKE '%{0}%'", txtSearchType.Text);

        }

        private void grdViewAllOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {


                name = grdViewAllOrder.CurrentRow.Cells["ProductName"].Value.ToString();
                oPrice = grdViewAllOrder.CurrentRow.Cells["ProductMRP"].Value.ToString();
                cartId = Convert.ToInt32(grdViewAllOrder.CurrentRow.Cells["CartId"].Value.ToString());
                frmOffer objOffer = new frmOffer();
                objOffer.Show();
                objOffer.MdiParent =this.MdiParent;

                grdViewAllOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grdViewAllOrder.MultiSelect = false;
            //    int newPrice = objOffer.newPrice;

                this.Close();

          //      grdViewAllOrder.CurrentRow.Cells["DiscountPrice"].Value.ToString() = objOffer.newPrice;
            }
            // var senderGrid = (DataGridView)sender;
            //if (senderGrid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            //{
            //    for (int i = 0; i < grdViewAllOrder.Rows.Count; i++)
            //    {
            //        if (Convert.ToBoolean(grdViewAllOrder.Rows[i].Cells[0].Value) == true)
            //        {
            //            grdViewAllOrder.Rows.RemoveAt(i);
            //        }
            //    }
            //}

        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            grdViewAllOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdViewAllOrder.MultiSelect = false;


            for (int i = grdViewAllOrder.Rows.Count - 1; i >= 0; i--)
            {
                if ((bool)grdViewAllOrder.Rows[i].Cells[0].FormattedValue)
                {
                    int CartId = Convert.ToInt32(grdViewAllOrder.Rows[i].Cells[2].Value);
                    grdViewAllOrder.Rows.RemoveAt(i);

                    clsProduct objProd = new clsProduct(CartId);
                    objProd.updatetoCart();
                    
                }
            }


            //      string Status = "Deleted";
            //int sizeId = grdViewAllOrder.Rows[i].Cells[2].ColumnIndex;
            //int userId = grdViewAllOrder.Rows[i].Cells[1].ColumnIndex;

            //  int CartId = Convert.ToInt32(grdViewAllOrder.CurrentRow.Cells["CartId"].Value.ToString());


            ////     Delete.Value= !(Delete.Value == null ? false : (bool)Delete.Value);
            //foreach (DataGridViewRow item in grdViewAllOrder.Rows)
            //{
            //    DataGridViewCheckBoxCell Delete = (DataGridViewCheckBoxCell)item.Cells[0];
            //    if (Convert.ToBoolean(Delete.Value) == true)
            //        { 
            //            grdViewAllOrder.Rows.Remove(item);                   
            //    }


            //  //  MessageBox.Show("Selected " + item.Cells[0].RowIndex.ToString() + "Rows Deleted...!");


            //}
            //grdViewAllOrder.Refresh();



            //////////////DataGridViewRow Delete = new DataGridViewRow();
            //////////////for (int i = 0; i < grdViewAllOrder.Rows.Count; i++)
            //////////////{
            //////////////    Delete = grdViewAllOrder.Rows[i];
            //////////////    if (Convert.ToBoolean(Delete.Cells[0].Value) == true)
            //////////////    {

            //////////////                grdViewAllOrder.Rows.RemoveAt(i);

            //////////////    }

            //    grdViewAllOrder.MultiSelect = true;


            //for (int i = 0; i < grdViewAllOrder.SelectedRows.Count; i++)
            //{
            //    if (grdViewAllOrder.SelectedRows[i].Selected)                  
            //    {
            //      //  grdViewAllOrder.Rows.RemoveAt(i);
            //        foreach (DataGridViewRow row in grdViewAllOrder.SelectedRows)
            //        {
            //            grdViewAllOrder.Rows.Remove(row);
            //        }
            //        // i--;
            //    }
            // grdViewAllOrder.Refresh();


        }
    }
}
