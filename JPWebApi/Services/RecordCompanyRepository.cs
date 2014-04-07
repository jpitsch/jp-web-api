using JPWebApi.Models;
using MongoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JPWebApi.Services
{
    public interface IRecordCompanyRepository
    {
    }

    public class RecordCompanyRepository : MongoRepository<RecordCompany>
    {
    }
}