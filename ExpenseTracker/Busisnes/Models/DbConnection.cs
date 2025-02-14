using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ExpenseTracker.Busisnes.Interface;
using MySql.Data.MySqlClient;

namespace ExpenseTracker.Busisnes.Models
{
    public abstract class DbConnection
    {
        private string _connectionString;
        protected MySqlConnection connection;

        public DbConnection(string server, string port,string dataBase, string user)
        {
            _connectionString = $"Server={server};Port={port} ;DataBase={dataBase};Uid={user}";
        }
        public void OpenBd()
        {
            connection = new MySqlConnection(_connectionString);
            connection.Open();
        }
        public void CloseBd()
        {
            if(connection != null && connection.State == System.Data.ConnectionState.Open) 
                connection.Close();
        }
    }
}
