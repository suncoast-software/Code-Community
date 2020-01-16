using System;
using System.Collections.Generic;
using System.Text;
using Code_Community.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Code_Community.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ForumUser> ForumUsers { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
