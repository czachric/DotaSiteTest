using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotA_Site.Models
{
    public class HeroResult
    {
        public List<Hero> heroes { get; set; }
        public int count { get; set; }
    }
}