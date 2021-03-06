﻿using GraphQLSample.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GraphQLSample.Models.Entities
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public ArticleCategory? Category { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
