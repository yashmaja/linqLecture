using System;
using System.Collections.Generic;
using System.Linq;

namespace linqLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 6, 9, 1, 3, 0, 1 };
            int oddcount = numbers.Count(n => n % 2 == 1);
            Console.WriteLine($"There are {oddcount} odd numbers");

            //Query Expression
            List<int> largest = (from n in numbers
                           where n == 9
                           select n).ToList();
            
            
            Console.WriteLine(largest);

            //Method
            List<int> above5 = numbers.Where(n => n > 5).ToList();
            Console.WriteLine("There are the number above 5");

            foreach (int num in above5)
            {
                Console.WriteLine(num);
            }

            //examples
            //first
            int firstEven = numbers.First(n => n % 2 == 0);
            Console.WriteLine($"The first even number is {firstEven}");

            //single
            int onlyNine = numbers.Single(n => n == 9);
            Console.WriteLine(onlyNine);

            //any
            bool check = numbers.Any(n => n >= 10);
            Console.WriteLine($"Are there any numbers greater than 10?: {check}");

            //where
            List<int> under5 = numbers.Where(n => n < 5).ToList();
            foreach(int num in under5)
            {
                Console.WriteLine(num);
            }
        }
    }
}
