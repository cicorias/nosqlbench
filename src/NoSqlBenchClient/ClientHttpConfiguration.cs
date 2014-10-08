using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace NoSqlBenchClient
{
    public class ClientHttpConfiguration : HttpConfiguration
    {
        public ClientHttpConfiguration()
        {
            ConfigureRoutes();
            ConfigureJsonSerialization();

        }

        private void ConfigureRoutes()
        { 
            this.MapHttpAttributeRoutes();
            
            Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

           
        }

        private void ConfigureJsonSerialization()
        {
#if DEBUG
            var jsonSettings = Formatters.JsonFormatter.SerializerSettings;
            jsonSettings.Formatting = Formatting.Indented;
#endif
        }
    }
}
