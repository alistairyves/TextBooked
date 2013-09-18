using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TextBooked.Models
{
    public class TextBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public DateTime PostDate { get; set; }
    }
}