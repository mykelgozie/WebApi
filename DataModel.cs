using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApi
{
   public class DataModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string About { get; set; }
        public int Submitted { get; set; }
        public DateTime Updated_at { get; set; }
        public int Submission_count { get; set; }
        public int Comment_count { get; set; }
        public int Created_at { get; set; }
    }
}
