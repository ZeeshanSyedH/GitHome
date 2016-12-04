namespace GitHome.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDB : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Units", "AgentID_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Units", new[] { "AgentID_Id" });
            AddColumn("dbo.Units", "AgentID", c => c.String(nullable: false));
            DropColumn("dbo.Units", "AgentID_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Units", "AgentID_Id", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Units", "AgentID");
            CreateIndex("dbo.Units", "AgentID_Id");
            AddForeignKey("dbo.Units", "AgentID_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
    }
}
