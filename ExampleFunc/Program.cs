
using System;

namespace DelegateGenericCovariance
{
    
    class Program
    {
        // Declaring the delegate
        public delegate int my_delegate(int s, int d,
                                       int f, int g);

        // Method
        public static int mymethod(int s, int d,
                                  int f, int g)
        {
            return s * d * f * g;
        }

        static void Main(string[] args)
        {
            // Creating object of my_delegate
            my_delegate del = mymethod;
            Console.WriteLine(del(12, 34, 35, 34));

            // Using Func delegate
            // Here, Func delegate contains
            // the four parameters of int type
            // one result parameter of int type
            Func<int, int, int, int, int> val = mymethod;
            Console.WriteLine(val(10, 100, 1000, 1));

        }


    }
}


