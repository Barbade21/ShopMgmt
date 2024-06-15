using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;


namespace ShopManagment
{
    internal class clsProduct
    {
        SqlConnection con = new SqlConnection("Data Source=SWAPNIL\\SQLEXPRESS;Initial Catalog=ClothShop;Integrated Security=True;Encrypt=False");

        public string PType { get; set; }
        public int TypeId { get; set; }
        public string PName { get; set; }
        public string PColor { get; set; }
        public string PSize { get; set; }
        public int PQty { get; set; }
        public float PMRP { get; set; }
        public float PRealPrice { get; set; }

        public int ProdId { get; set; }
        public int Grd { get; set; }
        public int UserId { get; set; }
        public float nDiscount { get; set; }
        public string Status { get; set; }

        public clsProduct(int pid,int typeId, string pname, string Color, string Size, int Qty, float MRP, float RealPrice)
        {
            ProdId = pid;
            TypeId = typeId;
            PName = pname;
            PColor = Color;
            PSize = Size;
            PQty = Qty;
            PMRP = MRP;
            PRealPrice = RealPrice;

        }

        public clsProduct(string Type)
        {
            PType= Type;
        }
        public clsProduct(int TId, string Name) 
        {        
            TypeId= TId;
            PName = Name;
        }
        public clsProduct() { }
        public clsProduct(int TId)
        {
            TypeId=TId;
        }
        public clsProduct(string type, string pname)
        {
            PType= type;
            PName = pname;
        }
        public clsProduct(int Pid, int Uid, string status)
        {
            TypeId = Pid;
            UserId = Uid;
            Status = status;
        }

        public clsProduct(float price,int Uid)
        {
            nDiscount = price;
            TypeId= Uid;
        }
        public void AddSize()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPProduct", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "AddSize");
            cmd.Parameters.AddWithValue("@ProductId",ProdId);
            cmd.Parameters.AddWithValue("@TypeId", TypeId);
            cmd.Parameters.AddWithValue("@ProductName", PName);
            cmd.Parameters.AddWithValue("@ProductColor", PColor);
            cmd.Parameters.AddWithValue("@ProductSize", PSize);
            cmd.Parameters.AddWithValue("@ProductQty", PQty);
            cmd.Parameters.AddWithValue("@ProductMRP", PMRP);
            cmd.Parameters.AddWithValue("@ProductRealPrice", PRealPrice);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void AddType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPProduct", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag","AddType");
            cmd.Parameters.AddWithValue("@ProductType",PType);
            cmd.ExecuteNonQuery();
            con.Close();    
        }
        public void AddProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPProduct", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag","AddProduct");
            cmd.Parameters.AddWithValue("@TypeId", TypeId);
            cmd.Parameters.AddWithValue("@ProductName", PName );
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable ShowType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPProduct", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag","ShowType");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            
            con.Close();
            return dt;
        }

        public DataTable ShowProduct() 
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPProduct", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag","ShowProduct");
            cmd.Parameters.AddWithValue("@TypeId", TypeId);
            SqlDataAdapter adpt=new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
            

        }

        public DataTable ShowSize()
        {
            SqlCommand cmd = new SqlCommand("SPProduct", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "ShowSize");
            cmd.Parameters.AddWithValue("@TypeId", TypeId);
            cmd.Parameters.AddWithValue("@ProductName", PName);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            con.Close();
            return dt;
        }
        public DataTable ShowAllProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPProduct", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "ShowAllProduct");
            //cmd.ExecuteNonQuery();
            //cmd.Parameters.AddWithValue("@SizeId", TypeId);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            return dt;
            con.Close();

        }

       
        public DataTable ShowAllOrder()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPProduct", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "ShowAllOrder");
            //  cmd.ExecuteNonQuery();
            //cmd.Parameters.AddWithValue("@SizeId", TypeId);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            return dt;
            con.Close();
        }

        public void Discount()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPProduct", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "Discount");
            cmd.Parameters.AddWithValue("@Discount", nDiscount);
            cmd.Parameters.AddWithValue("@cartId", TypeId);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable ShowUnOrderedProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPProduct", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "ShowUnOrderedProduct");
            //  cmd.ExecuteNonQuery();
            //cmd.Parameters.AddWithValue("@SizeId", TypeId);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            return dt;
            con.Close();
        }

        public void AddtoCart()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPProduct", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag","AddtoCart");
            cmd.Parameters.AddWithValue("@UserId", UserId);
            cmd.Parameters.AddWithValue("@SizeId", TypeId);
            cmd.Parameters.AddWithValue("@Date", DateTime.Now);
            cmd.Parameters.AddWithValue("@OrderStatus", Status);
            //cmd.Parameters.AddWithValue("@ProductName", PName);
            //cmd.Parameters.AddWithValue("@ProductColor", PColor);
            //cmd.Parameters.AddWithValue("@ProductSize", PSize);
            //cmd.Parameters.AddWithValue("@ProductQty", PQty);
            //cmd.Parameters.AddWithValue("@ProductMRP", PMRP);
            //cmd.Parameters.AddWithValue("@ProductRealPrice", PRealPrice);
            cmd.ExecuteNonQuery();        
            con.Close();
        }

       public void updatetoCart()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPProduct", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "updatetoCart");
           
            cmd.Parameters.AddWithValue("@cartId", TypeId);
            cmd.ExecuteNonQuery();
            con.Close();




            // cmd.Parameters.AddWithValue("@UserId", UserId);
            //cmd.Parameters.AddWithValue("@Date", DateTime.Now);
            //    cmd.Parameters.AddWithValue("@OrderStatus", PName);
            //cmd.Parameters.AddWithValue("@ProductName", PName);
            //cmd.Parameters.AddWithValue("@ProductColor", PColor);
            //cmd.Parameters.AddWithValue("@ProductSize", PSize);
            //cmd.Parameters.AddWithValue("@ProductQty", PQty);
            //cmd.Parameters.AddWithValue("@ProductMRP", PMRP);
            //cmd.Parameters.AddWithValue("@ProductRealPrice", PRealPrice);

        }

        public DataTable ShowCart()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPProduct", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "ShowCart");
            cmd.Parameters.AddWithValue("@SizeId", TypeId);
            cmd.Parameters.AddWithValue("@UserId", UserId);
            
            //cmd.Parameters.AddWithValue("@UserId", UserId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            return dt;
            con.Close();
        }

    }
}
