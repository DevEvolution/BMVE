using BMVE.Core.Interfaces;
using BMVE.Core.Utils.Database;
using BMVE.Core.Utils.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Commands
{
    internal static class DatabaseProxy
    {
        internal static void Database_OpenSqlServerConnection(int number, string connectionString)
        {
            OpenSocket<MsSqlDbProvider>(number, connectionString);
        }

        internal static void Database_OpenMySqlConnection(int number, string connectionString)
        {
            OpenSocket<MySqlDbProvider>(number, connectionString);
        }

        internal static void Database_OpenPostgreSqlConnection(int number, string connectionString)
        {
            OpenSocket<PostgreSqlDbProvider>(number, connectionString);
        }

        internal static void Database_OpenOracleDbConnection(int number, string connectionString)
        {
            OpenSocket<OracleDbProvider>(number, connectionString);
        }

        internal static void Database_OpenSqliteConnection(int number, string connectionString)
        {
            OpenSocket<SqliteDbProvider>(number, connectionString);
        }

        internal static bool Database_IsConnectionOpen(int number)
        {
            return ManagedSocketResolver
                .DatabaseSocket
                .IsSocketBusy(number);
        }

        internal static int Database_ExecuteNonQuery(int number, string sqlString, params string[] parameters)
        {
            AssertDbSocketIsOpen(number);

            return ManagedSocketResolver
                .DatabaseSocket[number]
                .DatabaseProvider
                .ExecuteNonQuery(sqlString, parameters);
        }

        internal static string Database_ExecuteScalar(int number, string sqlString, params string[] parameters)
        {
            AssertDbSocketIsOpen(number);

            return ManagedSocketResolver
                .DatabaseSocket[number]
                .DatabaseProvider
                .ExecuteScalar(sqlString, parameters);
        }

        internal static string[,] Database_ExecuteReader(int number, string sqlString, params string[] parameters)
        {
            AssertDbSocketIsOpen(number);

            return ManagedSocketResolver
                .DatabaseSocket[number]
                .DatabaseProvider
                .ExecuteReader(sqlString, parameters);
        }

        internal static void Database_BeginTransaction(int number)
        {
            AssertDbSocketIsOpen(number);

            ManagedSocketResolver
                .DatabaseSocket[number]
                .DatabaseProvider
                .BeginTransaction();
        }

        internal static void Database_CommitTransaction(int number)
        {
            AssertDbSocketIsOpen(number);

            ManagedSocketResolver
                .DatabaseSocket[number]
                .DatabaseProvider
                .CommitTransaction();
        }

        internal static void Database_RollbackTransaction(int number)
        {
            AssertDbSocketIsOpen(number);

            ManagedSocketResolver
                .DatabaseSocket[number]
                .DatabaseProvider
                .RollbackTransaction();
        }

        internal static void Database_CloseConnection(int number)
        {
            AssertDbSocketIsOpen(number);

            ManagedSocketResolver
                .DatabaseSocket
                .CloseSocket(number);
        }

        private static void OpenSocket<TProvider>(int number, string connectionString)
            where TProvider : IDatabaseProvider, new()
        {
            AssertDbSocketIsFree(number);

            var socket = new DatabaseSocket { DatabaseProvider = new TProvider() };
            socket
                .DatabaseProvider
                .OpenConnection(connectionString);

            ManagedSocketResolver
                .DatabaseSocket
                .OpenNewSocket(number, socket);
        }

        private static void AssertDbSocketIsFree(int number)
        {
            if (ManagedSocketResolver.DatabaseSocket.IsSocketBusy(number))
            {
                throw new Exception($"Подключение к базе данных с номером ({number}) уже было открыто");
            }
        }

        private static void AssertDbSocketIsOpen(int number)
        {
            if (!ManagedSocketResolver.DatabaseSocket.IsSocketBusy(number))
            {
                throw new Exception($"Подключение к базе данных с номером ({number}) не было открыто");
            }
        }
    }
}
