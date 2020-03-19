using GraphQLSample.DataAccess.Configuration;
using GraphQLSample.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;

namespace GraphQLSample.DataAccess
{
    public class GraphQLSampleDbContext : DbContext
    {
        private readonly ConnectionStringSettings _connectionStringSettings;
        public GraphQLSampleDbContext(DbContextOptions<GraphQLSampleDbContext> options, IOptions<ConnectionStringSettings> optionsAccessor) : base(options)
        {
            _connectionStringSettings = optionsAccessor.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionStringSettings.LocalDB);
        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
