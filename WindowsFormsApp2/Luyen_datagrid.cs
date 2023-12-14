using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Luyen_datagrid : Form
    {
        public Luyen_datagrid()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt_hoten.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            cbo_gioitinh.SelectedItem = dataGridView1.Rows[i].Cells[1].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txt_hoten.Text, cbo_gioitinh.SelectedItem.ToString(),
                dateTimePicker1.Value.ToString());
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

        }
    }
}
