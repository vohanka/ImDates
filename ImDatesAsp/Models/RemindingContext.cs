using Hangfire;
using Hangfire.SqlServer;
using ImDatesAsp.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ImDatesAsp.Models
{
	public class RemindingContext : DbContext
	{
		//public DbSet<ApplicationUser> Users { get; set; }
		public DbSet<RemindedPerson> RemindedPersons { get; set; }

		
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}