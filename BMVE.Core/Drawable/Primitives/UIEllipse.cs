﻿using BMVE.Core.Interfaces;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Drawable.Primitives
{
    internal class UIEllipse : UIBase, IColorized, IHaveBackground, IHaveLength, IHaveBorder
    {
        public SKColor ForegroundColor { get; set; }
        public SKColor? BackgroundColor { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int BorderThickness { get; set; }
    }
}
