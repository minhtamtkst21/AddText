using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddText.Classes
{
    public class HinhAnh
    {
        public string path { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public Image Image { get; set; }
        public Bitmap Bitmap { get; set; }
        public Graphics Graphics { get; set; }
    }
}
