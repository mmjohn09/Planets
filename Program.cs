using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){
                "Mercury", "Mars"};

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastThreePlanets = new List<string>(){
                "Uranus", "Neptune", "Pluto"
            };

            planetList.AddRange(lastThreePlanets);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            planetList.Remove("Pluto");

            planetList.ForEach(planet => Console.WriteLine(planet));

            List<string> rockyPlanets = planetList.GetRange(0, 4);
            Console.WriteLine("---Rocky Planets---");
            rockyPlanets.ForEach(planet => Console.WriteLine(planet));

        }
    }
}
