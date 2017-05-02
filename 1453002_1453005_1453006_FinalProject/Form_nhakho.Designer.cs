namespace _1453002_1453005_1453006_FinalProject
{
    partial class Form_nhakho
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
            this.dgv_nhakho = new System.Windows.Forms.DataGridView();
            this.makho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edt_makho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_tenkho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edt_mota = new System.Windows.Forms.TextBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhakho)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_nhakho
            // 
            this.dgv_nhakho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhakho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makho,
            this.tenkho,
            this.mota});
            this.dgv_nhakho.Location = new System.Drawing.Point(0, 146);
            this.dgv_nhakho.Name = "dgv_nhakho";
            this.dgv_nhakho.Size = new System.Drawing.Size(698, 184);
            this.dgv_nhakho.TabIndex = 0;
            this.dgv_nhakho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhakho_CellClick);
            // 
            // makho
            // 
            this.makho.DataPropertyName = "makho";
            this.makho.HeaderText = "Mã Kho";
            this.makho.Name = "makho";
            // 
            // tenkho
            // 
            this.tenkho.DataPropertyName = "tenkho";
            this.tenkho.HeaderText = "Tên Kho";
            this.tenkho.Name = "tenkho";
            // 
            // mota
            // 
            this.mota.DataPropertyName = "mota";
            this.mota.HeaderText = "Mô Tả";
            this.mota.Name = "mota";
            // 
            // edt_makho
            // 
            this.edt_makho.Location = new System.Drawing.Point(82, 40);
            this.edt_makho.Name = "edt_makho";
            this.edt_makho.ReadOnly = true;
            this.edt_makho.Size = new System.Drawing.Size(100, 20);
            this.edt_makho.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Kho";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(25, 117);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Kho";
            // 
            // edt_tenkho
            // 
            this.edt_tenkho.Location = new System.Drawing.Point(82, 75);
            this.edt_tenkho.Name = "edt_tenkho";
            this.edt_tenkho.Size = new System.Drawing.Size(100, 20);
            this.edt_tenkho.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mô Tả";
            // 
            // edt_mota
            // 
            this.edt_mota.Location = new System.Drawing.Point(252, 40);
            this.edt_mota.Name = "edt_mota";
            this.edt_mota.Size = new System.Drawing.Size(100, 20);
            this.edt_mota.TabIndex = 6;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(135, 117);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 8;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(252, 117);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // Form_nhakho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 353);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edt_mota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edt_tenkho);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edt_makho);
            this.Controls.Add(this.dgv_nhakho);
            this.Name = "Form_nhakho";
            this.Text = "Form_nhakho";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhakho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_nhakho;
        private System.Windows.Forms.DataGridViewTextBoxColumn makho;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn mota;
        private System.Windows.Forms.TextBox edt_makho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edt_tenkho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edt_mota;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
    }
}