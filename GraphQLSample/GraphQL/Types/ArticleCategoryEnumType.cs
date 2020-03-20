using GraphQL.Types;
using GraphQLSample.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLSample.GraphQL.Types
{
    public class ArticleCategoryEnumType : EnumerationGraphType<ArticleCategory>
    {
        public ArticleCategoryEnumType()
        {
            Name = "Category";
            Description = "The category of article";
        }
    }
}
