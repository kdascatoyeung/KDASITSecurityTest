using System;
using System.Collections.Generic;
using System.Text;

namespace ITSecurityTest.Models.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private ITSecurityTestEntities dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public ITSecurityTestEntities DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.Commit();
        }
    }
}