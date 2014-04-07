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
    public class RecordCompanyController : ApiController
    {
        private RecordCompanyRepository recordCompanyRepository;

        public RecordCompanyController()
        {
            recordCompanyRepository = new RecordCompanyRepository();
        }

        public RecordCompany Get()
        {
            return null;
        }
    }
}
