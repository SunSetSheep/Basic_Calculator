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
            // Result from calculation
            int result;

            // Calculate operator 
            string operationDecision;


            // Message to display to user on start
            Console.WriteLine("\t\t\tWelcome to the calculator ! \n");

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
                Console.WriteLine("Input must be a whole number. Please try again \n ");
            }

            // Handle operation to numbers

            Console.WriteLine("How do you want to calculate the numbers ? \n ");
            Console.WriteLine("Enter A to add the numbers, S to subtract the numbers, M to multiple the numbers and D to divide the numbers. \n ");

            operationDecision = Console.ReadLine();

           
            if (operationDecision == "A" || operationDecision == "a")
            {
                result = number1 + number2;
            }
            else if (operationDecision == "S" || operationDecision == "s")
            {
                result = number1 - number2;
            }
            else if (operationDecision == "M" || operationDecision == "m")
            {
                result = number1 * number2;
            }
            else
            {
                result = number1 / number2;
            }

            // Inject result into console along with message
            Console.WriteLine("The result is :" + result);

            // Keep console open
            Console.ReadKey();



            
        }
    }
}
