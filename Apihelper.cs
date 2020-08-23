using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace DemoApi
{
    public static class Apihelper
    {
        public static HttpClient Apiclient { get; set; } 
        public static void Initialize()
        {

            Apiclient = new HttpClient();
            Apiclient.DefaultRequestHeaders.Accept.Clear();
            Apiclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
    }
}
