﻿using System;
using System.Collections.Generic;

namespace Pluralsight.BegCshCollections.ReadAllCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\jhill\source\data\CountryList.csv";
            CsvReader reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountries();

            foreach(Country country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)} : {country.Name}");
            }

            Console.WriteLine($"{countries.Count} countries");
        }
    }
}
