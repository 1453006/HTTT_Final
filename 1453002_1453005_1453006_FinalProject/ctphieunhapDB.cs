using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1453002_1453005_1453006_FinalProject
{
    class ctphieunhapDB
    {

        public static void ThemCTPhieuNhap(List<ctphieunhap> ct)
        {
            
            for(int i = 0;i< ct.Count;i++)
            {
                string q = "insert into CTPHIEUNHAPKHO(maphieunhap,manguyenlieu,soluong,thanhtien)" +
                    " values('@MAPHIEUNHAP','@MANGUYENLIEU',@SOLUONG,@THANHTIEN)";
                q = q.Replace("@MAPHIEUNHAP", ct[i].maphienhap);
                q = q.Replace("@MANGUYENLIEU", ct[i].manguyenlieu.ToString());
                q = q.Replace("@SOLUONG", ct[i].soluong.ToString());
                q = q.Replace("@THANHTIEN", ct[i].thanhtien.ToString());

                DataProvider.query(q);
            }
        }
    }
}
