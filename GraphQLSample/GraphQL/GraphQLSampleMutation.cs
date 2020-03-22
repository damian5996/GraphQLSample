using GraphQL.Types;
using GraphQLSample.DataAccess.Repositories.Interfaces;
using GraphQLSample.GraphQL.Types;
using GraphQLSample.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLSample.GraphQL
{
    public class GraphQLSampleMutation : ObjectGraphType
    {
        private readonly IArticleRepository _articleRepository;

        public GraphQLSampleMutation(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;

            FieldAsync<ArticleType>(
                "createArticle",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<ArticleInputType>> { Name = "article" }),
                resolve: async context =>
                {
                    var article = context.GetArgument<Article>("article");
                    return await context.TryAsyncResolve(
                        async c => await _articleRepository.AddArticle(article));
                });
        }
    }
}
