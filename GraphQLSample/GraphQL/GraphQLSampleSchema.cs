using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLSample.GraphQL
{
    public class GraphQLSampleSchema : Schema
    {
        public GraphQLSampleSchema(IDependencyResolver dependencyResolver) : base(dependencyResolver)
        {
            Query = dependencyResolver.Resolve<GraphQLSampleQuery>();
            Mutation = dependencyResolver.Resolve<GraphQLSampleMutation>();
        }
    }
}
