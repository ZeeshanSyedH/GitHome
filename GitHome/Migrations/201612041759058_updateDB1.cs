namespace GitHome.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDB1 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.SecurityQuestions");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SecurityQuestions",
                c => new
                    {
                        securityID = c.Int(nullable: false, identity: true),
                        Question = c.String(nullable: false, maxLength: 120),
                        Answer = c.String(nullable: false, maxLength: 120),
                    })
                .PrimaryKey(t => t.securityID);
            
        }
    }
}
