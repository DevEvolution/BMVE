using BMVE.Core.Enums;
using BMVE.Core.Interfaces;
using BMVE.Core.Utils.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Database
{
    internal abstract class AbstractDbProvider : IDatabaseProvider, IDisposable
    {
        internal abstract DatabaseKind DatabaseKind { get; }
        internal IDbConnection Connection { get; set; }
        internal IDbTransaction Transaction { get; set; }

        public abstract void OpenConnection(string connectionString);

        public virtual void BeginTransaction()
        {
            this.AssertConnectionOpen();

            if (this.Connection.State != System.Data.ConnectionState.Open)
            {
                this.Connection.Open();
            }

            this.Transaction = this.Connection.BeginTransaction();
        }

        public virtual void CommitTransaction()
        {
            this.AssertConnectionOpen();
            this.AssertTransactionOpen();

            this.Transaction.Commit();
        }

        public virtual void RollbackTransaction()
        {
            this.AssertConnectionOpen();
            this.AssertTransactionOpen();

            this.Transaction.Rollback();
        }

        public virtual int ExecuteNonQuery(string sqlString, params string[] parameters)
        {
            this.AssertConnectionOpen();

            var command = this.GetParsedCommand(sqlString, parameters);

            return command.ExecuteNonQuery();
        }

        public virtual string ExecuteScalar(string sqlString, params string[] parameters)
        {
            this.AssertConnectionOpen();

            var command = this.GetParsedCommand(sqlString, parameters);

            return command.ExecuteScalar().ToString();
        }

        public virtual string[,] ExecuteReader(string sqlString, params string[] parameters)
        {
            this.AssertConnectionOpen();

            var command = this.GetParsedCommand(sqlString, parameters);
            var resultMultiList = new List<List<string>>();

            var columnCount = 0;
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    columnCount = reader.FieldCount;
                    var row = new List<string>(columnCount);
                    for (int i = 0; i < columnCount; i++)
                    {
                        row.Add(reader.GetString(i));
                    }
                    resultMultiList.Add(row);
                }
            }

            var resultArray = new string[columnCount, resultMultiList.Count];
            for (int i = 0; i < resultMultiList.Count; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    resultArray[j, i] = resultMultiList[i][j];
                }
            }

            return resultArray;
        }

        protected IDbCommand GetParsedCommand(string sqlString, params string[] parameters)
        {
            var command = this.Connection.CreateCommand();
            command.CommandText = sqlString;

            var paramEnumerator = parameters.GetEnumerator();

            foreach (Match match in Regex.Matches(sqlString, @"\s+(:\w+)", RegexOptions.IgnoreCase))
            {
                var param = command.CreateParameter();
                param.ParameterName = match.Groups[1].Value;

                if (!paramEnumerator.MoveNext())
                {
                    throw new Exception("Несоответствие количества указанных и переданных параметров в SQL запросе");
                }

                param.Value = paramEnumerator.Current as string;
                command.Parameters.Add(param);
            }

            return command;
        }

        protected void AssertConnectionOpen()
        {
            if (this.Connection == null)
            {
                throw new Exception("Подключение к БД не было установлено либо было закрыто");
            }
        }

        protected void AssertTransactionOpen()
        {
            if (this.Transaction == null)
            {
                throw new Exception("Транзакция не была начата либо уже была завершена");
            }
        }

        #region Disposable

        private bool _disposed;
        private object _disposingSyncRoot = new object();

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            lock (this._disposingSyncRoot)
            {
                if (this._disposed)
                {
                    return;
                }

                this._disposed = true;
            }
            if (disposing)
            {
                this.Transaction.Dispose();
                this.Connection.Dispose();
            }
        }

        #endregion
    }
}
