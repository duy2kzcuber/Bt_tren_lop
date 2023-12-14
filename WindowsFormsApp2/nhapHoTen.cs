using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class nhapHoTen : Form
    {
        public nhapHoTen()
        {
            InitializeComponent();
        }

        private void nhapHoTen_Load(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn mở ứng dụng không?",
                "Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.Cancel)
            {
                Dispose(); // dung chuong trinh
            }
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Họ và tên: " + txtHoten.Text, "Kết quả");
        }

        private void nhapHoTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.H)
            {
                txtHoten.Text = "Trường ĐH Công Nghệ GTVT";
            }

        }

        private void nhapHoTen_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Bạn vừa nhấn chuột trái!", "Thông Báo");
            }
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Bạn vừa nhấn chuột phải!", "Thông Báo");
            }
            if (e.Button == MouseButtons.Middle)
            {
                MessageBox.Show("Bạn vừa nhấn chuột giữa!", "Thông Báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn tắt không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dl == DialogResult.Yes)
            {
                Application.Exit(); // dung chuong trinh
            }
        }
    }
}
