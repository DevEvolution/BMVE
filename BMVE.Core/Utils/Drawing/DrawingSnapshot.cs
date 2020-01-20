using BMVE.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Drawing
{
    /// <summary>
    /// Single frame
    /// </summary>
    internal class DrawingSnapshot
    {
        internal List<IDrawable> DrawingPipe = new List<IDrawable>();

        internal void Add(IDrawable drawable)
        {
            DrawingPipe.Add(drawable);
        }

        internal void Clear()
        {
            DrawingPipe.Clear();
        }

        internal DrawingSnapshot Clone()
        {
            return new DrawingSnapshot() { DrawingPipe = new List<IDrawable>(this.DrawingPipe) };
        }
    }
}
