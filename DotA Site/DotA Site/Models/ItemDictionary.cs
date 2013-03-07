using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace DotA_Site.Models
{
	public sealed class ItemDictionary
	{
		public List<Item> items { get; set; }

		private static readonly ItemDictionary instance = new ItemDictionary();

		// Explicit static constructor to tell C# compiler
		// not to mark type as beforefieldinit
		static ItemDictionary()
		{
		}

		public static ItemDictionary Instance
		{
			get
			{
				return instance;
			}
		}

		//Singleton Initialization
		private ItemDictionary()
		{
			populateItemDefinitions();
		}

		private void populateItemDefinitions()
		{
			string itemJson = System.IO.File.ReadAllText(@"C:\Users\BAIRD\Dota Items\ItemsBundle\ItemsBundle\items.json");
			items = JsonConvert.DeserializeObject<List<Item>>(itemJson);
		}
	}
}