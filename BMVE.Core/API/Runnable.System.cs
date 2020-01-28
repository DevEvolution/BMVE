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
        /// Задает режим отображения: немедленное отображение
        /// </summary>
        protected void System_SetImmediateDrawingMode() => SystemProxy.System_SetDrawingMode(Enums.RenderingMode.Immediate);

        /// <summary>
        /// Задает режим отображения: буферизованное отображение
        /// </summary>
        protected void System_SetBufferedDrawingMode() => SystemProxy.System_SetDrawingMode(Enums.RenderingMode.Buffered);

        /// <summary>
        /// Приостановка выполнения программы на указанное количество миллисекунд
        /// </summary>
        /// <param name="milliseconds">Количество миллисекунд, на которое приостановить выполнение</param>
        protected void System_Sleep(int milliseconds) => SystemProxy.System_Sleep(milliseconds);

        /// <summary>
        /// Версия продукта Black Magic Virtual Environment
        /// </summary>
        /// <returns>Версия продукта BMVE</returns>
        protected string System_Version() => SystemProxy.System_Version();
    }
}
