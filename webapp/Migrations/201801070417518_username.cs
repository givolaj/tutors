namespace Tutors.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class username : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentProfiles", "UserName", c => c.String());
            DropColumn("dbo.StudentProfiles", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StudentProfiles", "UserId", c => c.Guid(nullable: false));
            DropColumn("dbo.StudentProfiles", "UserName");
        }
    }
}
