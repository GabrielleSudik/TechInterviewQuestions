using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechInterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //bizzbuzz 3 & 5 program

            Console.WriteLine("Let's play Bizz Buzz!\n");
            Console.WriteLine("Please enter a number.");
            int number = int.Parse(Console.ReadLine());

            if (number % 3 == 0)
            {
                Console.Write("Bizz");
            }

            if (number % 5 == 0)
            {
                Console.Write("Buzz");
            }

            //else if (number % 3 == 0 && number % 5 == 0)
            //{
            //    Console.WriteLine("BizzBuzz!");
            //}

            else
            {
                Console.WriteLine("Neither divisible by 3 nor by 5.");
            }

            Console.WriteLine("\n\nThanks for playing. Game over!");

            Console.ReadLine();
        }
    }
}
