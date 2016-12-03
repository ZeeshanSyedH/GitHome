namespace GitHome.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Agents", "agentAddress_addressID", "dbo.Addresses");
            DropForeignKey("dbo.Agents", "securityQuestions_securityID", "dbo.SecurityQuestions");
            DropForeignKey("dbo.UnitDetails", "AddressID_addressID", "dbo.Addresses");
            DropForeignKey("dbo.Units", "AgentID_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Units", "UnitDetailID_unitDetailID", "dbo.UnitDetails");
            DropIndex("dbo.Agents", new[] { "agentAddress_addressID" });
            DropIndex("dbo.Agents", new[] { "securityQuestions_securityID" });
            DropIndex("dbo.UnitDetails", new[] { "AddressID_addressID" });
            DropIndex("dbo.Units", new[] { "AgentID_Id" });
            DropIndex("dbo.Units", new[] { "UnitDetailID_unitDetailID" });
            AlterColumn("dbo.Agents", "agentFirstName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Agents", "agentLastName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Agents", "agentAddress_addressID", c => c.Int(nullable: false));
            AlterColumn("dbo.Agents", "securityQuestions_securityID", c => c.Int(nullable: false));
            AlterColumn("dbo.Addresses", "street", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Addresses", "city", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Addresses", "zipCode", c => c.String(nullable: false, maxLength: 6));
            AlterColumn("dbo.SecurityQuestions", "Question", c => c.String(nullable: false, maxLength: 120));
            AlterColumn("dbo.SecurityQuestions", "Answer", c => c.String(nullable: false, maxLength: 120));
            AlterColumn("dbo.Clients", "clientFirstName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Clients", "clientLastName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Clients", "clientEmail", c => c.String(maxLength: 80));
            AlterColumn("dbo.UnitDetails", "AddressID_addressID", c => c.Int(nullable: false));
            AlterColumn("dbo.Units", "AgentID_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Units", "UnitDetailID_unitDetailID", c => c.Int(nullable: false));
            CreateIndex("dbo.Agents", "agentAddress_addressID");
            CreateIndex("dbo.Agents", "securityQuestions_securityID");
            CreateIndex("dbo.UnitDetails", "AddressID_addressID");
            CreateIndex("dbo.Units", "AgentID_Id");
            CreateIndex("dbo.Units", "UnitDetailID_unitDetailID");
            AddForeignKey("dbo.Agents", "agentAddress_addressID", "dbo.Addresses", "addressID", cascadeDelete: true);
            AddForeignKey("dbo.Agents", "securityQuestions_securityID", "dbo.SecurityQuestions", "securityID", cascadeDelete: true);
            AddForeignKey("dbo.UnitDetails", "AddressID_addressID", "dbo.Addresses", "addressID", cascadeDelete: true);
            AddForeignKey("dbo.Units", "AgentID_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Units", "UnitDetailID_unitDetailID", "dbo.UnitDetails", "unitDetailID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Units", "UnitDetailID_unitDetailID", "dbo.UnitDetails");
            DropForeignKey("dbo.Units", "AgentID_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.UnitDetails", "AddressID_addressID", "dbo.Addresses");
            DropForeignKey("dbo.Agents", "securityQuestions_securityID", "dbo.SecurityQuestions");
            DropForeignKey("dbo.Agents", "agentAddress_addressID", "dbo.Addresses");
            DropIndex("dbo.Units", new[] { "UnitDetailID_unitDetailID" });
            DropIndex("dbo.Units", new[] { "AgentID_Id" });
            DropIndex("dbo.UnitDetails", new[] { "AddressID_addressID" });
            DropIndex("dbo.Agents", new[] { "securityQuestions_securityID" });
            DropIndex("dbo.Agents", new[] { "agentAddress_addressID" });
            AlterColumn("dbo.Units", "UnitDetailID_unitDetailID", c => c.Int());
            AlterColumn("dbo.Units", "AgentID_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.UnitDetails", "AddressID_addressID", c => c.Int());
            AlterColumn("dbo.Clients", "clientEmail", c => c.String());
            AlterColumn("dbo.Clients", "clientLastName", c => c.String());
            AlterColumn("dbo.Clients", "clientFirstName", c => c.String());
            AlterColumn("dbo.SecurityQuestions", "Answer", c => c.String());
            AlterColumn("dbo.SecurityQuestions", "Question", c => c.String());
            AlterColumn("dbo.Addresses", "zipCode", c => c.String());
            AlterColumn("dbo.Addresses", "city", c => c.String());
            AlterColumn("dbo.Addresses", "street", c => c.String());
            AlterColumn("dbo.Agents", "securityQuestions_securityID", c => c.Int());
            AlterColumn("dbo.Agents", "agentAddress_addressID", c => c.Int());
            AlterColumn("dbo.Agents", "agentLastName", c => c.String());
            AlterColumn("dbo.Agents", "agentFirstName", c => c.String());
            CreateIndex("dbo.Units", "UnitDetailID_unitDetailID");
            CreateIndex("dbo.Units", "AgentID_Id");
            CreateIndex("dbo.UnitDetails", "AddressID_addressID");
            CreateIndex("dbo.Agents", "securityQuestions_securityID");
            CreateIndex("dbo.Agents", "agentAddress_addressID");
            AddForeignKey("dbo.Units", "UnitDetailID_unitDetailID", "dbo.UnitDetails", "unitDetailID");
            AddForeignKey("dbo.Units", "AgentID_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.UnitDetails", "AddressID_addressID", "dbo.Addresses", "addressID");
            AddForeignKey("dbo.Agents", "securityQuestions_securityID", "dbo.SecurityQuestions", "securityID");
            AddForeignKey("dbo.Agents", "agentAddress_addressID", "dbo.Addresses", "addressID");
        }
    }
}
