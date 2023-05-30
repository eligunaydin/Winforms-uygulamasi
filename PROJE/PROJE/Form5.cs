using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE
{
    //Dikdörtgen-dikdörtgen çarpışması
    public partial class Form5 : Form
    {
        dikdortgen d1=new dikdortgen();
        dikdortgen d2 = new dikdortgen();
        Rectangle a;
        Rectangle b;
        Rectangle kosea;
        Rectangle koseb;
        public Form5()
        {
            InitializeComponent();
        }

        public void Form5_Load(object sender, EventArgs e)
        {
            d1.M.x = 100;
            d1.M.y = 100;
            d1.En = 37;
            d1.Boy = 37;
            d2.En = 50;
            d2.Boy = 50;
            a = new Rectangle(d1.M.x, d1.M.y, 80, 100);
            b = new Rectangle(d2.M.x, d2.M.y, 80, 100);
            kosea = new Rectangle((d1.M.x + 40), (d1.M.y + 50), 4, 4);
        }

        private void Form5_MouseMove(object sender, MouseEventArgs e)       // Mouse hareketi
        {
            d2.M.x = e.X - 50;
            d2.M.y = e.Y - 50;
            b = new Rectangle(d2.M.x, d2.M.y, 100, 100);
            koseb = new Rectangle((e.X - 4), (e.Y - 4), 8, 8);
            carpisma.dikdortgenCarp(d1, d2);
            Invalidate(); //Denetimin belirli bir bölgesini geçersiz kılıp denetime bir boya iletisi gönderilmesini sağlar.
        }

        private void Form5_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Coral, a);
            e.Graphics.FillRectangle(Brushes.DarkSeaGreen, b);
            e.Graphics.FillEllipse(Brushes.Black, kosea);
            e.Graphics.FillEllipse(Brushes.Black, koseb);
            e.Graphics.DrawLine(Pens.Lime, (d1.M.x + 40), (d1.M.y + 50), (d2.M.x + 50), (d2.M.y + 50));
        }
    }
}
