﻿using GraphQLSample.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLSample.DataAccess.Repositories.Interfaces
{
    public interface IAuthorRepository
    {
        Task<Author> Get(int id);
    }
}
