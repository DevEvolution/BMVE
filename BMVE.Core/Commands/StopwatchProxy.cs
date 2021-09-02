using BMVE.Core.Utils.Utils;
using BMVE.Core.Utils.Utils.Socket;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Commands
{
    internal static class StopwatchProxy
    {
        internal static void Stopwatch_Start(int number)
        {
            if (ManagedSocketResolver
                .StopwatchSocket
                .IsSocketBusy(number))
            {
                ManagedSocketResolver
                    .StopwatchSocket
                    .CloseSocket(number);
            }

            var socket = new StopwatchSocket { Stopwatch = new Stopwatch() };

            ManagedSocketResolver
                .StopwatchSocket
                .OpenNewSocket(number, socket);

            socket.Stopwatch.Start();
        }

        internal static long Stopwatch_GetMillisecondsElapsed(int number)
        {
            AssertStopwatchIsStarted(number);

            return ManagedSocketResolver
                .StopwatchSocket[number]
                .Stopwatch
                .ElapsedMilliseconds;
        }

        internal static void Stopwatch_Stop(int number)
        {
            AssertStopwatchIsStarted(number);

            ManagedSocketResolver
                .StopwatchSocket[number]
                .Stopwatch.Stop(); 
        }

        internal static void Stopwatch_Close(int number)
        {
            AssertStopwatchIsStarted(number);

            ManagedSocketResolver
                .StopwatchSocket
                .CloseSocket(number);
        }

        internal static long Stopwatch_GetSecondsElapsed(int number)
        {
            AssertStopwatchIsStarted(number);

            return ManagedSocketResolver
                .StopwatchSocket[number]
                .Stopwatch
                .ElapsedMilliseconds / 1000;
        }

        internal static bool Stopwatch_IsCreated(int number)
        {
            return ManagedSocketResolver
                    .StopwatchSocket
                    .IsSocketBusy(number);
        }

        internal static bool Stopwatch_IsRunning(int number)
        {
            return ManagedSocketResolver
                .StopwatchSocket
                .IsSocketBusy(number)
                && ManagedSocketResolver
                .StopwatchSocket[number]
                .Stopwatch.IsRunning;
        }

        private static void AssertStopwatchIsStarted(int number)
        {
            if (!ManagedSocketResolver
                .StopwatchSocket
                .IsSocketBusy(number))
            {
                throw new Exception($"Таймер №{number} не был запущен");
            }
        }
    }
}
