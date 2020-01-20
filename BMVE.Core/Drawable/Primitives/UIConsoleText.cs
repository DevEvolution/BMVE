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
    internal class UIConsoleText : UIBase, IDrawable, IColorized, IFontCustomizable
    {
        public string Text { get; set; } = "";
        public SKColor ForegroundColor { get; set; }
        public FontInfo FontInfo { get; set; }
    }
}
