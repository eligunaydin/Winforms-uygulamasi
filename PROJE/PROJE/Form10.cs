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
    //Silindir çizimi
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void Form10_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode=System.Drawing.Drawing2D.SmoothingMode.AntiAlias;   //Çizilenlerin daha yumuşak hatlı görünüme sahip olmasını sağlar.
            using (LinearGradientBrush l=new LinearGradientBrush(new Rectangle(12,12,100,35),Color.FromArgb(255,0,0,255),Color.FromArgb(255,0,0,255),LinearGradientMode.Vertical))
            {
                //Renk ayarlaması
                using (Pen p = new Pen(l, 12))
                {
                    e.Graphics.DrawEllipse(p, new Rectangle(12, 212, 100, 35));
                }
            }

            GraphicsPath gPath=new GraphicsPath();                      //Şekilleri çizmek için kullanılan sınıf
            gPath.AddArc(new Rectangle(12, 12, 100, 35), 180, 180);     //Geçerli şekle eliptik bir yay ekler.
            gPath.AddArc(new Rectangle(12, 212, 100, 35), 0, 180);
           
            GraphicsPath g2=(GraphicsPath)gPath.Clone();                // Yolun tam bir kopyasını oluşturan metod
            RectangleF r=g2.GetBounds();                                //Çember etrafında dikdörtgen döndürme

            float w = (r.Width + 4) / r.Width;
            float h = (r.Height + 4)/r.Height;
            g2.Transform(new Matrix(w, 0, 0, h, -2, -2));               //Yolu istenilen eksen yönünde girilen birim kadar çevirmek için dönüştürme matrisi oluşturur.

            using (PathGradientBrush p=new PathGradientBrush(g2))
            {
                p.CenterColor = Color.FromArgb(171, 195, 195, 195);
                p.SurroundColors = new Color[] { Color.FromArgb(171, 0, 0, 255) };
                p.FocusScales = new PointF(0.71F, 0.71F);
                e.Graphics.FillPath(p, gPath);
            }

            using (LinearGradientBrush l = new LinearGradientBrush(new Rectangle(12, 12, 100, 35), Color.FromArgb(255, 0, 0, 255), Color.FromArgb(255, 0, 0, 255), LinearGradientMode.Vertical))
            {
                using (Pen p=new Pen(l,12))
                {
                    e.Graphics.DrawEllipse(p, l.Rectangle);
                }
            }
            gPath.Dispose();             // GraphicsPath tarafından kullanılan tüm kaynakları serbest bırakır.
        }
    }
}
