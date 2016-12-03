namespace GitHome.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgentNSecuQuestTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agents",
                c => new
                    {
                        AgentID = c.Int(nullable: false, identity: true),
                        joinedOn = c.DateTime(nullable: false),
                        isActive = c.Boolean(nullable: false),
                        housesSold = c.Int(nullable: false),
                        agentFirstName = c.String(),
                        agentLastName = c.String(),
                        agentAddress_addressID = c.Int(),
                        securityQuestions_securityID = c.Int(),
                    })
                .PrimaryKey(t => t.AgentID)
                .ForeignKey("dbo.Addresses", t => t.agentAddress_addressID)
                .ForeignKey("dbo.SecurityQuestions", t => t.securityQuestions_securityID)
                .Index(t => t.agentAddress_addressID)
                .Index(t => t.securityQuestions_securityID);
            
            CreateTable(
                "dbo.SecurityQuestions",
                c => new
                    {
                        securityID = c.Int(nullable: false, identity: true),
                        AgentID = c.Int(nullable: false),
                        Question = c.String(),
                        Answer = c.String(),
                    })
                .PrimaryKey(t => t.securityID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Agents", "securityQuestions_securityID", "dbo.SecurityQuestions");
            DropForeignKey("dbo.Agents", "agentAddress_addressID", "dbo.Addresses");
            DropIndex("dbo.Agents", new[] { "securityQuestions_securityID" });
            DropIndex("dbo.Agents", new[] { "agentAddress_addressID" });
            DropTable("dbo.SecurityQuestions");
            DropTable("dbo.Agents");
        }
    }
}
