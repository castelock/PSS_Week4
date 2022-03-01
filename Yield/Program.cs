
using System;

namespace Yield
{


    class Program
    {
        static IEnumerable<int> Pares(int firstNumber, int lastNumber)
        {
            for (int number = firstNumber; number <= lastNumber; number++)
            {
                if (number % 2 == 0)
                {
                    yield return number;
                }
            }
        }

        public static System.Collections.Generic.IEnumerable<int> Power(int number, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result = result * number;
                yield return result;
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("The options for this program are: {0} 1- Yield return with power example. {0} " +
                "2- Yield return with even example. {0} ", Environment.NewLine);
            Console.WriteLine("Insert one of the previous options: ");
            String option = Console.ReadLine();
            
            switch (option)
            {
                case "1":
                    foreach (int i in Power(2, 8))
                    {
                        Console.Write("{0} ", i);
                    }
                    break;
                case "2":
                    foreach (int i in Pares(3, 10)) Console.Write(i + " ");
                    break;
                default:
                    Console.WriteLine("The option is not valid.");
                    break;
            }
            

           
            
        }


    }
}
