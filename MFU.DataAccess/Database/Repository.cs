using MFU.Models;
using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
namespace MFU.DataAccess
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        public IDbConnection connectionFactory;

        public Repository()
        {
            connectionFactory = ConnectionFactory.GetInstant();
        }

        public Repository(DatabaseSource dataSource)
        {
            connectionFactory = ConnectionFactory.GetInstant(dataSource);
        }

        public T GetById(int id)
        {
            using (connectionFactory)
            {
                return connectionFactory.Get<T>(id);
            }
        }

        public IEnumerable<T> GetAll()
        {
            using (connectionFactory)
            {
                return connectionFactory.GetList<T>();
            }
        }

        public void Add(T entity)
        {
            using (connectionFactory)
            {
                connectionFactory.Insert(entity);
            }
        }

        public void Delete(T entity)
        {
            using (connectionFactory)
            {
                connectionFactory.Delete(entity);
            }
        }

        public void Update(T entity)
        {
            using (connectionFactory)
            {
                connectionFactory.Update(entity);
            }
        }
    }
}