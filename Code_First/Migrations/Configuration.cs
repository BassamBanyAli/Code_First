namespace Code_First.Migrations
{
    using Code_First.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Code_First.Models.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Code_First.Models.MyDbContext context)
        {


            context.Subjects.AddOrUpdate(
            t => t.SubjectId,
            new Subject { Name = "Mathematics" },
            new Subject { Name = "Science" },
            new Subject { Name = "History" }
        );
        }

        }
    }

