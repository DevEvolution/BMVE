using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Utils
{
    internal class ImageSocket : IDisposable
    {
        internal SKBitmap Image { get; set; }

        internal SKBitmap TransformedImage { get; set; }

        internal double Angle { get; set; }

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
                this.TransformedImage.Dispose();
                this.Image.Dispose();
            }

            this._disposed = true;
        }

        ~ImageSocket()
        {
            this.Dispose(false);
        }
    }
}
