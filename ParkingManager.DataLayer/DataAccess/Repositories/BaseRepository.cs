using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ParkingManager.DataLayer.DataAccess.Repositories
{
    public abstract class BaseRepository<TContext, T> where TContext : DbContext where T : class
    {
        protected TContext Db;
        public BaseRepository(TContext dbContext)
        {
            Db = dbContext;
        }

        public bool CommitTransactions()
        {
            try
            {
                Db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public virtual T? FirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            var set = Db.Set<T>();
            return set.FirstOrDefault(predicate);
        }
        public virtual List<T> GetAll()
        {
            var set = Db.Set<T>();
            return set.ToList();
        }

        public virtual List<T> Get(Expression<Func<T, bool>> predicate)
        {
            var set = Db.Set<T>();
            return set.Where(predicate).ToList();
        }

        public virtual T? Add(T model)
        {
            var set = Db.Set<T>();
            set.Add(model);

            return CommitTransactions() ? model : null;
        }

        public virtual bool Delete(T entity)
        {
            var set = Db.Set<T>();
            set.Remove(entity);
            return CommitTransactions();
        }
    }
}
