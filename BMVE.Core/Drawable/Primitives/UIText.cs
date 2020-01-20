using BMVE.Core.Interfaces;
using BMVE.Core.Utils.Utils;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Drawable.Primitives
{
    internal class UIText : UIBase, IColorized, IFontCustomizable
    {
        public SKColor ForegroundColor { get; set; }
        public string Text { get; set; } = "";
        public FontInfo FontInfo { get; set; }
    }
}
