using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi
{
    class Program
    {
        public static List<DataModel> Allusers { get; set; } = new List<DataModel>();

        static async Task Main(string[] args)
        {
            int page = 0;
            Apihelper.Initialize();

            while (page < 3)
            {

                page++;
                var datas = await ClientClass.LoadApi(page);

                Allusers.AddRange(datas.Data.ToList());

            }

          //var datas = await ClientClass.LoadApi( );

          //  Allusers.AddRange(datas.Data.ToList());


            foreach (var item in Allusers)
            {

                Console.WriteLine(item.Id);

            }
        }
    }
}
