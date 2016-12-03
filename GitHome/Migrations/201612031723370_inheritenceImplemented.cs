namespace GitHome.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inheritenceImplemented : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Agents", "agentAddress_addressID", "dbo.Addresses");
            DropIndex("dbo.Agents", new[] { "agentAddress_addressID" });
            AddColumn("dbo.Agents", "FirstName", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Agents", "LastName", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Agents", "Email", c => c.String(maxLength: 80));
            AddColumn("dbo.Agents", "PhoneNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "FirstName", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Clients", "LastName", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Clients", "Email", c => c.String(maxLength: 80));
            AddColumn("dbo.Clients", "PhoneNumber", c => c.Int(nullable: false));
            DropColumn("dbo.Agents", "agentFirstName");
            DropColumn("dbo.Agents", "agentLastName");
            DropColumn("dbo.Agents", "agentAddress_addressID");
            DropColumn("dbo.Clients", "clientFirstName");
            DropColumn("dbo.Clients", "clientLastName");
            DropColumn("dbo.Clients", "clientEmail");
            DropColumn("dbo.Clients", "clientPhoneNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "clientPhoneNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "clientEmail", c => c.String(maxLength: 80));
            AddColumn("dbo.Clients", "clientLastName", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Clients", "clientFirstName", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Agents", "agentAddress_addressID", c => c.Int(nullable: false));
            AddColumn("dbo.Agents", "agentLastName", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Agents", "agentFirstName", c => c.String(nullable: false, maxLength: 30));
            DropColumn("dbo.Clients", "PhoneNumber");
            DropColumn("dbo.Clients", "Email");
            DropColumn("dbo.Clients", "LastName");
            DropColumn("dbo.Clients", "FirstName");
            DropColumn("dbo.Agents", "PhoneNumber");
            DropColumn("dbo.Agents", "Email");
            DropColumn("dbo.Agents", "LastName");
            DropColumn("dbo.Agents", "FirstName");
            CreateIndex("dbo.Agents", "agentAddress_addressID");
            AddForeignKey("dbo.Agents", "agentAddress_addressID", "dbo.Addresses", "addressID", cascadeDelete: true);
        }
    }
}
