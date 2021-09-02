using BMVE.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core
{
    public partial class Runnable
    {
        /// <summary>
        /// Запуск таймера
        /// </summary>
        /// <param name="number">Номер таймера</param>
        protected void Stopwatch_Start(int number) => StopwatchProxy.Stopwatch_Start(number);

        /// <summary>
        /// Получить количество милисекунд, прошешее с начала запуска указанного таймера
        /// </summary>
        /// <param name="number">Номер таймера</param>
        /// <returns>Прошедшее время в миллисекундах</returns>
        protected long Stopwatch_GetMillisecondsElapsed(int number) => StopwatchProxy.Stopwatch_GetMillisecondsElapsed(number);

        /// <summary>
        /// Получить количество секунд, прошешее с начала запуска указанного таймера
        /// </summary>
        /// <param name="number">Номер таймера</param>
        /// <returns>Прошедшее время в секундах</returns>
        protected long Stopwatch_GetSecondsElapsed(int number) => StopwatchProxy.Stopwatch_GetSecondsElapsed(number);

        /// <summary>
        /// Остановка таймера
        /// </summary>
        /// <param name="number">Номер таймера</param>
        protected void Stopwatch_Stop(int number) => StopwatchProxy.Stopwatch_Stop(number);

        /// <summary>
        /// Закрыть сокет таймера
        /// </summary>
        /// <param name="number">Номер таймера</param>
        protected void Stopwatch_Close(int number) => StopwatchProxy.Stopwatch_Close(number);

        /// <summary>
        /// Запущен ли таймер с указанным номером
        /// </summary>
        /// <param name="number">Номер таймера</param>
        /// <returns>Запущен ли таймер</returns>
        protected bool Stopwatch_IsRunning(int number) => StopwatchProxy.Stopwatch_IsRunning(number);

        /// <summary>
        /// Создан ли таймер с указанным номером
        /// </summary>
        /// <param name="number">Номер таймера</param>
        /// <returns>Создан ли таймер</returns>
        protected bool Stopwatch_IsCreated(int number) => StopwatchProxy.Stopwatch_IsCreated(number);
    }
}
