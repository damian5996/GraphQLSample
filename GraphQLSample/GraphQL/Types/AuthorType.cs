using GraphQL.Types;
using GraphQLSample.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLSample.GraphQL.Types
{
    public class AuthorType : ObjectGraphType<Author>
    {
        public AuthorType()
        {
            Field(t => t.Id);
            Field(t => t.FirstName);
            Field(t => t.LastName);
            Field(t => t.Age, nullable:true);
        }
    }
}
