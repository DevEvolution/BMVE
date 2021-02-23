using BMVE.Core.Interfaces;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Drawable.Primitives
{
    internal class UILine : UIBase, IColorized, IHaveAdditionalCoordinates, IHaveBorder
    {
        public SKColor ForegroundColor { get; set; }
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int BorderThickness { get; set; }
    }
}
