using MFU.Models;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace MFU.DataAccess.Repository
{
    public class RequestRepository : Repository<Request>
    {
        public RequestRepository(DatabaseSource databaseSource) : base (databaseSource)
        {

        }
        public IEnumerable<Request> GetAllRequest()
        {
            //using (var conn = ConnectionFactory.Connection())
            //{
            //    return conn.Query<Request, RequestType, Request>(SqlText.Request_Select,
            //    (request, reuestType) =>
            //    {
            //        request.RequestType = reuestType;
            //        return request;
            //    },
            //    splitOn: "RequestTypeId"
            //    ).ToList();
            //}
            return new List<Request>();
        }

        public Request GetRequestById(int id)
        {
            //using (var conn = ConnectionFactory.Connection())
            //{
            //    return conn.Query<Request, RequestType, Request>(SqlText.Request_Select_ByID.Replace("@REQUESTID", id.ToString()),
            //    (request, reuestType) =>
            //    {
            //        request.RequestType = reuestType;
            //        return request;
            //    },
            //    splitOn: "RequestTypeId"
            //    ).FirstOrDefault();
            //}
            return new Request();
        }

        public Province GetProvinceById(string id)
        {
            using (var conn = ConnectionFactory.Connection())
            {
                var parameters = new OracleDynamicParameters();
                parameters.Add("vprovinceid", 170, dbType: OracleDbType.Int32);
                parameters.Add("vlanguage", "T", dbType: OracleDbType.Varchar2);
                parameters.Add("pdata", dbType: OracleDbType.RefCursor, direction: ParameterDirection.Output);
                var affectedRows = conn.Query<Province>(
                    sql: "SP_NAME",
                    param: parameters,
                    commandType: CommandType.StoredProcedure).FirstOrDefault();
                return affectedRows;
            }
        }

    }
}
