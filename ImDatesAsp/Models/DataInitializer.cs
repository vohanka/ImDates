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

			//var user = new Entities.User { FirstName = "Libor", LastName = "Vohanka" };
			
			//var firstUser = context.Users.FirstOrDefault();


			var remindedPerson = new Entities.RemindedPerson { FirstName = "Lada", LastName = "Hejduková"/*, User = firstUser*/ };
			var remindedPerson2 = new Entities.RemindedPerson { FirstName = "Jiří", LastName = "Vohanka"/*, User = firstUser */};

			context.RemindedPersons.Add(remindedPerson);
			context.RemindedPersons.Add(remindedPerson2);
			context.SaveChanges();

		}

	}
}