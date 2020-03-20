using GraphQLSample.Models.Entities;
using GraphQLSample.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphQLSample.DataAccess
{
    public static class InitialData
    {
        public static void Seed(this GraphQLSampleDbContext dbContext)
        {
            if (!dbContext.Articles.Any())
            {
                dbContext.Articles.Add(new Article
                {
                    Title = "Title1",
                    Content = "Content1",
                    CreationDate = DateTime.Now,
                    Category = ArticleCategory.Business,
                    Author = new Author
                    {
                        FirstName = "Jan",
                        LastName = "Kowalski",
                        Age = 56
                    }
                });

                dbContext.Articles.Add(new Article
                {
                    Title = "Title2",
                    Content = "Content2",
                    CreationDate = DateTime.Now,
                    Category = ArticleCategory.Sport,
                    Author = new Author
                    {
                        FirstName = "John",
                        LastName = "Smith",
                        Age = 31
                    }
                });

                dbContext.Articles.Add(new Article
                {
                    Title = "Title3",
                    Content = "Content3",
                    CreationDate = DateTime.Now,
                    Category = ArticleCategory.Education,
                    Author = new Author
                    {
                        FirstName = "Angelina",
                        LastName = "Smith",
                        Age = 26
                    }
                });

                dbContext.Articles.Add(new Article
                {
                    Title = "Title4",
                    Content = "Content4",
                    CreationDate = DateTime.Now,
                    Category = ArticleCategory.Education,
                    Author = new Author
                    {
                        FirstName = "Henryk",
                        LastName = "Gruszka",
                        Age = 44
                    }
                });

                dbContext.Articles.Add(new Article
                {
                    Title = "Title5",
                    Content = "Content5",
                    CreationDate = DateTime.Now,
                    Category = ArticleCategory.Sport,
                    Author = new Author
                    {
                        FirstName = "Ernest",
                        LastName = "Nowak",
                        Age = 23
                    }
                });

                dbContext.SaveChanges();
            }
        }
    }
}
