using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;


namespace Host.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]

    public class UserController
    {
        [HttpPost]
        public Response AddUser([FromBody] User user)
        {
            Response response = UserService.AddUser(user);
            return response;


        }
        [HttpPost]
        [Route("login")]
        public LoginResponse Login([FromBody] LoginRequest request)
        {
            LoginResponse response = UserService.Login(request);
            return response;
        }
    }
}