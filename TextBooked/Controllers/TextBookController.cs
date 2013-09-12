using TextBooked.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TextBooked.Controllers
{
    public class TextBookController : ApiController
    {
        public TextBook Get()
        {
            return new TextBook
            {
                Id=1,
                title="The",
                author="Him",
                PostDate=DateTime.Now,
            };
        }
    }
}
