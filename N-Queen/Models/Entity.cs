using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace N_Queen.Models
{
    public class CustomControl
    {
        public int col { get; set; }
        public int row { get; set; }
        public Point Location { get; set; }
        public Size Size { get; set; }
        public RectangleF Rect { get; set; }
        public char Color { get; set; }
        public bool IsQueen{get; set;}
    }
}
