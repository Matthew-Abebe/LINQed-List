using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQed_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //Restriction/Filtering Operations
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            //Exposes the enumerator(a counter), which supports a simple iteration over a specialized type.
            IEnumerable<string> LFruits = from fruit in fruits
                                          where fruit.StartsWith("L")
                                          select fruit;

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            //Exposes the enumerator(a counter), which supports a simple iteration over a specialized type.
            //'.Where' filters a sequence of values based on a predicate.
            //A predicate It represents a method that contains a set of criteria and checks whether the passed parameter meets those criteria or not
            IEnumerable<int> fourSixMultiples = numbers.Where(x => x % 4 == 0 || x % 6 == 0);

            //Ordering Operations
            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            //'.OrderByDescending sorts the elements of a sequence in descending order according to a key
            List<string> descend = names.OrderByDescending(n => n).ToList();

            // Build a collection of these numbers sorted in ascending order (uses number list on line 20)
            //'.OrderBy sorts the elements of a sequence in descending order according to a key
            List<int> ascNums = numbers.OrderBy(n => n).ToList();

            //Aggregate Operations
            // Output how many numbers are in this list (uses number list on line 20)
            //'.Count' returns the number of elements in a sequence
            var howManyNums = numbers.Count();

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            //'.Sum' Computes the sum of a sequence
            var totalMoney = purchases.Sum();

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            //'.Max' returns the maximum value in a sequence
            var mostExpensive = prices.Max();

            //Partitioning Operations

            //Store each number in the following List until a perfect square is detected.
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            //'.TakeWhile returns elements from a sequence as long as a specified condition is true
            //one way to solve
            List<int> perfectSquare = wheresSquaredo.TakeWhile(num => Math.Sqrt(num) % 1 != 0).ToList();

            //another way to solve
            List<int> perfectSquare2 = wheresSquaredo.TakeWhile(num =>
            {
                int number = Convert.ToInt32(Math.Sqrt(num));
                return number * number != num;
            }).ToList();

        }
    }
}

