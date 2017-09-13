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

            //here's another test:

            //create an array of whatever size integers.
            //method should return largest number in the array

            //whee you got this one on your own!
            //well... you didn't put it in a method, but you got it

            Console.WriteLine();

            int[] array =         
             { 2, 3, 5, 7, 11, 13, 17, 19, 23, 31, 37, 43, 41 };

            int biggestNumber = 0;

            Console.WriteLine(array[12]);

            for (int i = 0; i < array.Length-1 ; i++)
            {
                if (array[i] > array[i + 1])
                {
                    biggestNumber = array[i];
                }

                else
                {
                    biggestNumber = array[i + 1];           }
            }

            Console.WriteLine($"Biggest number is {biggestNumber}");

            //there are a lot of ways to do this problem
            //there's an example on slack (photo of white board)

            //public int LargestNumber (int[] array)

            //...
            //return biggestNumber;


            //create a method that takes a string parameter
            //then returns that string reversed.
            //DO NOT use .Reverse

            Console.WriteLine();

            string name = "GABRIELLE";

            for (int i = 0; i <name.Length; i++)
            {
                Console.Write(name[name.Length-i-1]);
            }

            //NameReversed(name);

            //Console.WriteLine(reversed);

            Console.ReadLine();
        }

        public void NameReversed (string name)
        {
            string reversedName = "";

            for (int i = 0; i < name.Length; i++)  //could also set (1 = name.Length - 1; i >=0; i--)
            {
                Console.Write(name[name.Length - i - 1]);
            }

            //here's a thing: you can += with chars in a string!
            //like:   reversedName += name[i]

            //then return reversedName;
            
        }
        }
    }
