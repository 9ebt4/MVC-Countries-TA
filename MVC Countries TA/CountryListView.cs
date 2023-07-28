using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries_TA
{
    public class CountryListView
    {
        public List<Country> Countries { get; set; }

        public CountryListView(List<Country> countries) 
        {
            Countries= countries;
        }

        public void Display()
        {
            int i = 1;
            foreach (Country country in Countries)
            {
                Console.WriteLine($"{i++}. {country.Name}");
            }
        }
    }
}
