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
    public partial class SRMcombobox : Form
    {
        public SRMcombobox()
        {
            InitializeComponent();
        }

        private void cbo_MonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lst_MonHoc.Text = cbo_MonHoc.SelectedItem.ToString();
            lst_monhoc.Items.Add(cbo_MonHoc.SelectedItem.ToString());
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            cbo_MonHoc.Items.Add(txtMonHoc.Text);
        }

        private void txtMonHoc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
