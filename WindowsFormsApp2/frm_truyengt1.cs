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
    public partial class frm_truyengt1 : Form
    {
        public frm_truyengt1()
        {
            InitializeComponent();
        }

        private void btn_hienthi_Click(object sender, EventArgs e)
        {
            string p_masv = txt_masv.Text.Trim();
            string p_hoten = txt_hoten.Text.Trim();
            string p_diachi = txt_diachi.Text.Trim();
            Form f = new frm_nhangiatri(p_masv, p_hoten , p_diachi);
            f.Show();
        }
    }
}
