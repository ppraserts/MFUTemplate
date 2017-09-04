using MFU.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MFU.DataAccess.Repository
{
    public class DocumentCategoryRepository : IRepository<DocumentCategory>
    {
        private readonly IDbConnection db;
        public DocumentCategoryRepository()
        {
            db = DbConnector.GetInstant();
        }
        public DocumentCategoryRepository(DatabaseSource dataSource)
        {
            db = DbConnector.GetInstant(dataSource);
        }

        public IEnumerable<DocumentCategory> GetAll()
        {
            return db.GetList<DocumentCategory>();
        }

        public DocumentCategory GetById(int id)
        {
            return db.Get<DocumentCategory>(id);
        }
    }
}