
using System;

namespace CovarianceContravariance
{
    class Mammals { }
    class Dogs : Mammals { }

    class Program
    {
       
        // Define the delegate.  
        public delegate Mammals HandlerMethod();

        public static Mammals MammalsHandler()
        {
            return null;
        }

        public static Dogs DogsHandler()
        {
            return null;
        }
        static void Main(string[] args)
        {
            HandlerMethod handlerMammals = MammalsHandler;

            // Covariance enables this assignment.  
            HandlerMethod handlerDogs = DogsHandler;


        }


    }
}

