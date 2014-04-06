using MongoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JPWebApi.Models
{
    public class Album : Entity
    { 
        public string AlbumName { get; set; }
    }
}