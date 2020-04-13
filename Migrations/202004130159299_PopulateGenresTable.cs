namespace FuncoGallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Adventure')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Sports')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Fighting')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Indie')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Strategy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'RPG')");
        }
        
        public override void Down()
        {
        }
    }
}
