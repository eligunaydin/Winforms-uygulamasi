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
    //Silindir-Silindir çarpışması
    public partial class Form6 : Form
    {
        silindir s1 = new silindir();
        silindir s2 = new silindir();

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            s1.M.x = 150;
            s1.M.y = 150;
            s1.M.z = 150;
            s1.H = 200;
            s1.R = 50;
            s2.M.x = 250;
            s2.M.y = 250;
            s2.M.z = 200;
            s2.H = 200;
            s2.R = 50;
        }

        private void Form6_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.DarkBlue, 2);
            Brush brush = new SolidBrush(Color.Beige);

            // Silindir 1 çizimi
            Rectangle c1 = new Rectangle(s1.M.x - s1.R, s1.M.y - s1.R, s1.R * 2, s1.R * 2);
            g.FillEllipse(brush, c1);
            g.DrawEllipse(pen, c1);

            // Silindir 2 çizimi
            Rectangle c2 = new Rectangle(s2.M.x - s2.R, s2.M.y - s2.R, s2.R * 2, s2.R* 2);
            g.FillEllipse(brush, c2);
            g.DrawEllipse(pen, c2);

            // Çarpışma denetimi
            double distance = Math.Sqrt(Math.Pow(s2.M.x - s1.M.x, 2) + Math.Pow(s2.M.y - s1.M.y, 2));
            double combinedRadius = 50 * 2;
            if (distance <= combinedRadius)
            {
                Brush collisionBrush = new SolidBrush(Color.Green);
                g.FillRectangle(collisionBrush, c1);
                g.FillRectangle(collisionBrush, c2);
            }
        }
        private void Form6_MouseMove(object sender, MouseEventArgs e)
        {
            s2.M.x = e.X;
            s2.M.y = e.Y;
            Invalidate();
        }

    }
}
