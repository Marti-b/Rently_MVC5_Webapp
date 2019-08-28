namespace Rently.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, GenreTypeId, ReleaseDate, DateAdded, NumberInStock) VALUES (2, 'Girl With Tattoo', 2, 1/2/2011, 11/3/2018, 3)");
            Sql("INSERT INTO Movies (Id, Name, GenreTypeId, ReleaseDate, DateAdded, NumberInStock) VALUES (3, 'Coco', 3, 1/5/2015, 23/4/2012, 9)");
            Sql("INSERT INTO Movies (Id, Name, GenreTypeId, ReleaseDate, DateAdded, NumberInStock) VALUES (4, 'Romeo and Juliet', 4, 1/10/2005, 23/4/2012, 16)");
            Sql("INSERT INTO Movies (Id, Name, GenreTypeId, ReleaseDate, DateAdded, NumberInStock) VALUES (5, 'Jump street', 5, 11/8/2009, 23/1/2019, 23)");
            Sql("SET IDENTITY_INSERT Movies OFF");
        }

        public override void Down()
        {
        }
    }
}
