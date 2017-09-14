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
    public class ConnectionFactory
    {
        private ConnectionFactory() { }

        public static IDbConnection GetInstant()
        {
            var dataSource = (DatabaseSource)Enum.Parse(typeof(DatabaseSource), DataAccessAppSetting.DefaultDatabase);
            return GetDatabaseConnection(dataSource);
        }

        public static IDbConnection GetInstant(DatabaseSource dataSource)
        {
            return GetDatabaseConnection(dataSource);
        }

        private static IDbConnection GetDatabaseConnection(DatabaseSource dataSource)
        {
            switch (dataSource)
            {
                case DatabaseSource.SqlServer:
                    return new SqlConnection(DataAccessConnectionString.SqlServer);
                case DatabaseSource.Oracle:
                    return new OracleConnection(DataAccessConnectionString.Oracle);
                case DatabaseSource.MySql:
                    return new MySqlConnection(DataAccessConnectionString.MySql);
                default:
                    return new SqlConnection(DataAccessConnectionString.SqlServer);
            }
        }
    }
}