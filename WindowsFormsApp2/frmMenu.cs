using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void trToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cậpNhậtLoạiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new GiaiPtbac1();
            f.Show();
        }

        private void btn_pckcl_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Mở file ảnh";
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void btn_luuanh_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Lưu file ảnh";
            saveFileDialog1.ShowDialog();
            pictureBox1.Image.Save(saveFileDialog1.FileName);
            textBox1.Text = saveFileDialog1.FileName;
        }
    }
}
