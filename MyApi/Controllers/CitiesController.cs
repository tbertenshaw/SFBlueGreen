using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Cities")]
    public class CitiesController : Controller
    {
        public CitiesController()
        {

        }
        ////V1
        //[HttpGet]
        //[Route("getcities")]
        //public IEnumerable<string> GetCities()
        //{
        //    return new string[] { "Seattle", "London" };
        //}

        //V2
        [HttpGet]
        [Route("getcities")]
        public IEnumerable<string> GetCities()
        {
            return new string[] { "Seattle", "London", "Delhi", "Berlin" };
        }
    }
}