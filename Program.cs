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
            foreach (int n in sortedNumbers)
            {
                Console.WriteLine($"{n}");
            }
        }



    }
}
