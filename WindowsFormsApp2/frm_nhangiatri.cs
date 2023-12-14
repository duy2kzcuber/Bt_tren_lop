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
    public partial class frm_nhangiatri : Form
    {
        private string p_hoten;
        private string p_diachi;
        private string p_masv;

        public frm_nhangiatri(string p_masv)
        {
            InitializeComponent();
        }

        public frm_nhangiatri(string p_masv, string p_hoten, string p_diachi) : this(p_masv)
        {
            this.p_hoten = p_hoten;
            this.p_diachi = p_diachi;
            this.p_masv = p_masv;
        }

        private void frm_nhangiatri_Load(object sender, EventArgs e)
        {
            lbl_diachi.Text = p_diachi;
            lbl_hoten.Text = p_hoten;
            lbl_masv.Text = p_masv;
        }
    }
}
