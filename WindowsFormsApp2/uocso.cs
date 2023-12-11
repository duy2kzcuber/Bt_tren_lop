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
    public partial class uocso : Form
    {
        public uocso()
        {
            InitializeComponent();
        }

        private void uocso_Load(object sender, EventArgs e)
        {

        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt_nhap.Text);
            cbo_so.Items.Add(a);
            txt_nhap.Clear(); 
            txt_nhap.Focus();
        }

        private void txt_nhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void cbo_so_SelectedIndexChanged(object sender, EventArgs e)
        {
            lst_uoc.Items.Clear();
            int a = (int)cbo_so.SelectedItem;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    lst_uoc.Items.Add(i.ToString());
                }
            }
        }

        private void btn_tonguoc_Click(object sender, EventArgs e)
        {   
            int sum = 0;
            int tmp;
            for (int i = 0; i < lst_uoc.Items.Count; i++)
            {
                tmp = int.Parse(lst_uoc.Items[i].ToString());
                sum += tmp ;
            }
            MessageBox.Show("Tổng ước là: " + sum);
        }

        private void btn_souocchan_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            int tmp;
            for(int i = 0; i < lst_uoc.Items.Count; i++)
            {
                tmp = int.Parse(lst_uoc.Items[i].ToString()) ;
                if (tmp % 2 == 0) cnt++;
            }
            MessageBox.Show("Số lượng ước chẵn là: " +  cnt);
        }
        bool snt(int n)
        {
            if (n == 1 || n == 0) return false;
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return n > 1;
        }
        private void btn_uocnt_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            int tmp;
            for (int i = 0; i < lst_uoc.Items.Count; i++)
            {
                tmp = int.Parse(lst_uoc.Items[i].ToString());
                if(snt(tmp) == true) cnt++;
            }
            MessageBox.Show("Số lượng ước nguyên tố là: " + cnt);
        }

        private void txt_nhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
