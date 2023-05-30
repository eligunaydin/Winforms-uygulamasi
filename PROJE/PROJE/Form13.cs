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
    // Nokta-Dikdörtgen çarpışması
    public partial class Form13 : Form
    {
        Rectangle rect;
        Rectangle rect2;
        Rectangle centre1;
        Rectangle centre2;
        circle circle = new circle();
        dikdortgen dikdortgen = new dikdortgen();
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            circle.M.x = 200;
            circle.M.y = 200;
            circle.R = 15;
            dikdortgen.M.x = 100;
            dikdortgen.M.y = 100;
            dikdortgen.En = 50;
            dikdortgen.Boy = 100;
            rect2 = new Rectangle(circle.M.x, circle.M.y, 80, 100);
            rect = new Rectangle(dikdortgen.M.x, dikdortgen.M.y, dikdortgen.En, dikdortgen.Boy);
            centre1 = new Rectangle((circle.M.x + 40), (circle.M.y + 50), 4, 4);
            centre2 = new Rectangle();
        }

        private void Form13_MouseMove(object sender, MouseEventArgs e)     //Mouse hareketi
        {
            dikdortgen.M.x = e.X - 25;
            dikdortgen.M.y = e.Y - 50;
            rect = new Rectangle(dikdortgen.M.x, dikdortgen.M.y, dikdortgen.En, dikdortgen.Boy);
            centre2 = new Rectangle((e.X - 4), (e.Y - 4), 8, 8);
            carpisma.circledikdortgenCarp(circle, dikdortgen);
            Invalidate();          // Denetimin belirli bir bölgesini geçersiz kılıp denetime bir boya iletisi gönderilmesini sağlar.
        }

        private void Form13_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.BlueViolet, rect2);
            e.Graphics.FillEllipse(Brushes.DarkOrange, centre1);
            e.Graphics.FillEllipse(Brushes.DarkOrange, centre2);
            e.Graphics.DrawLine(Pens.Lime, (circle.M.x + 40), (circle.M.y + 50), (dikdortgen.M.x + 25), (dikdortgen.M.y + 50));
        }
    }
}
