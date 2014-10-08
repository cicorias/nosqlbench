using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace NoSqlBenchLib.Tests.TestHelpers
{
    public class SelfHostServerTestController : ApiController
    {
        [HttpGet]
        public string EchoString()
        {
            return "echoString";
        }

        [HttpGet]
        public HttpResponseMessage EchoStream()
        {
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StreamContent(new MemoryStream(Encoding.UTF8.GetBytes("echoStream")))
            };
        }

        /*
        [HttpGet]
        public HttpResponseMessage ThrowBeforeTask()
        {
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                RequestMessage = Request,
                Content = new HttpSelfHostServerTest.ThrowsBeforeTaskObjectContent()
            };
        }

        [HttpGet]
        public HttpResponseMessage ThrowBeforeWrite()
        {
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                RequestMessage = Request,
                Content = new HttpSelfHostServerTest.ThrowBeforeWriteObjectContent()
            };
        }

        [HttpGet]
        public HttpResponseMessage ThrowAfterWrite()
        {
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                RequestMessage = Request,
                Content = new HttpSelfHostServerTest.ThrowAfterWriteObjectContent()
            };
        }

        [HttpGet]
        public HttpResponseMessage ThrowBeforeWriteStream()
        {
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                RequestMessage = Request,
                Content = new HttpSelfHostServerTest.ThrowBeforeWriteStream()
            };
        }

        [HttpGet]
        public HttpResponseMessage ThrowAfterWriteStream()
        {
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                RequestMessage = Request,
                Content = new HttpSelfHostServerTest.ThrowAfterWriteStream()
            };
        }
         * */
    }
}
