namespace GitHome.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<GitHome.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(GitHome.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Agents.AddOrUpdate(
                x => x.AgentId,
                new Models.Agent
                {
                    AgentId = 1,
                    Email = "vmrocha@gmail.com",
                    FirstName = "Vinicius",
                    LastName = "Rocha",
                    PhoneNumber = "5145532379",
                    housesSold = 1,
                    isActive = true,
                    joinedOn = DateTime.Now
                });

            context.Addresses.AddOrUpdate(
                x => x.addressID,
                new Models.Address
                {
                    addressID = 1,
                    city = "Montreal",
                    civicNumber = 1234,
                    street = "Main Street",
                    zipCode = "I0K0B6"
                });

            context.Properties.AddOrUpdate(
                x => x.unitDetailID,
                new Models.UnitProperties
                {
                    unitDetailID = 1,
                    AddressID = 1,
                    forSale = true,
                    yearBuilt = 1980,
                    askingPrice = 100,
                    Title = "Title",
                    description = "Nice old home"
                },
                new Models.UnitProperties
                {
                    unitDetailID = 2,
                    AddressID = 1,
                    forSale = true,
                    yearBuilt = 2016,
                    askingPrice = 3000,
                    Title = "Title",
                    description = "Nice old home"
                });

            context.Units.AddOrUpdate(
                x => x.ID,
                new Models.Unit
                {
                    ID = 1,
                    AgentId = 1,
                    availableFrom = DateTime.Now,
                    UnitDetailID = 1
                },
                new Models.Unit
                {
                    ID = 2,
                    AgentId = 1,
                    availableFrom = DateTime.Now,
                    UnitDetailID = 2
                });
        }
    }
}
