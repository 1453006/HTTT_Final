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
    public partial class Form_ctphieunhap : Form
    {
       

        private string _maphieunhap = "FN";
        private DataTable listNL;

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyMMddfff");
        }

        public Form_ctphieunhap()
        {
            InitializeComponent();

            //default for number
            this.edt_soluong.Text = "0";
            this.edt_thanhtien.Text = "0";
            this.edt_tongtien.Text = "0";

            String timeStamp = GetTimestamp(DateTime.Now);
            _maphieunhap += timeStamp;
            this.edt_maphieunhap.Text = _maphieunhap;

            LoadDBInfo();

        }

        private void LoadPhieuNhapDetail(string maphieunhap)
        {


            DataTable table = phieunhap.LayThongTinPhieuNhap(maphieunhap);

            this.edt_maphieunhap.Text = table.Rows[0][0].ToString();

            this.datepicker_ngaynhap.Hide();
            this.cmb_nv.Text = table.Rows[0][2].ToString(); //nv
            this.edt_tongtien.Text = table.Rows[0][3].ToString(); //tongtien
            this.cmb_nhacungcap.Text = table.Rows[0][4].ToString(); // nha cungcap

            this.group_ctpn.Hide();

        }

        public Form_ctphieunhap(string maphieunhap)
        {
            InitializeComponent();

            MessageBox.Show(maphieunhap);

            LoadPhieuNhapDetail(maphieunhap);

        }

        private void LoadDBInfo()
        {
           
            this.cmb_nv.DisplayMember = "tennv";
            this.cmb_nv.ValueMember = "manv";
            this.cmb_nv.DataSource = nhanvien.LayDSNhanVien();

            this.cmb_kho.DisplayMember = "tenkho";
            this.cmb_kho.ValueMember = "makho";
            this.cmb_kho.DataSource = nhakho.LayThongTinKho();

            this.cmb_nhacungcap.DisplayMember = "ten";
            this.cmb_nhacungcap.ValueMember = "manhacungcap";
            this.cmb_nhacungcap.DataSource = nhacungcap.LayDSNhacungcap();

    
        }

        private void datepicker_ngaynhap_ValueChanged(object sender, EventArgs e)
        {
            string value = datepicker_ngaynhap.Value.ToString("MMddyy");

            _maphieunhap = "FN";
            _maphieunhap += value;
            _maphieunhap += DataProvider.RandomString(3);
            this.edt_maphieunhap.Text = _maphieunhap;
        }

        private void getInfo(ref ctphieunhap pn)
        {
           
        }
       
        private void getInfoPN(ref phieunhap phieu)
        {
            phieu.maphieunhap = edt_maphieunhap.Text;
            phieu.ngaynhap = datepicker_ngaynhap.Value.ToString("MM/dd/yyyy");
            phieu.manv = int.Parse(cmb_nv.SelectedValue.ToString());
            phieu.thanhtien = float.Parse(edt_tongtien.Text.ToString());
            phieu.manhacungcap = int.Parse(cmb_nhacungcap.SelectedValue.ToString());
            


           
        }

        private void createListCTNHAP(ref List<ctphieunhap> list)
        {
            
            ctphieunhap ct = new ctphieunhap();
            ct.maphienhap = _maphieunhap;
            ct.soluong = int.Parse(this.edt_soluong.Text.ToString());
            ct.manguyenlieu = int.Parse(this.cmb_nguyenlieu.SelectedValue.ToString());
            ct.thanhtien = float.Parse(this.edt_soluong.Text.ToString()) * float.Parse(this.edt_thanhtien.Text.ToString());
            ct.mactphieunhap = -1; //auto

            list.Add(ct);

        }

        private void EmptyField()
        {
            edt_soluong.Text = "0";
            edt_thanhtien.Text = "0";
           
        }
        private void setRowInfo()
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();

                row.CreateCells(dgv_nhapkho_insert);

                row.Cells[0].Value = cmb_nguyenlieu.Text.ToString();
                row.Cells[1].Value = edt_donvi.Text;
                row.Cells[2].Value = edt_soluong.Text.ToString(); //sl
                row.Cells[3].Value = float.Parse(edt_thanhtien.Text) * float.Parse(edt_soluong.Text);
                dgv_nhapkho_insert.Rows.Add(row);

                //update tongtien
                float oldvalue = float.Parse(edt_tongtien.Text);
                float newvalue = oldvalue + float.Parse(edt_thanhtien.Text) * float.Parse(edt_soluong.Text);
                edt_tongtien.Text = newvalue.ToString();

            }
            catch(Exception)
            {
                MessageBox.Show("Nhap sai!!!! xin thu lai");
                EmptyField();
            }

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            setRowInfo();

            

        }

        private void cmb_nhacungcap_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dgv_nhapkho_insert.Rows.Clear();
            string value = this.cmb_nhacungcap.SelectedValue.ToString();
           
            this.cmb_nguyenlieu.DisplayMember = "ten";
            this.cmb_nguyenlieu.ValueMember = "manguyenlieu";
            listNL = _1453002_1453005_1453006_FinalProject.nguyenlieu.LayDSNLTheoNCC(value);
            this.cmb_nguyenlieu.DataSource = listNL;

        }

        private void cmb_nguyenlieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string manguyenlieu = cmb_nguyenlieu.SelectedValue.ToString();
            string donvi =  _1453002_1453005_1453006_FinalProject.nguyenlieu.Laydonvi(manguyenlieu);
            edt_donvi.Text = donvi;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            List<ctphieunhap> list = new List<ctphieunhap>();
            createListCTNHAP(ref list);

            phieunhap pn = new phieunhap();
            getInfoPN(ref pn);
            pn.ThemPhieuNhap();

            ctphieunhap ctpn = new ctphieunhap();
            ctpn.ThemCTPhieuNhap(list);


        }
    }
}
