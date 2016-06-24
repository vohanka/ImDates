using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace ImDatesAsp.Controllers
{
	public class HomeController : Controller
	{
		private Models.RemindingContext db = new Models.RemindingContext();
		public ActionResult Index()
		{
			//var reminding = db.RemindedPersons.Where(x=>!x.LastName.StartsWith("V")).ToList();
			return View(/*reminding*/);
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

		public ActionResult Mail()
		{
			SendEmail();
			return RedirectToAction("Index");
		}

		public static void SendEmail()
		{
			// Compose a message
			MailMessage mail = new MailMessage("vohanka.libor@gmail.com", "vohanka.libor@gmail.com");
			mail.Subject = "Hello";
			mail.Body = "Testing some Mailgun awesomness";

			// Send it!
			SmtpClient client = new SmtpClient();
			client.Port = 587;
			client.DeliveryMethod = SmtpDeliveryMethod.Network;
			client.UseDefaultCredentials = false;
			client.Credentials = new System.Net.NetworkCredential("postmaster@imdates.gear.host", "a1db0a13228ef232c93e873bf301b3b8");
			client.Host = "smtp.mailgun.org";

			client.Send(mail);
		}		
	}
}