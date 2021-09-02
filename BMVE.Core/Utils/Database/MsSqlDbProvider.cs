using BMVE.Core.Enums;
using BMVE.Core.Interfaces;
using BMVE.Core.Utils.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Database
{
    internal class MsSqlDbProvider : AbstractDbProvider
    {
        internal override DatabaseKind DatabaseKind => DatabaseKind.MsSqlServer;

        public override void OpenConnection(string connectionString)
        {
            this.Connection = new SqlConnection(connectionString);
            this.Connection.Open();
        }

    }
}
