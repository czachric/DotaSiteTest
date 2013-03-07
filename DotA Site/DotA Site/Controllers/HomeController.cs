using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using DotA_Site.Models;

namespace DotA_Site.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

			List<Player> players = new List<Player>();

			DotaAPI apiCaller = new DotaAPI();
			string matchJson = apiCaller.callApi("match_id=127835521");
			MatchDetails matchDetails = new MatchDetails();
			matchDetails.populateResult(matchJson);
			players = matchDetails.result.players;

			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your app description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult Test()
		{
			ViewBag.Message = "Test page.";

			return View();
		}
	}
}
