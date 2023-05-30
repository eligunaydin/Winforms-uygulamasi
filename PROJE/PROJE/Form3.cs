using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE
{
    // Çember-Çember çarpışması
    public partial class Form3 : Form
    {
        Rectangle c1;
        Rectangle c2;
        Rectangle centre1;
        Rectangle centre2;
        circle circle1 = new circle();
        circle circle2 = new circle();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            circle1.M.x = 100;
            circle1.M.y= 100;
            circle1.R = 40;
            circle2.M.x = 0;
            circle2.M.y=0;
            circle2.R = 50;
            c1 = new Rectangle(circle1.M.x, circle1.M.y, 80, 100);
            c2 = new Rectangle(circle2.M.x, circle2.M.y, 100, 100);
            centre1 = new Rectangle((circle1.M.x + 40 - 2), (circle1.M.y + 40 - 2), 4, 4);
            centre2 = new Rectangle();
        }
        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            circle2.M.x = e.X - 50;
            circle2.M.y = e.Y - 50;
            c2 = new Rectangle(circle2.M.x, circle2.M.y, 100, 100);
            centre2 = new Rectangle((e.X - 4), (e.Y - 4), 8, 8);
            carpisma.circleCarp(circle1, circle2);
            Invalidate();
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.HotPink, c1);
            e.Graphics.FillEllipse(Brushes.LightSkyBlue, c2);
            e.Graphics.FillEllipse(Brushes.DarkOrange, centre1);
            e.Graphics.FillEllipse(Brushes.DarkOrange, centre2);
            e.Graphics.DrawLine(Pens.Lime, (circle1.M.x + 40), (circle1.M.y + 40), (circle2.M.x + 50), (circle2.M.y + 50));
        }
    }
}
