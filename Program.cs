// Adam Ishak
using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using System.Threading.Tasks.Sources;

namespace Conditions_AdamIshak
{
    internal class Program
    {
        static void Main(string[] args)
        { // Exercise 1

            int num1;
            int num2;

            while (true)
            {
                try
                {
                    Console.WriteLine("Could you put two numbers in?");
                    num1 = int.Parse(Console.ReadLine());
                    num2 = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("You did not input a number");
                }
            }

            if (num1 > num2)
            {
                Console.WriteLine("num1 > num2");
            }
            else if (num1 < num2) 
            {
                Console.WriteLine("num1 < num2");
            }
            else
            {
                Console.WriteLine("num1 = num2");

            }
            // Exercise 2

            if( (num1 > 90) && (num2 < 100 ) )
            {
                Console.WriteLine("The letter of score is A");
            }
            else if ((num1 > 80) && (num2 < 90) )
            {
                Console.WriteLine("The letter of score if B");
            }
            else if ((num1 > 70) && (num2 < 80) )
            {
                Console.WriteLine("The letter of score is C");
            }
            else if ((num1 > 60) && (num2 < 70) )
            {
                Console.WriteLine("The letter of this score is D");
            }
            else if ((num1 > 0) && (num2 >59) )
            {
                Console.WriteLine("The letter of this score is:(F");
            }
            // Exercise 3
            
            if (num1 % 4 == 0)
            {

            }
           
            {

            }
                // Exercise 4
                // Exercise 5
            

        } // Main

    } //
    
} // namespace
