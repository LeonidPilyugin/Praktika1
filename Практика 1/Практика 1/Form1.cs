using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_1
{
    public partial class Form1 : Form
    {
        private bool b;
        private bool start;
        private Point startp;
        private Point[] p;
        private int a;
        public Form1()
        {
            start = true;
            b = true;
            p = new Point[3];
            startp = new Point(Height/2, Width/2);
            a = 1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start = false;
            b = true;
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (!start)
            {
                if (b)
                    a++;
                p[0].Y = startp.Y + a;
                p[1].X = startp.X - a;
                p[2].X = startp.X + a;
                e.Graphics.FillPolygon(new SolidBrush(Color.Khaki), p);
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            startp = new Point(Height / 2, Width / 2);
            b = false;
            Invalidate();
        }
    }
}
