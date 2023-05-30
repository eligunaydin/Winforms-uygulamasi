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
    //Küre-Küre çarpışması
    public partial class Form16 : Form
    {
        kure kure1 = new kure();
        kure kure2 = new kure();
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            kure1.M.x = 100;
            kure1.M.y = 100;
            kure1.R = 50;
            kure2.M.x = 200;
            kure2.M.y = 200;
            kure2.R = 55;
        }

        private void Form16_MouseMove(object sender, MouseEventArgs e)
        {
            kure2.M.x = e.X - 5;
            kure2.M.y = e.Y - 5;
            carpisma.kureCarp(kure1, kure2);
            Invalidate();
        }

        private void Form16_Paint(object sender, PaintEventArgs e)
        {
            //1.küre çizimi
            Color color1 = Color.RebeccaPurple;

            GraphicsPath gPath1 = new GraphicsPath();

            Rectangle rect1 = new Rectangle(kure1.M.x - kure1.R, kure1.M.y - kure1.R, kure1.R * 2, kure1.R * 2);
            gPath1.AddEllipse(rect1);

            PathGradientBrush pathGradientBrush1 = new PathGradientBrush(gPath1);
            pathGradientBrush1.CenterPoint = new PointF(kure1.M.x, kure1.M.y);
            pathGradientBrush1.CenterColor = color1;
            pathGradientBrush1.SurroundColors = new Color[] { Color.White };

            e.Graphics.FillPath(pathGradientBrush1, gPath1);


            //2.küre çizimi
            Color color2 = Color.HotPink;

            GraphicsPath gPath2 = new GraphicsPath();

            Rectangle rect2 = new Rectangle(kure2.M.x - kure2.R, kure2.M.y - kure2.R, kure2.R * 2, kure2.R * 2);
            gPath2.AddEllipse(rect2);

            PathGradientBrush pathGradientBrush2 = new PathGradientBrush(gPath2);
            pathGradientBrush2.CenterPoint = new PointF(kure2.M.x, kure2.M.y);
            pathGradientBrush2.CenterColor = color2;
            pathGradientBrush2.SurroundColors = new Color[] { Color.White };

            e.Graphics.FillPath(pathGradientBrush2, gPath2);
            e.Graphics.DrawLine(Pens.Yellow, kure1.M.x, kure1.M.y, kure2.M.x, kure2.M.y);
            gPath1.Dispose();            // Graphics tarafından kullanılan tüm kaynakları serbest bırakır.
            gPath2.Dispose();            // Graphics tarafından kullanılan tüm kaynakları serbest bırakır.
        }
    }
}
