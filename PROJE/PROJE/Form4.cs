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
    //Nokta-Çember çarpışması
    public partial class Form4 : Form
    {
        Rectangle c1;
        Rectangle c2;
        Rectangle centre1;
        Rectangle centre2;
        circle circle1 = new circle();
        circle circle2 = new circle();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            circle1.M.x = 100;
            circle1.M.y = 100;
            circle1.R = 40;
            circle2.M.x = 0;
            circle2.M.y = 0;
            circle2.R = 5;
            c1 = new Rectangle(circle1.M.x, circle1.M.y, 80, 100);
            c2 = new Rectangle(circle2.M.x, circle2.M.y, 5, 5);
            centre1 = new Rectangle((circle1.M.x + 40), (circle1.M.y + 50), 4, 4);
            centre2 = new Rectangle();
        }

        private void Form4_MouseMove(object sender, MouseEventArgs e)    // Mouse hareketi
        {
            circle2.M.x = e.X - 50;
            circle2.M.y = e.Y - 50;
            c2 = new Rectangle(circle2.M.x, circle2.M.y, 100, 100);
            centre2 = new Rectangle((e.X - 4), (e.Y - 4), 8, 8);
            carpisma.circleCarp(circle1, circle2);
            Invalidate();             //Denetimin belirli bir bölgesini geçersiz kılıp denetime bir boya iletisi gönderilmesini sağlar.
        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.HotPink, c1);
            e.Graphics.FillEllipse(Brushes.DarkBlue, centre1);
            e.Graphics.FillEllipse(Brushes.DarkBlue, centre2);
            e.Graphics.DrawLine(Pens.Lime, (circle1.M.x + 40), (circle1.M.y + 50), (circle2.M.x + 50), (circle2.M.y + 50));
        }
    }
}
