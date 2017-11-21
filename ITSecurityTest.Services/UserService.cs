using ITSecurityTest.Models;
using ITSecurityTest.Models.Infrastructure;
using ITSecurityTest.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITSecurityTest.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        User Get(int id);
        void Add(User department);
        void Update(User department);
        void Delete(int id);
        void Save();
    }

    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IUnitOfWork unitOfWork;

        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            this.userRepository = userRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IUserService Members

        public IEnumerable<User> GetAll()
        {
            var users = userRepository.GetAll();
            return users;
        }

        public User Get(int id)
        {
            var user = userRepository.GetById(id);
            return user;
        }

        public void Add(User user)
        {
            userRepository.Add(user);
        }

        public void Update(User user)
        {
            userRepository.Update(user);
        }

        public void Delete(int id)
        {
            userRepository.Delete(id);
        }

        public void Save()
        {
            unitOfWork.Commit();
        }

        #endregion
    }
}
