using System;
using System.Linq;
using System.Collections.Generic;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'

            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = from fruit in fruits
                                          where fruit.StartsWith("L")
                                          orderby fruit ascending
                                          select fruit;

            //consoloing out to keep from showing list every time program runs
            // foreach (string f in LFruits)
            // {
            //     Console.WriteLine($"{f}");
            // }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
{
    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
};

            IEnumerable<int> fourSixMultiples = numbers.Where(number => number % 4 == 0 || number % 6 == 0).OrderBy(number => number);

            // //commenting out to keep from showing list every time program runs
            // foreach (int n in fourSixMultiples)
            // {
            //     Console.WriteLine($"{n}");
            // }
            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
{
    "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
    "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
    "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
    "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
    "Francisco", "Tre"
};

            IEnumerable<string> descend = names.OrderByDescending(n => n);
            //consoloing out to keep from showing list every time program runs
            // foreach (string n in descend)
            // {
            //     Console.WriteLine($"{n}");
            // }

            // Build a collection of these numbers sorted in ascending order
            List<int> numberonis = new List<int>()
{
    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
};
            IEnumerable<int> sortedNumbers = numberonis.OrderBy(n => n);
            // foreach (int n in sortedNumbers)
            // {
            //     Console.WriteLine($"{n}");
            // }

            // Output how many numbers are in this list
            List<int> numbronies = new List<int>()
{
    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
};
            Console.WriteLine(numbronies.Count());

            List<double> purchases = new List<double>()
{
    2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
};
            Console.WriteLine(purchases.Sum());


            // What is our most expensive product?
            List<double> prices = new List<double>()
{
    879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
};

            IOrderedEnumerable<double> orderedEnumerables = prices.OrderBy(n => n);
            IEnumerable<double> priciest = orderedEnumerables;
            Console.WriteLine($"huzzah {priciest.Last()}");

            List<int> wheresSquaredo = new List<int>()
{
    66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
};
            /*
                Store each number in the following List until a perfect square
                is detected.

                Expected output is { 66, 12, 8, 27, 82, 34, 7, 50, 19, 46 } 

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */


            IEnumerable<int> nonSquared = wheresSquaredo.TakeWhile(n => Math.Sqrt(n) % 1 != 0);
            foreach (int n in nonSquared)
            {
                Console.WriteLine($"{n}");
            }

        }



    }
}

