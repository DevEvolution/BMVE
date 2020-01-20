using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BMVE.Core.Utils.Utils
{
    internal class FontInfo
    {
        internal string Family { get; set; }
        internal double Size { get; set; }
        internal FontWeight Weight { get; set; }
        internal FontStyle Style { get; set; }
        internal FontStretch Stretch { get; set; }

        internal FontInfo Clone()
            => new FontInfo()
            {
                Family = this.Family,
                Size = this.Size,
                Weight = this.Weight,
                Style = this.Style,
                Stretch = this.Stretch
            };
    }
}
