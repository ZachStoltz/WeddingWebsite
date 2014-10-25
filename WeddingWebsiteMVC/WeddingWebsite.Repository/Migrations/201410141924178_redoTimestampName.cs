namespace WeddingWebsite.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class redoTimestampName : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.Comments", "timeStamp", "TimeStamp");
        }
        
        public override void Down()
        {
        }
    }
}
