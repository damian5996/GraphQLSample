﻿using GraphQL.Types;
using GraphQLSample.DataAccess.Repositories.Interfaces;
using GraphQLSample.GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLSample.GraphQL
{
    public class GraphQLSampleQuery : ObjectGraphType
    {
        private readonly IArticleRepository _articleRepository;

        public GraphQLSampleQuery(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;

            Field<ListGraphType<ArticleType>>(
                "articles",
                resolve: context => _articleRepository.GetAll()
            );

            Field<ArticleType>(
                "article",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return articleRepository.GetOne(id);
                }
            );
        }
    }
}
