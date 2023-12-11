namespace WindowsFormsApp2
{
    partial class Luyen_tap_lstbox
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
            this.cbo_bao = new System.Windows.Forms.ComboBox();
            this.list_bao = new System.Windows.Forms.ListBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbo_bao
            // 
            this.cbo_bao.FormattingEnabled = true;
            this.cbo_bao.Items.AddRange(new object[] {
            "Tuổi trẻ",
            "Thanh Niên",
            "VNExpress",
            "Dân trí",
            "Công An"});
            this.cbo_bao.Location = new System.Drawing.Point(95, 64);
            this.cbo_bao.Name = "cbo_bao";
            this.cbo_bao.Size = new System.Drawing.Size(203, 24);
            this.cbo_bao.TabIndex = 0;
            // 
            // list_bao
            // 
            this.list_bao.FormattingEnabled = true;
            this.list_bao.ItemHeight = 16;
            this.list_bao.Location = new System.Drawing.Point(430, 66);
            this.list_bao.Name = "list_bao";
            this.list_bao.Size = new System.Drawing.Size(209, 164);
            this.list_bao.TabIndex = 1;
            this.list_bao.SelectedIndexChanged += new System.EventHandler(this.list_bao_SelectedIndexChanged);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(95, 284);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 2;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(270, 284);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Luyen_tap_lstbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.list_bao);
            this.Controls.Add(this.cbo_bao);
            this.Name = "Luyen_tap_lstbox";
            this.Text = "Luyen_tap_lstbox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_bao;
        private System.Windows.Forms.ListBox list_bao;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_reset;
    }
}