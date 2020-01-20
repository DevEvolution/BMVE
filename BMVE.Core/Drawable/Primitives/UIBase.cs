using BMVE.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Drawable.Primitives
{
    internal class UIBase : IDrawable
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
