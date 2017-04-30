using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1453002_1453005_1453006_FinalProject
{
    public partial class Form_nhakho : Form
    {
        private void LayThongTinKho()
        {
           
            this.dgv_nhakho.DataSource = nhakho.LayThongTinKho();

        }
        public Form_nhakho()
        {
            InitializeComponent();
            LayThongTinKho();


        }
    }
}
