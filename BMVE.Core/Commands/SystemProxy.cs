using BMVE.Core.Enums;
using BMVE.Core.Utils.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Commands
{
    internal static class SystemProxy
    {
        internal static void System_SetDrawingMode(RenderingMode mode)
        {
            DrawingPipeline.RenderingMode = mode;
        }

        internal static RenderingMode System_GetDrawingMode()
        {
            return DrawingPipeline.RenderingMode;
        }

        internal static string System_Version() => "2.0.0";

        internal static void System_Sleep(int milliseconds)
        {
            Task.Delay(milliseconds).Wait();
        }
    }
}
