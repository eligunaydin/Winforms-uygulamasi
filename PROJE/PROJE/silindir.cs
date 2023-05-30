using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJE
{
    public class silindir
    {
        point3d m; int r; int h;
        public silindir()
        {
            M = new point3d();  // merkez noktası
            R = 0;
            H = 0;
        }
        public silindir(point3d p, int r, int h)
        { M = p; R = r; H = h; }
        public int R { get => r; set => r = value; }
        public int H { get => h; set => h = value; }
        public point3d M { get => m; set => m = value; }

    }
}
