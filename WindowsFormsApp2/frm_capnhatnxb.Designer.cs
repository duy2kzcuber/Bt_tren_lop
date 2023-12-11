namespace WindowsFormsApp2
{
    partial class frm_capnhatnxb
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
            this.label = new System.Windows.Forms.Label();
            this.labele = new System.Windows.Forms.Label();
            this.sa = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_manxb = new System.Windows.Forms.TextBox();
            this.txt_tennxb = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_em = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.dgv_nxb = new System.Windows.Forms.DataGridView();
            this.manxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_xuatfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nxb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NXB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên NXB";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(164, 262);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(72, 16);
            this.label.TabIndex = 2;
            this.label.Text = "Điện Thoại";
            // 
            // labele
            // 
            this.labele.AutoSize = true;
            this.labele.Location = new System.Drawing.Point(507, 105);
            this.labele.Name = "labele";
            this.labele.Size = new System.Drawing.Size(41, 16);
            this.labele.TabIndex = 3;
            this.labele.Text = "Email";
            // 
            // sa
            // 
            this.sa.AutoSize = true;
            this.sa.Location = new System.Drawing.Point(507, 183);
            this.sa.Name = "sa";
            this.sa.Size = new System.Drawing.Size(47, 16);
            this.sa.TabIndex = 4;
            this.sa.Text = "Địa chỉ";
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.Location = new System.Drawing.Point(507, 269);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(51, 16);
            this.note.TabIndex = 5;
            this.note.Text = "Ghi chú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(289, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(627, 38);
            this.label7.TabIndex = 6;
            this.label7.Text = "CẬP NHẬT THÔNG TIN NHÀ XUẤT BẢN";
            // 
            // txt_manxb
            // 
            this.txt_manxb.Location = new System.Drawing.Point(259, 97);
            this.txt_manxb.Name = "txt_manxb";
            this.txt_manxb.Size = new System.Drawing.Size(199, 22);
            this.txt_manxb.TabIndex = 7;
            // 
            // txt_tennxb
            // 
            this.txt_tennxb.Location = new System.Drawing.Point(259, 183);
            this.txt_tennxb.Name = "txt_tennxb";
            this.txt_tennxb.Size = new System.Drawing.Size(199, 22);
            this.txt_tennxb.TabIndex = 8;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(259, 259);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(199, 22);
            this.txt_sdt.TabIndex = 9;
            // 
            // txt_em
            // 
            this.txt_em.Location = new System.Drawing.Point(593, 102);
            this.txt_em.Name = "txt_em";
            this.txt_em.Size = new System.Drawing.Size(451, 22);
            this.txt_em.TabIndex = 10;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(593, 166);
            this.txt_diachi.Multiline = true;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(451, 48);
            this.txt_diachi.TabIndex = 11;
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(593, 242);
            this.txt_note.Multiline = true;
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(451, 55);
            this.txt_note.TabIndex = 12;
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(86, 355);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(120, 34);
            this.btn_luu.TabIndex = 13;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(278, 355);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(120, 34);
            this.btn_sua.TabIndex = 14;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(445, 355);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(120, 34);
            this.btn_timkiem.TabIndex = 15;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(629, 355);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(120, 34);
            this.btn_xoa.TabIndex = 16;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(924, 355);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(120, 34);
            this.btn_thoat.TabIndex = 17;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // dgv_nxb
            // 
            this.dgv_nxb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nxb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manxb,
            this.tennxb,
            this.sdt,
            this.email,
            this.diachi,
            this.ghichu});
            this.dgv_nxb.Location = new System.Drawing.Point(38, 428);
            this.dgv_nxb.Name = "dgv_nxb";
            this.dgv_nxb.RowHeadersWidth = 51;
            this.dgv_nxb.RowTemplate.Height = 24;
            this.dgv_nxb.Size = new System.Drawing.Size(1111, 213);
            this.dgv_nxb.TabIndex = 18;
            this.dgv_nxb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nxb_CellContentClick);
            // 
            // manxb
            // 
            this.manxb.DataPropertyName = "manxb";
            this.manxb.HeaderText = "Mã NXB";
            this.manxb.MinimumWidth = 6;
            this.manxb.Name = "manxb";
            this.manxb.Width = 125;
            // 
            // tennxb
            // 
            this.tennxb.DataPropertyName = "tennxb";
            this.tennxb.HeaderText = "Tên NXB";
            this.tennxb.MinimumWidth = 6;
            this.tennxb.Name = "tennxb";
            this.tennxb.Width = 125;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "Dienthoai";
            this.sdt.HeaderText = "Điện Thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 150;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "Diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 325;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi Chú";
            this.ghichu.MinimumWidth = 6;
            this.ghichu.Name = "ghichu";
            this.ghichu.Width = 300;
            // 
            // btn_xuatfile
            // 
            this.btn_xuatfile.Location = new System.Drawing.Point(784, 355);
            this.btn_xuatfile.Name = "btn_xuatfile";
            this.btn_xuatfile.Size = new System.Drawing.Size(120, 34);
            this.btn_xuatfile.TabIndex = 19;
            this.btn_xuatfile.Text = "Xuất file";
            this.btn_xuatfile.UseVisualStyleBackColor = true;
            this.btn_xuatfile.Click += new System.EventHandler(this.btn_xuatfile_Click_1);
            // 
            // frm_capnhatnxb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 736);
            this.Controls.Add(this.btn_xuatfile);
            this.Controls.Add(this.dgv_nxb);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_em);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_tennxb);
            this.Controls.Add(this.txt_manxb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.note);
            this.Controls.Add(this.sa);
            this.Controls.Add(this.labele);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_capnhatnxb";
            this.Text = "frm_capnhatnxb";
            this.Load += new System.EventHandler(this.frm_capnhatnxb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nxb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labele;
        private System.Windows.Forms.Label sa;
        private System.Windows.Forms.Label note;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_manxb;
        private System.Windows.Forms.TextBox txt_tennxb;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_em;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DataGridView dgv_nxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn manxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.Button btn_xuatfile;
    }
}