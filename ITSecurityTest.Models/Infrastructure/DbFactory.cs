using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITSecurityTest.Models.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        ITSecurityTestEntities dbContext;

        public ITSecurityTestEntities Init()
        {
            return dbContext ?? (dbContext = new ITSecurityTestEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }

    public interface IDbFactory : IDisposable
    {
        ITSecurityTestEntities Init();
    }
}
