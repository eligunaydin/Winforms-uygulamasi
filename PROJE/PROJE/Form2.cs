using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJE
{
    // Noktayı forma çizdirme
    public partial class Form2 : Form
    {
        Rectangle r;
        point point=new point();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            point.x = 100;
            point.y = 100;
            r = new Rectangle(point.x, point.y, 10, 10);
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Black,r);
        }

    }
}