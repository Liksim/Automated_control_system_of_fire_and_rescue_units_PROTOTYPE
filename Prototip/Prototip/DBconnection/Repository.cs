using Dapper;
using Microsoft.EntityFrameworkCore;
using Prototip.DBconnection.Entities;
using System.Data;

namespace Prototip.DBconnection
{
    public class Repository<T> where T : Entity
    {
        private readonly Context _context;

        public Repository(Context context) 
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Add(entity);
            Save();
        }

        public IQueryable<T> Read() 
        {
            return _context.Set<T>().AsNoTracking();
        }

        public T Read(int id) 
        {
            return _context.Set<T>().Where(x => x.Id == id).First();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            Save();
        }

        public void Delete(int id)
        {
            _context.Remove(Read(id));
            Save();
        }

        public void Save() 
        { 
            _context.SaveChanges();
        }

        public IEnumerable<Q> SQL<Q>(string sql, object? param = null)
        {
            var conn = _context.Database.GetDbConnection();

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            return conn.Query<Q>(sql, param: param);
        }
    }
}
