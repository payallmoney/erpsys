using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace erpsys
{
    public partial class main : Form
    {
        private login loginwin = new login();
        public main()
        {
            InitializeComponent();
        }


        protected override void WndProc(ref Message m)
        {
            const int WM_NCLBUTTONDBLCLK = 0x00A3;
            switch (m.Msg)
            {
                case WM_NCLBUTTONDBLCLK:
                    return;
            }
            base.WndProc(ref m);
        }

        private void main_Load(object sender, EventArgs e)
        {

            loginwin.Owner = this;
            loginwin.Show();
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       

    }
}
