﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Project.Models.PostViewModels
{
    public class Post
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Picture { get; set; }


        public string Category { get; set; }

        public string TagString { get; set; }
        
        public List<Tag> Tags { get; set; } = new List<Tag>();

        [Required]
        public string Title { get; set; }

        public string Abstract { get; set; }

        [Required]
        public string Content { get; set; }

        public string Comment { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ApplicationUser Author { get; set; }

        public string AuthorId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastModified { get; set; }

        public int CountOfVoters { get; set; }

        public float Raiting { get; set; }
    }
}
