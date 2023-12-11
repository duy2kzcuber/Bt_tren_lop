namespace WindowsFormsApp2
{
    partial class SRMcombobox
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
            this.cbo_MonHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonHoc = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.lst_monhoc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbo_MonHoc
            // 
            this.cbo_MonHoc.FormattingEnabled = true;
            this.cbo_MonHoc.Items.AddRange(new object[] {
            "Lập trình trực quan c#",
            "Cấu trúc dữ liệu và giải thuật",
            "Phân tích và thiết kế hệ thống thông tin",
            "Hệ quản trị CSDL SQL server"});
            this.cbo_MonHoc.Location = new System.Drawing.Point(198, 159);
            this.cbo_MonHoc.Name = "cbo_MonHoc";
            this.cbo_MonHoc.Size = new System.Drawing.Size(364, 24);
            this.cbo_MonHoc.TabIndex = 0;
            this.cbo_MonHoc.SelectedIndexChanged += new System.EventHandler(this.cbo_MonHoc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Môn học";
            // 
            // txtMonHoc
            // 
            this.txtMonHoc.Location = new System.Drawing.Point(198, 65);
            this.txtMonHoc.Name = "txtMonHoc";
            this.txtMonHoc.Size = new System.Drawing.Size(363, 22);
            this.txtMonHoc.TabIndex = 2;
            this.txtMonHoc.TextChanged += new System.EventHandler(this.txtMonHoc_TextChanged);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(198, 111);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(85, 33);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // lst_monhoc
            // 
            this.lst_monhoc.FormattingEnabled = true;
            this.lst_monhoc.ItemHeight = 16;
            this.lst_monhoc.Location = new System.Drawing.Point(198, 218);
            this.lst_monhoc.Name = "lst_monhoc";
            this.lst_monhoc.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_monhoc.Size = new System.Drawing.Size(329, 116);
            this.lst_monhoc.TabIndex = 4;
            // 
            // SRMcombobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_monhoc);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txtMonHoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_MonHoc);
            this.Name = "SRMcombobox";
            this.Text = "SRMcombobox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_MonHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonHoc;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.ListBox lst_monhoc;
    }
}