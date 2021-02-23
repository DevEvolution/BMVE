using BMVE.Core.Utils.Utils;
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
        private static Dictionary<int, ThreadSocket> threadSocketDict = new Dictionary<int, ThreadSocket>();
        private static Dictionary<int, object> threadSyncRootDict = new Dictionary<int, object>();

        internal static void Thread_Create(int number, Action function)
        {
            if (threadSocketDict.ContainsKey(number))
            {
                throw new Exception($"Поток №{number} уже был открыт");
            }

            threadSocketDict[number] = new ThreadSocket()
            {
                Function = function,
                Thread = new System.Threading.Thread(new System.Threading.ThreadStart(function))
            };
            threadSocketDict[number].Thread.Start();
        }

        internal static void Thread_Create(int number, Action<string> function, string parameter)
        {
            if (threadSocketDict.ContainsKey(number))
            {
                throw new Exception($"Поток №{number} уже был открыт");
            }

            threadSocketDict[number] = new ThreadSocket()
            {
                Thread = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(new Action<object>((x) => function(x.ToString()))))
            };
            threadSocketDict[number].Thread.Start(parameter);
        }

        internal static void Thread_Pause(int number)
        {
            if (!threadSocketDict.ContainsKey(number))
            {
                throw new Exception($"Поток №{number} не был создан");
            }

            threadSocketDict[number].Thread.Suspend();
        }

        internal static void Thread_Continue(int number)
        {
            if (!threadSocketDict.ContainsKey(number))
            {
                throw new Exception($"Поток №{number} не был создан");
            }

            threadSocketDict[number].Thread.Resume();
        }

        internal static void Thread_Lock(int lockNumber)
        {
            if (!threadSyncRootDict.ContainsKey(lockNumber))
            {
                threadSyncRootDict[lockNumber] = new object();
            }

            //bool isLocked = false;
            Monitor.Enter(threadSyncRootDict[lockNumber]);
        }

        internal static void Thread_Unlock(int lockNumber)
        {
            if (!threadSyncRootDict.ContainsKey(lockNumber))
            {
                throw new Exception($"Блокировка №{lockNumber} не была создана");
            }

            //bool isLocked = false;
            Monitor.Exit(threadSyncRootDict[lockNumber]);
        }

        internal static void Thread_Stop(int number)
        {
            if (!threadSocketDict.ContainsKey(number))
            {
                throw new Exception($"Поток №{number} не был создан");
            }

            try
            {
                threadSocketDict[number].Thread.Abort();
            }
            finally
            {
                threadSocketDict[number].Thread = null;
                threadSocketDict[number].Function = null;
                threadSocketDict.Remove(number);
            }
        }
    }
}
