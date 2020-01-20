using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Interfaces
{
    internal interface IColorized
    {
        SKColor ForegroundColor { get; set; }
    }
}
