namespace AudMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomersDataWithBirthDate : DbMigration
    {
        public override void Up()
        {
			Sql("UPDATE Customers SET BirthDate = '20010112 11:45:09 AM' WHERE Id = 1");
			Sql("UPDATE Customers SET BirthDate = '20020128 11:45:09 AM' WHERE Id = 2");
		}
        
        public override void Down()
        {
        }
    }
}
