﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApplication1_Authentication_.Controllers
{
        [Authorize]
        public class POCController : ApiController
        {
            [HttpGet]
            [Route("api/TestMethod")]
            public string TestMethod()
            {
                return "Hello, C# Corner Member. ";
            }


        }
    
}