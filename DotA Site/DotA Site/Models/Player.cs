using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace DotA_Site.Models
{
	public class Player
	{
		public string account_id { get; set; }
		public string account_name { get; set; } //custom field
		public int player_slot { get; set; }
		public int hero_id { get; set; }
		public string hero_name { get; set; } //custom field
		public string internal_hero_name { get; set; } //custom field
		public int item_0 { get; set; }
		public int item_1 { get; set; }
		public int item_2 { get; set; }
		public int item_3 { get; set; }
		public int item_4 { get; set; }
		public int item_5 { get; set; }
		public List<Item> items { get; set; } //custom field
		public int kills { get; set; }
		public int deaths { get; set; }
		public int assists { get; set; }
		public int leaver_status { get; set; }
		public int gold { get; set; }
		public int last_hits { get; set; }
		public int denies { get; set; }
		public int gold_per_min { get; set; }
		public int xp_per_min { get; set; }
		public int gold_spent { get; set; }
		public int hero_damage { get; set; }
		public int tower_damage { get; set; }
		public int hero_healing { get; set; }
		public int level { get; set; }
		public List<AbilityUpgrades> ability_upgrades { get; set; }

		public string getPlayerName()
		{
			SteamPlayerSummaries player = new SteamPlayerSummaries();
			string jsonResult = string.Empty;

			if (account_id == "4294967295")
				return "Anonymous";

			return player.getPlayerName(Convert.ToInt64(account_id));
		}

		public void populateHeroName()
		{
			//Heroes heroes = new Heroes();

			//hero_name = heroes.getHeroName(hero_id);

			Singleton heroes = Singleton.Instance;
			hero_name = heroes.heroDictionary[hero_id];
		}

		public void populateItems()
		{
			ItemDictionary itemDictionary = ItemDictionary.Instance;

			items = new List<Item>();

			items.Add(itemDictionary.items[item_0]);
			items.Add(itemDictionary.items[item_1]);
			items.Add(itemDictionary.items[item_2]);
			items.Add(itemDictionary.items[item_3]);
			items.Add(itemDictionary.items[item_4]);
			items.Add(itemDictionary.items[item_5]);
		}
	}
}