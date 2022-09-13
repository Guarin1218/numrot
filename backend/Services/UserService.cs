using System;
using AutoMapper;
using backend.Entities;
using backend.Helpers;
using backend.Interfaces;
using WebApi.Models.Users;

namespace backend.Services
{
   
  
   public class UserService : IUserService
    {

        private DataContext _context;

        private readonly IMapper _mapper;

        public UserService(
        DataContext context,
        IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        public void Create(CreateRequest model)
        {   
            // validate
            if (_context.Users.Any(x => x.Email == model.Email))
                throw new BadHttpRequestException("Usuario con email '" + model.Email + "' ya existe");

            // map model to new user object
            var user = _mapper.Map<User>(model);           

            // save user
            _context.Users.AddAsync(user);            
            _context.SaveChanges();    
        }
    }
}

