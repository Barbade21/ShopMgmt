using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagment
{
    public class clsUser
    {
        SqlConnection con = new SqlConnection("Data Source=SWAPNIL\\SQLEXPRESS;Initial Catalog=ClothShop;Integrated Security=True;Encrypt=False");
       // public static int id;
        public string clsName {  get; set; }
        public string clsType { get; set; }
        public  string clsEmail { get; set; }
        public  string clsGender { get; set; }
        public  string clsState { get; set; }
        public  string clsPassword { get; set; }
        public  int clsUserId { get; set; }
        public clsUser(string type, string name,string email,string gender,string state,string pwd) 
        {
            clsName = name;
            clsType = type;
            clsEmail = email;
            clsGender = gender;
            clsState = state;
            clsPassword = pwd;
        }

        public clsUser(string type, string name, string pwd)
        {
            clsType = type;
            clsName = name;
            clsEmail = name;
            clsPassword= pwd;

        }
        public clsUser(string name, string email)
        {
            clsName= name;
            clsEmail = email;

        }
        public clsUser() { }

        public void RegisterUser()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPUser", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "RegisterUser");
            cmd.Parameters.AddWithValue("@UserType",clsType);
            cmd.Parameters.AddWithValue("@UserName",clsName);
            cmd.Parameters.AddWithValue("@UserEmail",clsEmail);
            cmd.Parameters.AddWithValue("@UserGender",clsGender);
            cmd.Parameters.AddWithValue ("@UserState",clsState);
            cmd.Parameters.AddWithValue("@UserPassword",clsPassword);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public DataTable LoginUser()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "LoginUser");
            cmd.Parameters.AddWithValue("@UserType", clsType);
            cmd.Parameters.AddWithValue("@UserName", clsName);
            cmd.Parameters.AddWithValue("@UserEmail", clsEmail);
            cmd.Parameters.AddWithValue("@UserPassword", clsPassword);
          //  SqlDataReader dr = cmd.ExecuteReader();
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
          //  return dr;
            con.Close();
        }

        public DataTable ShowUser()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "ShowUser");
            cmd.Parameters.AddWithValue("@UserType", clsType);
            cmd.Parameters.AddWithValue("@UserName", clsName);
            cmd.Parameters.AddWithValue("@UserEmail", clsName);
            cmd.Parameters.AddWithValue("@UserPassword", clsPassword);
            // SqlDataReader dr = cmd.ExecuteReader();
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            //  return dr;
            con.Close();

        }
        public DataTable ShowUnorderedUser()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "ShowUnorderedUser");
            //cmd.ExecuteNonQuery();
            //cmd.Parameters.AddWithValue("@SizeId", TypeId);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            return dt;
            con.Close();

        }

        public DataTable ValidUser()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "ValidUser");
           // cmd.Parameters.AddWithValue("@UserType", clsType);
            cmd.Parameters.AddWithValue("@UserName", clsName);
            cmd.Parameters.AddWithValue("@UserEmail", clsEmail);
          //  cmd.Parameters.AddWithValue("@UserPassword", clsPassword);
            // SqlDataReader dr = cmd.ExecuteReader();
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            //  return dr;
            con.Close();

        }


    }
}
