using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotA_Site.Models
{
	public class Item
	{
		public int Id { get; set; }
		public string ItemName { get; set; }
		public string Image { get; set; }
		public string Quality { get; set; }
		public string Description { get; set; }
		public List<ItemAttribute> Attributes { get; set; }
		public string Manacost { get; set; }
		public string Cooldown { get; set; }
		public string Lore { get; set; }
		public List<Item> Components { get; set; }
		public string Created { get; set; }
		public string ItemReferenceName { get; set; }
	}
}