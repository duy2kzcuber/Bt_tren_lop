using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class GiaiPtbac1 : Form
    {
        public GiaiPtbac1()
        {
            InitializeComponent();
        }

        private void btnGiaiPT_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            float x = (float)b / a;
            if (a == 0)
            {
                if (b == 0)
                {
                    txtKQ.Text = "Phương trình có vô số nghiệm!";
                }
                else
                {
                    txtKQ.Text = "Phương trình vô nghiệm!";
                }
            }
            else
            {
                txtKQ.Text = "Phương trình đã cho có nghiệm là x= " + x;
            }
        }
    }
}
