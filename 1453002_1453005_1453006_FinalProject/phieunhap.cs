using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _1453002_1453005_1453006_FinalProject
{
    class phieunhap
    {
        private string _maphieunhap;
        private string _ngaynhap;
        private int _manv;
        private float _thanhtien;
        private int _manhacungcap;

        public string maphieunhap
        {
            get { return _maphieunhap; }
            set { _maphieunhap = value; }
        }
        public string ngaynhap
        {
            get { return _ngaynhap; }
            set { _ngaynhap = value; }
        }
        public int manv
        {
            get { return _manv; }
            set { _manv = value; }
        }
        public float thanhtien
        {
            get { return _thanhtien; }
            set { _thanhtien = value; }
        }
        public int manhacungcap
        {
            get { return _manhacungcap; }
            set { _manhacungcap = value; }
        }

        public void taoMaphieunhap()
        {
            DateTime currentDate = DateTime.UtcNow.Date;
            currentDate.ToString("dd/MM/yyyy");

        }

        public static DataTable LayThongTinPhieuNhap(string maphieunhap)
        {
            return phieunhapDB.LayThongTinPhieuNhap(maphieunhap);
        }

        public static DataTable LayDSPhieuNhap()
        {
            return phieunhapDB.LayDSPhieuNhap();
        }

        public void ThemPhieuNhap()
        {
            phieunhapDB.ThemPhieuNhap(this);
        }

        public void XoaPhieuNhap()
        {

        }

        public void SuaPhieuNhap()
        {

        }
        
    }

}
