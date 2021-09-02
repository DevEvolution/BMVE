using BMVE.Core.Utils.Utils.Socket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Utils
{
    internal static class ManagedSocketResolver
    {
        internal static SocketManager<FileSocket> FileSocket { get; set; } = new SocketManager<FileSocket>();
        internal static SocketManager<EffectSocket> EffectSocket { get; set; } = new SocketManager<EffectSocket>();
        internal static SocketManager<DatabaseSocket> DatabaseSocket { get; set; } = new SocketManager<DatabaseSocket>();
        internal static SocketManager<ImageSocket> ImageSocket { get; set; } = new SocketManager<ImageSocket>();
        internal static SocketManager<SoundSocket> SoundSocket { get; set; } = new SocketManager<SoundSocket>();
        internal static SocketManager<ThreadSocket> ThreadSocket { get; set; } = new SocketManager<ThreadSocket>();
        internal static SocketManager<ThreadSyncSocket> ThreadSyncSocket { get; set; } = new SocketManager<ThreadSyncSocket>();
        internal static SocketManager<StopwatchSocket> StopwatchSocket { get; set; } = new SocketManager<StopwatchSocket>();
    }
}
