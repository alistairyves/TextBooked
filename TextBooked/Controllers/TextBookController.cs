﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TextBooked.Controllers
{
    public class TextBookController : ApiController
    {
        public string[] Get()
        {
            return new string[]
            {
                "Hello",
                "World"            
            };
        }
    }
}