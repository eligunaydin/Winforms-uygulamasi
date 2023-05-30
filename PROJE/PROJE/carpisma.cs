using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJE
{
    public static class carpisma
    {

        public static void circleCarp(circle c1, circle c2)
        {
            float d = (float)Math.Sqrt(Math.Pow(((c1.M.X+40) - (c2.M.X+50)), 2) + Math.Pow(((c1.M.Y+40) - (c2.M.Y+50)), 2));
            if ((c1.R + c2.R) > d)
                _ = MessageBox.Show("Çarpışma");
        }
        public static void kureCarp(kure k1, kure k2)
        {
            float d = (float)Math.Sqrt(Math.Pow((k1.M.X - k2.M.X), 2) +
            Math.Pow((k1.M.Y - k2.M.Y), 2) + Math.Pow((k1.M.Z - k2.M.Z), 2));
            if ((k1.R + k2.R) > (int)d)
                _ = MessageBox.Show("Çarpışma");
        }
        public static void dikdortgenCarp(dikdortgen d1, dikdortgen d2)
        {
            double Xa = d1.M.X + d1.En / 2;
            double Ya = d1.M.Y + d1.Boy / 2;
            double Xb = d2.M.X + d2.En / 2;
            double Yb = d2.M.Y + d2.Boy / 2;
            if (Math.Abs(Xa - Xb) < (d1.En / 1 + d2.En / 1) && Math.Abs(Ya - Yb) < (d1.Boy / 1+ d2.Boy / 1))
                _ = MessageBox.Show("Çarpışma");
        }
        public static void cylenderCarp(silindir k1, silindir k2)
        {
            point3d pa = new point3d(k1.M.X, k1.M.Y + k1.H / 2, k1.M.Z);
            point3d pb = new point3d(k2.M.X, k2.M.Y + k2.H / 2, k2.M.Z);
            float d = (float)Math.Sqrt(Math.Pow((pa.X - pb.X), 2) +
            Math.Pow((pa.Y - pb.Y), 2) + Math.Pow((pa.Z - pb.Z), 2));
            if ((k1.R + k2.R) > (int)d && Math.Abs(pa.Y - pb.Y) < ((k1.H + k2.H) / 2))
                _ = MessageBox.Show("Çarpışma");
        }
        public static void circledikdortgenCarp(circle c,dikdortgen d)
        {
            Rectangle rect = new Rectangle(d.M.X, d.M.Y, d.En, d.Boy);
            if (rect.IntersectsWith(new Rectangle(c.M.X+40 - c.R, c.M.Y+40 - c.R, c.R * 2, c.R * 2)))
               _ = MessageBox.Show("Çarpışma");
        }
    }

}
