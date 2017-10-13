using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Features
{
    class Tuples
    {
        /// <summary>
        /// Assigning a tuple to individually declared variables.
        /// </summary>
        /// <returns>string</returns>
        public string Examples()
        {
            //Example1
            (string country, string capital, double gdpPerCapita) = ("Malawi", "Lilongwe", 226.50);

            var result = $@"The poorest country in the world in 2017 was {country}, {capital}: {gdpPerCapita}";

            return result;
        }

        /// <summary>
        /// Assigning a tuple to individually declared variables that are pre-declared.
        /// </summary>
        /// <returns>string</returns>
        public string Example2()
        {
            
            //Example2
            string country;
            string capital;
            double gdpPerCapita;
            (country, capital, gdpPerCapita) = ("Malawi", "Lilongwe", 226.50);

            var result = $@"The poorest country in the world in 2017 was {country}, {capital}: {gdpPerCapita}";
            return result;
        }

        /// <summary>
        /// Assigning a named item tuple to a single implicitly typed variable that’s implicitly typed and then accessing the tuple items by name.
        /// </summary>
        /// <returns>string</returns>
        public string Example3()
        {
            var countryInfo =(Name: "Malawi", Capital: "Lilongwe", GdpPerCapita: 226.50);
            var result=  $@"The poorest country in the world in 2017 was {countryInfo.Name}, {countryInfo.Capital}: {countryInfo.GdpPerCapita}";

            return result;
        }

        /// <summary>
        /// Assigning an unnamed tuple to a single implicitly typed variable and then accessing the tuple elements by their Item-number property.
        /// </summary>
        /// <returns>string</returns>
        public string Example4()
        {
            var countryInfo =("Malawi", "Lilongwe", 226.50);
            var result= $@"The poorest country in the world in 2017 was {countryInfo.Item1}, {countryInfo.Item2}: {countryInfo.Item3}";

            return result;
        }


        

    }
}
