using BMVE.Core.Utils.Utils;
using BMVE.Core.Utils.Utils.Socket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BMVE.Core.Commands
{
    internal static class ThreadProxy
    {
        internal static void Thread_Create(int number, Action function)
        {
            AssertSocketIsFree(number);

            var socket = new ThreadSocket()
            {
                Function = function,
                Thread = new System.Threading.Thread(new System.Threading.ThreadStart(function))
            };
            socket.Thread.Start();

            ManagedSocketResolver
                .ThreadSocket
                .OpenNewSocket(number, socket);
        }

        internal static void Thread_Create(int number, Action<string> function, string parameter)
        {
            AssertSocketIsFree(number);

            var socket = new ThreadSocket()
            {
                Thread = new System.Threading.Thread(
                    new System.Threading.ParameterizedThreadStart(
                        new Action<object>((x) => function(x.ToString()))
                        )
                    )
            };
            socket.Thread.Start(parameter);

            ManagedSocketResolver
                .ThreadSocket
                .OpenNewSocket(number, socket);
        }

        internal static void Thread_Pause(int number)
        {
            AssertSocketIsOpen(number);

            ManagedSocketResolver
                .ThreadSocket
                .GetSocket(number)
                .Thread
                .Suspend();
        }

        internal static void Thread_Continue(int number)
        {
            AssertSocketIsOpen(number);

            ManagedSocketResolver
                .ThreadSocket.GetSocket(number)
                .Thread
                .Resume();
        }

        internal static void Thread_Lock(int lockNumber)
        {
            if (!ManagedSocketResolver
                .ThreadSyncSocket
                .IsSocketBusy(lockNumber))
            {
                ManagedSocketResolver
                .ThreadSyncSocket
                .OpenNewSocket(lockNumber, new ThreadSyncSocket());
            }

            var syncRoot = ManagedSocketResolver
                .ThreadSyncSocket
                .GetSocket(lockNumber)
                .SyncRoot;

            Monitor.Enter(syncRoot);
        }

        internal static void Thread_Unlock(int lockNumber)
        {
            AssertLockIsExists(lockNumber);

            var syncRoot = ManagedSocketResolver
                .ThreadSyncSocket
                .GetSocket(lockNumber)
                .SyncRoot;

            Monitor.Exit(syncRoot);
        }

        internal static void Thread_Stop(int number)
        {
            AssertSocketIsOpen(number);

            ManagedSocketResolver
                .ThreadSocket
                .CloseSocket(number);
        }

        private static void AssertSocketIsOpen(int number)
        {
            if (!ManagedSocketResolver
                .ThreadSocket
                .IsSocketBusy(number))
            {
                throw new Exception($"Поток №{number} не был создан");
            }
        }

        private static void AssertSocketIsFree(int number)
        {
            if (ManagedSocketResolver
                .ThreadSocket
                .IsSocketBusy(number))
            {
                throw new Exception($"Поток №{number} уже был открыт");
            }
        }

        private static void AssertLockIsExists(int number)
        {
            if (!ManagedSocketResolver
                .ThreadSyncSocket
                .IsSocketBusy(number))
            {
                throw new Exception($"Блокировка №{number} не была создана");
            }
        }
    }
}
