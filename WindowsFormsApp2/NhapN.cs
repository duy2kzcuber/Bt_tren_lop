using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class NhapN : Form
    {
        public NhapN()
        {
            InitializeComponent();
        }
        private void btnKQ_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            int tong = 0;
            String b = "Các số thỏa mãn: ";
            for (int i = 1; i < n; i++)
            {
                if (i % 3 == 0 && i % 2 != 0)
                {
                    tong = tong + i;
                    b = b + "; " + i;
                }
            }
            string a = " Tổng các số thỏa mãn yêu cầu là: " + tong;
            txtKQ.Text = a + " \n " + b;
        }
    }
}
