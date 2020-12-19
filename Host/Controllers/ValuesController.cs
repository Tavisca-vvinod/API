using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values/5
        [HttpGet("{number}")]
        public ActionResult<int> GetMultipleOf6(int number)
        {
            int answer = number * 6;
            return answer;
        }      
    }
}
