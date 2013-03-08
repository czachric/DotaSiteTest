using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotA_Site.Models;

namespace DotA_Site.Controllers
{
    public class MatchesController : Controller
    {
        //
        // GET: /Matches/
        public ActionResult Index()
        {
            return View();
        }

		//
		// GET: /Matches/matchId
		// VIEW: MatchDetails.cshtml
		[HttpGet]
		public ActionResult MatchDetails(string matchId)
		{
			List<Player> players = new List<Player>();

			DotaAPI apiCaller = new DotaAPI();
			string matchJson = apiCaller.callMyApi("matchId=" + matchId); //hardcoded match_id = 127835521
			MatchDetails matchDetails = new MatchDetails();
			matchDetails.populateResult(matchJson);
			players = matchDetails.result.players;

			return View(players);
		}

    }
}
