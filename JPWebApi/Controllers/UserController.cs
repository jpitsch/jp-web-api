using JPWebApi.Models;
using JPWebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JPWebApi.Controllers
{
    [RoutePrefix("api/users")]
    public class UserController : ApiController
    {
        private UserRepository userRepository;

        public UserController()
        {
            userRepository = new UserRepository();
        }

        public IEnumerable<User> Get()
        {
            var users = userRepository.Where(u => u.Role == "Admin");
            return users;
        }

        public IEnumerable<User> Username(string username)
        {
            var users = userRepository.Where(u => u.UserName == username);
            return users;
        }
    }
}
