using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE
{
    // Küre çizimi
    public partial class Form9 : Form
    {
        kure kure = new kure();
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            kure.M.x = 100;
            kure.M.y = 100;
            kure.R = 80;
        }
        private void Form9_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.RebeccaPurple;

            GraphicsPath gPath = new GraphicsPath();             //Şekilleri çizmek için kullanılan sınıf

            Rectangle rect = new Rectangle(kure.M.x - kure.R, kure.M.y - kure.R, kure.R * 2, kure.R * 2);   //Dikdörtgen oluşturur.
            gPath.AddEllipse(rect);                             //Elips oluşturur.

            PathGradientBrush pathGradientBrush = new PathGradientBrush(gPath);
            pathGradientBrush.CenterPoint = new PointF(kure.M.x, kure.M.y);
            pathGradientBrush.CenterColor = color;
            pathGradientBrush.SurroundColors = new Color[] { Color.White };

            e.Graphics.FillPath(pathGradientBrush, gPath);

            gPath.Dispose();
        }
    }
}
