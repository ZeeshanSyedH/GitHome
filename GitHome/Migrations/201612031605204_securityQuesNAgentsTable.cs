namespace GitHome.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class securityQuesNAgentsTable : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.UnitDetails", name: "unitAddress_addressID", newName: "AddressID_addressID");
            RenameIndex(table: "dbo.UnitDetails", name: "IX_unitAddress_addressID", newName: "IX_AddressID_addressID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.UnitDetails", name: "IX_AddressID_addressID", newName: "IX_unitAddress_addressID");
            RenameColumn(table: "dbo.UnitDetails", name: "AddressID_addressID", newName: "unitAddress_addressID");
        }
    }
}
