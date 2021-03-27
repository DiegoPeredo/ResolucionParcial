using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RecuperacionDiego.Controllers
{
    public class AddController : ApiController
    {
        [HttpGet]
        public int Sumar(int a, int b)
        {
            return a + b;
        }
    }
}
