using Code_Community.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code_Community.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        public string UserId { get; set; }
        public int CategoryId { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Title is Required!")]
        public string PostTitle { get; set; }

        public string PostMessage { get; set; }

        public Category Category { get; set; }

        public int Likes { get; set; }

        public DateTime Created { get; set; }

    }
}
