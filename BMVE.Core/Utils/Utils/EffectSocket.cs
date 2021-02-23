using BMVE.Core.Drawable.Shaders;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Utils
{
    internal class EffectSocket
    {
        internal SShaderBase Shader { get; set; }

        internal int? X { get; set; }

        internal int? Y { get; set; }

        internal int? Width { get; set; }

        internal int? Height { get; set; }

        internal (int? x, int? y) Center => (X + Width / 2, Height + Height / 2);

        internal int? Radius => Math.Min(Center.x.GetValueOrDefault() - X.GetValueOrDefault(), Center.y.GetValueOrDefault() - Y.GetValueOrDefault());
    }
}
