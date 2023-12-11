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
using System.Data.Sql;
namespace WindowsFormsApp2
{
    public partial class frm_ketnoi : Form
    {
        SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=viduSQL;Integrated Security=True");
  //      con.ConnectionString = "Data Source=MSI;Initial Catalog=viduSQL;Integrated Security=True";
        public frm_ketnoi()
        {

            InitializeComponent();
        }
        private void Load_dgv_loaisach()
        {
            //b1: ket noi den database

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //b2: tao doi tuong command de truy van
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * From Loai_sach";
            //b3: tao doi tuong dataAdapter de lay DL tu cmd
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            // b4: do du lieu tu da vao datatable
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose(); // giai phong bo nho
            con.Close();
            //b5: hien thi tb len datagridview
            dgv_loaisach.DataSource = tb;
            dgv_loaisach.Refresh();
        }
        private void frm_ketnoi_Load(object sender, EventArgs e)
        {
            Load_dgv_loaisach();
        }
    }
}
