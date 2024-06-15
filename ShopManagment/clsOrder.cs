using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagment
{
    internal class clsOrder
    {
        SqlConnection con = new SqlConnection("Data Source=SWAPNIL\\SQLEXPRESS;Initial Catalog=ClothShop;Integrated Security=True;Encrypt=False");

        public int TId { get; set; }
        public string Grd {  get; set; }
        public int PId {  set; get; }
        public clsOrder(int pid)
        {
           // TId = tid;
            PId = pid;
        }
        public clsOrder(int typid,int prodid,string grd) 
        {
            TId = typid;
            PId = prodid;
            Grd = grd;

        }
        public clsOrder() { }
       
    }
}
