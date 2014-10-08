using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Owin.Hosting;
using Owin;
using Microsoft.Owin;
using System.Web.Http; 


namespace NoSqlBenchClient
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Initialize(app);

            var config = new ClientHttpConfiguration();
            app.UseWebApi(config);


        }

        void Initialize(IAppBuilder app)
        {
#if DEBUG
            app.UseErrorPage();
#endif
            app.UseWelcomePage("/");
        }
    }
}
