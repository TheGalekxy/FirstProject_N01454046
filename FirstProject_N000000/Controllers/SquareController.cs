using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstProject_N000000.Controllers
{
    public class SquareController : ApiController
    {
        // GET api/Square/{id} -> id*2
        public IEnumerable<int> Get(int id)
        {
            return new int[] { id * id };
        }

    }
}
