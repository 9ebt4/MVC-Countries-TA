using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validator_Object;
using static MVC_Countries_TA.Country;

namespace MVC_Countries_TA
{
    public class CountryController
    {
        List<Country> CountryDb = new List<Country>()
        {
            new Country("United States of America", Continent.NorthAmerica, "Red", "White", "Blue"),
            new Country("Canada", Continent.NorthAmerica, "Red", "White"),
            new Country("United Kingdom", Continent.Europe, "Red", "White", "Blue"),
            new Country("France", Continent.Europe, "Blue", "White", "Red"),
            new Country("Brazil", Continent.SouthAmerica, "Green", "Yellow", "Blue"),
            new Country("India", Continent.Asia, "Orange", "White", "Green"),
            new Country("China", Continent.Asia, "Red", "Yellow"),
            new Country("Australia", Continent.Oceania, "Blue", "White", "Red"),
            new Country("South Africa", Continent.Africa, "Red", "Blue", "Green"),
            new Country("Antarctica", Continent.Antarctica, "White")
        };

        public void CountryAction(Country c)
        {
            CountryView countryView = new CountryView(c);
            countryView.Display();
        }
        public void WelcomeAction()
        {
            while (true)
            {
                CountryListView countryListView = new CountryListView(CountryDb);
                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list by number.");
                countryListView.Display();
                int input = -1;
                while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > CountryDb.Count())
                {
                    Console.WriteLine($"Invalid Input: Only enter whole numbers from 1 to {CountryDb.Count()}");
                    
                }
                CountryAction(CountryDb[input-1]);
                Console.WriteLine();
                Console.WriteLine("Learn about another country?");
                if (Validator.Continue())
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Goodbye");
                    break;
                }
            }            
        }
    }
}
