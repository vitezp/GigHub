namespace FullStack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeartistaccestype : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Gigs", new[] { "artist_Id" });
            CreateIndex("dbo.Gigs", "Artist_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Gigs", new[] { "Artist_Id" });
            CreateIndex("dbo.Gigs", "artist_Id");
        }
    }
}
