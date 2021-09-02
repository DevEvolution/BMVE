using BMVE.Core.Utils.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Interfaces
{
    internal interface IDatabaseProvider : IDisposable
    {
        void OpenConnection(string connectionString);

        void BeginTransaction();

        void CommitTransaction();

        void RollbackTransaction();

        int ExecuteNonQuery(string sqlString, params string[] parameters);

        string ExecuteScalar(string sqlString, params string[] parameters);

        string[,] ExecuteReader(string sqlString, params string[] parameters);
    }
}
