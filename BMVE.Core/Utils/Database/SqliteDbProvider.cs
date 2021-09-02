using BMVE.Core.Enums;
using BMVE.Core.Utils.Utils;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Database
{
    internal class SqliteDbProvider : AbstractDbProvider
    {
        internal override DatabaseKind DatabaseKind => DatabaseKind.Sqlite;

        public override void OpenConnection(string connectionString)
        {
            SQLitePCL.Batteries.Init();
            this.Connection = new SqliteConnection(connectionString);
            this.Connection.Open();
        }
    }
}
