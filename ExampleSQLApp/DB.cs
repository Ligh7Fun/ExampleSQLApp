using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSQLApp
{
    internal class DB
    {
        private const string Host = "95.105.52.2";
        private const string Port = "5432";
        private const string Username = "examplesqlapp";
        private const string Password = "12345";
        private const string Database = "examplesqlapp";

        public static NpgsqlConnection GetConnection()
        {
            string connectionString = $"Host={Host};Port={Port};Username={Username};Password={Password};Database={Database}";

            // Возвращает объект NpgsqlConnection, готовый для использования при подключении к базе данных PostgreSQL
            return new NpgsqlConnection(connectionString);
        }
    }
}