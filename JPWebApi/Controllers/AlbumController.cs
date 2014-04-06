using JPWebApi.Models;
using JPWebApi.Services;
using MongoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JPWebApi.Controllers
{
    public class AlbumController : ApiController
    {
        private AlbumRepository albumRepository;
        //static MongoRepository<Album> albumRepo = new MongoRepository<Album>();

        public AlbumController()
        {
            this.albumRepository = new AlbumRepository();
        }

        public Album get()
        {
            return albumRepository.First(a => a.AlbumName == "MyAlbum");
        }
    }
}
