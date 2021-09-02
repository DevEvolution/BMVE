using BMVE.Core.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Utils
{
    internal class FileSocket : IDisposable
    {
        internal string Filename { get; set; }

        internal FileSocketState SocketState { get; set; }

        internal Stream Stream { get; set; }

        internal StreamWriter Writer { get; set; }

        internal StreamReader Reader { get; set; }

        private bool _disposed = false;

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
                this.Writer?.Close();
                this.Writer?.Dispose();

                this.Reader?.Close();
                this.Reader?.Dispose();

                this.Stream?.Dispose();
                this.SocketState = FileSocketState.Closed;
            }

            this._disposed = true;
        }

        ~FileSocket()
        {
            this.Dispose(false);
        }
    }
}
