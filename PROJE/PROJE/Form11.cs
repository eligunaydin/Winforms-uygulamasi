using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE
{
    // 2 boyutlu yüzey çizimi
    public partial class Form11 : Form
    {
        dikdortgen d1 = new dikdortgen();
        Rectangle r1;
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            d1.M.x = 200;
            d1.M.y = 200;
            d1.En = 200;
            d1.Boy = 20;
            r1 = new Rectangle(d1.M.x, d1.M.y, d1.En, d1.Boy);

        }
        private void Form11_Paint(object sender, PaintEventArgs e)
        {

            PointF point1 = new PointF(d1.M.x, d1.M.y);
            PointF point2 = new PointF(d1.M.x + d1.En, d1.M.y);
            PointF point3 = new PointF(300, 50);
            PointF point4 = new PointF(500, 50);
            PointF[] points = { point1, point3, point4,point2 };  //Noktalar dizisi

            Pen pen = new Pen(Color.DarkBlue);                    // Çizim için kalem ayarlaması
            
            e.Graphics.DrawRectangle(Pens.DarkBlue, r1);          //Dikdörtgen çizimi
            e.Graphics.DrawPolygon(pen, points);                  //Noktaları birleştirerek çokgen çizen metod
        }  
    }
}
