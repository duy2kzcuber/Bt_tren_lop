using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using e_excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp2
{
    public partial class capnhattacgia_file : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dtconnect"].ConnectionString);
        public capnhattacgia_file()
        {
            InitializeComponent();
        }
        private void tacgia_ins(string matg, string tentg, DateTime ngaysinh, string gioitinh, string sdt, string email, string diachi)
        {
            //ket noi db
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //khoi tao doi tuong cmd de thuc hien them du lieu vao bang
            string sql = "Insert Tac_gia Values('" + matg + "', N'" + tentg + "', '" + ngaysinh + "', N'" + gioitinh + "', '" + sdt + "', '" + email + "', N'" + diachi + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        private void ReadExcel(string filename)
        {
            //kiểm tra xem filename đã có dữ liệu chưa
            if (filename == null)
            {
                MessageBox.Show("Chưa chọn file");
            }
            else
            {
                e_excel.Application Excel = new e_excel.Application();// tạp một app làm việc mới
                // mở dữ liệu từ file
                Excel.Workbooks.Open(filename);
                //đọc dữ liệu từng sheet của excel
                foreach (e_excel.Worksheet wsheet in Excel.Worksheets)
                {
                    int i = 2;  //để đọc từng dòng của sheet bắt đầu từ dòng số 2
                    do
                    {
                        if (wsheet.Cells[i, 1].Value == null && wsheet.Cells[i, 2].Value == null && wsheet.Cells[i, 3].Value == null)
                        {
                            break;
                        }
                        else
                        {
                            DateTime ng = Convert.ToDateTime(wsheet.Cells[i, 3].Value);
                            //Đổ dòng dữ liệu vào DB
                            tacgia_ins(wsheet.Cells[i, 1].Value, wsheet.Cells[i, 2].Value, ng, wsheet.Cells[i, 4].Value,
                                wsheet.Cells[i, 5].Value, wsheet.Cells[i, 6].Value, wsheet.Cells[i, 7].Value);
                            i++;
                        }
                    }
                    while (true);
                }
            }

        }
        private void load_dgv_tacgia()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * From Tac_gia";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            con.Close();

            dgv_tacgia.DataSource = dt;
            dgv_tacgia.Refresh();
        }
        private void capnhattacgia_file_Load(object sender, EventArgs e)
        {
            load_dgv_tacgia();
        }
        string p_tenfile;
        private void btn_pick_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Title = "Import File";
            f.Filter = "Excel file| *xls;*.xlsx";
            f.FilterIndex = 1;// tro vao vi tri dau tien cua bo loc
            f.RestoreDirectory = true; // nho duong dan cua lan truy cap truoc
            f.Multiselect = false; // ko cho phep chon nhieu file cung 1 luc
            if (f.ShowDialog() == DialogResult.OK)
            {
                p_tenfile = f.FileName;
                txt_tenfile.Text = p_tenfile;
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            ReadExcel(p_tenfile);
            MessageBox.Show("Import Thành Công");
            load_dgv_tacgia();
        }
    }
}
