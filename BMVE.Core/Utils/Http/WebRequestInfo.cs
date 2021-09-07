using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Http
{
    internal class WebRequestInfo
    {
        public Guid MetaId { get; set; }

        public string FormBody { get; set; }

        public Dictionary<string, string> QueryString { get; set; }

        public Dictionary<string, string> FormData { get; set; }
    }
}
