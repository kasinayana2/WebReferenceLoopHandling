using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebReferenceLoopHandling.Controllers
{
    public class CustomerController : ApiController
    {
        databaseContext db;

        public CustomerController()
        {
            db = new databaseContext();
        }
        public IEnumerable<Customer> GetCustomer()
        {
            return db.Customers.ToList();
        }
    }
}
