using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using Newtonsoft.Json;

namespace DotA_Site.Models
{
	public class DotaAPI : WebClient
	{
		public string callSteamAPI(string suffix)
		{
			string result = "No Result";

			this.BaseAddress = "http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?";
			string fullUrl = this.BaseAddress + suffix + "&key=84D99D637A49766C4725E98DE758BD4D";
			result = this.DownloadString(fullUrl);

			return result;
		}

		public string callApi(string suffix)
		{
			string result = "No Result";

			//WebClient apiCaller = new WebClient();
			this.BaseAddress = "https://api.steampowered.com/IDOTA2Match_570/GetMatchDetails/V001/?";
			string fullUrl = this.BaseAddress + suffix + "&key=84D99D637A49766C4725E98DE758BD4D";
			result =  this.DownloadString(fullUrl);
			
			return result;
		}

		public string callMyApi(string suffix)
		{
			string result = string.Empty;

			this.BaseAddress = "http://dotawebapitest.apphb.com/api/MatchDetails/GetMatchDetails?";
			string fullUrl = this.BaseAddress + suffix;
			result = this.DownloadString(fullUrl);

			return result;
		}

        public string callHeroApi()
        {
            string result = "No Result";

            this.BaseAddress = "https://api.steampowered.com/IEconDOTA2_570/GetHeroes/v0001/?";
            string fullUrl = this.BaseAddress + "key=84D99D637A49766C4725E98DE758BD4D&language=en_us";
            result = this.DownloadString(fullUrl);

            return result;
        }
	}
}