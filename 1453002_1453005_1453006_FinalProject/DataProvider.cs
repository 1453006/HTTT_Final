using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _1453002_1453005_1453006_FinalProject
{
   public class DataProvider
    {
        public static string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB_HUONGRUNG.mdf;Integrated Security=True";


        SqlConnection con;
        DataTable dt;
        SqlDataAdapter da;
        SqlCommand cmd;

        public SqlConnection open()
        {
            con = new SqlConnection(connectionstring);
            if (con.State == ConnectionState.Closed) // nwe đag đóng thì mở
            {
                con.Open();

            }
            return con;
        }

        public SqlConnection close()
        {
            con = new SqlConnection(connectionstring);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            return con;
        }

        public DataTable query(string sql)
        {
            open();
            dt = new DataTable();
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            close();
            return dt;

        }


        protected virtual object GetDataFromDataRow(DataTable dt, int i)
        {
            return null;
        }


    }
}
