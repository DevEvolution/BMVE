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
        internal static object syncRoot = new object();

        internal List<IDrawable> DrawingPipe = new List<IDrawable>();

        internal void Add(IDrawable drawable)
        {
            lock (syncRoot)
            {
                DrawingPipe.Add(drawable);
            }
        }

        internal void Clear()
        {
            lock (syncRoot)
            {
                DrawingPipe.Clear();
            }
        }

        internal DrawingSnapshot Clone()
        {
            lock (syncRoot)
            {
                return new DrawingSnapshot() { DrawingPipe = new List<IDrawable>(this.DrawingPipe) };
            }
        }
    }
}
