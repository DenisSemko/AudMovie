namespace AudMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertDataCustomers : DbMigration
    {
        public override void Up()
        {
			Sql("INSERT INTO Customers(Name, IsSubscribedToNewsLetter, MembershipTypeId) VALUES('Denis Semko', 1, 2)");
			Sql("INSERT INTO Customers(Name, IsSubscribedToNewsLetter, MembershipTypeId) VALUES('Sofia Bykovska', 1, 4)");
			Sql("INSERT INTO Customers(Name, IsSubscribedToNewsLetter, MembershipTypeId) VALUES('Sebiastan Stan', 0, 1)");
			Sql("INSERT INTO Customers(Name, IsSubscribedToNewsLetter, MembershipTypeId) VALUES('Luisa Smith', 1, 3)");

		}
        
        public override void Down()
        {
        }
    }
}
