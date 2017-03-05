namespace FullStack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populategenrestable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Jazz')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Rock')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Pop')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Contry')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM TABLE Genres WHERE Id IN (1,2,3,4)"); 
        }
    }
}
