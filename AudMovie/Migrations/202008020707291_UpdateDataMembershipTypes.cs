namespace AudMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDataMembershipTypes : DbMigration
    {
        public override void Up()
        {
			Sql("UPDATE MembershipTypes SET Name = 'Pay as You Go' WHERE DurationInMonths = 0");
			Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE DurationInMonths = 1");
			Sql("UPDATE MembershipTypes SET Name = 'Third Part' WHERE DurationInMonths = 3");
			Sql("UPDATE MembershipTypes SET Name = 'Annualy' WHERE DurationInMonths = 12");
		}
        
        public override void Down()
        {
        }
    }
}
