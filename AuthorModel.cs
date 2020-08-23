using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApi
{
    public class AuthorModel
    {
        public string Page { get; set; }
        public int Per_page { get; set; }
        public int Total { get; set; }
        public int Total_pages { get; set; }
        public DataModel[] Data { get; set; }
    }
}
