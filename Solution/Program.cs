using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MapDistances.Models;

namespace MapDistances
{
    class Program
    {

        public static List<City> GetCityCollection() {

            return new List<City>{
                new City{Name = "Manchester", NorthernBearing= 398052, EasternBearing = 383819 },
                new City{Name = "Leeds", NorthernBearing= 434337, EasternBearing = 430774 },
                new City{Name = "Oxford", NorthernBearing= 206181, EasternBearing = 451342 },
                new City{Name = "Edinburgh", NorthernBearing= 674007, EasternBearing = 325847 },
                new City{Name = "London", NorthernBearing= 180381, EasternBearing = 530034 }
            };

        }
            
        static void Main(string[] args)
        {

            //Loop through all cities, and for each loop through the other cities and print distance (as crow flys) to screen

            foreach(City city1 in GetCityCollection()){

                foreach (City city2 in GetCityCollection().Where(city => city.Name != city1.Name))
                {
                    Console.WriteLine(city1.Name + " to " + city2.Name + " is " + NumberOfMilesBetweenCitys(city1, city2).ToString("##.##") + " miles.\r\n");
                }

            }

            Console.WriteLine("\r\nThis program has ended. Press a key to close.");
            Console.ReadKey();

        }

        public static double NumberOfMilesBetweenCitys(City City1, City City2) {

            double distance_metres = Math.Sqrt(Math.Pow((City2.EasternBearing - City1.EasternBearing), 2) + Math.Pow((City2.NorthernBearing - City1.NorthernBearing), 2));
            double metresPerMile = 1609.344;
            return distance_metres / metresPerMile;

        }

    }

}
