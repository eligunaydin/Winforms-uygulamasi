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
    // Dörtgeni forma çizdirme
    public partial class Form7 : Form
    {
        point p1=new point();
        point p2 = new point();
        point p3 = new point();
        point p4 = new point();
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // Oluşturulan noktaların x ve y değerlerine rastgele değer atandı.
            p1.x = 143; p1.y = 178;
            p2.x =446; p2.y = 252;
            p3.x = 109; p3.y = 276;
            p4.x = 20; p4.y = 190;
        }

        private void Form7_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.DarkSlateBlue, p1.x, p1.y, p2.x, p2.y);
            e.Graphics.DrawLine(Pens.DarkOliveGreen, p2.x, p2.y, p3.x, p3.y);
            e.Graphics.DrawLine(Pens.DarkOrchid, p3.x, p3.y, p4.x, p4.y);
            e.Graphics.DrawLine(Pens.DarkRed, p4.x, p4.y, p1.x, p1.y);
        }
    }
}
