namespace WindowsFormsApp2
{
    partial class capnhattacgia_file
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
            this.txt_tenfile = new System.Windows.Forms.TextBox();
            this.btn_pick = new System.Windows.Forms.Button();
            this.dgv_tacgia = new System.Windows.Forms.DataGridView();
            this.btn_upload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.matg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tacgia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT THÔNG TIN TÁC GIẢ";
            // 
            // txt_tenfile
            // 
            this.txt_tenfile.Location = new System.Drawing.Point(154, 92);
            this.txt_tenfile.Name = "txt_tenfile";
            this.txt_tenfile.Size = new System.Drawing.Size(339, 22);
            this.txt_tenfile.TabIndex = 2;
            // 
            // btn_pick
            // 
            this.btn_pick.Location = new System.Drawing.Point(28, 88);
            this.btn_pick.Name = "btn_pick";
            this.btn_pick.Size = new System.Drawing.Size(106, 31);
            this.btn_pick.TabIndex = 3;
            this.btn_pick.Text = "Chọn file";
            this.btn_pick.UseVisualStyleBackColor = true;
            this.btn_pick.Click += new System.EventHandler(this.btn_pick_Click);
            // 
            // dgv_tacgia
            // 
            this.dgv_tacgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tacgia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matg,
            this.tentg,
            this.ngaysinh,
            this.gioitinh,
            this.Dienthoai,
            this.Email,
            this.Diachi});
            this.dgv_tacgia.Location = new System.Drawing.Point(43, 164);
            this.dgv_tacgia.Name = "dgv_tacgia";
            this.dgv_tacgia.RowHeadersWidth = 51;
            this.dgv_tacgia.RowTemplate.Height = 24;
            this.dgv_tacgia.Size = new System.Drawing.Size(921, 281);
            this.dgv_tacgia.TabIndex = 4;
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(515, 92);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(80, 26);
            this.btn_upload.TabIndex = 5;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // matg
            // 
            this.matg.DataPropertyName = "Matg";
            this.matg.HeaderText = "Mã tác giả";
            this.matg.MinimumWidth = 6;
            this.matg.Name = "matg";
            this.matg.Width = 125;
            // 
            // tentg
            // 
            this.tentg.DataPropertyName = "Tentg";
            this.tentg.HeaderText = "Tên tác giả";
            this.tentg.MinimumWidth = 6;
            this.tentg.Name = "tentg";
            this.tentg.Width = 125;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "Ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 125;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "Gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 125;
            // 
            // Dienthoai
            // 
            this.Dienthoai.DataPropertyName = "Dienthoai";
            this.Dienthoai.HeaderText = "Điện thoại";
            this.Dienthoai.MinimumWidth = 6;
            this.Dienthoai.Name = "Dienthoai";
            this.Dienthoai.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "Diachi";
            this.Diachi.HeaderText = "Địa chỉ";
            this.Diachi.MinimumWidth = 6;
            this.Diachi.Name = "Diachi";
            this.Diachi.Width = 125;
            // 
            // capnhattacgia_file
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 525);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.dgv_tacgia);
            this.Controls.Add(this.btn_pick);
            this.Controls.Add(this.txt_tenfile);
            this.Controls.Add(this.label1);
            this.Name = "capnhattacgia_file";
            this.Text = "capnhattacgia_file";
            this.Load += new System.EventHandler(this.capnhattacgia_file_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tacgia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tenfile;
        private System.Windows.Forms.Button btn_pick;
        private System.Windows.Forms.DataGridView dgv_tacgia;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn matg;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
    }
}