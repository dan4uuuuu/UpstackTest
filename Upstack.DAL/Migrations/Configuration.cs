namespace Upstack.DAL.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Upstack.DAL.Context;
    using Upstack.DAL.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<Upstack.DAL.Context.UpstackContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UpstackContext context)
        {
            if (!context.Persons.Any())
            {
                var persons = new List<Person>()
            {
                new Person()
                {
                    FirstName = "Yordan",
                    LastName = "Ivanov"
                },

                new Person()
                {
                    FirstName = "Kristina",
                    LastName = "Atanasova"
                },

                new Person()
                {
                    FirstName = "Kristian",
                    LastName = "Kosharov"
                },
            };

                persons.ForEach(p => context.Persons.Add(p));
                context.SaveChanges();
            }
        }
    }
}
