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
    public partial class GiaiPTbac2 : Form
    {
        public GiaiPTbac2()
        {
            InitializeComponent();
        }

        private void btnGiaiPT_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int c = int.Parse(txtC.Text);
            //a phai khac 0
            if (a == 0)
            {
                txtA.Focus();
                MessageBox.Show("A phai khac 0!");
                return;
            }
            //Giai phuong trinh
            int delta = b * b - 4 * a * c;
            if (delta < 0)
                txtKQ.Text = "Phuong trinh vo nghiem";
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                txtKQ.Text = "Phuong trinh co nghiem kep x= "+ x;
            }

            else
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                txtKQ.Text = "Phuong trinh co hai nghiem phan biet x1= " + x1 + " va x2= " + x2;


            }
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }
        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }


        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }
    }
}
