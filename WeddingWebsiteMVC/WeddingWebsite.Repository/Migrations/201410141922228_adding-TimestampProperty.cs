namespace WeddingWebsite.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingTimestampProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "timeStamp", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "timeStamp");
        }
    }
}
