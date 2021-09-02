using BMVE.Core.Enums;
using BMVE.Core.Utils.Utils;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Database
{
    internal class OracleDbProvider : AbstractDbProvider
    {
        internal override DatabaseKind DatabaseKind => DatabaseKind.Oracle;

        public override void OpenConnection(string connectionString)
        {
            this.Connection = new OracleConnection(connectionString);
            this.Connection.Open();
        }
    }
}
