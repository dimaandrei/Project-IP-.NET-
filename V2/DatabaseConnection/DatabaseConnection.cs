using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseConnection
{
    public class DatabaseConnection
    {
        //private static DatabaseConnection _dbConn= null;
        private static OracleConnection _dbConn;// = new OracleConnection(@"Data Source=localhost;User ID=andreidima;Password=********");
        public static OracleConnection GetConncetionInstance()
        {
            if (_dbConn == null)
                _dbConn = new OracleConnection(@"Data Source=localhost;User ID=andreidima;Password=********");
            return _dbConn;
        }
        public static void CloseConnection()
        {
            if (_dbConn != null)
                _dbConn.Close();
        }
    }
}
