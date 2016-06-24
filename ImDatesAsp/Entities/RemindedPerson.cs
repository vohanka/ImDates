using ImDatesAsp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImDatesAsp.Entities
{
	public class RemindedPerson
	{
		[Key]
		[ScaffoldColumn(false)]
		public int Id { get; set; }

		[Required]
		[Display(Name = "Jméno")]
		public string FirstName { get; set; }

		[Display(Name = "Příjmení")]
		public string LastName { get; set; }

		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy}")]
		[Display(Name = "První svátek")]
		public DateTime? NameDayDate { get; set; }

		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy}")]
		[Display(Name = "Datum narození")]
		public DateTime? BirthdayDate { get; set; }

		[Display(Name = "Kolik dní před")]
		public int? RemindBeforeInDays { get; set; }

		[DataType(DataType.Time)]
		[Display(Name = "V kolik hodin")]
		public DateTime? RemindAt { get; set; }

		[Display(Name = "Poznámka")]
		public string Description { get; set; }

		[Display(Name = "Upozornění")]
		public bool Notify { get; set; }

		//// Navigation properties
		//public virtual ApplicationUser User { get; set; }
	}
}