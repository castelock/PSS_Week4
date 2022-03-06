
using System;

namespace DelegateGenericCovariance
{
    public class Person { }
    public class Employee : Person { }

    class Program
    {
        static Employee FindByTitle(String title)
        {
            // This is a stub for a method that returns  
            // an employee that has the specified title.  
            return new Employee();
        }

        static void Main(string[] args)
        {
            // Create an instance of the delegate without using variance.  
            Func<String, Employee> findEmployee = FindByTitle;

            // The delegate expects a method to return Person,  
            // but you can assign it a method that returns Employee.  
            Func<String, Person> findPerson = FindByTitle;

            // You can also assign a delegate
            // that returns a more derived type
            // to a delegate that returns a less derived type.  
            findPerson = findEmployee;

        }


    }
}


