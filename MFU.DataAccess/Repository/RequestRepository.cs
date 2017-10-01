using MFU.Models;
using System.Collections.Generic;
using System.Linq;
using Dapper;

namespace MFU.DataAccess.Repository
{
    public class RequestRepository : Repository<Request>
    {
        public RequestRepository(DatabaseSource databaseSource) : base (databaseSource)
        {

        }
        public IEnumerable<Request> GetAllRequest()
        {
            using (var conn = ConnectionFactory.Connection())
            {
                return conn.Query<Request, RequestType, Request>(SqlText.Request_Select,
                (request, reuestType) =>
                {
                    request.RequestType = reuestType;
                    return request;
                },
                splitOn: "RequestTypeId"
                ).ToList();
            }
        }

        public Request GetRequestById(int id)
        {
            using (var conn = ConnectionFactory.Connection())
            {
                return conn.Query<Request, RequestType, Request>(SqlText.Request_Select_ByID.Replace("@REQUESTID", id.ToString()),
                (request, reuestType) =>
                {
                    request.RequestType = reuestType;
                    return request;
                },
                splitOn: "RequestTypeId"
                ).FirstOrDefault();
            }
        }

    }
}
