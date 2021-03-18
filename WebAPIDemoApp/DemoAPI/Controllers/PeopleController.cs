using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers
{

    /// <summary>
    /// This is where I give you all the information about my peeps.
    /// </summary>
    public class PeopleController : ApiController
    {

        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "Willie", LastName = "Ferebee", Id = 1 });
            people.Add(new Person { FirstName = "Lydia", LastName = "Ferebee", Id = 2 });
            people.Add(new Person { FirstName = "Rory", LastName = "O'Donnell", Id = 3 });

        }

        //[Route("api/People/GetFirstNames")]// could call this anything
        //[HttpGet] // if you want to add more put a comma between them


        /// <summary>
        /// Gets a list of the first names of all users.
        /// </summary>
        /// <param name="userId">The unique identifier for this person</param> 
        /// <param name="age">We want to know how old they are</param> 
        /// <returns>A list of First names.</returns> 
        [Route("api/People/GetFirstNames/{userId:int}/{age:int}")]// this is how we could pass in extra paramters if we were hooked up to a database
        [HttpGet] 
        public List<string> GetFirstNames(int userId, int age)
        {
            List<string> output = new List<string>();

            foreach (var p in people)
            {
                output.Add(p.FirstName);
            }

            return output;
        }
        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person val)
        {
            people.Add(val);
        }


        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
