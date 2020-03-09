using System;

namespace SimpleAddition
{
   
    class Program
    {
        /// <summary>
        /// Demonstrates, the parameters being passed into the method 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");

            string userInput = Console.ReadLine();

            //we need to convert user input into an integer
            int number1 = int.Parse(userInput);

            Console.Write("Enter the second number: ");
            userInput = Console.ReadLine();

            int number2 = int.Parse(userInput);

            int sum = number1 + number2;

            Console.WriteLine("The sum is: " + sum);

            //converts integer sum into string 
            Console.WriteLine("The sum is: " + sum.ToString());
            //parenthesis tells machine to complete task inside of them
            Console.WriteLine("The sum is: " + (number1 + number2));

            //this right is necessary for the console to read your code
            Console.WriteLine("X format: {0:X}", 99999);
            //the second parameter is hardcoded into the place holder {0: E}
            //E specifies how to print out the hardcoded number 
            Console.WriteLine("D format: {0:f3}", 12345);
            
            
            Console.ReadLine();
        }
    }
}
