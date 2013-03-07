using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace DotA_Site.Models
{
	public class MatchDetails
	{
		public MatchDetailsResult result = new MatchDetailsResult();

		public void populateResult(string matchJson)
		{
			MatchDetails temp = JsonConvert.DeserializeObject<MatchDetails>(matchJson);
			HeroDictionary heroDictionary = HeroDictionary.Instance;

			//Populate the player and hero names as well as localized hero name
			foreach (Player player in temp.result.players)
			{
				player.account_name = player.getPlayerName();
				player.hero_name = heroDictionary.heroes[player.hero_id].localized_name;
				player.internal_hero_name = heroDictionary.heroes[player.hero_id].name.Substring(14);
				//player.populateItems();
			}

			this.result = temp.result;
		}

		public List<string> getPlayerIDs(string matchJson)
		{
			List<string> playerIds = new List<string>();

			this.populateResult(matchJson);

			foreach(Player thePlayer in this.result.players)
			{
				playerIds.Add(thePlayer.account_id);
			}

			return playerIds;
		}

		private List<string> getPlayerNames()
		{
			string playerName = string.Empty;
			List<string> playerNames = new List<string>();
			SteamPlayerSummaries player = new SteamPlayerSummaries();

			foreach (Player thePlayer in this.result.players)
			{
				playerNames.Add(thePlayer.getPlayerName());
			}

			return playerNames;
		}
	}
}