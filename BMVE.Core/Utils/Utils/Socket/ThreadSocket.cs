using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Utils
{
    internal class ThreadSocket : IDisposable
    {
        internal Thread Thread { get; set; }

        internal Action Function { get; set; }


        private bool _disposed = false;
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (this._disposed)
            {
                return;
            }

            if (disposing)
            {
                this.Thread.Abort();
                this.Thread = null;
                this.Function = null;
            }
        }

        ~ThreadSocket()
        {
            this.Dispose(false);
        }
    }
}
