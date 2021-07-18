namespace CliniSoft.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CliniSoft.Models.Clinic>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CliniSoft.Models.Clinic";
        }

        protected override void Seed(CliniSoft.Models.Clinic context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
