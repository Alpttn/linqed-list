using System;
using System.Collections.Generic;
using System.Linq;

namespace Linqed_list
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            List<string> LFruits = fruits.Where(fruit => fruit.StartsWith("L")).ToList();
            //where n.StartsWith("S") 

            Console.WriteLine("----fruits with L-----");

            foreach (string fruit in LFruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine();

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            List<int> fourSixMultiples = numbers.Where(num => num % 4 == 0 || num % 6 == 0).ToList(); //didn't work without the ToList()
            // var result = list.Where(i => i%2 == 0);

            Console.WriteLine("----multiples of 4 & 6-----");

            foreach (int num in fourSixMultiples)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("----student names alphabetically-----");

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            List<string> descendingNames = names.OrderByDescending(name => name).ToList(); //specify the identity function (x => x you compare to itself

            foreach (string name in descendingNames)
            {
                Console.WriteLine(name);
            }
            //other way to write
            // IEnumerable<Product> inexpensive = from product in shoppingCart
            // where product.Price < 100.00
            // orderby product.Price descending
            // select product;

            Console.WriteLine("----numbers in ascending order-----");

            // Build a collection of these numbers sorted in ascending order
            List<int> numbersToOrder = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            List<int> ascendingNumbers = numbersToOrder.OrderBy(n => n).ToList(); //default is ascending

            foreach (int num in ascendingNumbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("----how many nums in this list?-----");

            // Output how many numbers are in this list
            List<int> bunchOfNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            int numberCount = bunchOfNumbers.Count();
            Console.WriteLine(numberCount);

            




        }
    }
}
