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
    public partial class frmUnOrderedUser : Form
    {
        public frmUnOrderedUser()
        {
            InitializeComponent();
        }

        private void frmUnOrderedUser_Load(object sender, EventArgs e)
        {
            clsUser objUnOrderedUser = new clsUser();
            DataTable dt = new DataTable();
            dt = objUnOrderedUser.ShowUnorderedUser();

            grdViewUnorderedUser.DataSource = dt;
            this.grdViewUnorderedUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
           
            (grdViewUnorderedUser.DataSource as DataTable).DefaultView.RowFilter = string.Format("UserEmail LIKE '%{0}%'", txtSearchEmail.Text);

        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            (grdViewUnorderedUser.DataSource as DataTable).DefaultView.RowFilter = string.Format("UserName LIKE '%{0}%'", txtSearchUser.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearchEmail.Clear();
            txtSearchUser.Clear();  
        }
    }
}
