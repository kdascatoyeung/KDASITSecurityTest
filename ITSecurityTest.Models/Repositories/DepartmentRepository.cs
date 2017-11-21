using ITSecurityTest.Models.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITSecurityTest.Models.Repositories
{
    public class DepartmentRepository : RepositoryBase<Department>, IDepartmentRepository
    {
        public DepartmentRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IDepartmentRepository : IRepository<Department>
    {
    }
}
