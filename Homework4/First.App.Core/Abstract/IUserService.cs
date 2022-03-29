using First.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.App.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetById(int id);
        User Create(User user);
        User Update(User user);
        void Delete(User user);
        bool UserExists(User user);
    }
}
