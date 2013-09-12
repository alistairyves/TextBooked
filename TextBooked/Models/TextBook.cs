using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TextBooked.Models
{
    public class TextBook
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string isbn { get; set; }
        public DateTime PostDate { get; set; }
    }
}