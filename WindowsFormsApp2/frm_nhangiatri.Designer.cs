namespace WindowsFormsApp2
{
    partial class frm_nhangiatri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_diachi = new System.Windows.Forms.Label();
            this.lbl_hoten = new System.Windows.Forms.Label();
            this.lbl_masv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã sinh viên";
            // 
            // lbl_diachi
            // 
            this.lbl_diachi.AutoSize = true;
            this.lbl_diachi.Location = new System.Drawing.Point(225, 141);
            this.lbl_diachi.Name = "lbl_diachi";
            this.lbl_diachi.Size = new System.Drawing.Size(47, 16);
            this.lbl_diachi.TabIndex = 11;
            this.lbl_diachi.Text = "Địa chỉ";
            // 
            // lbl_hoten
            // 
            this.lbl_hoten.AutoSize = true;
            this.lbl_hoten.Location = new System.Drawing.Point(225, 95);
            this.lbl_hoten.Name = "lbl_hoten";
            this.lbl_hoten.Size = new System.Drawing.Size(64, 16);
            this.lbl_hoten.TabIndex = 10;
            this.lbl_hoten.Text = "Họ và tên";
            // 
            // lbl_masv
            // 
            this.lbl_masv.AutoSize = true;
            this.lbl_masv.ForeColor = System.Drawing.Color.Red;
            this.lbl_masv.Location = new System.Drawing.Point(223, 54);
            this.lbl_masv.Name = "lbl_masv";
            this.lbl_masv.Size = new System.Drawing.Size(81, 16);
            this.lbl_masv.TabIndex = 9;
            this.lbl_masv.Text = "Mã sinh viên";
            // 
            // frm_nhangiatri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_diachi);
            this.Controls.Add(this.lbl_hoten);
            this.Controls.Add(this.lbl_masv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_nhangiatri";
            this.Text = "frm_nhangiatri";
            this.Load += new System.EventHandler(this.frm_nhangiatri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_diachi;
        private System.Windows.Forms.Label lbl_hoten;
        private System.Windows.Forms.Label lbl_masv;
    }
}