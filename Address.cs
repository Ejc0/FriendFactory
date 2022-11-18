using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1UPGF
{
    public struct Adress
    {
        

        private string Streetname { get; set; }
        private string Zipcode { get; set; }
        private string City { get; set; }
        private string Country { get; set; }

        public override string ToString()
        {
            return Streetname + " " + Zipcode + " " + City + " " + Country;
            
        }
        public Adress(string streetname, string zipcode, string city, string country)
        {
            Streetname = streetname;
            Zipcode = zipcode;
            City = city;
            Country = country;
        }

        public static class Factory
        {
            public static Adress CreateAdress()
            {
                var choice = new Random();
                string[] streetnames = { "järnvägsgatan", "Falugatan", "kunggatan", "drottningatan" };
                string[] zipcodes = { "4321", "12344", "64422", "67482", "9867", "67876" };
                string[] cities = { "Falun", "stockholm", "göteborg", "kungsbacka", "Malmö" };
                string[] countrynames = { "Sverige", "Danmark", "Finland", "Norge" };

                string streetname = streetnames[choice.Next(streetnames.Length)];
                string zipcode = zipcodes[choice.Next(zipcodes.Length)];
                string city = cities[choice.Next(cities.Length)];
                string country = countrynames[choice.Next(countrynames.Length)];

                var adress = new Adress(streetname, zipcode, city, country);
                return adress;
            }
        }
    }

}


