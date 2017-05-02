using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _1453002_1453005_1453006_FinalProject
{
    class nhanvien
    {
        private int _manv;
        private string _loainv;
        private string _tennv;
        private string _sdt;
        private string _cmnd;

        public static DataTable LayDSNhanVien()
        {
            return nhanvienDB.LayDSNhanVien();
        }

    }
}
