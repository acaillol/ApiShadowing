using APE.Exposition.Vente.Api.Configurations;
using APE.Exposition.Vente.Api.Middlewares;
using APE.Exposition.Vente.Api.Proxies.Affiliation;
using APE.Exposition.Vente.Api.Proxies.Security;
using APE.Exposition.Vente.Api.Proxies.TokenChecker;
using APE.Exposition.Vente.Api.Services.Affiliation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace APE.Exposition.Vente.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                        .SetBasePath(env.ContentRootPath)
                        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
            services.AddMvc();

            // needed for NLogWeb
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddSingleton<ILoggerFactory, LoggerFactory>();
            services.AddSingleton(typeof(ILogger<>), typeof(Logger<>));
            //Singleton needed to keep the memory cache
            services.AddSingleton<ITokenChecker, TokenChecker>();
            services.AddSingleton<ISecuriteProxy, SecuriteProxy>();

            services.AddScoped<RequestCache>();
            services.AddScoped<AffiliationCreationService>();
            services.AddScoped<IAffiliationProxy, AffiliationProxy>();

            services.AddLogging((builder) => builder.SetMinimumLevel(LogLevel.Trace));
            services.AddMemoryCache();

            var serviceProvider = services.BuildServiceProvider();

            var loggerFactory = serviceProvider.GetRequiredService<ILoggerFactory>();

            services.Configure<IISOptions>(config =>
            {
                config.AutomaticAuthentication = true;
            });

            services.AddOptions();

            services.Configure<ApplicationUrls>(options => Configuration.GetSection("ApplicationUrls").Bind(options));

            AutoMapperConfig.Config();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMiddleware<CheckTokenMiddleware>();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            //Permet de connaitre l'adresse ip du client
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });
        }
    }
}
