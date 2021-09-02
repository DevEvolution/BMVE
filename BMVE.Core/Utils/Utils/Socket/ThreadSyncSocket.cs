using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Utils.Socket
{
    internal class ThreadSyncSocket : IDisposable
    {
        internal object SyncRoot { get; set; }

        public void Dispose()
        {
            if (Monitor.IsEntered(this.SyncRoot))
            {
                Monitor.Exit(this.SyncRoot);
            }
            this.SyncRoot = null;
        }
    }
}
