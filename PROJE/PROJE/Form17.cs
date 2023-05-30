using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE
{
    //Küre-Silindir çarpışması
    public partial class Form17 : Form
    {
        kure kure = new kure();
        public Form17()
        {
            InitializeComponent();

        }
        private void Form17_Load(object sender, EventArgs e)
        {
            kure.M.x = 200;
            kure.M.y = 200;
            kure.R = 55;
        }

        private void Form17_Paint(object sender, PaintEventArgs e)
        {
            //Silindir çizimi
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;   //Çizilenlerin daha yumuşak hatlı görünüme sahip olmasını sağlar.
            using (LinearGradientBrush l = new LinearGradientBrush(new Rectangle(12, 12, 100, 35), Color.FromArgb(255, 0, 0, 255), Color.FromArgb(255, 0, 0, 255), LinearGradientMode.Vertical))
            {
                //Renk ayarlaması
                using (Pen p = new Pen(l, 12))
                {
                    e.Graphics.DrawEllipse(p, new Rectangle(12, 212, 100, 35));
                }
            }

            GraphicsPath gPath = new GraphicsPath();                      //Şekilleri çizmek için kullanılan sınıf
            gPath.AddArc(new Rectangle(12, 12, 100, 35), 180, 180);     //Geçerli şekle eliptik bir yay ekler.
            gPath.AddArc(new Rectangle(12, 212, 100, 35), 0, 180);

            GraphicsPath g2 = (GraphicsPath)gPath.Clone();                // Yolun tam bir kopyasını oluşturan metod
            RectangleF r = g2.GetBounds();                                //Çember etrafında dikdörtgen döndürme

            float w = (r.Width + 4) / r.Width;
            float h = (r.Height + 4) / r.Height;
            g2.Transform(new Matrix(w, 0, 0, h, -2, -2));               //Yolu istenilen eksen yönünde girilen birim kadar çevirmek için dönüştürme matrisi oluşturur.

            using (PathGradientBrush p = new PathGradientBrush(g2))
            {
                p.CenterColor = Color.FromArgb(171, 195, 195, 195);
                p.SurroundColors = new Color[] { Color.FromArgb(171, 0, 0, 255) };
                p.FocusScales = new PointF(0.71F, 0.71F);
                e.Graphics.FillPath(p, gPath);
            }

            using (LinearGradientBrush l = new LinearGradientBrush(new Rectangle(12, 12, 100, 35), Color.FromArgb(255, 0, 0, 255), Color.FromArgb(255, 0, 0, 255), LinearGradientMode.Vertical))
            {
                using (Pen p = new Pen(l, 12))
                {
                    e.Graphics.DrawEllipse(p, l.Rectangle);
                }
            }
            gPath.Dispose();             // GraphicsPath tarafından kullanılan tüm kaynakları serbest bırakır.

            //Küre çizimi
            Color color2 = Color.HotPink;

            GraphicsPath gPath2 = new GraphicsPath();

            Rectangle rect2 = new Rectangle(kure.M.x - kure.R, kure.M.y - kure.R, kure.R * 2, kure.R * 2);
            gPath2.AddEllipse(rect2);

            PathGradientBrush pathGradientBrush2 = new PathGradientBrush(gPath2);
            pathGradientBrush2.CenterPoint = new PointF(kure.M.x, kure.M.y);
            pathGradientBrush2.CenterColor = color2;
            pathGradientBrush2.SurroundColors = new Color[] { Color.White };

            e.Graphics.FillPath(pathGradientBrush2, gPath2);
            e.Graphics.DrawLine(Pens.Yellow, kure.M.x, kure.M.y-55,62,28 );
            e.Graphics.DrawLine(Pens.Yellow, kure.M.x, kure.M.y+55, 62, 228);
            gPath2.Dispose();            // Graphics tarafından kullanılan tüm kaynakları serbest bırakır.
        }

        private void Form17_MouseMove(object sender, MouseEventArgs e)
        {
            kure.M.x = e.X - 5;
            kure.M.y = e.Y - 5;
            Invalidate();
        }
    }
}
