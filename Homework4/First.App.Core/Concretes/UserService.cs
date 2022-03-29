using First.App.Business.Abstract;
using First.App.DataAccess.EntityFramework.Repository.Abstracts;
using First.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First.App.Business.Concretes
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> repository;
        private readonly IUnitOfWork unitOfWork;

        public UserService(IRepository<User> repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public User Create(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(User user)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            return repository.Get().ToList();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public User Update(User user)
        {
            throw new NotImplementedException();
        }

        public bool UserExists(User user)
        {
            return GetAll().Any(x => x.Name == user.Name && x.Password == user.Password);
        }
    }
}
