using BMVE.Core.Interfaces;
using BMVE.Core.Utils.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Drawable.Primitives
{
    internal class UIImage : UIBase, IHaveLength
    {
        public ImageSocket Image { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }
    }
}
