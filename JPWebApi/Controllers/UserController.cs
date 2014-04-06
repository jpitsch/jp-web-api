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
    public class UserController : ApiController
    {
        private UserRepository userRepository;

        public UserController()
        {
            userRepository = new UserRepository();
        }

        public User get()
        {
            var user = userRepository.First(u => u.FirstName == "Jason");
            return user;
        }
    }
}
