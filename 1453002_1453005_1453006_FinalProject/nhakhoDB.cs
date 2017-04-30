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
    }
}
