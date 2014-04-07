using MongoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JPWebApi.Models
{
    public class Album : BaseEntity
    { 
        public string AlbumName { get; set; }

        public Genre Genre { get; set; }

        public DateTime ReleaseYear { get; set; }
    }
}