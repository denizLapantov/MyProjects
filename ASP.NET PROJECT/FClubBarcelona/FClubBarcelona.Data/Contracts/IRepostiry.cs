using System;
using System.Linq;
using System.Linq.Expressions;

namespace FClubBarcelona.Data.Contracts
{
    public interface IRepostiry<T>
    {
        void Add(T entity);

        void Delete(T entity);

        T FindByPredicate(Expression<Func<T, bool>> predicate);

        IQueryable<T> Find(Expression<Func<T, bool>> predicate);

        IQueryable<T> GetAll();

        T GetById(int id);
    }
}
