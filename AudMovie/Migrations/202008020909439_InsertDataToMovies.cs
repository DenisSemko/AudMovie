namespace AudMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertDataToMovies : DbMigration
    {
        public override void Up()
        {
			Sql("INSERT INTO Genres(Name) VALUES('Comedy')");
			Sql("INSERT INTO Genres(Name) VALUES('Comedy-drama')");
			Sql("INSERT INTO Genres(Name) VALUES('Drama')");
			Sql("INSERT INTO Genres(Name) VALUES('Detective-thriller')");

			Sql("INSERT INTO Movies(Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES('Hangover', 1, '20200802 12:13:45 PM', '20091106 10:34:09 AM', 5)");
			Sql("INSERT INTO Movies(Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES('Parasite', 2, '20200802 12:13:45 PM', '20190521 10:34:09 AM', 10)");
			Sql("INSERT INTO Movies(Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES('Revolutionary Road', 3, '20200802 12:13:45 PM', '20081215 10:34:09 AM', 4)");
			Sql("INSERT INTO Movies(Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES('Shutter Island', 3, '20200802 12:13:45 PM', '20100219 10:34:09 AM', 12)");
			Sql("INSERT INTO Movies(Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES('Gone Girl', 4, '20200802 12:13:45 PM', '20141003 10:34:09 AM', 12)");

		}

		public override void Down()
        {
        }
    }
}
