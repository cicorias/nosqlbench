using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Microsoft.Owin.Hosting;
using NoSqlBenchClient;
using System.Net.Http;

namespace NoSqlBenchLib.Tests.ClientTests
{
    [TestClass]
    public class SelfHostTests
    {
        static string s_serverUri = @"http://localhost:{0}";

        
        [TestMethod]
        public void TestMethod1()
        {
            string baseUri = null;
            using (var server = CreateServer(out baseUri))
            {
                HttpResponseMessage response = new HttpClient().GetAsync(baseUri + "/EchoString" ).Result;
                response.EnsureSuccessStatusCode();
            }
        }

        static IDisposable CreateServer(out string baseUri)
        {
            Microsoft.TestCommon.PortReserver portreserver = new Microsoft.TestCommon.PortReserver();
            var uri = string.Format(s_serverUri, portreserver.PortNumber);
            var server = WebApp.Start<Startup>(portreserver.BaseUri);
            baseUri = portreserver.BaseUri;
            return server;
        }
    }

}
