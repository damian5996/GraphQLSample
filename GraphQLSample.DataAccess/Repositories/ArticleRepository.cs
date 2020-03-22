using GraphQLSample.DataAccess.Repositories.Interfaces;
using GraphQLSample.Models.Entities;
using GraphQLSample.Models.Enums;
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

        public async Task<Article> AddArticle(Article article)
        {
            article.CreationDate = DateTime.Now;
            article.Category = article.Category ?? ArticleCategory.Other;
            _dbContext.Articles.Add(article);
            await _dbContext.SaveChangesAsync();
            return article;
        }
    }
}
