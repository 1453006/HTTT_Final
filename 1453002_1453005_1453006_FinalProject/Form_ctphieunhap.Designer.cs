namespace _1453002_1453005_1453006_FinalProject
{
    partial class Form_ctphieunhap
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
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_nhacungcap = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_nv = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_maphieunhap = new System.Windows.Forms.TextBox();
            this.dgv_nhapkho_insert = new System.Windows.Forms.DataGridView();
            this.nguyenlieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_nguyenlieu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edt_soluong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.edt_thanhtien = new System.Windows.Forms.TextBox();
            this.datepicker_ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.btn_insert = new System.Windows.Forms.Button();
            this.cmb_kho = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.edt_donvi = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.edt_tongtien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.group_ctpn = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhapkho_insert)).BeginInit();
            this.group_ctpn.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nhà cung cấp";
            // 
            // cmb_nhacungcap
            // 
            this.cmb_nhacungcap.FormattingEnabled = true;
            this.cmb_nhacungcap.Location = new System.Drawing.Point(98, 125);
            this.cmb_nhacungcap.Name = "cmb_nhacungcap";
            this.cmb_nhacungcap.Size = new System.Drawing.Size(121, 21);
            this.cmb_nhacungcap.TabIndex = 14;
            this.cmb_nhacungcap.SelectedIndexChanged += new System.EventHandler(this.cmb_nhacungcap_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nhân viên";
            // 
            // cmb_nv
            // 
            this.cmb_nv.FormattingEnabled = true;
            this.cmb_nv.Location = new System.Drawing.Point(96, 80);
            this.cmb_nv.Name = "cmb_nv";
            this.cmb_nv.Size = new System.Drawing.Size(121, 21);
            this.cmb_nv.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ngày nhập kho";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // edt_maphieunhap
            // 
            this.edt_maphieunhap.Location = new System.Drawing.Point(96, 6);
            this.edt_maphieunhap.Name = "edt_maphieunhap";
            this.edt_maphieunhap.Size = new System.Drawing.Size(100, 20);
            this.edt_maphieunhap.TabIndex = 8;
            // 
            // dgv_nhapkho_insert
            // 
            this.dgv_nhapkho_insert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhapkho_insert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nguyenlieu,
            this.donvi,
            this.soluong,
            this.thanhtien});
            this.dgv_nhapkho_insert.Location = new System.Drawing.Point(29, 263);
            this.dgv_nhapkho_insert.Name = "dgv_nhapkho_insert";
            this.dgv_nhapkho_insert.Size = new System.Drawing.Size(644, 150);
            this.dgv_nhapkho_insert.TabIndex = 16;
            // 
            // nguyenlieu
            // 
            this.nguyenlieu.HeaderText = "Nguyên Liệu";
            this.nguyenlieu.Name = "nguyenlieu";
            // 
            // donvi
            // 
            this.donvi.HeaderText = "Đơn vị";
            this.donvi.Name = "donvi";
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            // 
            // thanhtien
            // 
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            // 
            // cmb_nguyenlieu
            // 
            this.cmb_nguyenlieu.FormattingEnabled = true;
            this.cmb_nguyenlieu.Location = new System.Drawing.Point(88, 19);
            this.cmb_nguyenlieu.Name = "cmb_nguyenlieu";
            this.cmb_nguyenlieu.Size = new System.Drawing.Size(121, 21);
            this.cmb_nguyenlieu.TabIndex = 17;
            this.cmb_nguyenlieu.SelectedIndexChanged += new System.EventHandler(this.cmb_nguyenlieu_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nguyên liệu";
            // 
            // edt_soluong
            // 
            this.edt_soluong.Location = new System.Drawing.Point(88, 59);
            this.edt_soluong.Name = "edt_soluong";
            this.edt_soluong.Size = new System.Drawing.Size(100, 20);
            this.edt_soluong.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Gía mua";
            // 
            // edt_thanhtien
            // 
            this.edt_thanhtien.Location = new System.Drawing.Point(296, 56);
            this.edt_thanhtien.Name = "edt_thanhtien";
            this.edt_thanhtien.Size = new System.Drawing.Size(100, 20);
            this.edt_thanhtien.TabIndex = 21;
            // 
            // datepicker_ngaynhap
            // 
            this.datepicker_ngaynhap.CustomFormat = "MM/dd/yy";
            this.datepicker_ngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker_ngaynhap.Location = new System.Drawing.Point(98, 47);
            this.datepicker_ngaynhap.Name = "datepicker_ngaynhap";
            this.datepicker_ngaynhap.Size = new System.Drawing.Size(200, 20);
            this.datepicker_ngaynhap.TabIndex = 23;
            this.datepicker_ngaynhap.ValueChanged += new System.EventHandler(this.datepicker_ngaynhap_ValueChanged);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(437, 233);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 24;
            this.btn_insert.Text = "Thêm";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // cmb_kho
            // 
            this.cmb_kho.FormattingEnabled = true;
            this.cmb_kho.Location = new System.Drawing.Point(451, 50);
            this.cmb_kho.Name = "cmb_kho";
            this.cmb_kho.Size = new System.Drawing.Size(121, 21);
            this.cmb_kho.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Kho";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Don vi";
            // 
            // edt_donvi
            // 
            this.edt_donvi.Location = new System.Drawing.Point(296, 19);
            this.edt_donvi.Name = "edt_donvi";
            this.edt_donvi.ReadOnly = true;
            this.edt_donvi.Size = new System.Drawing.Size(100, 20);
            this.edt_donvi.TabIndex = 27;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(558, 234);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 29;
            this.btn_save.Text = "Luu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // edt_tongtien
            // 
            this.edt_tongtien.Location = new System.Drawing.Point(573, 434);
            this.edt_tongtien.Name = "edt_tongtien";
            this.edt_tongtien.ReadOnly = true;
            this.edt_tongtien.Size = new System.Drawing.Size(100, 20);
            this.edt_tongtien.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(515, 441);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Tong tien";
            // 
            // group_ctpn
            // 
            this.group_ctpn.Controls.Add(this.label9);
            this.group_ctpn.Controls.Add(this.edt_donvi);
            this.group_ctpn.Controls.Add(this.label7);
            this.group_ctpn.Controls.Add(this.edt_thanhtien);
            this.group_ctpn.Controls.Add(this.label6);
            this.group_ctpn.Controls.Add(this.edt_soluong);
            this.group_ctpn.Controls.Add(this.label5);
            this.group_ctpn.Controls.Add(this.cmb_nguyenlieu);
            this.group_ctpn.Location = new System.Drawing.Point(8, 162);
            this.group_ctpn.Name = "group_ctpn";
            this.group_ctpn.Size = new System.Drawing.Size(406, 94);
            this.group_ctpn.TabIndex = 32;
            this.group_ctpn.TabStop = false;
            // 
            // Form_nhapkho_insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 482);
            this.Controls.Add(this.group_ctpn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.edt_tongtien);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_kho);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.datepicker_ngaynhap);
            this.Controls.Add(this.dgv_nhapkho_insert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_nhacungcap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_nv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edt_maphieunhap);
            this.Name = "Form_nhapkho_insert";
            this.Text = "Form_nhapkho_insert";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhapkho_insert)).EndInit();
            this.group_ctpn.ResumeLayout(false);
            this.group_ctpn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_nhacungcap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_nv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edt_maphieunhap;
        private System.Windows.Forms.DataGridView dgv_nhapkho_insert;
        private System.Windows.Forms.ComboBox cmb_nguyenlieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edt_soluong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edt_thanhtien;
        private System.Windows.Forms.DateTimePicker datepicker_ngaynhap;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.ComboBox cmb_kho;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguyenlieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox edt_donvi;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox edt_tongtien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox group_ctpn;
    }
}