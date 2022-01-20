using System;

namespace Delegate
{
    public delegate void Del(string message);    

    class Program
    {
        static void Main(string[] args)
        {

            Covariance cov = new Covariance();
            cov.start();

            // Instantiate the delegate.
            Del handler = DelegateMethod;

            // Call the delegate.
            handler("We are learning about delegate.");
        }

        // Create a method for a delegate.
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
    }
}
