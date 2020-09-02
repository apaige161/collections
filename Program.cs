using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using static System.Console;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            create list
            */
            var cities = new List<string>();
            cities.Add("London");
            cities.Add("Paris");
            cities.Add("Milan");

            //write out list items
            WriteLine("Initial List");
            foreach(string city in cities)
            {
                WriteLine($"{city}");
            }

            //add to list
            cities.Insert(0, "Sydney");
            WriteLine("After inserting at index 0");
            foreach(string city in cities)
            {
                WriteLine(city);
            }

            //remove from list
            cities.RemoveAt(1);
            cities.Remove("Milan");
            WriteLine("After removing 2 items");
            foreach(string city in cities)
            {
                WriteLine(city);
            }

            /*
            immutable collections
            */
            var immutableCities = cities.ToImmutableList();
            var newList = immutableCities.Add("Rio");
            Write("Immutable cities: ");
            foreach(string city in immutableCities)
            {
                WriteLine(city);
            }
            
            WriteLine("");
            Write("New list of cities: ");
            foreach(string city in newList)
            {
                WriteLine(city);
            }
            WriteLine("");








            /*
            create dictionary
            */
            var keywords = new Dictionary<string, string>();
            keywords.Add("int", "32-bit integer data type");
            keywords.Add("long", "64-bit integer data type");
            keywords.Add("float", "Single precision floating point number");

            WriteLine("Keywords and their deffinitions");
            foreach(KeyValuePair<string, string> item in keywords)
            {
                WriteLine($"    {item.Key}: {item.Value}");
            }
            WriteLine($"The definition of a long is {keywords["long"]}");


            












        }
    }
}
