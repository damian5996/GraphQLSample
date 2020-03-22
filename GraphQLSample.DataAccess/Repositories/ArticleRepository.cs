using GraphQLSample.DataAccess.Repositories.Interfaces;
using GraphQLSample.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLSample.DataAccess.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly GraphQLSampleDbContext _dbContext;

        public ArticleRepository(GraphQLSampleDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Article>> GetAll()
        {
            return await _dbContext.Articles.ToListAsync();
        }

        public async Task<Article> GetOne(int id)
        {
            return await _dbContext.Articles.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
