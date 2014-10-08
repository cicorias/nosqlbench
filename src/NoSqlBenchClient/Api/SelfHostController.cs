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
    [RoutePrefix("api")]
    public class SelfHostServerTestController : ApiController
    {
        [HttpGet]
        [Route("echostring")]
        public string EchoString()
        {
            return "echoString";
        }

    }
}
