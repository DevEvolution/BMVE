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
        /// Создает и запускает новый поток, выполняющий указанную функцию
        /// </summary>
        /// <param name="number">Номер потока</param>
        /// <param name="function">Функция без параметров и возвращаемого значения, которая будет выполняться потоком</param>
        protected void Thread_Create(int number, Action function) => ThreadProxy.Thread_Create(number, function);

        /// <summary>
        /// Создает и запускает новый поток, выполняющий указанную функцию с указанным параметром типа <see cref="string"/>
        /// </summary>
        /// <param name="number">Номер потока</param>
        /// <param name="function">Функция с единственным параметром типа <see cref="string"/> и без возвращаемого значения, которая будет выполняться потоком</param>
        /// <param name="parameter">Параметр функции, которая будет выполняться</param>
        protected void Thread_Create(int number, Action<string> function, string parameter) => ThreadProxy.Thread_Create(number, function, parameter);

        /// <summary>
        /// Приостанавливает указанный поток
        /// </summary>
        /// <param name="number">Номер потока</param>
        protected void Thread_Pause(int number) => ThreadProxy.Thread_Pause(number);

        /// <summary>
        /// Продолжает выполнение указанного потока, если он приостановлен
        /// </summary>
        /// <param name="number">Номер потока</param>
        protected void Thread_Continue(int number) => ThreadProxy.Thread_Continue(number);
        
        /// <summary>
        /// Устанавливает блокировку для всех потоков, выполняющих текущую функцию
        /// <para>Только один поток единовременно может выполнять код, начинающийся с этой команды и до выполнения команды освобождения блокировки <see cref="Thread_Unlock(int)"/></para>
        /// </summary>
        /// <param name="lockNumber">Номер блокировки</param>
        protected void Thread_Lock(int lockNumber) => ThreadProxy.Thread_Lock(lockNumber);

        /// <summary>
        /// Освобождает блокировку, позволяя другому потоку войти в секцию <see cref="Thread_Lock(int)"/>
        /// </summary>
        /// <param name="lockNumber">Номер блокировки</param>
        protected void Thread_Unlock(int lockNumber) => ThreadProxy.Thread_Unlock(lockNumber);

        /// <summary>
        /// Останавливает указанный поток
        /// </summary>
        /// <param name="number">Номер потока</param>
        protected void Thread_Stop(int number) => ThreadProxy.Thread_Stop(number);
    }
}
