namespace WindowsFormsApp2
{
    partial class frm_truyengt1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_hienthi = new System.Windows.Forms.Button();
            this.txt_masv = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // btn_hienthi
            // 
            this.btn_hienthi.Location = new System.Drawing.Point(107, 175);
            this.btn_hienthi.Name = "btn_hienthi";
            this.btn_hienthi.Size = new System.Drawing.Size(117, 37);
            this.btn_hienthi.TabIndex = 6;
            this.btn_hienthi.Text = "Hiển thị";
            this.btn_hienthi.UseVisualStyleBackColor = true;
            this.btn_hienthi.Click += new System.EventHandler(this.btn_hienthi_Click);
            // 
            // txt_masv
            // 
            this.txt_masv.Location = new System.Drawing.Point(124, 23);
            this.txt_masv.Name = "txt_masv";
            this.txt_masv.Size = new System.Drawing.Size(244, 22);
            this.txt_masv.TabIndex = 3;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(124, 70);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(244, 22);
            this.txt_hoten.TabIndex = 4;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(124, 116);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(244, 22);
            this.txt_diachi.TabIndex = 5;
            // 
            // frm_truyengt1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_hienthi);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.txt_masv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_truyengt1";
            this.Text = "frm_truyengt1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_hienthi;
        private System.Windows.Forms.TextBox txt_masv;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.TextBox txt_diachi;
    }
}