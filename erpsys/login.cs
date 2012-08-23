using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace erpsys
{
    public partial class login : Form
    {
        public login()
        {
            
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCLBUTTONDBLCLK = 0x00A3;
            Debug.WriteLine(m.Msg);
            switch (m.Msg)
            {                  
                case WM_NCLBUTTONDBLCLK:
                    return;
            }
            base.WndProc(ref m);
        }

        private void login_Load(object sender, EventArgs e)
        {
            Owner.Hide();
            //测试
            panel1.Left = (this.Width-panel1.Width)/2;
            panel1.Top = (this.Height - panel1.Height) / 2 - 50;
            panel1.Visible = true;

            panel2.Left = (this.Width - panel2.Width) / 2;
            panel2.Top = (this.Height - panel2.Height) / 2 - 300;
            panel2.Visible = true;
            

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = erpsys.Properties.Resources.bt1;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = erpsys.Properties.Resources.bt;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = erpsys.Properties.Resources.bt_exit_1;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = erpsys.Properties.Resources.bt_exit;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Owner.ShowInTaskbar = true;
            this.Hide();
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void login_Paint(object sender, PaintEventArgs e)
        {
            Graphics gf = Graphics.FromHwnd(this.Handle);
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(160, 191, 209));
            Point point1 = new Point(panel1.Left, panel1.Top + 20);
            Point point2 = new Point(panel1.Left - 30, panel1.Top + 18);
            Point point3 = new Point(panel1.Left, panel1.Top + panel1.Height);
            Point[] curvePoints = { point1, point2, point3 };
            gf.FillPolygon(blueBrush, curvePoints);


            point1 = new Point(panel1.Left + panel1.Width, panel1.Top + 20);
            point2 = new Point(panel1.Left + panel1.Width + 30, panel1.Top + 18);
            point3 = new Point(panel1.Left + panel1.Width, panel1.Top + panel1.Height);
            Point[] curvePoints1 = { point1, point2, point3 };
            gf.FillPolygon(blueBrush, curvePoints1,System.Drawing.Drawing2D.FillMode.Winding);
            
        }

    }
}
