using System;
using System.Collections.Generic;

namespace Sea
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the prototype class
            SeaCreaturePrototype<SeaCreature> prototype = new SeaCreaturePrototype<SeaCreature>();

            // Add some sea creatures to the prototype
            prototype.Add(new SeaCreature("Fish", "swimming"));
            prototype.Add(new SeaCreature("Octopus", "squishing"));
            prototype.Add(new SeaCreature("Shark", "hunting"));

            // Clone the prototype and add a new sea creature to the clone
            SeaCreaturePrototype<SeaCreature> clone = prototype.Clone();
            clone.Add(new SeaCreature("Dolphin", "jumping"));

            // Print the sea creatures in the prototype and the clone
            Console.WriteLine("Prototype:");
            foreach (SeaCreature creature in prototype.GetCreatures())
            {
                Console.WriteLine(creature);
            }

            Console.WriteLine("\nClone:");
            foreach (SeaCreature creature in clone.GetCreatures())
            {
                Console.WriteLine(creature);
            }

            // Use nullable types
            int? nullableInt = null;
            Console.WriteLine($"\nNullable int: {nullableInt}");

            // Use abstract structures
            List<SeaCreature> creatureList = new List<SeaCreature>();
            creatureList.Add(new SeaCreature("Whale", "singing"));
            creatureList.Add(new SeaCreature("Crab", "scuttling"));

            Dictionary<string, SeaCreature> creatureDict = new Dictionary<string, SeaCreature>();
            creatureDict.Add("Starfish", new SeaCreature("Starfish", "clinging"));
            creatureDict.Add("Jellyfish", new SeaCreature("Jellyfish", "floating"));

            Console.WriteLine("\nCreature List:");
            foreach (SeaCreature creature in creatureList)
            {
                Console.WriteLine(creature);
            }

            Console.WriteLine("\nCreature Dictionary:");
            foreach (KeyValuePair<string, SeaCreature> kvp in creatureDict)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }

    // Define the SeaCreature class
    class SeaCreature
    {
        public string Name { get; set; }
        public string Action { get; set; }

        public SeaCreature(string name, string action)
        {
            Name = name;
            Action = action;
        }

        public override string ToString()
        {
            return $"{Name} is {Action}";
        }
    }

    // Define the SeaCreaturePrototype class
    class SeaCreaturePrototype<T> where T : class, new()
    {
        private List<T> creatures = new List<T>();

        public void Add(T creature)
        {
            creatures.Add(creature);
        }

        public void Remove(T creature)
        {
            creatures.Remove(creature);
        }

        public SeaCreaturePrototype<T> Clone()
        {
            SeaCreaturePrototype<T> clone = new SeaCreaturePrototype<T>();
            foreach (T creature in creatures)
            {
                clone.Add(creature);
            }
            return clone;
        }

        public List<T> GetCreatures()
        {
            return creatures;
        }
    }
}
