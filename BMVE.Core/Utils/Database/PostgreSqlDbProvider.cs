using BMVE.Core.Enums;
using BMVE.Core.Utils.Utils;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Database
{
    internal class PostgreSqlDbProvider : AbstractDbProvider
    {
        internal override DatabaseKind DatabaseKind => DatabaseKind.PostgreSql;

        public override void OpenConnection(string connectionString)
        {
            this.Connection = new NpgsqlConnection(connectionString);
            this.Connection.Open();
        }
    }
}
