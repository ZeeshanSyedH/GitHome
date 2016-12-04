namespace GitHome.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tableUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Agents", "securityQuestions_securityID", "dbo.SecurityQuestions");
            DropIndex("dbo.Agents", new[] { "securityQuestions_securityID" });
            AddColumn("dbo.Agents", "securityQuestionID", c => c.Int(nullable: false));
            DropColumn("dbo.Agents", "securityQuestions_securityID");
            DropColumn("dbo.SecurityQuestions", "AgentID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SecurityQuestions", "AgentID", c => c.Int(nullable: false));
            AddColumn("dbo.Agents", "securityQuestions_securityID", c => c.Int(nullable: false));
            DropColumn("dbo.Agents", "securityQuestionID");
            CreateIndex("dbo.Agents", "securityQuestions_securityID");
            AddForeignKey("dbo.Agents", "securityQuestions_securityID", "dbo.SecurityQuestions", "securityID", cascadeDelete: true);
        }
    }
}
