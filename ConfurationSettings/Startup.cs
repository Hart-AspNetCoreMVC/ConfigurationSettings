using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace ConfurationSettings
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        //services are any object that provides functionality to other parts of app(they are just classes); 
        // Services can be doled out to other parts of the app through dependency injection; set a field in the class to hold the object, and instantiate via the controller
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to add middleware to configure the HTTP request pipeline.
        // Types of middleware are: content generating, short-circuiting, request editing, and response editing
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
//            below sets configurations based on the environment. For more complex configs, build separate config methods for each by adding the env to the method name
//                example ConfigureDevelopmentServices() will contain methods only for dev env
            // if these individual methods become too fat, you can also break up the config into separate env specific classes ex. StartupDevelopment 
            //will contain settings for just the dev env; when separating configs out into classes, must change program file to  .UseStartup(nameof(<namespace>))
            //so asp.net knows to look for class names that reflect the dev env
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
