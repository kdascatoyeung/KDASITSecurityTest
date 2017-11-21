using ITSecurityTest.Models.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITSecurityTest.Models.Repositories
{
    public class GroupRepository : RepositoryBase<Group>, IGroupRepository
    {
        public GroupRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IGroupRepository : IRepository<Group>
    {
    }
}
