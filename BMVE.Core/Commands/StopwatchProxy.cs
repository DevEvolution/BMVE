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
            if (TimersDict.ContainsKey(number))
                TimersDict[number].Stop();

            TimersDict[number] = new Stopwatch();
            TimersDict[number].Start();
        }

        internal static int Stopwatch_GetMillisecondsElapsed(int number)
        {
            if (!TimersDict.ContainsKey(number))
            {
                throw new Exception($"Таймер №{number} не был запущен");
            }
            return (int)TimersDict[number].ElapsedMilliseconds;
        }

        internal static void Stopwatch_Stop(int number)
        {
            if (!TimersDict.ContainsKey(number))
            {
                throw new Exception($"Таймер №{number} не был запущен");
            }
            TimersDict[number].Stop();
            TimersDict.Remove(number);
        }

        internal static int Stopwatch_GetSecondsElapsed(int number)
        {
            if (!TimersDict.ContainsKey(number))
            {
                throw new Exception($"Таймер №{number} не был запущен");
            }
            return (int)(TimersDict[number].ElapsedMilliseconds / 1000);
        }

        internal static bool Stopwatch_IsRunning(int number)
        {
            return TimersDict.ContainsKey(number) && TimersDict[number].IsRunning;
        }

        private static Dictionary<int, Stopwatch> TimersDict = new Dictionary<int, Stopwatch>();
    }
}
