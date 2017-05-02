using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace _1453002_1453005_1453006_FinalProject
{
    public class nguyenlieu
    {
        public static DataTable LayDSNLTheoNCC(string manhacungcap)
        {
            return nguyenlieuDB.LayDSNguyenLieuTheoNCC(manhacungcap);
        }

        public static string Laydonvi(string manguyenlieu)
        {
            return nguyenlieuDB.Laydonvi(manguyenlieu);
        }
    }
}
