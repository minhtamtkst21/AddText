using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddText.Classes
{
    public class AddTextClass
    {
        public string TenText { get; set; }
        public string FontChu { get; set; }
        public int SizeChu { get; set; }
        public int ViTriDoc { get; set; }
        public int ViTriNgang { get; set; }
        public bool CanGiuaDoc { get; set; }
        public bool CanGiuaNgang { get; set; }
        public bool Regular { get; set; }
        public bool Bold { get; set; }
        public bool Italic { get; set; }
        public bool Underline { get; set; }
        public bool Strikeout { get; set; }
        public Font font { get; set; }
    }
}
