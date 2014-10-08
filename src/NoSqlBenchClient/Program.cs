using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSqlBenchClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string uri = "http://localhost:8080/";

            using (WebApp.Start<Startup>(uri))
            {
                Console.WriteLine("Started on host:port - {0}", uri);
                Console.ReadKey();
                Console.WriteLine("Stopping");

            }

        }
    }

}
