
using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;

namespace ExampleDictionary
{


    class Program
    {

        
        static void Main(string[] args)
        {
            // Create a dictionary with string key and Int16 value pair
            Dictionary<string, int> AuthorList = new Dictionary<string, int>();
            AuthorList.Add("Mahesh Chand", 35);
            AuthorList.Add("Mike Gold", 25);
            AuthorList.Add("Praveen Kumar", 29);
            AuthorList.Add("Raj Beniwal", 21);
            AuthorList.Add("Dinesh Beniwal", 84);
            // Read all data
            Console.WriteLine("Authors List");
            foreach (KeyValuePair<string, int> author in AuthorList)
            {
                Console.WriteLine("Key: {0}, Value: {1}", author.Key, author.Value);
            }


            Console.WriteLine("Count: {0}", AuthorList.Count);

            // Set Item value
            AuthorList["Mahesh Chand"] = 20;
            // Get Item value
            Console.WriteLine(AuthorList["Mahesh Chand"]);

            // Get and display keys
            Dictionary<string, int>.KeyCollection keys = AuthorList.Keys;
            foreach (string key in keys)
            {
                Console.WriteLine("Key: {0}", key);
            }

            // Get and display values
            Dictionary<string, int>.ValueCollection values = AuthorList.Values;
            foreach (Int16 val in values)
            {
                Console.WriteLine("Value: {0}", val);
            }

            // Remove item 
            Console.WriteLine("Removing an element");
            AuthorList.Remove("Mahesh Chand");

            Console.WriteLine("Finding a key");
            if (!AuthorList.ContainsKey("Mahesh Chand"))
            {
                AuthorList["Mahesh Chand"] = 100;
            }

            Console.WriteLine("Finding a value");
            if (!AuthorList.ContainsValue(9))
            {
                Console.WriteLine("Item found");
            }

        }


    }
}

