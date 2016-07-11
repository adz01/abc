namespace EntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using HrContext;
    using Model.Nomenclatores;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFrameworkDemo.HrContext.HrContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityFrameworkDemo.HrContext.HrContext context)
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

            PopulateGenderEnum(context);
            PopulateLevelEnum(context);
        }

        private void PopulateLevelEnum(HrContext context)
        {
            var levelList = new List<Level>
            {
                new Level { Id= 1, Name="Junior"},
                new Level { Id= 2, Name="Middle"},
                new Level { Id= 3, Name="Senior"}
            };
            foreach(var level in levelList)
            {
                context.Levels.AddOrUpdate(p => p.Name, level);
            }
        }

        private void PopulateGenderEnum(HrContext context)
        {
            var genderList = new List<Gender>
            {
                new Gender {Id=1, Name= "Masculin" },
                new Gender {Id=2, Name= "Feminin" }
            };
            foreach(var gender in genderList)
            {
                context.Genders.AddOrUpdate(p => p.Name, gender);
            }
        }
    }
}
