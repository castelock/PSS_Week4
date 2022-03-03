
using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;

namespace SwapVariables
{


    class Program
    {
        private static bool myFunc(string strcity)
        {
            if (strcity.StartsWith('M'))
            {
                return true;
            }
            return false;

        }

        static void Main(string[] args)
        {
            // Adding items
            SortedSet<string> sortedSetDemo = new SortedSet<string>();
            sortedSetDemo.Add("Mumbai");
            sortedSetDemo.Add("Surat");
            sortedSetDemo.Add("Vadodara");
            sortedSetDemo.Add("Dabhoi");
            sortedSetDemo.Add("Pune");

            foreach (var item in sortedSetDemo)
            {
                Console.WriteLine(item);
            }

            // Contains()
            if (sortedSetDemo.Contains("Vadodara"))
            {
                Console.WriteLine("Vadodara is present in the collection");
            }
            else
            {
                Console.WriteLine("Vadodara is not present in the collection");
            }

            Console.WriteLine("Removing an element");
            sortedSetDemo.Remove("Surat");

            foreach (var item in sortedSetDemo)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Removing elements that start with M");
            sortedSetDemo.RemoveWhere(myFunc);

            foreach (var item in sortedSetDemo)
            {
                Console.WriteLine(item);
            }
            

            Console.WriteLine("Copying from a list");
            List<string> lstString = new List<string>()
            {
                "Mumbai",
                "Surat",
                "Vadodara",
                "Dabhoi",
                "Pune",
                "Mathura"
            };

            sortedSetDemo = new SortedSet<string>(lstString);

            foreach (var item in sortedSetDemo)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Number of elements: "+sortedSetDemo.Count);

            Console.WriteLine("Merging 2 collections");
            // Union with
            SortedSet<string> collection1 = new SortedSet<string>();
            collection1.Add("Mumbai");
            collection1.Add("Surat");

            SortedSet<string> collection2 = new SortedSet<string>();
            collection2.Add("Vadodara");
            collection2.Add("Dabhoi");
            collection2.Add("Pune");
            collection2.Add("Mathura");

            collection1.UnionWith(collection2);
            foreach (var item in collection1)
            {
                Console.WriteLine(item);
            }
        }


    }
}
