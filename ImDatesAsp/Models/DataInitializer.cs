using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ImDatesAsp.Models
{
	public class DataInitializer : DropCreateDatabaseAlways<RemindingContext>
	{
		protected override void Seed(RemindingContext context)
		{

			//var passwordHash = new PasswordHasher();
			//string password = passwordHash.HashPassword("123QWEasd/");
			//context.Users.Add(
			//	new ApplicationUser
			//	{
			//		UserName = "aa@aa.aa",
			//		Email = "aa@aa.aa",
			//		PasswordHash = password,
			//		PhoneNumber = "123456789",
			//		SecurityStamp = Guid.NewGuid().ToString(),

			//	});
			


			//var user = new Entities.User { FirstName = "Libor", LastName = "Vohanka" };

			//var firstUser = context.Users.FirstOrDefault();


			var remindedPerson = new Entities.RemindedPerson { FirstName = "Lada", LastName = "Hejduková"/*, User = context.Users.First()*/ };
			var remindedPerson2 = new Entities.RemindedPerson { FirstName = "Jiří", LastName = "Vohanka"/*, User = context.Users.First()*/ };

			context.RemindedPersons.Add(remindedPerson);
			context.RemindedPersons.Add(remindedPerson2);
			context.SaveChanges();

		}

	}
}