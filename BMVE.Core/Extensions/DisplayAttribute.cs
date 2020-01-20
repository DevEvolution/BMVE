using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Extensions
{
    internal class DisplayAttribute : Attribute
    {
        internal string Name { get; set; }

        internal DisplayAttribute(string name)
        {
            Name = name;
        }
    }
}
