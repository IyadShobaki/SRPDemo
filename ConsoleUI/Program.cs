using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// SRP stands for "Single Responsibility Principle" - Design Pattern
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            // Ask for user information
            Person user = PersonDataCapture.Capture();

            // Checks to be sure the first and last names are valid
            bool isUserValid = PersonValidator.Validate(user);
            if (isUserValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            // Create a username for the person
            AccountGenerator.CreateAccount(user);

            StandardMessages.EndApplication();




            //Console.WriteLine("Welcome to my application");

            //// Ask for user information
            //Person user = new Person();

            //Console.WriteLine("What is your first name: ");
            //user.FirstName = Console.ReadLine();

            //Console.WriteLine("What is your last name: ");
            //user.LastName = Console.ReadLine();


            //// Checks to be sure the first and last names are valid
            //if (string.IsNullOrWhiteSpace(user.FirstName))
            //{
            //    Console.WriteLine("You did not give us a valid first name!");
            //    //Console.ReadLine();
            //    StandardMessages.EndApplication();
            //    return;
            //}

            //if (string.IsNullOrWhiteSpace(user.LastName))
            //{
            //    Console.WriteLine("You did not give us a valid last name!");
            //    //Console.ReadLine();
            //    StandardMessages.EndApplication();
            //    return;
            //}

            //// Create a username for the person
            //Console.WriteLine($"Your username is { user.FirstName.Substring(0,1) }{ user.LastName }");


            // Console.ReadLine();
            //StandardMessages.EndApplication();

        }
    }
}
