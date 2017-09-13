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

            //Jackie started with %15 to cover both bizz and buzz.
            //then she did the 3 and 5 as else-if statements

            //Jordan started with if (number % 3 == 0 && number % 5 == 0)
            //which is basically the same thing

            if (number % 3 == 0)
            {
                Console.Write("Bizz");
            }

            if (number % 5 == 0)
            {
                Console.Write("Buzz");
            }

            else
            {
                Console.WriteLine("Neither divisible by 3 nor by 5.");
            }

            Console.WriteLine("\n\nThanks for playing. Game over!");

            //print all prime numbers between 0 and 100

            //Ric did a bool first -- isPrime 
            //then his logical statement was only "if" to determine isPrime = false
            //even the teachers like this better than their ways

            double n = 100;
            double m = Math.Sqrt(n);

            for (int i = 3; i <= 100; i++)
            {
                for (double j = 2; j <= m; j++)
                {

                    if (i % j == 0 && i != j) //need a && i != j 
                    {
                        Console.WriteLine($"{i} is not prime");
                        break;
                    }

                    //if (i % j != 0)
                    //{
                    //    Console.WriteLine($"{i} is prime.");
                    //    continue;
                    //}
                }
            }

            //here is ric's solution:

            bool IsPrime = true;
            Console.WriteLine("Prime numbers: ");
            for (int i = 2; i <= 1000; i++)
            {
                for (int j = 2; j < 1000; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if (IsPrime)
                {
                    Console.Write(i + " ");
                }
                IsPrime = true;
            }

            Console.ReadLine();
        }
    }
}
