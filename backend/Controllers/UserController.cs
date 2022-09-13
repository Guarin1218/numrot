using System;
using AutoMapper;
using backend.Interfaces;
using Microsoft.AspNetCore.Mvc;
using backend.Services;
using WebApi.Models.Users;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        private IUserService _userService;
        private IMapper _mapper;

        public UserController(
        IUserService userService,
        IMapper mapper
        )
        {
            _userService = userService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        [HttpPost()]
        public IActionResult Create([FromBody] CreateRequest model)
        {
            
            _userService.Create(model);
            return Ok(new { message = "Usuario creado con éxito" });
        }

    }
}

