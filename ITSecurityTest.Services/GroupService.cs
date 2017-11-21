using ITSecurityTest.Models;
using ITSecurityTest.Models.Infrastructure;
using ITSecurityTest.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITSecurityTest.Services
{
    public interface IGroupService
    {
        IEnumerable<Group> GetAll();
        Group Get(int id);
        void Add(Group department);
        void Update(Group department);
        void Delete(int id);
        void Save();
    }

    public class GroupService : IGroupService
    {
        private readonly IGroupRepository groupRepository;
        private readonly IUnitOfWork unitOfWork;

        public GroupService(IGroupRepository groupRepository, IUnitOfWork unitOfWork)
        {
            this.groupRepository = groupRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IGroupService Members

        public IEnumerable<Group> GetAll()
        {
            var departments = groupRepository.GetAll();
            return departments;
        }

        public Group Get(int id)
        {
            var department = groupRepository.GetById(id);
            return department;
        }

        public void Add(Group group)
        {
            groupRepository.Add(group);
        }

        public void Update(Group group)
        {
            groupRepository.Update(group);
        }

        public void Delete(int id)
        {
            groupRepository.Delete(id);
        }

        public void Save()
        {
            unitOfWork.Commit();
        }

        #endregion
    }
}
