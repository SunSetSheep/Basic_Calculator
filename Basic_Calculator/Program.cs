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

            string operationDecision;

            // Message to display to user on start
            Console.WriteLine("Welcome to the calculator ! \n");

            // Tell user to insert a number 
            Console.WriteLine("Please enter your first number \n ");
            
            // Hold user response in varialbe and convert string to int
            // Add error handling, if isn't int then display message
           while (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Input must be a whole number. Please try again");
            }
          
            // Tell user to insert another number
            Console.WriteLine("Please enter your second number \n ");

            // Hold user second response in variable and convert string to int
            while (!int.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Input must be a whole number. Please try again");
            }

            // Handle operation to numbers

            Console.WriteLine("How do you want to calculate the numbers ? \n ");
            Console.WriteLine("Enter A to add the numbers, S to subtract the numbers, M to multiple the numbers and D to divide the numbers. \n ");

            operationDecision = Console.ReadLine();


            // Keep console open
            Console.ReadKey();



            
        }
    }
}
