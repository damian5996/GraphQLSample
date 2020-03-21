using GraphQLSample.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GraphQLSample.DataAccess.Repositories.Interfaces
{
    public interface IAuthorRepository
    {
        Task<IDictionary<int, Author>> Get(IEnumerable<int> ids, CancellationToken cancellationToken);
    }
}
