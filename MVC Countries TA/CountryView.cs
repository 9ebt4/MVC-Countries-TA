using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries_TA
{
    public class CountryView
    {
        public Country DisplayCountry { get; set; }
        public CountryView(Country country) 
        {
            DisplayCountry = country;
        }

        public void Display()
        {
            Console.Write($"Name: {DisplayCountry.Name} Continent: {DisplayCountry.CountryContinent} Flag Colors: ");
            DisplayCountry.Colors.ForEach(c => 
            { 
                Console.ForegroundColor = Enum.Parse<ConsoleColor>(c); 
                Console.Write(c + " "); 
            }
            );
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
