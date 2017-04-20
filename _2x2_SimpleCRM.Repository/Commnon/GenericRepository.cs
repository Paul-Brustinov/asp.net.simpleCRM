using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqKit;

namespace _2x2_SimpleCRM.Repository.Commnon
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T:class
    {
        protected DbContext Context;
        protected readonly IDbSet<T> DbSet;

        public GenericRepository(DbContext context)
        {
            Context = context;
            DbSet = context.Set<T>();
        }

        public T AddOrUpdate(T entity)
        {
            DbSet.AddOrUpdate(entity);
            return entity;
        }

        public T Delete(T entity)
        {
            DbSet.Remove(entity);
            return entity;
        }

        public IEnumerable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return DbSet.AsExpandable().Where(predicate);
        }

        public T Get(int id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return DbSet.AsEnumerable<T>();
        }
    }
}
