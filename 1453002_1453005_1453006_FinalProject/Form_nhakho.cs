using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1453002_1453005_1453006_FinalProject
{
    public partial class Form_nhakho : Form
    {

        private void getInfo(ref nhakho kho)
        {
           
                kho.makho = int.Parse(this.edt_makho.Text.ToString());
                kho.tenkho = this.edt_tenkho.Text;
                kho.mota = this.edt_mota.Text;
           
        }
        private void SetInfo(int index)
        {
            this.edt_makho.Text = this.dgv_nhakho.Rows[index].Cells["makho"].Value.ToString();
            this.edt_tenkho.Text = this.dgv_nhakho.Rows[index].Cells["tenkho"].Value.ToString();
            this.edt_mota.Text = this.dgv_nhakho.Rows[index].Cells["mota"].Value.ToString();
        }
        private void emptyField()
        {
            edt_makho.Text = "";
            edt_tenkho.Text = "";
            edt_mota.Text = "";
        }
        private void LayThongTinKho()
        {
           
            this.dgv_nhakho.DataSource = nhakho.LayThongTinKho();

        }
        
        private void ThemKho()
        {
            try
            {
                nhakho kho = new nhakho();
                getInfo(ref kho);

                if(!kho.ThemKho())
                {
                    MessageBox.Show("Kho đã tồn tại!!!");
                }
                LayThongTinKho();
                emptyField();
            }
            catch(Exception)
            {
                MessageBox.Show("Không thể thêm!!!");
            }
        }
        public Form_nhakho()
        {
            InitializeComponent();
            LayThongTinKho();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            this.edt_makho.Text = "1";
            ThemKho();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                nhakho kho = new nhakho();
                getInfo(ref kho);

                kho.ChinhSuaKho();
                LayThongTinKho();
                emptyField();
            }catch(Exception)
            {
                MessageBox.Show("Không thể sửa!!!");
            }
        }

        private void dgv_nhakho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in this.dgv_nhakho.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
            int index = this.dgv_nhakho.CurrentCell.RowIndex;
            this.dgv_nhakho.Rows[index].DefaultCellStyle.BackColor = Color.Yellow;
            SetInfo(index);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                nhakho kho = new nhakho();
                getInfo(ref kho);

                kho.XoaKho();
                LayThongTinKho();
                emptyField();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể Xóa!!!");
            }
        }
    }
}
