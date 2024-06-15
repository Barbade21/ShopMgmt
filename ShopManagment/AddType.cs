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
    public partial class frmAddType : Form
    {
        public frmAddType()
        {
            InitializeComponent();
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            if (txtAddType.Text!="")
            {
                clsProduct PType = new clsProduct(txtAddType.Text);
                PType.AddType();
                this.Close();
                MessageBox.Show("Type inserted Successfully...!!");

            }
            else { MessageBox.Show("Please insert Valid Datea...!"); }
        }
    }
}
