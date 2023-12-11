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
    public partial class Luyen_tap_lstbox : Form
    {
        public Luyen_tap_lstbox()
        {
            InitializeComponent();
        }

        private void list_bao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            list_bao.Items.Add(cbo_bao.SelectedItem.ToString());
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            list_bao.Items.Clear();
        }
    }
}
