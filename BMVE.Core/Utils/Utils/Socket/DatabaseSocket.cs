using BMVE.Core.Enums;
using BMVE.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Utils
{
    internal class DatabaseSocket : IDisposable
    {
        private bool _disposed = false;

        internal IDatabaseProvider DatabaseProvider { get; set; }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing)
        {
            if (this._disposed)
            {
                return;
            }

            if (disposing)
            {
                this.DatabaseProvider.Dispose();
            }

            this._disposed = true;
        }

        ~DatabaseSocket()
        {
            this.Dispose(false);
        }
    }
}
