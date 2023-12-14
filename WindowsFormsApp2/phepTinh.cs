using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class phepTinh : Form
    {
        public phepTinh()
        {
            InitializeComponent();
        }


        private void txt_s1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void txt_s2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void rbtn_cong_CheckedChanged(object sender, EventArgs e)
        {
            int a = int.Parse(txt_s1.Text);
            int b = int.Parse(txt_s2.Text);
            int c = a + b;
            txt_kq.Text = (c).ToString();
        }

        private void rbtn_tru_CheckedChanged(object sender, EventArgs e)
        {
            int a = int.Parse(txt_s1.Text);
            int b = int.Parse(txt_s2.Text);
            int c = a - b;
            txt_kq.Text = (c).ToString();
        }

        private void rbtn_nhan_CheckedChanged(object sender, EventArgs e)
        {
            int a = int.Parse(txt_s1.Text);
            int b = int.Parse(txt_s2.Text);
            int c = a * b;
            txt_kq.Text = (c).ToString();
        }

        private void rbtn_chia_CheckedChanged(object sender, EventArgs e)
        {
            int a = int.Parse(txt_s1.Text);
            int b = int.Parse(txt_s2.Text);

            if (b == 0)
            {
                txt_kq.Text = "Số chia bạn nhập không hợp lệ, vui lòng thử lại!";
            }
            else
            {
                int c = a / b;
                txt_kq.Text = (c).ToString();
            }
        }

        private void phepTinh_Load(object sender, EventArgs e)
        {

        }
    }
}
