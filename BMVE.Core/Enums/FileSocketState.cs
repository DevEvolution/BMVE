using BMVE.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Enums
{
    internal enum FileSocketState
    {
        [Display("открыт для чтения")]
        OpenedToRead,

        [Display("открыт для записи")]
        OpenedToWrite,

        [Display("открыт для дозаписи")]
        OpenedToAppend,

        [Display("закрыт")]
        Closed
    }
}
