using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries_TA
{
    public class Country
    {
        public enum Continent
        {
            Africa,
            Asia,
            Europe,
            NorthAmerica,
            SouthAmerica,
            Oceania,
            Antarctica
        }
        public string Name { get; set; }
        public Continent CountryContinent { get; set; }
        public List<string> Colors { get; set; }

        public Country(string name, Continent continent, params string[] colors)
        {
            Name= name;
            CountryContinent = continent;
            Colors = colors.ToList();
        }

        
    }
}
