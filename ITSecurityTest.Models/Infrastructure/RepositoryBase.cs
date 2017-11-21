using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ITSecurityTest.Models.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(int id);

        void Delete(T entity);

        void Delete(Expression<Func<T, bool>> where);

        T GetById(int id);

        T GetByIdNoTracking(int id);

        IEnumerable<T> GetAll();

        IEnumerable<T> GetAllNoTracking();

        T Get(Expression<Func<T, bool>> where);

        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
    }

    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        #region Properties
        protected ITSecurityTestEntities dataContext;
        protected readonly DbSet<T> dbSet;

        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        protected ITSecurityTestEntities DbContext
        {
            get { return dataContext ?? (dataContext = DbFactory.Init()); }
        }
        #endregion

        protected RepositoryBase(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
            dbSet = DbContext.Set<T>();
        }

        #region Implementation
        public virtual void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(int id)
        {
            T entityToDelete = dbSet.Find(id);
            dbSet.Remove(entityToDelete);
        }

        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbSet.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbSet.Remove(obj);
        }

        public virtual T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public virtual T GetByIdNoTracking(int id)
        {
            var entity = dbSet.Find(id);
            dataContext.Entry(entity).State = EntityState.Detached;
            return entity;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public virtual IEnumerable<T> GetAllNoTracking()
        {
            return dbSet.AsNoTracking().ToList();
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).ToList();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).FirstOrDefault<T>();
        }

        #endregion

    }
}
