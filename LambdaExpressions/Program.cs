
using System;

namespace AnonymousMethod
{

    class Program
    {
        private delegate double Mathematical(double value);

        static void Main(string[] args)
        {
            Mathematical doublePower = (double value) => { return Math.Pow(value, 2); };
            Mathematical halfValue = (double value) => { return value / 2; };

            Console.WriteLine(doublePower(3));
            Console.WriteLine(halfValue(3));
        }


    }
}


