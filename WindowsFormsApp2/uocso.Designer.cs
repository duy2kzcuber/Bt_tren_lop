namespace WindowsFormsApp2
{
    partial class uocso
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_so = new System.Windows.Forms.ComboBox();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.txt_nhap = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_uoc = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_tonguoc = new System.Windows.Forms.Button();
            this.btn_souocchan = new System.Windows.Forms.Button();
            this.btn_uocnt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_so);
            this.groupBox1.Controls.Add(this.btn_capnhat);
            this.groupBox1.Controls.Add(this.txt_nhap);
            this.groupBox1.Location = new System.Drawing.Point(50, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // cbo_so
            // 
            this.cbo_so.FormattingEnabled = true;
            this.cbo_so.Location = new System.Drawing.Point(19, 83);
            this.cbo_so.Name = "cbo_so";
            this.cbo_so.Size = new System.Drawing.Size(295, 24);
            this.cbo_so.TabIndex = 2;
            this.cbo_so.SelectedIndexChanged += new System.EventHandler(this.cbo_so_SelectedIndexChanged);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Location = new System.Drawing.Point(217, 24);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(98, 28);
            this.btn_capnhat.TabIndex = 1;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // txt_nhap
            // 
            this.txt_nhap.Location = new System.Drawing.Point(19, 30);
            this.txt_nhap.Name = "txt_nhap";
            this.txt_nhap.Size = new System.Drawing.Size(143, 22);
            this.txt_nhap.TabIndex = 0;
            this.txt_nhap.TextChanged += new System.EventHandler(this.txt_nhap_TextChanged);
            this.txt_nhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nhap_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_uoc);
            this.groupBox2.Location = new System.Drawing.Point(443, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 274);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // lst_uoc
            // 
            this.lst_uoc.FormattingEnabled = true;
            this.lst_uoc.ItemHeight = 16;
            this.lst_uoc.Location = new System.Drawing.Point(21, 28);
            this.lst_uoc.Name = "lst_uoc";
            this.lst_uoc.ScrollAlwaysVisible = true;
            this.lst_uoc.Size = new System.Drawing.Size(275, 228);
            this.lst_uoc.TabIndex = 0;
            this.lst_uoc.SelectedIndexChanged += new System.EventHandler(this.uocso_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_tonguoc
            // 
            this.btn_tonguoc.Location = new System.Drawing.Point(464, 343);
            this.btn_tonguoc.Name = "btn_tonguoc";
            this.btn_tonguoc.Size = new System.Drawing.Size(269, 31);
            this.btn_tonguoc.TabIndex = 3;
            this.btn_tonguoc.Text = "Tổng ước";
            this.btn_tonguoc.UseVisualStyleBackColor = true;
            this.btn_tonguoc.Click += new System.EventHandler(this.btn_tonguoc_Click);
            // 
            // btn_souocchan
            // 
            this.btn_souocchan.Location = new System.Drawing.Point(464, 399);
            this.btn_souocchan.Name = "btn_souocchan";
            this.btn_souocchan.Size = new System.Drawing.Size(269, 31);
            this.btn_souocchan.TabIndex = 4;
            this.btn_souocchan.Text = "Số lượng ước số chẵn";
            this.btn_souocchan.UseVisualStyleBackColor = true;
            this.btn_souocchan.Click += new System.EventHandler(this.btn_souocchan_Click);
            // 
            // btn_uocnt
            // 
            this.btn_uocnt.Location = new System.Drawing.Point(465, 446);
            this.btn_uocnt.Name = "btn_uocnt";
            this.btn_uocnt.Size = new System.Drawing.Size(269, 31);
            this.btn_uocnt.TabIndex = 5;
            this.btn_uocnt.Text = "Số lượng ước các số nguyên tố";
            this.btn_uocnt.UseVisualStyleBackColor = true;
            this.btn_uocnt.Click += new System.EventHandler(this.btn_uocnt_Click);
            // 
            // uocso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 521);
            this.Controls.Add(this.btn_uocnt);
            this.Controls.Add(this.btn_souocchan);
            this.Controls.Add(this.btn_tonguoc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "uocso";
            this.Text = "Nguyễn Hữu Duy";
            this.Load += new System.EventHandler(this.uocso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nhap;
        private System.Windows.Forms.ComboBox cbo_so;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst_uoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_tonguoc;
        private System.Windows.Forms.Button btn_souocchan;
        private System.Windows.Forms.Button btn_uocnt;
    }
}