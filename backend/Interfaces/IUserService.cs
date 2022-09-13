using System;
using backend.Entities;
using WebApi.Models.Users;

namespace backend.Interfaces
{
    public interface IUserService
    {

        IEnumerable<User> GetAll();
        //User GetById(int id);
        void Create(CreateRequest model);
        //void Update(int id, UpdateRequest model);
        //void Delete(int id);
    }
}

