namespace GitHome.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class populateAgents : DbMigration
    {
        public override void Up()
        {
            //  Sql("INSERT INTO Agents (AgentID,joinedOn,isActive,housesSold,agentFirstName,agentLastName,agentAddress_addressID,securityQuestions_securityID) VALUES ()");


        }

        public override void Down()
        {
        }
    }
}
