using Code_Community.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code_Community.Models
{
    public class ForumUser
    {
        [Key]
        public string UserId { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "Username is Required!")]
        public string Username { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Email is Required!")]
        [EmailAddress]
        public string Email { get; set; }

        public string AvatarUrl { get; set; }

        public Rank Rank { get; set; }

        public DateTime Member_Since { get; set; }

    }
}
