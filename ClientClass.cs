using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DemoApi
{
    public class ClientClass
    {

        public static async Task<AuthorModel> LoadApi(int count = 1)
        {



            string url =$"https://jsonmock.hackerrank.com/api/article_users/search?page={count}";

            using (HttpResponseMessage response = await Apihelper.Apiclient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {

                    //AuthorModel users = await response.Content.ReadAsAsync<AuthorModel>();

                    //return users;

                    string allAuthors = await response.Content.ReadAsStringAsync();
                    var users = JsonConvert.DeserializeObject<AuthorModel>(allAuthors);
             

                    return users;
                }
                else
                {

                    throw new Exception(response.ReasonPhrase);
                }


            }

        }
    }
}
