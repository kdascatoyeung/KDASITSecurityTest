using ITSecurityTest.Models;
using ITSecurityTest.Models.Infrastructure;
using ITSecurityTest.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITSecurityTest.Services
{
    public interface IDepartmentService
    {
        IEnumerable<Department> GetAll();
        Department Get(int id);
        void Add(Department department);
        void Update(Department department);
        void Delete(int id);
        void Save();
    }

    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository departmentRepository;
        private readonly IUnitOfWork unitOfWork;

        public DepartmentService(IDepartmentRepository departmentRepository, IUnitOfWork unitOfWork)
        {
            this.departmentRepository = departmentRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IDepartmentService Members

        public IEnumerable<Department> GetAll()
        {
            var departments = departmentRepository.GetAll();
            return departments;
        }

        public Department Get(int id)
        {
            var department = departmentRepository.GetById(id);
            return department;
        }

        public void Add(Department department)
        {
            departmentRepository.Add(department);
        }

        public void Update(Department department)
        {
            departmentRepository.Update(department);
        }

        public void Delete(int id)
        {
            departmentRepository.Delete(id);
        }

        public void Save()
        {
            unitOfWork.Commit();
        }

        #endregion
    }
}
