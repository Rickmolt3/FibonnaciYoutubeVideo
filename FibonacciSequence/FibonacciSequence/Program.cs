using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class Program
    {
        //code entry point
        static void Main(string[] args)
        {
            //call the method that takes userinput and prints results
            AfterInput();
        }

        //takes the parameter of length and returns a fibonnaci sequence corresponding to the input
        public static void Fibonacci(int len)
        {
            //initiate variables and then print initial values
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);

            //for loop that iterates through corresponding with the number the user input
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }

        //holds all the user input and console writing in this method
        public static void AfterInput()
        {
            //asks the user to input a number then records the input
            Console.WriteLine("Please Input a number to be input into the sequence");
            string userInput = Console.ReadLine();

            //converts the user input from a string to an integer
            Fibonacci(Convert.ToInt16(userInput));

            //waits for user to end the program
            Console.ReadKey();
        }

        //maybe add some other basic algorithms too fill more time
        //fix up comments to be more illustrative 
    }
}
