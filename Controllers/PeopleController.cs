using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        // GET: api/<PeopleController>
        List<Person> list = new List<Person>()
        {
            new Person { sno =1, name= "Rahul", city ="Chennai"},
            new Person { sno =2, name= "Peterson", city ="Bangalore"},
            new Person { sno =3, name= "Shaw", city ="Mumbai"}
        };

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return list;
        }

        // GET api/<PeopleController>/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return list[id - 1];
        }

        // POST api/<PeopleController>
        [HttpPost]
        public Person Post([FromBody] Person person)
        {
            list.Add(person);
            return person;
        }

      
    }
}
