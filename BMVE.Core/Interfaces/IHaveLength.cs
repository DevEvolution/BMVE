using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Interfaces
{
    internal interface IHaveLength
    {
        int Width { get; set; }
        int Height { get; set; }
    }
}
