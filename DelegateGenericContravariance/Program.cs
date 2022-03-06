
using System;

namespace DelegateGenericCovariance
{
    public class Person { }
    public class Employee : Person { }

    class Program
    {
        static void AddToContacts(Person person)
        {
            // This method adds a Person object  
            // to a contact list.  
        }

        static void Main(string[] args)
        {
            // Create an instance of the delegate without using variance.  
            Action<Person> addPersonToContacts = AddToContacts;

            // The Action delegate expects
            // a method that has an Employee parameter,  
            // but you can assign it a method that has a Person parameter  
            // because Employee derives from Person.  
            Action<Employee> addEmployeeToContacts = AddToContacts;

            // You can also assign a delegate
            // that accepts a less derived parameter to a delegate
            // that accepts a more derived parameter.  
            addEmployeeToContacts = addPersonToContacts;

        }


    }
}


