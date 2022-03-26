using System.Linq.Expressions;

namespace ParkingManager.DataLayer.DataAccess.Repositories
{
    public interface IRepository<T>
    {
        T? FirstOrDefault(Expression<Func<T, bool>> predicate);
        List<T> Get(Expression<Func<T, bool>> predicate);
        List<T> GetAll();
        T? Add(T entity);
        bool Delete(T entity);
    }
}
