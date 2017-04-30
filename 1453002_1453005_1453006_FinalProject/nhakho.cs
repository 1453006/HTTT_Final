using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _1453002_1453005_1453006_FinalProject
{
    class nhakho
    {
        private int makho;
        private string tenkho;
        private string mota;

        public static DataTable LayThongTinKho()
        {
           
            return  nhakhoDB.LayThongTinKho();
        }
    }
}
