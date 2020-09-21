using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstProject_N01454046.Controllers
{
    public class AddTenController : ApiController
    {
        // GET api/AddTen/{id} -> id + 10
        public IEnumerable<int> Get(int id)
        {
            return new int[] { id + 10 } ;
        }

    }
}
