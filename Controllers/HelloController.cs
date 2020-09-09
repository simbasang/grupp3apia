using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace grupp3api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : Controller
    {
        [HttpGet]
        public string GetHello()
        { 
            return "Hello";
        }
    }
}