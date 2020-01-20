using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Interfaces
{
    /// <summary>
    /// Drawable element inteface
    /// Every visual element should implement it
    /// </summary>
    internal interface IDrawable
    {
        int X { get; set; }
        int Y { get; set; }
    }
}
