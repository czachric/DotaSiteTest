using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotA_Site.Models
{
	public class MatchHistoryPopulator
	{
		//First Instance of populating player's match History
		public IList<MatchDetails> getInitialHistory(string accountID)
		{
			IList<MatchDetails> initialMatches = new List<MatchDetails>();

			return initialMatches;
		}
	}
}