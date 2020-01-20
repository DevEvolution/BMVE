using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Utils
{
    internal class CharShiftPair
    {
        internal char Char;
        internal char ShiftChar;

        public static implicit operator CharShiftPair(string value)
        {
            return new CharShiftPair() { Char = value[0], ShiftChar = value[1] };
        }
    }
}
