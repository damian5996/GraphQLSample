using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLSample.GraphQL.Types
{
    public class ArticleInputType : InputObjectGraphType
    {
        public ArticleInputType()
        {
            Name = "articleInput";
            Field<NonNullGraphType<StringGraphType>>("title");
            Field<NonNullGraphType<StringGraphType>>("content");
            Field<NonNullGraphType<IntGraphType>>("authorId");
            Field<ArticleCategoryEnumType>("category");
        }
    }
}
