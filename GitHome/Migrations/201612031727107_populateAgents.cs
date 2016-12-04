//namespace GitHome.Migrations
//{
//    using Models;
//    using System;
//    using System.Data.Entity.Migrations;

//    public partial class populateAgents : DbMigration
//    {
//        public override void Up()
//        {
//            // CREATE CURRENT DATETIME
//            DateTime curTime = DateTime.Now;
//            string timeFormat = "yyy/MM/dd HH:MM:ss";

//            CREATE SECURITY QUESTIONS
//           SecurityQuestion qOne = new SecurityQuestion(1, "Favorite Color", "Blue");
//            SecurityQuestion qTwo = new SecurityQuestion(2, "Favorite City", "LaSalle");
//            SecurityQuestion qThree = new SecurityQuestion(3, "Favorite School", "John Abbott");
//            SecurityQuestion qFour = new SecurityQuestion(4, "Favorite Car", "Bentley");



//            POPULATE SECURITY QUESTIONS INTO DB
//            Sql("INSERT INTO SecurityQuestions (securityID,Question,Answer) VALUES('" + qOne.securityID + "', '" + qOne.Question + "' , '" + qOne.Answer + "');");
//            Sql("INSERT INTO SecurityQuestions (securityID,Question,Answer) VALUES('" + qTwo.securityID + "', '" + qTwo.Question + "' , '" + qTwo.Answer + "');");
//            Sql("INSERT INTO SecurityQuestions (securityID,Question,Answer) VALUES('" + qThree.securityID + "', '" + qThree.Question + "' , '" + qThree.Answer + "');");
//            Sql("INSERT INTO SecurityQuestions (securityID,Question,Answer) VALUES('" + qFour.securityID + "', '" + qFour.Question + "' , '" + qFour.Answer + "');");


//            Sql("INSERT INTO SecurityQuestions (Question,Answer) VALUES('Favorite Color', 'Blue' );");


//            // CREATE AGENTS
//            Agent agentOne = new Agent(1, 1, curTime, true, 3, "Bob", "Johns", "bob@johns.com", 123456);
//            Agent agentTwo = new Agent(2, 2, curTime, true, 0, "Amanda", "Hoops", "amanda@hoops.com", 123456);
//            Agent agentThree = new Agent(3, 3, curTime, false, 7, "Max", "Leonard", "max@Leonard.com", 123456);
//            Agent agentFour = new Agent(4, 4, curTime, true, 2, "Richard", "Freestar", "richard@freestar.com", 123456);

//            // POPULATE AGENTS INTO DB

//            string preQuery = "INSERT INTO Agents (AgentID,joinedOn,isActive,housesSold,securityQuestions_securityID,FirstName,LastName,Email,PhoneNumber) VALUES";

//            Sql("'" + preQuery + "' ('" + agentOne.AgentID + "', '" + agentOne.joinedOn + "','" + agentOne.isActive + "', '" + agentOne.housesSold + "', '" + agentOne.securityQuestionID + "','" + agentOne.FirstName + "','" + agentOne.LastName + "','" + agentOne.Email + "','" + agentOne.PhoneNumber + "');");
//            Sql("'" + preQuery + "' ('" + agentTwo.AgentID + "', '" + agentTwo.joinedOn + "','" + agentTwo.isActive + "', '" + agentTwo.housesSold + "', '" + agentTwo.securityQuestionID + "','" + agentTwo.FirstName + "','" + agentTwo.LastName + "','" + agentTwo.Email + "','" + agentTwo.PhoneNumber + "');");
//            Sql("'" + preQuery + "' ('" + agentThree.AgentID + "', '" + agentThree.joinedOn + "','" + agentThree.isActive + "', '" + agentThree.housesSold + "', '" + agentThree.securityQuestionID + "','" + agentThree.FirstName + "','" + agentThree.LastName + "','" + agentThree.Email + "','" + agentThree.PhoneNumber + "');");
//            Sql("'" + preQuery + "' ('" + agentFour.AgentID + "', '" + agentFour.joinedOn + "','" + agentFour.isActive + "', '" + agentFour.housesSold + "', '" + agentFour.securityQuestionID + "','" + agentFour.FirstName + "','" + agentFour.LastName + "','" + agentFour.Email + "','" + agentFour.PhoneNumber + "');");
//        }

//        public override void Down()
//        {
//            Sql("DELETE FROM Agents WHERE AgentID IN (1)");
//        }
//    }
//}
