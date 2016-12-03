namespace GitHome.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedClientTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        clientID = c.Int(nullable: false, identity: true),
                        clientFirstName = c.String(),
                        clientLastName = c.String(),
                        clientEmail = c.String(),
                        clientPhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.clientID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clients");
        }
    }
}
