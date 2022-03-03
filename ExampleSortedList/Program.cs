
using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;

namespace SwapVariables
{


    class Program
    {



        static void Main(string[] args)
        {
            //creation of sortedlist  
            SortedList<int, string> sortedlist = new SortedList<int, string>();
            //add the elements in sortedlist  
            sortedlist.Add(1, "Sunday");
            sortedlist.Add(2, "Monday");
            sortedlist.Add(3, "Tuesday");
            sortedlist.Add(4, "Wednesday");
            sortedlist.Add(5, "Thusday");
            sortedlist.Add(6, "Friday");
            sortedlist.Add(7, "Saturday");
            //display the elements of the sortedlist  
            Console.WriteLine("The elements in the SortedList are:");
            foreach (KeyValuePair<int, string> pair in sortedlist)
            {
                Console.WriteLine("{0} => {1}", pair.Key, pair.Value);
            }
            //Find the capacity  
            Console.WriteLine("The capacity is:" + sortedlist.Capacity);
            sortedlist.Add(8, "januray");
            sortedlist.Add(9, "april");
            Console.WriteLine("After adding two more element the capacity is:" + sortedlist.Capacity);

            // Find the count
            Console.WriteLine("The total number of elements in the sortedlist are:" + sortedlist.Count);

            //Contain key method  
            Console.WriteLine("The key 1 contain in the SortedList:" + sortedlist.ContainsKey(1));
            Console.WriteLine("The key 5 contain in the SortedList:" + sortedlist.ContainsKey(5));
            Console.WriteLine("The key 10 contain in the SortedList:" + sortedlist.ContainsKey(10));
            Console.WriteLine("The key 50 contain in the SortedList:" + sortedlist.ContainsKey(50));

            //Contain value method  
            Console.WriteLine("The value Sunday contain in the SortedList:" + sortedlist.ContainsValue("Sunday"));
            Console.WriteLine("The value Friday contain in the SortedList:" + sortedlist.ContainsValue("Friday"));
            Console.WriteLine("The value May contain in the SortedList:" + sortedlist.ContainsValue("May"));
            Console.WriteLine("The value Wednesday contain in the SortedList:" + sortedlist.ContainsValue("Wednesday"));

            //IndexOfKey method  
            Console.WriteLine("***************INDEXOFKEY***************");
            Console.WriteLine();
            Console.WriteLine("The index value of the key 4 is:" + sortedlist.IndexOfKey(4));
            Console.WriteLine("The index value of the key 1 is:" + sortedlist.IndexOfKey(1));
            Console.WriteLine("The index value of the key 7 is:" + sortedlist.IndexOfKey(7));
            Console.WriteLine("The index value of the key 2 is:" + sortedlist.IndexOfKey(2));

            //IndexofValue method  
            Console.WriteLine();
            Console.WriteLine("***************INDEXOFVALUE***************");
            Console.WriteLine();
            Console.WriteLine("The index value of the value Sunday is:" + sortedlist.IndexOfValue("Sunday"));
            Console.WriteLine("The index value of the value Wednesday is:" + sortedlist.IndexOfValue("Wednesday"));
            Console.WriteLine("The index value of the value Monday is:" + sortedlist.IndexOfValue("Monday"));
            Console.WriteLine("The index value of the value Friday is:" + sortedlist.IndexOfValue("Friday"));

            //remove the elements from the sortedlist  
            sortedlist.Remove(3);
            sortedlist.Remove(7);
            sortedlist.Remove(1);
            Console.WriteLine("After remove some elements the sortedlist is as:");
            foreach (KeyValuePair<int, string> pair1 in sortedlist)
            {
                Console.WriteLine("{0} => {1}", pair1.Key, pair1.Value);

            }


        }
    }
}
