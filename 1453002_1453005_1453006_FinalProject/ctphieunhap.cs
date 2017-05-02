using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1453002_1453005_1453006_FinalProject
{
    class ctphieunhap
    {
        private int _mactphieunhap;
        private string _maphienhap;
        private int _manguyenlieu;
        private int _soluong;
        private float _thanhtien;

        public int mactphieunhap
        {
            get { return _mactphieunhap; }
            set { _mactphieunhap = value; }
        }

        public string maphienhap
        {
            get { return _maphienhap; }
            set { _maphienhap = value; }
        }

        public int manguyenlieu
        {
            get { return _manguyenlieu; }
            set { _manguyenlieu = value; }
        }

        public int soluong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }

        public float thanhtien
        {
            get { return _thanhtien; }
            set { _thanhtien = value; }
        }

        public void ThemCTPhieuNhap(List<ctphieunhap> a)
        {
            ctphieunhapDB.ThemCTPhieuNhap(a);
        }
    }
}
