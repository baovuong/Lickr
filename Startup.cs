using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Lickr.Dispensers;
using Lickr.SongHandlers;
using Lickr.Models;

namespace Lickr
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            
            services.AddTransient<ISongDispenser, MockSongDispenser>();

            services.AddTransient<ISongHandler, YoutubeSongHandler>();
            services.AddTransient(factory => 
            {
                Func<SourceType, ISongHandler> accessor = key =>
                {
                    switch (key)
                    {
                        case SourceType.YOUTUBE: return factory.GetService<YoutubeSongHandler>();
                        case SourceType.SPOTIFY: throw new KeyNotFoundException();
                        default: throw new KeyNotFoundException();

                    }
                };
                return accessor;
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
