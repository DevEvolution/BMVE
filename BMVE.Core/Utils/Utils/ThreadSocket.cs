using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Utils
{
    internal class ThreadSocket
    {
        internal Thread Thread { get; set; }

        internal Action Function { get; set; }

        internal Dictionary<int, object> SyncRoot { get; } = new Dictionary<int, object>();
    }
}
