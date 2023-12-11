namespace WindowsFormsApp2
{
    partial class phepTinh
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
            this.txt_s1 = new System.Windows.Forms.TextBox();
            this.txt_s2 = new System.Windows.Forms.TextBox();
            this.grb_pt = new System.Windows.Forms.GroupBox();
            this.rbtn_chia = new System.Windows.Forms.RadioButton();
            this.rbtn_nhan = new System.Windows.Forms.RadioButton();
            this.rbtn_tru = new System.Windows.Forms.RadioButton();
            this.rbtn_cong = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_kq = new System.Windows.Forms.TextBox();
            this.grb_pt.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số 2";
            // 
            // txt_s1
            // 
            this.txt_s1.Location = new System.Drawing.Point(230, 85);
            this.txt_s1.Name = "txt_s1";
            this.txt_s1.Size = new System.Drawing.Size(352, 22);
            this.txt_s1.TabIndex = 2;
            this.txt_s1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_s1_KeyPress);
            // 
            // txt_s2
            // 
            this.txt_s2.Location = new System.Drawing.Point(230, 140);
            this.txt_s2.Name = "txt_s2";
            this.txt_s2.Size = new System.Drawing.Size(352, 22);
            this.txt_s2.TabIndex = 3;
            this.txt_s2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_s2_KeyPress);
            // 
            // grb_pt
            // 
            this.grb_pt.Controls.Add(this.rbtn_chia);
            this.grb_pt.Controls.Add(this.rbtn_nhan);
            this.grb_pt.Controls.Add(this.rbtn_tru);
            this.grb_pt.Controls.Add(this.rbtn_cong);
            this.grb_pt.Location = new System.Drawing.Point(103, 199);
            this.grb_pt.Name = "grb_pt";
            this.grb_pt.Size = new System.Drawing.Size(567, 147);
            this.grb_pt.TabIndex = 4;
            this.grb_pt.TabStop = false;
            this.grb_pt.Text = "Phép tính";
            // 
            // rbtn_chia
            // 
            this.rbtn_chia.AutoSize = true;
            this.rbtn_chia.Location = new System.Drawing.Point(438, 62);
            this.rbtn_chia.Name = "rbtn_chia";
            this.rbtn_chia.Size = new System.Drawing.Size(55, 20);
            this.rbtn_chia.TabIndex = 3;
            this.rbtn_chia.TabStop = true;
            this.rbtn_chia.Text = "Chia";
            this.rbtn_chia.UseVisualStyleBackColor = true;
            this.rbtn_chia.CheckedChanged += new System.EventHandler(this.rbtn_chia_CheckedChanged);
            // 
            // rbtn_nhan
            // 
            this.rbtn_nhan.AutoSize = true;
            this.rbtn_nhan.Location = new System.Drawing.Point(294, 62);
            this.rbtn_nhan.Name = "rbtn_nhan";
            this.rbtn_nhan.Size = new System.Drawing.Size(60, 20);
            this.rbtn_nhan.TabIndex = 2;
            this.rbtn_nhan.TabStop = true;
            this.rbtn_nhan.Text = "Nhân";
            this.rbtn_nhan.UseVisualStyleBackColor = true;
            this.rbtn_nhan.CheckedChanged += new System.EventHandler(this.rbtn_nhan_CheckedChanged);
            // 
            // rbtn_tru
            // 
            this.rbtn_tru.AutoSize = true;
            this.rbtn_tru.Location = new System.Drawing.Point(143, 62);
            this.rbtn_tru.Name = "rbtn_tru";
            this.rbtn_tru.Size = new System.Drawing.Size(48, 20);
            this.rbtn_tru.TabIndex = 1;
            this.rbtn_tru.TabStop = true;
            this.rbtn_tru.Text = "Trừ";
            this.rbtn_tru.UseVisualStyleBackColor = true;
            this.rbtn_tru.CheckedChanged += new System.EventHandler(this.rbtn_tru_CheckedChanged);
            // 
            // rbtn_cong
            // 
            this.rbtn_cong.AutoSize = true;
            this.rbtn_cong.Location = new System.Drawing.Point(15, 62);
            this.rbtn_cong.Name = "rbtn_cong";
            this.rbtn_cong.Size = new System.Drawing.Size(60, 20);
            this.rbtn_cong.TabIndex = 0;
            this.rbtn_cong.TabStop = true;
            this.rbtn_cong.Text = "Cộng";
            this.rbtn_cong.UseVisualStyleBackColor = true;
            this.rbtn_cong.CheckedChanged += new System.EventHandler(this.rbtn_cong_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kết quả";
            // 
            // txt_kq
            // 
            this.txt_kq.Location = new System.Drawing.Point(230, 376);
            this.txt_kq.Name = "txt_kq";
            this.txt_kq.Size = new System.Drawing.Size(352, 22);
            this.txt_kq.TabIndex = 6;
            // 
            // phepTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_kq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grb_pt);
            this.Controls.Add(this.txt_s2);
            this.Controls.Add(this.txt_s1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "phepTinh";
            this.Text = "Nguyễn Hữu Duy";
            this.Load += new System.EventHandler(this.phepTinh_Load);
            this.grb_pt.ResumeLayout(false);
            this.grb_pt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_s1;
        private System.Windows.Forms.TextBox txt_s2;
        private System.Windows.Forms.GroupBox grb_pt;
        private System.Windows.Forms.RadioButton rbtn_chia;
        private System.Windows.Forms.RadioButton rbtn_nhan;
        private System.Windows.Forms.RadioButton rbtn_tru;
        private System.Windows.Forms.RadioButton rbtn_cong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_kq;
    }
}