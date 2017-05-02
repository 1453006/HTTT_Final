using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _1453002_1453005_1453006_FinalProject
{
    public class nhakho
    {
        private int _makho;
        private string _tenkho;
        private string _mota;

        public int makho
        {
            get { return _makho; }
            set { this._makho = value; }
        }
        public string tenkho
        {
            get { return _tenkho; }
            set { this._tenkho = value; }
        }
        public string mota
        {
            get { return _mota; }
            set { this._mota = value; }
        }

        public static DataTable LayThongTinKho()
        {
           
            return  nhakhoDB.LayThongTinKho();
        }

        public bool ThemKho()
        {
            //Kiểm tra tồn tại

            if( nhakhoDB.KiemtraTontai(_tenkho) == 0)
            {
                //chưa có 
          
                  nhakhoDB.ThemKho(this);
                 return true;
 
            }
            else
            {
                return false;
            }

        }

        public void XoaKho()
        {
            nhakhoDB.XoaKho(this.makho);
        }
        public void ChinhSuaKho()
        {
            nhakhoDB.ChinhSuaKho(this);
        }
    }
}
