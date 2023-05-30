using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE
{
    // Dikdörtgen-Çember çarpışması
    public partial class Form14 : Form
    {
        Rectangle rect;
        Rectangle rect2;
        Rectangle centre1;
        Rectangle centre2;
        circle circle=new circle();
        dikdortgen dikdortgen = new dikdortgen();
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            circle.M.x = 200;
            circle.M.y = 200;
            circle.R = 40;
            dikdortgen.M.x = 100;
            dikdortgen.M.y = 100;
            dikdortgen.En = 50;
            dikdortgen.Boy = 100;
            rect2 = new Rectangle(circle.M.x, circle.M.y, 80, 100);
            rect = new Rectangle(dikdortgen.M.x, dikdortgen.M.y, dikdortgen.En, dikdortgen.Boy);
            centre1 = new Rectangle((circle.M.x + 40 - 2), (circle.M.y + 40 - 2), 4, 4);
            centre2 = new Rectangle();
        }

        private void Form14_MouseMove(object sender, MouseEventArgs e)
        {
            dikdortgen.M.x = e.X-25;
            dikdortgen.M.y = e.Y-50;
            rect = new Rectangle(dikdortgen.M.x, dikdortgen.M.y, dikdortgen.En, dikdortgen.Boy);
            centre2= new Rectangle((e.X),(e.Y),8,8);
            carpisma.circledikdortgenCarp(circle, dikdortgen);
            Invalidate();
        }

        private void Form14_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Purple,rect);
            e.Graphics.FillRectangle(Brushes.LightPink, rect2);
            e.Graphics.FillEllipse(Brushes.DarkOrange, centre1);
            e.Graphics.FillEllipse(Brushes.DarkOrange, centre2);
            e.Graphics.DrawLine(Pens.Lime, (circle.M.x + 40), (circle.M.y + 40), (dikdortgen.M.x + 25), (dikdortgen.M.y + 50));
        }
    }
}
