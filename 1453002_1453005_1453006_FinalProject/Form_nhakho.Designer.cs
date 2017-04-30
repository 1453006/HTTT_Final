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
            this.dgv_nhakho.Location = new System.Drawing.Point(0, 65);
            this.dgv_nhakho.Name = "dgv_nhakho";
            this.dgv_nhakho.Size = new System.Drawing.Size(546, 184);
            this.dgv_nhakho.TabIndex = 0;
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
            // Form_nhakho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 261);
            this.Controls.Add(this.dgv_nhakho);
            this.Name = "Form_nhakho";
            this.Text = "Form_nhakho";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhakho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_nhakho;
        private System.Windows.Forms.DataGridViewTextBoxColumn makho;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn mota;
    }
}