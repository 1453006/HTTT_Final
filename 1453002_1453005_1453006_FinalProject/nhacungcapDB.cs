using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace _1453002_1453005_1453006_FinalProject
{
    class nhacungcapDB
    {
        public static DataTable LayDSNhacungcap()
        {
            string q = "select * from NHACUNGCAP;";
             return DataProvider.query(q);
        }
    }
}
