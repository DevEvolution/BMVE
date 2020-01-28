using BMVE.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BMVE.Core.Utils.Utils
{
    internal class VKLayout
    {
        internal InputLanguage Language { get; set; }
        internal Dictionary<Key, CharShiftPair> KeyMap { get; set; }
    }
}
