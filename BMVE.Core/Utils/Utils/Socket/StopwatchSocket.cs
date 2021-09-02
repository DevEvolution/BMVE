using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Utils.Socket
{
    internal class StopwatchSocket : IDisposable
    {
        internal Stopwatch Stopwatch { get; set; }

        public void Dispose()
        {
            this.Stopwatch.Stop();
            this.Stopwatch = null;
        }
    }
}
