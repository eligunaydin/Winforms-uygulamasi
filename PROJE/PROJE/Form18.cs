using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE
{
    //Nokta-Dikdörtgen prizma çarpışması
    public partial class Form18 : Form
    {
        point p = new point();
        point p2 = new point();
        Rectangle r;
        public Form18()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            p2.x = 250;
            p2.y = 250;
            r = new Rectangle(p2.x, p2.y, 10, 10);
        }

        private void Form18_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            // Dikdörtgen prizmanın boyutları
            float en = 150;
            float boy = 100;
            float derinlik = 75;

            // Dikdörtgen prizmanın başlangıç koordinatları
            p.x = 50;
            p.y = 50;

            // Dikdörtgen prizmanın kenarları için GraphicsPath nesnesi oluşturur.
            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(new PointF[] {         // Çokgen çizer.
                new PointF(p.x, p.y),
                new PointF(p.x + en, p.y),
                new PointF(p.x + en + derinlik, p.y + derinlik),
                new PointF(p.x + derinlik, p.y + derinlik)});
            path.CloseFigure();                  //Geçerli şekli kapatır ve yeni bir şekil başlatır.
            path.AddPolygon(new PointF[] {
                new PointF(p.x, p.y),
                new PointF(p.x + derinlik, p.y + derinlik),
                new PointF(p.x + derinlik, p.y + boy + derinlik),
                new PointF(p.x, p.y + boy) });
            path.CloseFigure();
            path.AddPolygon(new PointF[] {
                new PointF(p.x + derinlik, p.y + boy + derinlik),
                new PointF(p.x + en + derinlik, p.y + boy + derinlik),
                new PointF(p.x + en, p.y + boy),
                new PointF(p.x, p.y + boy)});
            path.CloseFigure();
            path.AddPolygon(new PointF[] {
                new PointF(p.x + en, p.y),
                new PointF(p.x + en + derinlik, p.y + derinlik),
                new PointF(p.x + en + derinlik, p.y + boy + derinlik),
                new PointF(p.x + en, p.y + boy)});
            path.CloseFigure();

            // Dikdörtgen prizmanın çizimi
            SolidBrush brush = new SolidBrush(Color.LightPink);
            graphics.FillPath(brush, path);

            // Dikdörtgen prizmanın kenar çizgileri
            graphics.DrawPath(Pens.Black, path);

            e.Graphics.FillEllipse(Brushes.Black, r);
        }

        private void Form18_MouseMove(object sender, MouseEventArgs e)
        {
            p2.x = e.X; p2.y=e.Y;
            Invalidate();
        }
    }
}
