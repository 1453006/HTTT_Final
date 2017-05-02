using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace _1453002_1453005_1453006_FinalProject
{
    class nguyenlieuDB
    {
        public static DataTable LayDSNguyenLieuTheoNCC(string manhacungcap)
        {
            string q = "SELECT * FROM NGUYENLIEU WHERE manhacungcap = @MANHACUNGCAP ";
            q = q.Replace("@MANHACUNGCAP", manhacungcap);

            return DataProvider.query(q);
        }
        public static string Laydonvi(string manguyenlieu)
        {
            string q = "SELECT DONVI.tendonvi, NGUYENLIEU.manguyenlieu FROM NGUYENLIEU left join DONVI on NGUYENLIEU.madonvi = DONVI.madonvi WHERE manguyenlieu = '@MANGUYENLIEU' ";
            q = q.Replace("@MANGUYENLIEU", manguyenlieu);

            return (string)DataProvider.query(q).Rows[0][0];
        }
    }
}
