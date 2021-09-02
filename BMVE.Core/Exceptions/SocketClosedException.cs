using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Exceptions
{
    internal class SocketClosedException : Exception
    {
        public int RequestedSocketNumber { get; }

        public SocketClosedException(int number)
        {
            this.RequestedSocketNumber = number;
        }
    }
}
