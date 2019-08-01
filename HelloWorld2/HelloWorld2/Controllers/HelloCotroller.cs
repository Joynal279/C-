using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld2.Controllers
{
    public class HelloCotroller:Controller
        
    {
        public IActionResult Message()
        {
            return Content("hello");
        }
    }
}
