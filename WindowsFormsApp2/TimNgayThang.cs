using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class TimNgayThang : Form
    {
        public TimNgayThang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            int m = int.Parse(txtThang.Text);
            int y = int.Parse(txtNam.Text);
            if (m > 0 && y > 0 && m <= 12)
            {
                switch (m)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        txtKetqua.Text = "Tháng " + m + " có 31 ngày";
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        txtKetqua.Text = "Tháng " + m + " có 30 ngày";
                        break;
                    case 2:
                        if ((y % 400 == 0) || (y % 4 == 0 && y % 100 != 0))
                        {
                            txtKetqua.Text = "Tháng " + m + " có 29 ngày";
                        }
                        else
                        {
                            txtKetqua.Text = "Tháng " + m + " có 28 ngày";
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Tháng hoặc năm bạn vừa nhập không hợp lệ! Vui lòng thử lại");
                return;
            }
            Form f = new GiaiPTbac2();
            f.MdiParent = this;
            f.Show();
        }

    }
}
