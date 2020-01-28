using BMVE.Core.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Utils
{
    internal class FileSocket
    {
        internal string Filename;

        internal FileSocketState SocketState;

        internal Stream Stream;

        internal StreamWriter Writer;
        internal StreamReader Reader;
    }
}
