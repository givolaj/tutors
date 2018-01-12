namespace Tutors.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userprofile2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfiles", "PhoneNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserProfiles", "PhoneNumber");
        }
    }
}
