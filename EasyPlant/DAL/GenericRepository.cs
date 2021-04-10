using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EasyPlant.DAL
{

   public class GenericRepository<T> where T : class
    {
        public BDPlant context;
        public DbSet<T> dbSet;
        public GenericRepository(BDPlant _context)
        {
            context = _context;
           dbSet = context.Set<T>();
        }
        public virtual EntityState Insert(T entity)
        {
            try
            {              
                dbSet.Add(entity);
                context.SaveChanges();
                return context.Entry(entity).State;
            }
            catch(Exception ex)
            {
                return EntityState.Added;
            }
            finally
            {
                
            }
           
        }
       
        public virtual void Update(T entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
            context.SaveChanges();
        }
        //public virtual void Select(T entity)
        //{
        //    dbSet.Select(entity);
        //}

        public virtual IEnumerable<T> Get(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }
        public virtual T GetByID(object id)
        {
            return dbSet.Find(id);
        }
        public virtual void Delete(object id)
        {
            T entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
            context.SaveChanges();
        }
        public virtual void Delete(T entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }
       

}
}
