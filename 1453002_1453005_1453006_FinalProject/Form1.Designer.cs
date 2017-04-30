namespace _1453002_1453005_1453006_FinalProject
{
    partial class Form1
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
            this.tabctl_main = new System.Windows.Forms.TabControl();
            this.tabfrm_qlikho = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_nhapkho = new System.Windows.Forms.Button();
            this.btn_xuatkho = new System.Windows.Forms.Button();
            this.btn_tonkho = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_nhakho = new System.Windows.Forms.Button();
            this.btn_loaisp = new System.Windows.Forms.Button();
            this.btn_nhacungcap = new System.Windows.Forms.Button();
            this.tabctl_qlkho = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabctl_main.SuspendLayout();
            this.tabfrm_qlikho.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabctl_main
            // 
            this.tabctl_main.Controls.Add(this.tabfrm_qlikho);
            this.tabctl_main.Controls.Add(this.tabPage2);
            this.tabctl_main.Location = new System.Drawing.Point(12, 12);
            this.tabctl_main.Name = "tabctl_main";
            this.tabctl_main.SelectedIndex = 0;
            this.tabctl_main.Size = new System.Drawing.Size(791, 380);
            this.tabctl_main.TabIndex = 1;
            this.tabctl_main.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            // 
            // tabfrm_qlikho
            // 
            this.tabfrm_qlikho.Controls.Add(this.groupBox2);
            this.tabfrm_qlikho.Controls.Add(this.groupBox1);
            this.tabfrm_qlikho.Controls.Add(this.tabctl_qlkho);
            this.tabfrm_qlikho.Location = new System.Drawing.Point(4, 22);
            this.tabfrm_qlikho.Name = "tabfrm_qlikho";
            this.tabfrm_qlikho.Padding = new System.Windows.Forms.Padding(3);
            this.tabfrm_qlikho.Size = new System.Drawing.Size(783, 354);
            this.tabfrm_qlikho.TabIndex = 0;
            this.tabfrm_qlikho.Text = "Quản lí kho";
            this.tabfrm_qlikho.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_nhapkho);
            this.groupBox2.Controls.Add(this.btn_xuatkho);
            this.groupBox2.Controls.Add(this.btn_tonkho);
            this.groupBox2.Location = new System.Drawing.Point(8, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 112);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lí";
            // 
            // btn_nhapkho
            // 
            this.btn_nhapkho.Location = new System.Drawing.Point(15, 19);
            this.btn_nhapkho.Name = "btn_nhapkho";
            this.btn_nhapkho.Size = new System.Drawing.Size(114, 23);
            this.btn_nhapkho.TabIndex = 1;
            this.btn_nhapkho.Text = "Nhập kho";
            this.btn_nhapkho.UseVisualStyleBackColor = true;
            this.btn_nhapkho.Click += new System.EventHandler(this.btn_nhapkho_Click);
            // 
            // btn_xuatkho
            // 
            this.btn_xuatkho.Location = new System.Drawing.Point(15, 48);
            this.btn_xuatkho.Name = "btn_xuatkho";
            this.btn_xuatkho.Size = new System.Drawing.Size(114, 23);
            this.btn_xuatkho.TabIndex = 2;
            this.btn_xuatkho.Text = "Xuất kho";
            this.btn_xuatkho.UseVisualStyleBackColor = true;
            this.btn_xuatkho.Click += new System.EventHandler(this.btn_xuatkho_Click);
            // 
            // btn_tonkho
            // 
            this.btn_tonkho.Location = new System.Drawing.Point(15, 77);
            this.btn_tonkho.Name = "btn_tonkho";
            this.btn_tonkho.Size = new System.Drawing.Size(114, 23);
            this.btn_tonkho.TabIndex = 3;
            this.btn_tonkho.Text = "Tồn kho";
            this.btn_tonkho.UseVisualStyleBackColor = true;
            this.btn_tonkho.Click += new System.EventHandler(this.btn_tonkho_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_nhakho);
            this.groupBox1.Controls.Add(this.btn_loaisp);
            this.groupBox1.Controls.Add(this.btn_nhacungcap);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 112);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục";
            // 
            // btn_nhakho
            // 
            this.btn_nhakho.Location = new System.Drawing.Point(15, 19);
            this.btn_nhakho.Name = "btn_nhakho";
            this.btn_nhakho.Size = new System.Drawing.Size(114, 23);
            this.btn_nhakho.TabIndex = 1;
            this.btn_nhakho.Text = "Nhà kho";
            this.btn_nhakho.UseVisualStyleBackColor = true;
            this.btn_nhakho.Click += new System.EventHandler(this.btn_nhakho_Click);
            // 
            // btn_loaisp
            // 
            this.btn_loaisp.Location = new System.Drawing.Point(15, 48);
            this.btn_loaisp.Name = "btn_loaisp";
            this.btn_loaisp.Size = new System.Drawing.Size(114, 23);
            this.btn_loaisp.TabIndex = 2;
            this.btn_loaisp.Text = "Loại SP";
            this.btn_loaisp.UseVisualStyleBackColor = true;
            this.btn_loaisp.Click += new System.EventHandler(this.btn_loaisp_Click);
            // 
            // btn_nhacungcap
            // 
            this.btn_nhacungcap.Location = new System.Drawing.Point(15, 77);
            this.btn_nhacungcap.Name = "btn_nhacungcap";
            this.btn_nhacungcap.Size = new System.Drawing.Size(114, 23);
            this.btn_nhacungcap.TabIndex = 3;
            this.btn_nhacungcap.Text = "Nhà cung cấp";
            this.btn_nhacungcap.UseVisualStyleBackColor = true;
            this.btn_nhacungcap.Click += new System.EventHandler(this.btn_nhacungcap_Click);
            // 
            // tabctl_qlkho
            // 
            this.tabctl_qlkho.Location = new System.Drawing.Point(155, 0);
            this.tabctl_qlkho.Name = "tabctl_qlkho";
            this.tabctl_qlkho.SelectedIndex = 0;
            this.tabctl_qlkho.Size = new System.Drawing.Size(625, 316);
            this.tabctl_qlkho.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(783, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 433);
            this.Controls.Add(this.tabctl_main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.tabctl_main.ResumeLayout(false);
            this.tabfrm_qlikho.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabctl_main;
        private System.Windows.Forms.TabPage tabfrm_qlikho;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_nhapkho;
        private System.Windows.Forms.Button btn_xuatkho;
        private System.Windows.Forms.Button btn_tonkho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_nhakho;
        private System.Windows.Forms.Button btn_loaisp;
        private System.Windows.Forms.Button btn_nhacungcap;
        private System.Windows.Forms.TabControl tabctl_qlkho;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

