using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//
using AngularJSTutorial.EF;
using AngularJSTutorial.Models;


namespace AngularJSTutorial.Controllers
{
    public class CountriesController : ApiController
    {
        private Salaries_PRODEntities Entity = new Salaries_PRODEntities();

        // GET: api/Countries
        public IEnumerable<Country> Get()
        {
            var c = (from c2 in Entity.COUNTRIES
                     select new Country()
                     {
                         Id = c2.CountryID,
                         Name = c2.CountryName
                     }).ToList();
            return c;
        }

        // GET: api/Countries/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Countries
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Countries/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Countries/5
        public void Delete(int id)
        {
        }
    }
}
