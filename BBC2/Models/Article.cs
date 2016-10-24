using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBC2.Models
{
    class Article
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public List<Article> articles { get; set; }
    }
}
