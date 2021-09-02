using BMVE.Core.Enums;
using BMVE.Core.Utils.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Database
{
    internal class MySqlDbProvider : AbstractDbProvider
    {
        internal override DatabaseKind DatabaseKind => DatabaseKind.MySql;

        public override void OpenConnection(string connectionString)
        {
            this.Connection = new MySqlConnection(connectionString);
            this.Connection.Open();
        }
    }
}
