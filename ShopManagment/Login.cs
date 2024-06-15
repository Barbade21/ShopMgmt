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
    public partial class frmLogin : Form
    {
        public static int UserId;
        public string LType;
        public static string LUName;
        public static string LUEmail;
        public string pass;
        public static string Id;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
             
            clsUser log = new clsUser(cmbbxLType.Text, txtLUName.Text, txtLUPass.Text);
            DataTable dt = new DataTable();
            dt=log.LoginUser();
           
                UserId = Convert.ToInt32(dt.Rows[0].Field<Int32>("UserId").ToString());
                string LType = dt.Rows[0].Field<string>("UserType").ToString();
                LUName = dt.Rows[0].Field<string>("UserName").ToString();
                LUEmail = dt.Rows[0].Field<string>("UserEmail").ToString();
                string Pass = dt.Rows[0].Field<string>("UserPassword").ToString();
            
            
                
            if (cmbbxLType.Text == LType)
                {
                    if (txtLUName.Text == LUName || txtLUName.Text == LUEmail)
                    {
                        if (txtLUPass.Text == Pass)
                        {
                        //MessageBox.Show("Login Successfully...!");
                             if (cmbbxLType.Text == "Customer")
                             {
                                  
                                  frmOrder objOrder = new frmOrder();
                                  objOrder.Show();
                            this.Close();
                            objOrder.MdiParent =this.MdiParent;
                                  //this.Close();
                             }
                              else
                              {
                                  
                                  frmAdmin objAdmin = new frmAdmin();
                                  objAdmin.Show();
                            this.Close();
                            objAdmin.MdiParent = this.MdiParent;
                                  
                        }
                        }
                        else
                        {
                            MessageBox.Show("Please Insert correct Password");
                        }
                    }
                    else

                    {
                        MessageBox.Show("Please Insert correct Username");
                    }

                }
            else
            {
                MessageBox.Show("Please insert correct Login Details...!");
            }




            //SqlDataReader sdr= log.LoginUser();
            //while (sdr.Read())
            //{
            //    if (cmbbxLType.Text == sdr["UserType"].ToString())
            //    {
            //        if (txtLUName.Text == sdr["UserName"].ToString() || txtLUName.Text == sdr["UserEmail"].ToString())
            //        {
            //                 if (txtLUPass.Text == sdr["UserPassword"].ToString()) 
            //                 {
            //                       MessageBox.Show("Login Successfully...!");

            //                           if(cmbbxLType.Text=="Admin")
            //                           {
            //                                frmProductList prodList = new frmProductList();
            //                                prodList.Show();
            //                           }
            //                 }
            //                  else
            //                  {
            //                     MessageBox.Show("Please Insert correct Password");
            //                  }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Please Insert correct Username");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please Select User Type");
            //    }
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbbxLType.Text = null;
            txtLUName.Text = null;
            txtLUPass.Clear();
        }


    }
}
