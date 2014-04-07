using JPWebApi.Models;
using MongoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JPWebApi.Services
{
    public interface ISingerRepository
    {
    }

    public class SingerRepository : MongoRepository<Singer>
    {
    }
}