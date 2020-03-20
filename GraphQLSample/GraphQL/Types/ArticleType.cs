using GraphQL.Types;
using GraphQLSample.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLSample.GraphQL.Types
{
    public class ArticleType : ObjectGraphType<Article>
    {
        public ArticleType()
        {
            Field(t => t.Id);
            Field(t => t.Title);
            Field(t => t.Content);
            Field(t => t.CreationDate);
            Field<ArticleCategoryEnumType>("Category", "The category of article");
        }
    }
}
