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
    // Dikdörtgen çizme
    public partial class Form8 : Form
    {
        point d = new point();
        Rectangle r;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            d.x = 100;
            d.y = 100;
            r = new Rectangle(d.x, d.y, 60, 200);
        }

        private void Form8_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Purple, r);
        }
    }
}
