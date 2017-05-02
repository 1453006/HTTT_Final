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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //full screen when start project
            System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
            this.MaximizedBounds = Screen.GetWorkingArea(this);
            this.WindowState = FormWindowState.Maximized;
        }

        //purpose: check if clicked tab is opened or not, if is opened --> return true | else return false
        public static bool is_existstab(TabControl tabctl, Form frm)
        {

            for (int i = 0; i < tabctl.TabCount; i++)
            {
                if (tabctl.TabPages[i].Text.Trim().ToString() == frm.Text.Trim().ToString())
                {
                    return true;
                }
            }
            return false;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            tabctl_main.Width = this.Width - 20;
            tabctl_main.Height = this.Height - 20;

            tabctl_qlkho.Width = this.Width - 190;
            tabctl_qlkho.Height = this.Width - 50;
        }

        private void btn_nhakho_Click(object sender, EventArgs e)
        {
            //clear all tab before open new tab
            tabctl_qlkho.TabPages.Clear();
            Form_nhakho frm = new Form_nhakho();
            //alway check before open tab
            if (!is_existstab(tabctl_qlkho, frm))
            {
                TabPage tpage = new TabPage(Text = frm.Text);
                this.tabctl_qlkho.TabPages.Add(tpage);
                frm.TopLevel = false;
                frm.Parent = tpage;

                frm.Show();
                frm.Dock = DockStyle.Fill;
            }

        }

        public void insertTab_nhapkho()
        {
            tabctl_qlkho.TabPages.Clear();
            Form_loaisp frm = new Form_loaisp();
            if (!is_existstab(tabctl_qlkho, frm))
            {
                TabPage tpage = new TabPage(Text = frm.Text);
                this.tabctl_qlkho.TabPages.Add(tpage);
                frm.TopLevel = false;
                frm.Parent = tpage;

                frm.Show();
                frm.Dock = DockStyle.Fill;
            }
        }
        private void btn_loaisp_Click(object sender, EventArgs e)
        {
            tabctl_qlkho.TabPages.Clear();
            Form_loaisp frm = new Form_loaisp();
            if (!is_existstab(tabctl_qlkho, frm))
            {
                TabPage tpage = new TabPage(Text = frm.Text);
                this.tabctl_qlkho.TabPages.Add(tpage);
                frm.TopLevel = false;
                frm.Parent = tpage;

                frm.Show();
                frm.Dock = DockStyle.Fill;
            }
        }

        private void btn_nhacungcap_Click(object sender, EventArgs e)
        {
            tabctl_qlkho.TabPages.Clear();
            Form_nhacungcap frm = new Form_nhacungcap();
            if (!is_existstab(tabctl_qlkho, frm))
            {
                TabPage tpage = new TabPage(Text = frm.Text);
                this.tabctl_qlkho.TabPages.Add(tpage);
                frm.TopLevel = false;
                frm.Parent = tpage;

                frm.Show();
                frm.Dock = DockStyle.Fill;
            }
        }

        private void btn_nhapkho_Click(object sender, EventArgs e)
        {
            tabctl_qlkho.TabPages.Clear();
            Form_nhapkho frm = new Form_nhapkho(this.tabctl_qlkho);
            if (!is_existstab(tabctl_qlkho, frm))
            {
                TabPage tpage = new TabPage(Text = frm.Text);
                this.tabctl_qlkho.TabPages.Add(tpage);
                frm.TopLevel = false;
                frm.Parent = tpage;

                frm.Show();
                frm.Dock = DockStyle.Fill;
            }
        }

        private void btn_xuatkho_Click(object sender, EventArgs e)
        {
            tabctl_qlkho.TabPages.Clear();
            Form_xuatkho frm = new Form_xuatkho();
            if (!is_existstab(tabctl_qlkho, frm))
            {
                TabPage tpage = new TabPage(Text = frm.Text);
                this.tabctl_qlkho.TabPages.Add(tpage);
                frm.TopLevel = false;
                frm.Parent = tpage;

                frm.Show();
                frm.Dock = DockStyle.Fill;
            }
        }

        private void btn_tonkho_Click(object sender, EventArgs e)
        {
            tabctl_qlkho.TabPages.Clear();
            Form_tonkho frm = new Form_tonkho();
            if (!is_existstab(tabctl_qlkho, frm))
            {
                TabPage tpage = new TabPage(Text = frm.Text);
                this.tabctl_qlkho.TabPages.Add(tpage);
                frm.TopLevel = false;
                frm.Parent = tpage;

                frm.Show();
                frm.Dock = DockStyle.Fill;
            }
        }

       
    }
}
