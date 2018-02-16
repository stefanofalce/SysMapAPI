using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NumbersAPI.Models;
using NumbersAPI.Business;
using System.Net.Http;

namespace NumbersAPI.Controllers
{
    [Route("api/Numbers")]
    public class NumbersController : Controller
    {
        NumberIntegration NI = new NumberIntegration();
        
        // POST api/values

        [HttpPost]
        public int Sum([FromBody]Numbers value)
        {
            NI.Num.NumbersArr = value.NumbersArr;
            return NI.Sum();
        }

        [HttpPost]
        public float Average([FromBody]Numbers value)
        {
            NI.Num.NumbersArr = value.NumbersArr;
            return NI.Average();
        }

    }
}
