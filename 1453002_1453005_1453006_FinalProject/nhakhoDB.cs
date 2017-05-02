using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _1453002_1453005_1453006_FinalProject
{
    public class nhakhoDB
    {
        public static DataTable LayThongTinKho()
        {
            string q = "select makho,tenkho,mota from KHO";
            return DataProvider.query(q);
        }

        public static void ThemKho(nhakho kho)
        {
            string q = "insert into KHO(tenkho,mota) values(N'@TENKHO',N'@MOTA')";
            q = q.Replace("@TENKHO", kho.tenkho);
            q = q.Replace("@MOTA", kho.mota);

            DataProvider.query(q);
        }

        public static void XoaKho(int makho)
        {
            string q = "Delete from KHO where makho = '@MAKHO' ";

            q = q.Replace("@MAKHO", makho.ToString());

            DataProvider.query(q);
        }
        public static int KiemtraTontai(string tenkho)
        {
            int result = 0;
            string q = "select count(*) from KHO where tenkho = N'@TENKHO' ";
            q = q.Replace("@TENKHO", tenkho);

            result = int.Parse(DataProvider.query(q).Rows[0][0].ToString());

            return result;
        }

        public static void ChinhSuaKho(nhakho kho)
        {
            string q = "update KHO set tenkho = N'@TENKHO', mota = N'@MOTA' where makho = @MAKHO ";
            q = q.Replace("@TENKHO", kho.tenkho);
            q = q.Replace("@MOTA", kho.mota);
            q = q.Replace("@MAKHO", kho.makho.ToString());

            DataProvider.query(q);
        }
    }
}
