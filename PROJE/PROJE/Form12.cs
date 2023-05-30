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
    // Dikdörtgen prizmayı forma çizdirme
    public partial class Form12 : Form
    {
        point p = new point();
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
        }

        private void Form12_Paint(object sender, PaintEventArgs e)
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
            path.AddPolygon(new PointF[] {       // Çokgen çizer.
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

        }
    }
}
