using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImDatesAsp.Controllers
{
	public class HomeController : Controller
	{
		private Models.RemindingContext db = new Models.RemindingContext();
		public ActionResult Index()
		{
			var reminding = db.RemindedPersons.Where(x=>!x.LastName.StartsWith("V")).ToList();
			return View(reminding);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}