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
