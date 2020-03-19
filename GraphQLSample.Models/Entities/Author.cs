﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQLSample.Models.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public short Age { get; set; }

    }
}
