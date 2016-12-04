namespace GitHome.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Units", "AvailableFrom", c => c.DateTime(nullable: false));
            DropColumn("dbo.Units", "DateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Units", "DateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Units", "AvailableFrom");
        }
    }
}
