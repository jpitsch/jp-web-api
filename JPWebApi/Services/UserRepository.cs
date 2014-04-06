using JPWebApi.Models;
using MongoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JPWebApi.Services
{
    public class UserRepository : MongoRepository<User>
    {
    }
}