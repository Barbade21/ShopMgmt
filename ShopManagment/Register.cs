using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ShopManagment
{
    public partial class frmRegister : Form
    {
        public string Gender;
        public string LUName;
        public string LUEmail;

        public frmRegister()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // int UserId = Convert.ToInt32(dt.Rows[0].Field<Int32>("UserId").ToString());

            //string Pass = dt.Rows[0].Field<string>("UserPassword").ToString();

           

            if (cmbbxRType.Text!="")
            {
                if(txtRName.Text!="" && txtRName.Text.Length>=4 && Char.IsDigit(txtRName.Text[0]) ==false)
                {
                    if (txtREmail.Text != "" && txtREmail.Text.Contains("@")==true)
                    {
                        clsUser log = new clsUser(txtRName.Text, txtREmail.Text);
                        DataTable dt = new DataTable();
                        dt = log.ValidUser();

                        // string LType = dt.Rows[0].Field<string>("UserType").ToString();
                        if (dt.Rows.Count!=0)
                        {
                            LUName = dt.Rows[0].Field<string>("UserName").ToString();
                            LUEmail = dt.Rows[0].Field<string>("UserEmail").ToString();                
                        }
                        else
                        {
                            LUName = "null"; LUEmail = "null";
                        }

                        if (rdoMale.Checked==true || rdoFemale.Checked == true)
                        {
                            if(cmbbxRState.Text!="")
                            {
                                if(txtRPass.Text != "" && txtRPass.Text.Length >= 8 && txtRPass.Text.Any(Char.IsLower)
                                    && txtRPass.Text.Any(Char.IsUpper) && txtRPass.Text.Any(Char.IsNumber) && txtRPass.Text.Any(char.IsPunctuation))
                                {
                                    if (/*cmbbxRType.Text != LType ||*/ txtRName.Text != LUName)
                                    {
                                        if (txtREmail.Text != LUEmail)
                                        {
                                            clsUser reg = new clsUser(cmbbxRType.Text, txtRName.Text, txtREmail.Text, Gender, cmbbxRState.Text, txtRPass.Text);
                                            reg.RegisterUser();
                                            MessageBox.Show("Registration completed Successfully...!");
                                            //MessageBox.Show("User Already Exists");
                                        }
                                        else { MessageBox.Show("Email Already Exists"); }
                                    }
                                    else { MessageBox.Show("Username Already Exists"); }
                                }
                                else { MessageBox.Show("Please Enter Valid Password..!"); }
                            }
                            else { MessageBox.Show("Please Insert Valid User State..!"); }
                        }
                        else { MessageBox.Show("Please Insert Valid User Gender..!"); }
                    }
                    else { MessageBox.Show("Please Insert Valid Email..!"); }
                }
                else { MessageBox.Show("Please Insert Valid User Name..!"); }
            }
            else { MessageBox.Show("Please Select Valid User Type..!"); }

            
        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender=rdoMale.Text;
        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender =rdoFemale.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbbxRType.Text = null;
            txtRName.Clear();
            txtREmail.Clear();
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            cmbbxRState.Text=null;
            txtRPass.Clear();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            
        }



        private void txtRName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
