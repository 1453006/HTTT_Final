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
    public partial class Form_nhapkho : Form
    {
        TabControl tabcontrol = null;
        public Form_nhapkho(TabControl tab)
        {
            InitializeComponent();
            tabcontrol = (TabControl)tab;


            this.datepicker_to.CustomFormat = "dd-MM-yyyy";
            this.datepicker_from.CustomFormat = "dd-MM-yyyy";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            
            Form_nhapkho_insert frm = new Form_nhapkho_insert();
            if (!Form1.is_existstab(tabcontrol, frm))
            {
                TabPage tpage = new TabPage(Text = frm.Text);
                this.tabcontrol.TabPages.Add(tpage);
                frm.TopLevel = false;
                frm.Parent = tpage;

                frm.Show();
                frm.Dock = DockStyle.Fill;
            }

        }
    }
}
