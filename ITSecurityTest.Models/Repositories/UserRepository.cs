using ITSecurityTest.Models.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITSecurityTest.Models.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IUserRepository : IRepository<User>
    {
    }
}
