using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using GraphQLSample.DataAccess;
using GraphQLSample.DataAccess.Configuration;
using GraphQLSample.DataAccess.Repositories;
using GraphQLSample.DataAccess.Repositories.Interfaces;
using GraphQLSample.GraphQL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GraphQLSample
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
            services.AddDbContext<GraphQLSampleDbContext>();
            services.Configure<ConnectionStringSettings>(Configuration.GetSection("ConnectionStrings"));
            services.Configure<IISServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });

            services.AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));
            services.AddScoped<GraphQLSampleSchema>();

            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddGraphQL(o => { o.ExposeExceptions = true; })
                .AddGraphTypes(ServiceLifetime.Scoped)
                .AddDataLoader();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, GraphQLSampleDbContext dbContext)
        {
            app.UseGraphQL<GraphQLSampleSchema>();
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions());

            dbContext.Seed();
        }
    }
}
