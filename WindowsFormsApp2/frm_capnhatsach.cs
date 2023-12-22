using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frm_capnhatsach : Form
    {

        public frm_capnhatsach()
        {
            InitializeComponent();
        }
        private void load_cboLoaisach()
        {
            string sql = "Select * From Loai_sach";
            DataTable dt = new DataTable();
            dt = Thuvien.Hienthi(sql);
            //Them 1 dong trong vao
            //vi tri dau tien cua bang
            DataRow r = dt.NewRow();
            r["Maloai"] = "";
            r["Tenloai"] = "Chon loai sach";
            dt.Rows.InsertAt(r,0);
            //hien thi tb vao combobox
           // cbo_maloaisach.DataSource = dt;
            //cbo_maloaisach.DisplayMember = "Tenloai";
           // cbo_maloaisach.ValueMember = "Maloai";
            cbo_malsach.DataSource = dt;
            cbo_malsach.DisplayMember = "Tenloai";
            cbo_malsach.ValueMember = "maloai";

        }

        private void frm_capnhatsach_Load(object sender, EventArgs e)
        {
            load_cboLoaisach();
        }

        private void btn_pick_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Title = " Chọn file ảnh";
            f.Filter = "Image file|*.jpg";
            f.FilterIndex = 1;
            f.RestoreDirectory = true;
            f.Multiselect = false;
            if(f.ShowDialog() == DialogResult.OK)
            {
                txt_pick.Text = f.FileName;
                pictureBox1.Image = Image.FromFile(f.FileName);
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            //lay du lieu tu cac control dua vao bien
           // string masach = txt_masach
        }

        private void cbo_malsach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
