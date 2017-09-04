using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MFU.DataAccess
{
    public class DbConnector
    {
        public static IDbConnection GetInstant()
        {
            string defaultDb = ConfigurationManager.AppSettings["DefaultDB"];
            var dataSource = (DatabaseSource)Enum.Parse(typeof(DatabaseSource), defaultDb);
            return GetDbConnection(dataSource);
        }

        public static IDbConnection GetInstant(DatabaseSource dataSource)
        {
            return GetDbConnection(dataSource);
        }

        private static IDbConnection GetDbConnection(DatabaseSource dataSource)
        {
            switch (dataSource)
            {
                case DatabaseSource.SQLServer:
                    return new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServerConnectionString"].ConnectionString);
                case DatabaseSource.Oracle:
                    return new OracleConnection(ConfigurationManager.ConnectionStrings["OracleConnectionString"].ConnectionString);
                case DatabaseSource.MySql:
                    return new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString);
                default:
                    return new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServerConnectionString"].ConnectionString);
            }
        }
    }
}