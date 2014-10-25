using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WeddingWebsite.Models;

namespace WeddingWebsite.Repository
{
    public class WeddingWebsiteDB : DbContext
    {
        public WeddingWebsiteDB()
            : base("DefaultConnection")
        {

        }

        public DbSet<Comment> Comments { get; set; }
    }
}
