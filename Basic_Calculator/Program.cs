using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Calculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Set variables to store user input
            int number1;
            int number2;

            // Message to display to user on start
            Console.WriteLine("Welcome to the calculator");

            // Tell user to insert a number 
            Console.WriteLine("Please enter your first number.");
            
            // Hold user response in varialbe and convert string to int
            number1 = Convert.ToInt32(Console.ReadLine());

            // Key console open
            Console.ReadKey();



            
        }
    }
}
