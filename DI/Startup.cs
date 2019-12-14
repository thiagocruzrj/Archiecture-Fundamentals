using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArchiectureFundamentals.Cases;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using static ArchiectureFundamentals.Cases.Operation;

namespace ArchiectureFundamentals
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            #region RealLife

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserServices, UserServices>();

            #endregion

            #region LifeCycle

            services.AddTransient<IOperationTransient, Operation>();
            services.AddScoped<IOperationScoped, Operation>();
            services.AddSingleton<IOperationSingleton, Operation>();
            services.AddSingleton<IOperationSingletonInstance>(new Operation(Guid.Empty));
            services.AddTransient<OperationService>();
            
            #endregion

            #region Generics
            
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            #endregion

            #region MultipleClasses
            
            services.AddTransient<ServiceA>();
            services.AddTransient<ServiceB>();
            services.AddTransient<ServiceC>();
            services.AddTransient<Func<string, IService>>(servicesProvider => key => {
                switch (key)
                {
                    case "A":
                        return servicesProvider.GetService<ServiceA>();
                    case "B":
                        return servicesProvider.GetService<ServiceB>();
                    case "C":
                        return servicesProvider.GetService<ServiceC>();
                    default:
                        return null;
                }
            });

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
