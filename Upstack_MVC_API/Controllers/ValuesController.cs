using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Upstack.DAL.Context;
using Upstack.DAL.Model;

namespace Upstack_MVC_API.Controllers
{
    public class ValuesController : ApiController
    {
        private UpstackContext _context;
        public ValuesController()
        {
            _context = new UpstackContext();
        }
        // GET api/values
        public List<Person> Get()
        {
            var persons = _context.Persons.ToList();
            return persons;
        }

        // GET api/values/5
        public List<Person> Get(int id)
        {
            var person = _context.Persons.Where(x => x.Id == id).ToList();
            return person;
        }

        // POST api/values
        public void Post([FromBody]Person value)
        {
            var person = _context.Persons.Where(x => x.Id == value.Id);
            person.First().FirstName = value.FirstName;
            person.First().LastName = value.LastName;
            _context.SaveChanges();
        }

        // PUT api/values/5
        public void Put([FromBody]Person value)
        {
            _context.Persons.Add(value);
            _context.SaveChanges();
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            var person = _context.Persons.Where(x => x.Id == id).First();

            _context.Persons.Remove(person);

            _context.SaveChanges();
        }
    }
}
