using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstProject_N000000.Controllers
{
    public class GreetingController : ApiController
    {
        // GET api/Greeting/{id} -> "Greetings to {id} people!"
        public IEnumerable<string> Get(int id)
        {
            return new string[] { "Greetings to " + id + " people!" };
        }


        // POST api/Greeting -> "Hello World!"
        public IEnumerable<string> Post([FromBody] string value)
        {
            return new string[] { "Hello World!" };
        }
    }

    
}
