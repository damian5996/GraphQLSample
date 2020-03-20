﻿using GraphQL.Types;
using GraphQLSample.DataAccess.Repositories.Interfaces;
using GraphQLSample.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLSample.GraphQL.Types
{
    public class ArticleType : ObjectGraphType<Article>
    {
        private readonly IAuthorRepository _authorRepository;
        public ArticleType(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;

            Field(t => t.Id);
            Field(t => t.Title);
            Field(t => t.Content);
            Field(t => t.CreationDate);
            Field<ArticleCategoryEnumType>("Category", "The category of article");
            Field<AuthorType>(
                "author",
                resolve: context => _authorRepository.Get(context.Source.Id)
                );

        }
    }
}
