
using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;

namespace ExampleList
{


    class Program
    {

        
        static void Main(string[] args)
        {
            // Add items to a List
            // Dynamic ArrayList with no size limit
            List<int> numberList = new List<int>();
            numberList.Add(32);
            numberList.Add(21);
            numberList.Add(45);
            numberList.Add(11);
            numberList.Add(89);
            // List of string
            List<string> authors = new List<string>(5);
            authors.Add("Mahesh Chand");
            authors.Add("Chris Love");
            authors.Add("Allen O'neill");
            authors.Add("Naveen Sharma");
            authors.Add("Monica Rathbun");
            authors.Add("David McCarter");

            // AddRange()
            // Collection of string
            string[] animals = { "Cow", "Camel", "Elephant" };
            // Create a List and add a collection
            List<string> animalsList = new List<string>();
            animalsList.AddRange(animals);
            foreach (string a in animalsList)
                Console.WriteLine(a);

            Console.WriteLine();

            // Display items            
            foreach (string a in authors)
                Console.WriteLine(a);

            Console.WriteLine(authors[2]);

            Console.WriteLine();

            // List properties
            Console.WriteLine("Count: " + authors.Count);
            Console.WriteLine("Capacity: " + authors.Capacity);

            Console.WriteLine();

            // Insert elements at a position
            authors.Insert(3, "Bill Author");
            // Collection of new authors
            string[] newAuthors = { "New Author1", "New Author2", "New Author3" };
            // Insert array at position 2
            authors.InsertRange(2, newAuthors);
            foreach (string a in authors)
                Console.WriteLine(a);

            Console.WriteLine();

            Console.WriteLine("Remove an item");
            // Remove an item
            authors.Remove("New Author1");
            foreach (string a in authors)
                Console.WriteLine(a);
            Console.WriteLine();

            Console.WriteLine("Remove 3rd item");
            // Remove 3rd item
            authors.RemoveAt(3);
            foreach (string a in authors)
                Console.WriteLine(a);
            Console.WriteLine();

            Console.WriteLine("Remove a range");
            // Remove a range
            authors.RemoveRange(3, 2);
            foreach (string a in authors)
                Console.WriteLine(a);
            Console.WriteLine();

            Console.WriteLine("Remove all items");
            // Remove all items
            authors.Clear();
            foreach (string a in authors)
                Console.WriteLine(a);

            // Adding the elements again
            Console.WriteLine("Adding the elements again");
            authors.Add("Mahesh Chand");
            authors.Add("Chris Love");
            authors.Add("Allen O'neill");
            authors.Add("Naveen Sharma");
            authors.Add("Monica Rathbun");
            authors.Add("David McCarter");

            Console.WriteLine("Finding an element");
            // Find an element
            int idx = authors.IndexOf("Naveen Sharma");
            if (idx > 0)
                Console.WriteLine($"Item index in List is: {idx}");
            else
                Console.WriteLine("Item not found");
            // IndexOf()
            Console.WriteLine(authors.IndexOf("Naveen Sharma", 2));

            Console.WriteLine("Original List items");
            Console.WriteLine("===============");
            // Print original order
            foreach (string a in authors)
                Console.WriteLine(a);
            // Sort list items
            authors.Sort();
            Console.WriteLine();
            Console.WriteLine("Sorted List items");
            Console.WriteLine("===============");
            // Print sorted items
            foreach (string a in authors)
                Console.WriteLine(a);

            Console.WriteLine("Original List items");
            Console.WriteLine("===============");
            // Print original order
            foreach (string a in authors)
                Console.WriteLine(a);
            // Reverse list items
            authors.Reverse();
            Console.WriteLine();
            Console.WriteLine("Reverse List items");
            Console.WriteLine("===============");
            // Print reversed items
            foreach (string a in authors)
                Console.WriteLine(a);
        }


    }
}
