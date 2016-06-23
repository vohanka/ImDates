namespace ImDatesAsp.Migrations
{
	using Microsoft.AspNet.Identity;
	using Models;
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	internal sealed class Configuration : DbMigrationsConfiguration<ImDatesAsp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "ImDatesAsp.Models.ApplicationDbContext";
        }

        protected override void Seed(ImDatesAsp.Models.ApplicationDbContext context)
        {
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data. E.g.
			
			var passwordHash = new PasswordHasher();
			string password = passwordHash.HashPassword("123QWEasd/");
			context.Users.AddOrUpdate(u => u.UserName,
				new ApplicationUser
				{
					UserName = "aa@aa.aa",
					Email = "aa@aa.aa",
					PasswordHash = password,
					PhoneNumber = "123456789",
					SecurityStamp = Guid.NewGuid().ToString(),

				});
			context.SaveChanges();
		}
	}
}
