using BMVE.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core
{
    public partial class Runnable
    {
        /// <summary>
        /// Открыть подключение к БД Microsoft SQL Server
        /// </summary>
        /// <param name="number">Номер подключения к БД</param>
        /// <param name="connectionString">Строка подключения</param>
        protected void Database_OpenSqlServerConnection(int number, string connectionString)
        {
            DatabaseProxy.Database_OpenSqlServerConnection(number, connectionString);
        }

        /// <summary>
        /// Открыть подключение к БД MySql
        /// </summary>
        /// <param name="number">Номер подключения к БД</param>
        /// <param name="connectionString">Строка подключения</param>
        protected void Database_OpenMySqlConnection(int number, string connectionString)
        {
            DatabaseProxy.Database_OpenMySqlConnection(number, connectionString);
        }

        /// <summary>
        /// Открыть подключение к БД PostgreSql
        /// </summary>
        /// <param name="number">Номер подключения к БД</param>
        /// <param name="connectionString">Строка подключения</param>
        protected void Database_OpenPostgreSqlConnection(int number, string connectionString)
        {
            DatabaseProxy.Database_OpenPostgreSqlConnection(number, connectionString);
        }

        /// <summary>
        /// Открыть подключение к БД Oracle Db
        /// </summary>
        /// <param name="number">Номер подключения к БД</param>
        /// <param name="connectionString">Строка подключения</param>
        protected void Database_OpenOracleDbConnection(int number, string connectionString)
        {
            DatabaseProxy.Database_OpenOracleDbConnection(number, connectionString);
        }

        /// <summary>
        /// Открыть подключение к БД Sqlite
        /// </summary>
        /// <param name="number">Номер подключения к БД</param>
        /// <param name="connectionString">Строка подключения</param>
        protected void Database_OpenSqliteConnection(int number, string connectionString)
        {
            DatabaseProxy.Database_OpenSqliteConnection(number, connectionString);
        }

        /// <summary>
        /// Открыто ли подключение к БД под указанным номером
        /// </summary>
        /// <param name="number">Номер подключения к БД</param>
        /// <returns>Открыто ли подключение</returns>
        protected bool Database_IsConnectionOpen(int number)
        {
            return DatabaseProxy.Database_IsConnectionOpen(number);
        }

        /// <summary>
        /// Выполнить запрос, не требующий возврата значения
        /// </summary>
        /// <param name="number">Номер подключения к БД</param>
        /// <param name="sqlString">Строка запроса. Подставляемые параметры должны начинаться с двоеточия и состоять только из букв и цифр (:param)</param>
        /// <param name="parameters">Значения параметров. Подставляются в порядке, в котором указаны при вызове функции</param>
        /// <returns>Количество затронутых строк</returns>
        protected int Database_ExecuteNonQuery(int number, string sqlString, params string[] parameters)
        {
            return DatabaseProxy.Database_ExecuteNonQuery(number, sqlString, parameters);
        }

        /// <summary>
        /// Выполнить запрос, возвращающий одиночное значение
        /// </summary>
        /// <param name="number">Номер подключения к БД</param>
        /// <param name="sqlString">Строка запроса. Подставляемые параметры должны начинаться с двоеточия и состоять только из букв и цифр (:param)</param>
        /// <param name="parameters">Значения параметров. Подставляются в порядке, в котором указаны при вызове функции</param>
        /// <returns>Возвращенное значение</returns>
        protected string Database_ExecuteScalar(int number, string sqlString, params string[] parameters)
        {
            return DatabaseProxy.Database_ExecuteScalar(number, sqlString, parameters);
        }

        /// <summary>
        /// Выполнить запрос, возвращающий таблицу
        /// </summary>
        /// <param name="number">Номер подключения к БД</param>
        /// <param name="sqlString">Строка запроса. Подставляемые параметры должны начинаться с двоеточия и состоять только из букв и цифр (:param)</param>
        /// <param name="parameters">Значения параметров. Подставляются в порядке, в котором указаны при вызове функции</param>
        /// <returns>Таблица строк</returns>
        protected string[,] Database_ExecuteReader(int number, string sqlString, params string[] parameters)
        {
            return DatabaseProxy.Database_ExecuteReader(number, sqlString, parameters);
        }

        /// <summary>
        /// Начать транзакцию
        /// </summary>
        /// <param name="number">Номер подключения к БД</param>
        protected void Database_BeginTransaction(int number)
        {
            DatabaseProxy.Database_BeginTransaction(number);
        }

        /// <summary>
        /// Зафиксировать транзакцию
        /// </summary>
        /// <param name="number">Номер подключения к БД</param>
        protected void Database_CommitTransaction(int number)
        {
            DatabaseProxy.Database_CommitTransaction(number);
        }

        /// <summary>
        /// Откатить транзакцию
        /// </summary>
        /// <param name="number">Номер подключения к БД</param>
        protected void Database_RollbackTransaction(int number)
        {
            DatabaseProxy.Database_RollbackTransaction(number);
        }

        /// <summary>
        /// Закрыть соединение с БД
        /// </summary>
        /// <param name="number">Номер подключения к БД</param>
        protected void Database_CloseConnection(int number)
        {
            DatabaseProxy.Database_CloseConnection(number);
        }
    }
}
