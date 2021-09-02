using BMVE.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Utils
{
    internal class SocketManager<TSocket>
    {
        private Dictionary<int, TSocket> _activeSocket;

        public SocketManager()
        {
            this._activeSocket = new Dictionary<int, TSocket>();
        }

        public bool IsSocketBusy(int number)
        {
            return this._activeSocket.ContainsKey(number);
        }

        public void OpenNewSocket(int number, TSocket socket)
        {
            this.AssertSocketIsFree(number);

            this._activeSocket.Add(number, socket);
        }

        public void CloseSocket(int number)
        {
            this.AssertSocketIsInUse(number);

            if (this._activeSocket[number] is IDisposable)
            {
                ((IDisposable)this._activeSocket[number]).Dispose();
            }
            this._activeSocket.Remove(number);
        }

        public TSocket GetSocket(int number)
        {
            this.AssertSocketIsInUse(number);

            return this._activeSocket[number];
        }

        public TSocket this[int index]
        {
            get { return this.GetSocket(index); }
        }


        private void AssertSocketIsFree(int number)
        {
            if (this.IsSocketBusy(number))
            {
                throw new SocketAlreadyInUseException(number);
            }
        }

        private void AssertSocketIsInUse(int number)
        {
            if (!this.IsSocketBusy(number))
            {
                throw new SocketClosedException(number);
            }
        }
    }
}
