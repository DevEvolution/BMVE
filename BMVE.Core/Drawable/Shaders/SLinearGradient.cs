using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Drawable.Shaders
{
    /**
     * \brief Шейдер линейного градиента
     */
    internal class SLinearGradient : SShaderBase
    {
        internal SKRect ShaderPosition;
        internal List<(SKColor color, float stop)> GradientStops = new List<(SKColor, float)>();
    }
}
