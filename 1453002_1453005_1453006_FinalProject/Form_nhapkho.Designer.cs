namespace _1453002_1453005_1453006_FinalProject
{
    partial class Form_nhapkho
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
            this.btn_insert = new System.Windows.Forms.Button();
            this.edt_maphieunhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.datepicker_from = new System.Windows.Forms.DateTimePicker();
            this.datepicker_to = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.dgv_phieunhap = new System.Windows.Forms.DataGridView();
            this.maphieunhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhacungcap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieunhap)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(12, 12);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Text = "Thêm mới";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // edt_maphieunhap
            // 
            this.edt_maphieunhap.Location = new System.Drawing.Point(119, 75);
            this.edt_maphieunhap.Name = "edt_maphieunhap";
            this.edt_maphieunhap.Size = new System.Drawing.Size(100, 20);
            this.edt_maphieunhap.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhà cung cấp";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // datepicker_from
            // 
            this.datepicker_from.CustomFormat = "MM/dd/yyyy";
            this.datepicker_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker_from.Location = new System.Drawing.Point(119, 146);
            this.datepicker_from.Name = "datepicker_from";
            this.datepicker_from.Size = new System.Drawing.Size(199, 20);
            this.datepicker_from.TabIndex = 4;
            // 
            // datepicker_to
            // 
            this.datepicker_to.CustomFormat = "MM/dd/yyyy";
            this.datepicker_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker_to.Location = new System.Drawing.Point(413, 146);
            this.datepicker_to.Name = "datepicker_to";
            this.datepicker_to.Size = new System.Drawing.Size(199, 20);
            this.datepicker_to.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đến ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Từ ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã số phiếu";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(305, 194);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // dgv_phieunhap
            // 
            this.dgv_phieunhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phieunhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphieunhap,
            this.ngaynhap,
            this.tennv,
            this.thanhtien,
            this.nhacungcap});
            this.dgv_phieunhap.Location = new System.Drawing.Point(41, 242);
            this.dgv_phieunhap.Name = "dgv_phieunhap";
            this.dgv_phieunhap.Size = new System.Drawing.Size(571, 150);
            this.dgv_phieunhap.TabIndex = 10;
            this.dgv_phieunhap.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_phieunhap_CellDoubleClick);
            // 
            // maphieunhap
            // 
            this.maphieunhap.DataPropertyName = "maphieunhap";
            this.maphieunhap.HeaderText = "Mã phiếu nhập";
            this.maphieunhap.Name = "maphieunhap";
            // 
            // ngaynhap
            // 
            this.ngaynhap.DataPropertyName = "ngaynhap";
            this.ngaynhap.HeaderText = "Ngày nhập";
            this.ngaynhap.Name = "ngaynhap";
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "tennv";
            this.tennv.HeaderText = "Nhân viên";
            this.tennv.Name = "tennv";
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            // 
            // nhacungcap
            // 
            this.nhacungcap.DataPropertyName = "nhacungcap";
            this.nhacungcap.HeaderText = "Nhà cung cấp";
            this.nhacungcap.Name = "nhacungcap";
            // 
            // Form_nhapkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 497);
            this.Controls.Add(this.dgv_phieunhap);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datepicker_to);
            this.Controls.Add(this.datepicker_from);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edt_maphieunhap);
            this.Controls.Add(this.btn_insert);
            this.Name = "Form_nhapkho";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieunhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox edt_maphieunhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker datepicker_from;
        private System.Windows.Forms.DateTimePicker datepicker_to;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgv_phieunhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieunhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhacungcap;
    }
}