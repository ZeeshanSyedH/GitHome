namespace GitHome.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        addressID = c.Int(nullable: false, identity: true),
                        civicNumber = c.Int(nullable: false),
                        street = c.String(),
                        city = c.String(),
                        zipCode = c.String(),
                    })
                .PrimaryKey(t => t.addressID);
            
            CreateTable(
                "dbo.UnitDetails",
                c => new
                    {
                        unitDetailID = c.Int(nullable: false, identity: true),
                        yearBuilt = c.Int(nullable: false),
                        numRooms = c.Int(nullable: false),
                        numBathrooms = c.Int(nullable: false),
                        numBedrooms = c.Int(nullable: false),
                        numGarageDoors = c.Int(nullable: false),
                        centralAirConditioning = c.Boolean(nullable: false),
                        description = c.String(),
                        askingPrice = c.Int(nullable: false),
                        unitAddress_addressID = c.Int(),
                    })
                .PrimaryKey(t => t.unitDetailID)
                .ForeignKey("dbo.Addresses", t => t.unitAddress_addressID)
                .Index(t => t.unitAddress_addressID);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        unitID = c.Int(nullable: false, identity: true),
                        clientID = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        AgentID_Id = c.String(maxLength: 128),
                        UnitDetailID_unitDetailID = c.Int(),
                    })
                .PrimaryKey(t => t.unitID)
                .ForeignKey("dbo.AspNetUsers", t => t.AgentID_Id)
                .ForeignKey("dbo.UnitDetails", t => t.UnitDetailID_unitDetailID)
                .Index(t => t.AgentID_Id)
                .Index(t => t.UnitDetailID_unitDetailID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Units", "UnitDetailID_unitDetailID", "dbo.UnitDetails");
            DropForeignKey("dbo.Units", "AgentID_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.UnitDetails", "unitAddress_addressID", "dbo.Addresses");
            DropIndex("dbo.Units", new[] { "UnitDetailID_unitDetailID" });
            DropIndex("dbo.Units", new[] { "AgentID_Id" });
            DropIndex("dbo.UnitDetails", new[] { "unitAddress_addressID" });
            DropTable("dbo.Units");
            DropTable("dbo.UnitDetails");
            DropTable("dbo.Addresses");
        }
    }
}
