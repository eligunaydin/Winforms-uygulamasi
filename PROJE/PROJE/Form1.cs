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
    // Çemberi forma çizdirme 
    public partial class Form1 : Form
    {
        circle circle = new circle();
        Rectangle r;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            circle.M.x = 100;
            circle.M.y = 100;
            circle.R = 50;
            r= new Rectangle(circle.M.x,circle.M.y,100,100);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(Pens.Black, r);
        }
    }
}
