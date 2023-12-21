using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp2
{
    internal class Thuvien
    {
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dtconnect"].ConnectionString);
        public static DataTable Hienthi(string sql)
        {
            //b1: Kết nối đến database
            if(con.State != ConnectionState.Open)
            {
                con.Open();
            }
            //b2 + b 3 tao doi tuong lay du lieu tu bang
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            //b4: do dua lieu tu dataapdapter vao bang
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            con.Close();
            return dt; // tra ve gia tri bang

        }
        public static void thucthi(string sql)
        {
            // B1 ket noi den db
            if(con.State != ConnectionState.Open)
            {
                con.Open();
            }
            //b2: tao doi tuong command de thuc hien them sua xoa dl vao bang
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public static bool checktrungma(string makt , string tenbang, string tencot)
        {
            //b1 :ket noi den database
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //b2: tao doi tuong command 
            string sql = "Select count(*) From " +tenbang+ " where " +tencot+ "= " +makt;
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = (int)cmd.ExecuteScalar();
            cmd.Dispose();
            con.Close();
            return kq > 0;
        }
    }
}
