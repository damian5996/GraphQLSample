using GraphQLSample.DataAccess.Repositories.Interfaces;
using GraphQLSample.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLSample.DataAccess.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly GraphQLSampleDbContext _dbContext;

        public AuthorRepository(GraphQLSampleDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Author> Get(int id)
        {
            return await _dbContext.Authors.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
