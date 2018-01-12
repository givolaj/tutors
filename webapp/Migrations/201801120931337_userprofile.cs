namespace Tutors.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userprofile : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        UserName = c.String(),
                        Name = c.String(),
                        ImageURL = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserProfiles");
        }
    }
}
