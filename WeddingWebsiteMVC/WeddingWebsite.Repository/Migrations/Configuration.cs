namespace WeddingWebsite.Repository.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WeddingWebsite.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WeddingWebsiteDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(WeddingWebsiteDB context)
        {
            //context.Comments.AddOrUpdate(c => c.Name,
            //    new Comment { Name = "Zach", Text = "Testing Out this data", SongRequest = "Dirty Pop", TimeStamp = DateTime.Now },
            //    new Comment { Name = "Erica", Text = "Testing Out this data", SongRequest = "Dirty Pop", TimeStamp = DateTime.Now },
            //    new Comment { Name = "Maverick", Text = "Testing Out this data", SongRequest = "Dirty Pop", TimeStamp = DateTime.Now });
        }
    }
}
