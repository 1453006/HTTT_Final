using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace _1453002_1453005_1453006_FinalProject
{
    class nhanvienDB
    {
        public static DataTable LayDSNhanVien()
        {
            string q = "select manv, LOAINV.tenloai , tennv, sdt, cmnd from NHANVIEN left join LOAINV on NHANVIEN.maloainv = LOAINV.maloai;";
            return DataProvider.query(q);
        }
    }
}
