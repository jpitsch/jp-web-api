using JPWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JPWebApi.Controllers
{
    public class SingerController : ApiController
    {
        public Singer[] Get()
        {
            return new Singer[]
            {
                new Singer
                {
                    //Id = "1",
                    Name = "Jason",
                    Birthday = new DateTime (1981, 02, 16),
                    Gender = Gender.MALE
                },
                new Singer
                {
                    //Id = "2",
                    Name = "Dugglas",
                    Birthday = new DateTime(1985, 01, 01),
                    Gender = Gender.MALE
                }
            };
        }
    }
}
