using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using e_excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp2
{
    public partial class frm_capnhatnxb : Form
    {
        SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=viduSQL;Integrated Security=True");
        public frm_capnhatnxb()
        {
            InitializeComponent();
        }
        private bool checktrungma(string manxb)
        {
            //b1 :ket noi den database
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //b2: tao doi tuong command
            string sql = "Select count(*) From Nha_xuat_ban where Manxb= '" + manxb + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = (int)cmd.ExecuteScalar();
            cmd.Dispose();
            con.Close();
            return kq > 0;
        }
        private void Load_dgv_nxb()
        {
            //b1 : ket noi den db
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            //b2 : ket noi den command de lay du lieu tu bang nha xuat ban
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * From Nha_xuat_ban";
            // b3: tao doi tuong data adapter de lay du lieu tu command
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            //b4: Do du lieu tu data adapter vao data table
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            con.Close();
            // b5: Hien thi data table len dataGridview
            dgv_nxb.DataSource = dt;
            dgv_nxb.Refresh();
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {

                //b1 lấy dữ liệu từ các control đưa vào biến
                string manxb = txt_manxb.Text.Trim(); // trim: xóa khoảng trắng ở đầu và cuối xâu
                string tennxb = txt_tennxb.Text.Trim();
                string sdt = txt_sdt.Text.Trim();
                string email = txt_em.Text.Trim();
                string diachi = txt_diachi.Text.Trim();
                string note = txt_note.Text.Trim();
                //kiem tra du lieu rong o ma nha xuat ban
                if (manxb == "")
                {
                    MessageBox.Show("Bạn phải nhập mã nhà xuất bản");
                    txt_diachi.Focus();
                    return;
                }
                if (String.IsNullOrEmpty(tennxb))
                {
                    MessageBox.Show("Tên nhà xuất bản không được rỗng");
                    txt_tennxb.Focus();
                    return;
                }
                // kiem tra trung khoa chinh
                if (checktrungma(manxb))
                {
                    MessageBox.Show("Mã nhà xuất bản đã tồn tại!");
                    txt_manxb.Focus(); // con tro se nhap nhay tai do
                    return;
                }
                //b2: kết nối database (xem dong 16)
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                //b3: tạo đối tượng command để chèn dữ liệu vào bảng NXB và thực thi nó

                string sql = "Insert Nha_xuat_ban Values ('" + manxb + "',N'" + tennxb + "','" + sdt + "','" + email + "',N'" + diachi + "',N'" + note + "')";
                //   string sql = "Insert Nha_xuat_ban Values(@manxb, @tenxb, @sdt, @email, @diachi, @note)";
                SqlCommand cmd = new SqlCommand(sql, con);
                //         cmd.Parameters.Add("@manxb", SqlDbType.NVarChar, 50).Value = manxb;
                //         cmd.Parameters.Add("@tenxb", SqlDbType.NVarChar, 50).Value = tennxb;
                //       cmd.Parameters.Add("@sdt", SqlDbType.NVarChar, 50).Value = sdt;
                //      cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = email;
                //      cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 50).Value = diachi;
                //      cmd.Parameters.Add("@note", SqlDbType.NVarChar, 50).Value = note;
                cmd.ExecuteNonQuery(); // dung de thuc thi
                cmd.Dispose(); // giai phong bo nho
                con.Close();
                MessageBox.Show("Thêm mới thành công");
                Load_dgv_nxb();
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống, liên hệ với quản trị viên!");
            }
        }

        private void frm_capnhatnxb_Load(object sender, EventArgs e)
        {
            Load_dgv_nxb();
        }

        private void dgv_nxb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt_manxb.Text = dgv_nxb.Rows[i].Cells[0].Value.ToString();
            txt_tennxb.Text = dgv_nxb.Rows[i].Cells[1].Value.ToString();
            txt_sdt.Text = dgv_nxb.Rows[i].Cells[2].Value.ToString();
            txt_em.Text = dgv_nxb.Rows[i].Cells[3].Value.ToString();
            txt_diachi.Text = dgv_nxb.Rows[i].Cells[4].Value.ToString();
            txt_note.Text = dgv_nxb.Rows[i].Cells[5].Value.ToString();
            txt_manxb.Enabled = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //b1 lấy dữ liệu từ các control đưa vào biến
            string manxb = txt_manxb.Text.Trim(); // trim: xóa khoảng trắng ở đầu và cuối xâu
            string tennxb = txt_tennxb.Text.Trim();
            string sdt = txt_sdt.Text.Trim();
            string email = txt_em.Text.Trim();
            string diachi = txt_diachi.Text.Trim();
            string note = txt_note.Text.Trim();
            // b2: kết nối đến database
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //b3: tạo đối tượng conmmand để thực hiện sửa dữ liệu
            string sql = "Update Nha_xuat_ban set Tennxb= N'" + tennxb + "', Dienthoai= '" + sdt + "',Email= '" + email + "', Diachi= N'" + diachi + "',ghichu = N'" + note + "' Where Manxb = '" + manxb + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Sửa thành công!");
            Load_dgv_nxb();
            txt_manxb.Enabled = true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //B1: lấy dữ liệu từ control đưa vào biến
            string manxb = txt_manxb.Text.Trim();
            //b2: kết nối đến database;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //b3: tạo đối tượng command
            string sql = "Delete Nha_xuat_ban Where Manxb = '" + manxb + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Xóa thành công!");
            Load_dgv_nxb();
            txt_manxb.Enabled = true;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            //b1: lay du lieu tu cac control dua vao bien
            string manxb = txt_manxb.Text.Trim(); // trim: xóa khoảng trắng ở đầu và cuối xâu
            string tennxb = txt_tennxb.Text.Trim();
            string sdt = txt_sdt.Text.Trim();
            string email = txt_em.Text.Trim();
            string diachi = txt_diachi.Text.Trim();
            //b2 ket noi den database
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //b3 : tao duoi tuong command de lay du lieu
            string sql = "Select * From Nha_xuat_ban Where Manxb like '%" + manxb + "%' and Tennxb like N'%" + tennxb + "%' and Dienthoai like '%" + sdt + "%' and Email like '%" + email + "%' and Diachi like N'%" + diachi + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            //b4: tao doi tuong data adapter de lay ket qua tu command
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            //b5 : do du lieu tu data vao data table
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            con.Close();
            //b6: hien thi dataTable len datagridview   
            dgv_nxb.DataSource = dt;
            dgv_nxb.Refresh();
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

            e_excel.Range head = oSheet.get_Range("A1", "F1");
            head.MergeCells = true;
            head.Value2 = "DANH SÁCH THÔNG TIN NHÀ XUẤT BẢN";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "16";
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            e_excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MÃ NHÀ XUẤT BẢN";
            cl1.ColumnWidth = 15;
            e_excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "TÊN NHÀ XUẤT BẢN";

            cl2.ColumnWidth = 25.0;
            e_excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "ĐIỆN THOẠI";
            cl3.ColumnWidth = 15.0;
            e_excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "EMAIL";
            cl4.ColumnWidth = 23.0;
            e_excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "ĐỊA CHỈ";
            cl5.ColumnWidth = 40.0;
            e_excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl5.Value2 = "GHI CHÚ";
            cl5.ColumnWidth = 55.0;
            //Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            //cl6.Value2 = "NGÀY THI";
            //cl6.ColumnWidth = 15.0;
            //Microsoft.Office.Interop.Excel.Range cl6_1 = oSheet.get_Range("F4", "F1000");
            //cl6_1.Columns.NumberFormat = "dd/mm/yyyy";

            e_excel.Range rowHead = oSheet.get_Range("A3", "F3");
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
                    if (c == 2)
                    {
                        arr[r, c] = "'" + dr[c];
                    }
                    else arr[r, c] = dr[c];
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
        private void btn_xuatfile_Click(object sender, EventArgs e)
        {

        }

        private void btn_xuatfile_Click_1(object sender, EventArgs e)
        {
            //b1: lay du lieu tu cac control dua vao bien
            string manxb = txt_manxb.Text.Trim(); // trim: xóa khoảng trắng ở đầu và cuối xâu
            string tennxb = txt_tennxb.Text.Trim();
            string sdt = txt_sdt.Text.Trim();
            string email = txt_em.Text.Trim();
            string diachi = txt_diachi.Text.Trim();
            //b2 ket noi den database
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //b3 : tao duoi tuong command de lay du lieu
            string sql = "Select * From Nha_xuat_ban Where Manxb like '%" + manxb + "%' and Tennxb like N'%" + tennxb + "%' and Dienthoai like '%" + sdt + "%' and Email like '%" + email + "%' and Diachi like N'%" + diachi + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            //b4: tao doi tuong data adapter de lay ket qua tu command
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            //b5 : do du lieu tu data vao data table
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            con.Close();

            //b6: xuất dữ liệu từ tb ra file
            ExportExcel(dt, "Danh sach nxb");
        }
    }
}
