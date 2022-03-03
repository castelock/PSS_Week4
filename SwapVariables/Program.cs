
using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;

namespace SwapVariables
{


    class Program
    {

        static void Intercambio<T>(ref T v1, ref T v2) where T : IComparable
        {
            if (v1.CompareTo(v2) > 0)
            {
                T temp = v1;
                v1 = v2;
                v2 = temp;
            }
        }

        static void Main(string[] args)
        {
            double a = 8.2;
            double b = 5;
            Intercambio<double>(ref a, ref b);
            Console.WriteLine(a + " <= " + b);

        }


    }
}
