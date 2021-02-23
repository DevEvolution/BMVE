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
        /// Приостановка выполнения программы на указанное количество миллисекунд
        /// </summary>
        /// <param name="milliseconds">Количество миллисекунд, на которое приостановить выполнение</param>
        protected void System_Sleep(int milliseconds) => SystemProxy.System_Sleep(milliseconds);

        /// <summary>
        /// Получает список всех аргументов командной строки, использованной при запуске программы
        /// </summary>
        /// <returns>Список всех аргументов командной строки</returns>
        protected string[] System_GetEnvironmentArguments() => SystemProxy.System_GetEnvironmentArguments();

        /// <summary>
        /// Возвращает имя netBIOS данного локального компьютера
        /// </summary>
        /// <returns>Возвращает имя netBIOS данного локального компьютера</returns>
        protected string System_GetMachineName() => SystemProxy.System_GetMachineName();

        /// <summary>
        /// Возвращает идентификатор платформы, версию и пакет обновления, установленные в системе
        /// </summary>
        /// <returns>Возвращает идентификатор платформы, версию и пакет обновления, установленные в системе</returns>
        protected string System_GetOSVersion() => SystemProxy.System_GetOSVersion();

        /// <summary>
        /// Возвращает число процессоров на текущей машине
        /// </summary>
        /// <returns>Возвращает число процессоров на текущей машине</returns>
        protected int System_GetProcessorCount() => SystemProxy.System_GetProcessorCount();

        /// <summary>
        /// Возвращает количество байтов на странице оперативной памяти системы
        /// </summary>
        /// <returns>Возвращает количество байтов на странице оперативной памяти системы</returns>
        protected int System_GetSystemPageSize() => SystemProxy.System_GetSystemPageSize();

        /// <summary>
        /// Возвращает полный путь к системному каталогу
        /// </summary>
        /// <returns>Возвращает полный путь к системному каталогу</returns>
        protected string System_GetSystemDirectory() => SystemProxy.System_GetSystemDirectory();

        /// <summary>
        /// Возвращает имя сетевого домена, связанного с текущим пользователем
        /// </summary>
        /// <returns>Возвращает имя сетевого домена, связанного с текущим пользователем</returns>
        protected string System_GetUserDomainName() => SystemProxy.System_GetUserDomainName();

        /// <summary>
        /// Возвращает имя пользователя, который на данный момент выполнил вход в операционную систему
        /// </summary>
        /// <returns>Имя пользователя</returns>
        protected string System_GetUserName() => SystemProxy.System_GetUserName();

        /// <summary>
        /// Возвращает объем физической памяти, сопоставленной контексту текущего процесса
        /// </summary>
        /// <returns></returns>
        protected string System_GetWorkingMemorySet() => SystemProxy.System_GetWorkingMemorySet();

        /// <summary>
        /// Версия продукта Black Magic Virtual Environment
        /// </summary>
        /// <returns>Версия продукта BMVE</returns>
        protected string System_Version() => SystemProxy.System_Version();
    }
}
