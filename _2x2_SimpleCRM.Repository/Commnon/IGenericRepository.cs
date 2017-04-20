using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2x2_SimpleCRM.Repository.Commnon
{
    public interface IGenericRepository<T> where T :class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);

        T Get(int id);
        T AddOrUpdate(T entity);
        T Delete(T entity);
    }
}
