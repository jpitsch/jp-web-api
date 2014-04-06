using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JPWebApi.Models
{
    public class Singer : Entity
    {
        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public Gender Gender { get; set; }
    }
}