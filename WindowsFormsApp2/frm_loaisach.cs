using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using e_excel = Microsoft.Office.Interop.Excel;
namespace WindowsFormsApp2
{
    public partial class frm_loaisach : Form
    {
        public frm_loaisach()
        {
            InitializeComponent();
        }
        //       SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=viduSQL;Integrated Security=True");
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dtconnect"].ConnectionString);
        private void load_dgv_loaisach()
        {
            if(con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * From Loai_sach";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            con.Close();

            dgv_loaisach.DataSource = dt;
            dgv_loaisach.Refresh();
        }
        private void frm_loaisach_Load(object sender, EventArgs e)
        {
            load_dgv_loaisach();
        }

        private void dgv_loaisach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt_maloai.Text = dgv_loaisach.Rows[i].Cells[0].Value.ToString();
            txt_tenloai.Text = dgv_loaisach.Rows[i].Cells[1].Value.ToString();
            txt_mota.Text = dgv_loaisach.Rows[i].Cells[2].Value.ToString();
            txt_maloai.Enabled = false;
        }
        private bool checktrungma(string maloai)
        {
            if(con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string sql = "Select count(*) From Loai_sach where Maloai= '" + maloai + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int res = (int)cmd.ExecuteScalar();
            cmd.Dispose();
            con.Close();
            return res > 0;
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                // lay du lieu tu textbox
                string maloai = txt_maloai.Text.Trim();
                string tenloai = txt_tenloai.Text.Trim();
                string mota = txt_mota.Text.Trim();
                //kiem tra du lieu rong o khoa chinh(ma loai)
                if (maloai == "")
                {
                    MessageBox.Show("Mã loại không được để trống!");
                    txt_maloai.Focus();
                    return;
                }
                // kiem tra trung khoa chinh
                if(checktrungma(maloai))
                {
                    MessageBox.Show("Mã loại sách đã tồn tại!");
                    txt_maloai.Focus();
                    return;
                }
                // ket noi database
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                //tao doi tuong command de chen vao bang loai sach va thuc thi no
                string sql = "Insert Loai_sach Values (@Maloai, @Tenloai, @mota)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@Maloai", SqlDbType.NVarChar, 50).Value = maloai;
                cmd.Parameters.Add("@Tenloai", SqlDbType.NVarChar, 50).Value = tenloai;
                cmd.Parameters.Add("@mota", SqlDbType.NVarChar, 200).Value = mota;
                
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("Thêm mới thành công");
                load_dgv_loaisach();
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống, vui lòng liên hệ với nhà phát triển!");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //b1 lay du lieu tu cac control dua vao bien
            string maloai = txt_maloai.Text.Trim();
            string tenloai = txt_tenloai.Text.Trim();
            string mota = txt_mota.Text.Trim();
            //b2 truy cap database
            if(con.State != ConnectionState.Open)
            {
                con.Open();
            }
            //b3 tao doi tuong command
            string sql = "Update Loai_sach set Tenloai= '" + tenloai + "', mota= '" + mota + "' where Maloai= '" + maloai + "'";
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Sửa thành công");
            load_dgv_loaisach();
            txt_maloai.Enabled = true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            // b1: lay du lieu tu control dua vao bien
            string maloai = txt_maloai.Text.Trim();

            //b2: truy  cap database
            if(con.State != ConnectionState.Open) { 
                con.Open();
            }
            //b3: tao doi tuong command
            string sql = "Delete From Loai_sach Where Maloai = '" + maloai + "'";
            SqlCommand cmd =new SqlCommand(sql,con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Xóa thành công");
            load_dgv_loaisach();
            txt_maloai.Enabled= true;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            string nofi = "Bạn có chắc chắn muốn thoát không?";
            var res = MessageBox.Show(nofi, "Thoát", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ExportExcel(DataTable tb, string sheetname)
        {
            //Tạo các đối tượng Excel

            e_excel.Application oExcel = new e_excel.Application();
            e_excel.Workbooks oBooks;
            e_excel.Sheets oSheets;
            e_excel.Workbook oBook;
            e_excel.Worksheet oSheet;
            //Tạo mới một Excel WorkBook 
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (e_excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (e_excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetname;
            // Tạo phần đầu nếu muốn

            e_excel.Range head = oSheet.get_Range("A1", "E1");
            head.MergeCells = true;
            head.Value2 = "DANH SÁCH LỚP HỌC";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "16";
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MÃ LỚP";
            cl1.ColumnWidth = 15;
            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "TÊN LỚP";

            cl2.ColumnWidth = 25.0;
            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "MÃ NGÀNH";
            cl3.ColumnWidth = 20.0;
            e_excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "SĨ SỐ";
            cl4.ColumnWidth = 15.0;
            e_excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "TÊN NGÀNH";
            cl5.ColumnWidth = 40.0;
            //Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            //cl6.Value2 = "NGÀY THI";
            //cl6.ColumnWidth = 15.0;
            //Microsoft.Office.Interop.Excel.Range cl6_1 = oSheet.get_Range("F4", "F1000");
            //cl6_1.Columns.NumberFormat = "dd/mm/yyyy";

            e_excel.Range rowHead = oSheet.get_Range("A3", "E3");
            rowHead.Font.Bold = true;
            // Kẻ viền
            rowHead.Borders.LineStyle = e_excel.Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo mảng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            object[,] arr = new object[tb.Rows.Count, tb.Columns.Count];
            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int r = 0; r < tb.Rows.Count; r++)
            {
                DataRow dr = tb.Rows[r];
                for (int c = 0; c < tb.Columns.Count; c++)

                {
                    arr[r, c] = dr[c];
                }
            }
            //Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + tb.Rows.Count - 1;
            int columnEnd = tb.Columns.Count;
            // Ô bắt đầu điền dữ liệu
            e_excel.Range c1 = (e_excel.Range)oSheet.Cells[rowStart, columnStart];
            // Ô kết thúc điền dữ liệu
            e_excel.Range c2 = (e_excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // Lấy về vùng điền dữ liệu
            e_excel.Range range = oSheet.get_Range(c1, c2);
            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;
            // Kẻ viền
            range.Borders.LineStyle = e_excel.Constants.xlSolid;
            // Căn giữa cột STT
            e_excel.Range c3 = (e_excel.Range)oSheet.Cells[rowEnd, columnStart];
            e_excel.Range c4 = oSheet.get_Range(c1, c3);
            oSheet.get_Range(c3, c4).HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string maloai = txt_maloai.Text.Trim();
            string tenloai = txt_tenloai.Text.Trim();
            string mota = txt_mota.Text.Trim();    
            if(con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string sql = "Select * From Loai_sach Where Maloai like N'%"+maloai+"%' and Tenloai like N'%"+tenloai+"%'  ";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            con.Close();

            dgv_loaisach.DataSource = dt;
            dgv_loaisach.Refresh();
        }
        

        private void btn_xuat_Click(object sender, EventArgs e)
        {
            string maloai = txt_maloai.Text.Trim();
            string tenloai = txt_tenloai.Text.Trim();
            string mota = txt_mota.Text.Trim();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string sql = "Select * From Loai_sach Where Maloai like N'%" + maloai + "%' and Tenloai like N'%" + tenloai + "%'  ";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            con.Close();

            dgv_loaisach.DataSource = dt;
            dgv_loaisach.Refresh();
        }
    }
}
