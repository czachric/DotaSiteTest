using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotA_Site.Models
{
	public class SteamPlayer
	{
		//mandatory response fields
		public string steamId { get; set; }
		public int communityvisibilitystate { get; set; }
		public int profilestate { get; set; }
		public string personaname { get; set; }
		public string lastlogoff { get; set; }
		public string profileurl { get; set; }
		public string avatar { get; set; }
		public string avatarmedium { get; set; }
		public string avatarfull { get; set; }
		public int personastate { get; set; }

		//optional response fields
		public string commentpermission { get; set; }
		public string realname { get; set; }
		public string primaryclanid { get; set; }
		public string timecreated { get; set; }
		public string loccountrycode { get; set; }
		public string locstatecode { get; set; }
		public string loccityid { get; set; }
		public string gameextrainfo { get; set; }
		public string gameid { get; set; }
		public string gameserverip { get; set; }
	}
}