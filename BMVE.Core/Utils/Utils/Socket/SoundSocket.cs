using BMVE.Core.Enums;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Utils
{
    internal class SoundSocket : IDisposable
    {
        internal string Filename;

        internal SoundSocketState SocketState = SoundSocketState.None;

        internal AudioFormat AudioFormat = AudioFormat.Mp3;

        internal WaveOut Player = new WaveOut();

        internal MemoryStream Stream;

        internal WaveStream Reader;

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
                this.Player?.Stop();
                this.Reader?.Dispose();
                this.Stream?.Dispose();
                this.Player?.Dispose();
                this.SocketState = SoundSocketState.None;
            }

            this._disposed = true;
        }

        ~SoundSocket()
        {
            this.Dispose(false);
        }
    }
}
