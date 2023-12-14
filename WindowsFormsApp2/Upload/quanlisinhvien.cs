using System;
using System.Windows.Forms;

namespace WindowsFormsApp2.Upload
{
    public partial class quanlisinhvien : Form
    {
        public quanlisinhvien()
        {
            InitializeComponent();
        }

        private void btn_themoi_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txt_masv.Text, txt_hoten.Text, txt_diachi.Text, dt_ngaysinh.Value.ToString(),
                cbo_lop.SelectedItem.ToString());
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentRow.Cells[0].Value = txt_masv.Text;
            dataGridView1.CurrentRow.Cells[1].Value = txt_hoten.Text;
            dataGridView1.CurrentRow.Cells[2].Value = txt_diachi.Text;
            dataGridView1.CurrentRow.Cells[3].Value = dt_ngaysinh.Value.ToString();
            dataGridView1.CurrentRow.Cells[4].Value = cbo_lop.SelectedItem.ToString();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                Application.Exit();
            }


        }
    }
}
