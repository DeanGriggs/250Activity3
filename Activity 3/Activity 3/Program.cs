using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int number = int.Parse(Console.ReadLine());
            int userInput = number;
            while (number != 1)
            {
                Console.WriteLine(number + " ");
                if (number % 2 == 0)
                {
                    number = number / 2;
                }
                else
                {
                    number = number * 3 + 1;
                }
            }

            Console.WriteLine(number);
            Console.ReadLine();




            Console.Write("and now as a Factorial: ");
            int number1 = userInput;

            int factorial = 1;

            for (int i = number1; i >= 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
            Console.ReadLine();



                int numberA = number1;

            Console.WriteLine("Please enter a second positive integer: ");
                int number2 = int.Parse(Console.ReadLine());


            int answer = gcd(numberA, number2);
                Console.Out.WriteLine("The gcd of {0} and {1} is {2}", numberA, number2, answer); Console.ReadLine();


            int gcd(int n1, int n2)
            {
                
                if (n2 == 0)
                {
                    return n1;
                }
                else
                {
                    Console.Out.WriteLine("Not yet. Remainder is {0}", n1 % n2);
                    return gcd(n2, n1 % n2);
                }
                
            }


            
        }
    }
}
