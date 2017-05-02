using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace _1453002_1453005_1453006_FinalProject
{
   
    class phieunhapDB
    {
        public static string dateformat = "dd/MM/yyyy";
        public static void ThemPhieuNhap(phieunhap info)
        {
            string q = "insert into PHIEUNHAPKHO(maphieunhap,ngaynhap,manv,thanhtien,manhacungcap) VALUES" +
                " ('@MAPHIEUNHAP','@NGAYNHAP','@MANV','@THANHTIEN','@MANHACUNGCAP');";
            q = q.Replace("@MAPHIEUNHAP", info.maphieunhap);
            q = q.Replace("@NGAYNHAP", info.ngaynhap.ToString());
            q = q.Replace("@MANV", info.manv.ToString());
            q = q.Replace("@THANHTIEN", info.thanhtien.ToString());
            q = q.Replace("@MANHACUNGCAP", info.manhacungcap.ToString());

            DataProvider.query(q);
        }
        public static DataTable LayThongTinPhieuNhap(string maphieunhap)
        {
            string q = "select maphieunhap,ngaynhap,NHANVIEN.tennv,thanhtien, NHACUNGCAP.ten as nhacungcap " +
                 " from PHIEUNHAPKHO left join NHANVIEN on NHANVIEN.manv = PHIEUNHAPKHO.manv left join NHACUNGCAP on NHACUNGCAP.manhacungcap = PHIEUNHAPKHO.manhacungcap where maphieunhap = '@MAPHIEUNHAP';";
            q = q.Replace("@MAPHIEUNHAP", maphieunhap);
            return DataProvider.query(q);
        }
        public static DataTable LayDSPhieuNhap()
        {
            string q = "select maphieunhap,ngaynhap,NHANVIEN.tennv,thanhtien, NHACUNGCAP.ten as nhacungcap "+
                 " from PHIEUNHAPKHO left join NHANVIEN on NHANVIEN.manv = PHIEUNHAPKHO.manv left join NHACUNGCAP on NHACUNGCAP.manhacungcap = PHIEUNHAPKHO.manhacungcap ;";
            return DataProvider.query(q);
        }

        public static void XoaPhieuNhap()
        {

        }

        public static void SuaPhieuNhap()
        {

        }
    }
}
